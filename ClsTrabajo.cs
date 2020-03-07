using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_DesarrollosUned
{
    /*
     * Clase base, de la que heredan ClsHistoria, ClsBug y ClsCajaT. Tiene los dos atributos que
     * son comunes a los tres tipos de trabajo, así como la lista en que se van almacenando las
     * instancias que se vayan creando.
     * 
     * Acá también está el Id, que se va autoincrementando conforme se instancia algún objeto.
     */
    class ClsTrabajo
    {
        public static int TrabajoSig = 0;
        public int IdTrabajo { get; private set; }
        public string Descripcion { get; set; }
        public double? TiempoEst { get; set; }

        public static BindingList<ClsTrabajo> trabajos = new BindingList<ClsTrabajo>();

        public ClsTrabajo(string descripcion, double? tiempoEst)
        {
            IdTrabajo = TrabajoSig++;
            Descripcion = descripcion;
            TiempoEst = tiempoEst;
        }
    }
}
