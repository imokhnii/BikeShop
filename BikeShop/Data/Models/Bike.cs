using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Data.Models
{
    public class Bike
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public ushort Price { get; set; }

        //Some other characteristics

        public bool IsFavourite { get; set; }

        public bool Available { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
