using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentSys.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public int ApartmentId { get; set; }
        public int TenantId { get; set; }

        public virtual Tenant Tenant { get; set; }
        public virtual Apartment Apartment { get; set; }

    }
}