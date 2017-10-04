using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentSys.Models
{
    public class Apartment
    {
        public int ApartmentId { get; set; }
        public int ApartmentNumber { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public string Location { get; set; }
        public string Floor { get; set; }
        public string Amenities { get; set; }
        public bool Available { get; set; }
    }
}