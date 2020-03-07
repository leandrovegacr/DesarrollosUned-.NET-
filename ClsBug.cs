using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_DesarrollosUned
{
    class ClsBug : ClsTrabajo
    {
        public int Id { get; private set; }
        public string CasoPrueba { get; set; }
        public ClsBug(string descripcion, double tiempoEst, string casoprueba) : base(descripcion, tiempoEst)
        {
            Id = IdTrabajo;
            CasoPrueba = casoprueba;
        }
    }
}
