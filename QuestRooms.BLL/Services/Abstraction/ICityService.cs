using QuestRooms.BLL.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Services.Abstraction
{
    public interface ICityService
    {
        ICollection<CityDTO> GetCityes();
    }
}
