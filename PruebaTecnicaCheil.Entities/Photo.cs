using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCheil.Entities
{
    public class Photos : Entity
    {
        public string UrlPhoto { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
