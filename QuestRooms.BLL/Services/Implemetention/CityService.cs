using DataAccessLayer.Repositories;
using QuestRooms.BLL.DTOModels;
using QuestRooms.BLL.Services.Abstraction;
using QuestRooms.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Services.Implemetention
{
    public class CityService : ICityService
    {
        private readonly IGenericRepository<City> repos;
        public CityService(IGenericRepository<City> _repos)
        {
            repos = _repos;
        }
        public ICollection<CityDTO> GetCityes()
        {
            List<CityDTO> res = new List<CityDTO>();
            var cityes = repos.GetAll();
            cityes.ToList().ForEach(q => res.Add(new CityDTO { Id = q.Id, Name = q.Name }));
            return res;
        }
    }
}
