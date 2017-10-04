using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentSys.Models
{
    public class Tenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public string PermanentAddress { get; set; }
        public string LicenseNo { get; set; }
        public int FamilySize { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        
    }
}