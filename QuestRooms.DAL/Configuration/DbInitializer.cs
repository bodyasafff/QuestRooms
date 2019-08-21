using QuestRooms.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Configuration
{
    public class DbInitializer:DropCreateDatabaseAlways<RoomsContext>
    {
        protected override void Seed(RoomsContext context)
        {
            for (int i = 0; i < 150; i++)
            {
                Address address = new Address();
                address.City = new City { Name = "Dubno" };
                address.Street = new Street { Name = "Kosmonavtiv" };
                address.Country = new Country { Name = "Ukraine" };

                Company company = new Company();
                company.Name = "CompaniyaBomgiv";


                Room room = new Room();
                room.Address = address;
                room.Company = company;
                room.Name = "Komnatakaroch";
                room.Phone = "+380569877452";
                room.Email = "vanichiNoski@gmail.com";
                room.Description = "TypaOpisanie";
                room.Logo = "logo.png";
                room.LvlDifficulty = 5;
                room.LvlFear = 6;
                room.MaxPlayers = 10;
                room.MinPlayers = 3;
                room.TimeGoing = DateTime.Now;
                room.Rating = 99999;
                context.SaveChanges();
            }

        }
    }
}
