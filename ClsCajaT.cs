using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_DesarrollosUned
{
    class ClsCajaT : ClsTrabajo
    {
        public int Id { get; private set; }
        public ClsCajaT(string descripcion, double tiempoEst) : base(descripcion, tiempoEst)
        {
            Id = IdTrabajo;
        }
    }
}
