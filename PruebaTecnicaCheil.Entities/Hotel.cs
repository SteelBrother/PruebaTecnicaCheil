using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCheil.Entities
{
    public class Hotel : Entity
    {
        //[Key]
        //public int HotelId { get; set; }
        public string HotelName { get; set; }
        public int Category { get; set; }
        public float Price { get; set; }
        public virtual ICollection<Qualification> Qualifications { get; set; }
        public virtual ICollection<Photos> Photos { get; set; }
    }
}
