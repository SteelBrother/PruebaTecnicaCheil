using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCheil.Entities
{
    public class Qualification : Entity
    {
        public int Rank { get; set; }
        public string Comentary { get; set; }
        public virtual Hotel Hotel { get; set; }

    }
}
