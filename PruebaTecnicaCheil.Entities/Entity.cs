using PruebaTecnicaCheil.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCheil.Entities
{
    public abstract class Entity : IEntity
    {
        public int id { set; get; }
    }
}
