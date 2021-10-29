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

            //ROLES
            if (!context.Roles.Any(x => x.Name == "Administrator"))
            {
                context.Roles.Add(new Role { Name = "Administrator" });
            }
            if(!context.Roles.Any(x => x.Name == "Agent"))
            {
                context.Roles.Add(new Role { Name = "Agent" });
            }
            context.SaveChanges();

            //USERS
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
                    PasswordHash = "lR1OXReev+1K6c7/yJx9wKXOi9k=",
                    PasswordSalt = "tyHlAlf9hHcYibxHpG01xA=="
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
                    PasswordHash = "qylkRtl9+mOd8UOsa4UN/VR2iNc=",
                    PasswordSalt = "5MmCglFy/ezYLsx6QSKVlA=="
                });
            }
            context.SaveChanges();

            //USERROLES
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

            //Country
            if(!context.Countries.Any(x => x.Name == "Bosna i Hercegovina"))
            {
                context.Countries.Add(new Country
                {
                    Name = "Bosna i Hercegovina"
                });
            }
            if (!context.Countries.Any(x => x.Name == "Hrvatska"))
            {
                context.Countries.Add(new Country
                {
                    Name = "Hrvatska"
                });
            }
            if (!context.Countries.Any(x => x.Name == "Crna Gora"))
            {
                context.Countries.Add(new Country
                {
                    Name = "Crna Gora"
                });
            }
            context.SaveChanges();

            //City
            var bosnaIHercegovinaId = context.Countries.First(x => x.Name == "Bosna i Hercegovina").Id;
            var hrvatskaId = context.Countries.First(x => x.Name == "Hrvatska").Id;
            var crnaGoraId = context.Countries.First(x => x.Name == "Crna Gora").Id;

            if (!context.Cities.Any(x => x.Name == "Mostar"))
            {
                context.Cities.Add(new City
                {
                    Name = "Mostar",
                    CountryId = bosnaIHercegovinaId
                });
            }
            if (!context.Cities.Any(x => x.Name == "Sarajevo"))
            {
                context.Cities.Add(new City
                {
                    Name = "Sarajevo",
                    CountryId = bosnaIHercegovinaId
                });
            }
            if (!context.Cities.Any(x => x.Name == "Tuzla"))
            {
                context.Cities.Add(new City
                {
                    Name = "Tuzla",
                    CountryId = bosnaIHercegovinaId
                });
            }
            if (!context.Cities.Any(x => x.Name == "Makarska"))
            {
                context.Cities.Add(new City
                {
                    Name = "Makarska",
                    CountryId = hrvatskaId
                });
            }
            if (!context.Cities.Any(x => x.Name == "Split"))
            {
                context.Cities.Add(new City
                {
                    Name = "Split",
                    CountryId = hrvatskaId
                });
            }
            if (!context.Cities.Any(x => x.Name == "Budva"))
            {
                context.Cities.Add(new City
                {
                    Name = "Budva",
                    CountryId = crnaGoraId
                });
            }
            context.SaveChanges();

            //OfferType
            if(!context.OfferTypes.Any(x => x.Name == "Prodaja"))
            {
                context.OfferTypes.Add(new OfferType
                {
                    Name = "Prodaja"
                });
            }
            if (!context.OfferTypes.Any(x => x.Name == "Izdavanje"))
            {
                context.OfferTypes.Add(new OfferType
                {
                    Name = "Izdavanje"
                });
            }
            context.SaveChanges();

            //Category
            if (!context.Categories.Any(x => x.Name == "Stan"))
            {
                context.Categories.Add(new Category
                {
                    Name = "Stan"
                });
            }
            if (!context.Categories.Any(x => x.Name == "Kuća"))
            {
                context.Categories.Add(new Category
                {
                    Name = "Kuća"
                });
            }
            if (!context.Categories.Any(x => x.Name == "Zemljište"))
            {
                context.Categories.Add(new Category
                {
                    Name = "Zemljište"
                });
            }
            if (!context.Categories.Any(x => x.Name == "Poslovni prostor"))
            {
                context.Categories.Add(new Category
                {
                    Name = "Poslovni prostor"
                });
            }
            if (!context.Categories.Any(x => x.Name == "Apartman"))
            {
                context.Categories.Add(new Category
                {
                    Name = "Apartman"
                });
            }
            context.SaveChanges();
        }
    }
}
