using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApartmentSys.Models
{
    public class PropertyInitializer:DropCreateDatabaseIfModelChanges<PropertyContext>
    {
        protected override void Seed(PropertyContext context)
        {
            var properties = new List<Apartment>
            {
                //new Apartment{"Swimming Pool,Furnitures",1,1714,true,"ground","777 Fairway Dr, Coppell,TX","$1600","3BHK"},
                
            };
        }
    }
}