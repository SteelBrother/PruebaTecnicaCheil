using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaCheil.WebApi.DTOs
{
    public class HotelDTO
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public int Category { get; set; }
        public float Price { get; set; }
    }
}
