using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Database;
using System;
using System.Linq;

namespace RealEstateAgency
{
    public class SetupService
    {
        public void Init(RealEstateAgencyContext context)
        {
            context.Database.Migrate();

            #region ROLES

            if (!context.Roles.Any(x => x.Name == "Administrator"))
            {
                context.Roles.Add(new Role { Name = "Administrator" });
            }
            if (!context.Roles.Any(x => x.Name == "Agent"))
            {
                context.Roles.Add(new Role { Name = "Agent" });
            }
            if (!context.Roles.Any(x => x.Name == "Client"))
            {
                context.Roles.Add(new Role { Name = "Client" });
            }
            context.SaveChanges();

            #endregion ROLES

            #region USERS

            var adminRoleId = context.Roles.First(x => x.Name == "Administrator").Id;
            var agentRoleId = context.Roles.First(x => x.Name == "Agent").Id;
            var clientRoleId = context.Roles.First(x => x.Name == "Client").Id;

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
            if (!context.Users.Any(x => x.UserName == "Agent"))
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
            if (!context.Users.Any(x => x.UserName == "Client"))
            {
                context.Users.Add(new User
                {
                    FirstName = "Client",
                    LastName = "Client",
                    Email = "client@gmail.com",
                    PhoneNumber = "060 000 000",
                    UserName = "Client",
                    PasswordHash = "qylkRtl9+mOd8UOsa4UN/VR2iNc=",
                    PasswordSalt = "5MmCglFy/ezYLsx6QSKVlA=="
                });
            }
            context.SaveChanges();

            #endregion USERS

            #region USERROLES

            var adminUserId = context.Users.First(x => x.UserName == "Administrator").Id;
            var agentUserId = context.Users.First(x => x.UserName == "Agent").Id;
            var clientUserId = context.Users.First(x => x.UserName == "Client").Id;

            if (!context.UsersRoles.Any(x => x.UserId == adminUserId && x.RoleId == adminRoleId))
            {
                context.UsersRoles.Add(new UserRoles
                {
                    RoleId = adminRoleId,
                    UserId = adminUserId
                });
            }
            if (!context.UsersRoles.Any(x => x.UserId == agentUserId && x.RoleId == agentRoleId))
            {
                context.UsersRoles.Add(new UserRoles
                {
                    RoleId = agentRoleId,
                    UserId = agentUserId
                });
            }
            if (!context.UsersRoles.Any(x => x.UserId == clientUserId && x.RoleId == clientRoleId))
            {
                context.UsersRoles.Add(new UserRoles
                {
                    RoleId = clientRoleId,
                    UserId = clientUserId
                });
            }
            context.SaveChanges();

            #endregion USERROLES

            #region Country

            if (!context.Countries.Any(x => x.Name == "Bosna i Hercegovina"))
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
            var bosnaIHercegovinaId = context.Countries.First(x => x.Name == "Bosna i Hercegovina").Id;
            var hrvatskaId = context.Countries.First(x => x.Name == "Hrvatska").Id;
            var crnaGoraId = context.Countries.First(x => x.Name == "Crna Gora").Id;

            #endregion Country

            #region City

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
            var mostarId = context.Cities.First(x => x.Name == "Mostar").Id;
            var budvaId = context.Cities.First(x => x.Name == "Budva").Id;

            #endregion City

            #region OfferType

            if (!context.OfferTypes.Any(x => x.Name == "Prodaja"))
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
            var prodajaId = context.OfferTypes.First(x => x.Name == "Prodaja").Id;
            var izdavanjeId = context.OfferTypes.First(x => x.Name == "Izdavanje").Id;

            #endregion OfferType

            #region Category

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
            var categoryStanId = context.Categories.First(x => x.Name == "Stan").Id;

            #endregion Category

            #region Agent

            if (!context.Agents.Any(x => x.User.Id == agentUserId))
            {
                context.Agents.Add(new Agent
                {
                    Id = agentUserId,
                    HireDate = DateTime.Now,
                    Salary = 1750
                });
            }
            context.SaveChanges();

            #endregion Agent

            #region OWNER

            if (!context.Owners.Any(x => x.FirstName == "Vlasnik" && x.LastName == "Vlasnikovic"))
            {
                context.Owners.Add(new Owner
                {
                    FirstName = "Vlasnik",
                    LastName = "Vlasnikovic",
                    Email = "vlasnik@gmail.com",
                    CityId = context.Cities.First(x => x.Name == "Mostar").Id,
                    PhoneNumber = "061 460 555",
                    Address = "Musala 22"
                });
            }
            if (!context.Owners.Any(x => x.FirstName == "Gazda" && x.LastName == "Gazdic"))
            {
                context.Owners.Add(new Owner
                {
                    FirstName = "Gazda",
                    LastName = "Gazdic",
                    Email = "gazda@gmail.com",
                    CityId = context.Cities.First(x => x.Name == "Mostar").Id,
                    PhoneNumber = "061 460 544",
                    Address = "Musala 20"
                });
            }
            context.SaveChanges();
            var ownerId = context.Owners.First(x => x.FirstName == "Vlasnik").Id;

            #endregion OWNER

            #region PROPERTY

            if (!context.Properties.Any(x => x.Title == "Dvosoban stan na Musali"))
            {
                context.Properties.Add(new Property
                {
                    Title = "Dvosoban stan na Musali",
                    SquareMeters = 60,
                    BalconySquareMeters = 5,
                    ShortDescription = "Dvosoban stan na Musali u samom centru Mostara",
                    Address = "Musala 20",
                    AgentId = agentUserId,
                    OwnerId = ownerId,
                    CategoryId = categoryStanId,
                    PublishDate = DateTime.Now.AddDays(-30),
                    CityId = mostarId,
                    Description = "Dvosoban stan na Musali u neposrednoj blizini svih važnijih dijelova" +
                    "grada. Stan ima 60 kvadrata i 5 kvadrata balkona sa pogledom na Neretvu.",
                    ElectricityConnection = true,
                    Internet = true,
                    Finished = false,
                    WaterConnection = true,
                    NumberOfBathRooms = 1,
                    NumberOfBedRooms = 2,
                    Price = 1100000,
                    OfferTypeId = prodajaId,
                });
            }
            context.SaveChanges();
            var propertyId = context.Properties.First(x => x.Title == "Dvosoban stan na Musali").Id;

            #endregion PROPERTY

            #region CONTRACT

            if (!context.Contracts.Any(x => x.UserId == clientUserId && x.AgentId == agentUserId) && !context.Contracts.Any(x => x.Id == propertyId))
            {
                context.Contracts.Add(new Contract
                {
                    AgentId = agentUserId,
                    Price = 105000,
                    ContractNumber = "557/21",
                    DateCreated = DateTime.Now,
                    Id = propertyId,
                    UserId = clientUserId
                });
            }
            context.SaveChanges();

            #endregion CONTRACT

            #region BOOKOFCOMPLAINTS

            if (!context.BookOfComplaints.Any(x => x.Comment == "Nije došao na zakazanu posjetu!"))
            {
                context.BookOfComplaints.Add(new BookOfComplaints
                {
                    AgentId = agentUserId,
                    DateCreated = DateTime.Now.AddDays(-10),
                    Comment = "Nije došao na zakazanu posjetu!",
                });
            }
            context.SaveChanges();

            #endregion BOOKOFCOMPLAINTS

            #region VISIT

            if (!context.Visits.Any(x => x.UserId == clientUserId && x.PropertyId == propertyId))
            {
                context.Add(new Visit
                {
                    PropertyId = propertyId,
                    UserId = clientUserId,
                    DateTime = DateTime.Now.AddDays(10),
                    Approved = true
                });
            }
            context.SaveChanges();

            #endregion VISIT
        }
    }
}