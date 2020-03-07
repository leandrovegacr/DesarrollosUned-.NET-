using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_DesarrollosUned
{
    class ClsHistoria : ClsTrabajo
    {
        public int Puntos { get; set; }
        public int Id { get; set; }

        public ClsHistoria(string descripcion, double tiempoEst,int puntos) : base(descripcion, tiempoEst)
        {
            Id=IdTrabajo;
            Puntos = puntos;
        }

    }
}
