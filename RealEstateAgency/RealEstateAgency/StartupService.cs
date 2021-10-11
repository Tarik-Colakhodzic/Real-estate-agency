using RealEstateAgency.Database;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RealEstateAgency
{
    public class SetupService
    {
        public void Init(RealEstateAgencyContext context)
        {
            //TODO popuniti podatke za sve tabele
            context.Database.Migrate();

            if(!context.Roles.Any(x => x.Name == "Administrator"))
            {
                context.Roles.Add(new Role { Name = "Administrator" });
            }
            if(!context.Roles.Any(x => x.Name == "Agent"))
            {
                context.Roles.Add(new Role { Name = "Agent" });
            }
            context.SaveChanges();

            var adminRoleId = context.Roles.First(x => x.Name == "Administrator").Id;
            var agentRoleId = context.Roles.First(x => x.Name == "Agent").Id;

            if (!context.Users.Any(x => x.UserName == "Administrator"))
            {
                context.Users.Add(new User
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@gmail.com",
                    PhoneNumber = "060 000 000",
                    UserName = "Administrator",
                    PasswordHash = "Admin",
                    PasswordSalt = "Admin"
                });
            }
            if(!context.Users.Any(x => x.UserName == "Agent"))
            {
                context.Users.Add(new User
                {
                    FirstName = "Agent",
                    LastName = "Agent",
                    Email = "agent@gmail.com",
                    PhoneNumber = "060 000 000",
                    UserName = "Agent",
                    PasswordHash = "Agent",
                    PasswordSalt = "Agent"
                });
            }
            context.SaveChanges();

            var adminUserId = context.Users.First(x => x.UserName == "Administrator").Id;
            var agentUserId = context.Users.First(x => x.UserName == "Agent").Id;

            if(!context.UsersRoles.Any(x => x.UserId == adminUserId && x.RoleId == adminRoleId))
            {
                context.UsersRoles.Add(new UserRoles
                {
                    RoleId = adminRoleId,
                    UserId = adminUserId
                });
            }
            if(!context.UsersRoles.Any(x => x.UserId == agentUserId && x.RoleId == agentRoleId))
            {
                context.UsersRoles.Add(new UserRoles
                {
                    RoleId = agentRoleId,
                    UserId = agentUserId
                });
            }
            context.SaveChanges();
        }
    }
}
