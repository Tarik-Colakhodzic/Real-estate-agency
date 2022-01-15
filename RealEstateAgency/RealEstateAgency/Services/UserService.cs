using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Database;
using RealEstateAgency.Filters;
using RealEstateAgency.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Services
{
    public class UserService : BaseCRUDService<Model.User, Database.User, Model.SimpleSearchRequest, Model.Requests.UserInsertRequest, Model.Requests.UserInsertRequest>, IUserService
    {
        public UserService(RealEstateAgencyContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.User> Get(Model.SimpleSearchRequest search = null)
        {
            var entity = Context.Set<Database.User>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.SearchText))
            {
                entity = entity.Where(x => x.FirstName.Contains(search.SearchText)
                    || x.LastName.Contains(search.SearchText)
                    || x.UserName.Contains(search.SearchText)
                    || x.Email.Contains(search.SearchText)
                    || x.PhoneNumber.Contains(search.SearchText));
            }

            if (search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();
            return _mapper.Map<List<Model.User>>(list);
        }

        public override Model.User Insert(UserInsertRequest request)
        {
            var users = Context.Set<Database.User>().AsQueryable();
            if(users.Any(x => x.UserName == request.Username))
            {
                return null;
            }
            var entity = _mapper.Map<Database.User>(request);
            Context.Add(entity);
            if (request.Password != request.ConfirmedPassword)
            {
                throw new UserException("Lozinka nije ispravna");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            Context.SaveChanges();

            foreach (var role in request.Roles)
            {
                Database.UserRoles userRoles = new Database.UserRoles
                {
                    UserId = entity.Id,
                    RoleId = role
                };

                Context.UsersRoles.Add(userRoles);
            }

            Context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }

        public override Model.User Update(int id, UserInsertRequest request)
        {
            var entity = Context.Users.Include(x => x.UserRoles).FirstOrDefault(x => x.Id == id);
            var oldPasswordHash = entity.PasswordHash;
            var oldPasswodSalt = entity.PasswordSalt;
            _mapper.Map(request, entity);
            if (string.IsNullOrEmpty(request.Password))
            {
                entity.PasswordHash = oldPasswordHash;
                entity.PasswordSalt = oldPasswodSalt;
            }
            else
            {
                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }
            Context.Users.Update(entity);

            var userRoleIdsToRemove = entity.UserRoles.Select(x => x.RoleId).Except(request.Roles).ToList();
            var userRolesToRemove = entity.UserRoles.Where(x => userRoleIdsToRemove.Any(y => y == x.RoleId)).ToList();

            var userRoleIdsToInsert = request.Roles.Except(entity.UserRoles.Select(x => x.RoleId));
            foreach (var role in userRoleIdsToInsert)
            {
                Database.UserRoles userRoles = new Database.UserRoles
                {
                    UserId = entity.Id,
                    RoleId = role
                };

                Context.UsersRoles.Add(userRoles);
            }
            Context.UsersRoles.RemoveRange(userRolesToRemove);
            Context.SaveChanges();
            return _mapper.Map<Model.User>(entity);
        }

        public async Task<Model.User> Login(string username, string password)
        {
            var entity = await Context.Users.Include("UserRoles.Role").FirstOrDefaultAsync(x => x.UserName == username);

            if (entity == null)
            {
                throw new UserException("Pogrešan username ili password");
            }

            var hash = GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
            {
                throw new UserException("Pogrešan username ili password");
            }
            return _mapper.Map<Model.User>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}