using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Training.ApplicationCore.Entities
{
    public class Shipper
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }

        public ICollection<ShipperRegion> ShipperRegions { get; set; }
    }
}
