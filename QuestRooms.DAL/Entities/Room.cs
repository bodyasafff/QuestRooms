using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TimeGoing { get; set; }
        public virtual Address Address { get; set; }
        public int MaxPlayers { get; set; }
        public int MinPlayers { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Rating { get; set; }
        public int LvlFear { get; set; }
        public int LvlDifficulty { get; set; }
        public string Logo { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
