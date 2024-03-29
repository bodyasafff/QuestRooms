﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public virtual City City { get; set; }
        public virtual Street Street { get; set; }
        public virtual Country Country { get; set; }
        public string HouseNumber { get; set; }
        public virtual ICollection<Room>Rooms { get; set; }
    }
}
