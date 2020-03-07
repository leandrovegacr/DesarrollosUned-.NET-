using System;

using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tarea3_DesarrollosUned
{
    public partial class Form1 : Form
    {
        public int TrabajoReg { get; private set; } = -1;//variable para el registro de trabajos
        public int TrabajoCons { get; private set; } = -1;//variable para consulta de trabajos

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //botón para salir del entorno.
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar el programa", "Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(0);
        }

        //función para habilitar la posibilidad de ingresar información.
        private void BtnIngresa_Click(object sender, EventArgs e)
        {
            TabControl.Visible = true;
            TabControl.SelectedTab = tabPage1;
        }

        //botón para habilitar la posibilidad de consultar información.
        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            if (!ClsTrabajo.trabajos.Any())
            {
                MessageBox.Show("Debe ingresar primero un trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TabControl.Visible = true;
                TabControl.SelectedTab = tabPage3;
            }
            //se define el origen de los desplegables en el Combobox de identificación en el apartado de consultas
            CmbIdentif.DataSource = ClsTrabajo.trabajos;
            CmbIdentif.ValueMember = "IdTrabajo";
            CmbIdentif.DisplayMember = "IdTrabajo";
        }

        
        /*
         * Esta función se lanza cuando se elige un tipo de trabajo en el combobox correspondiente
         * en el apartado de "registrar trabajo".
         * Se asigna una variable Trabajo, con base en la cual se despliegan los controles adecuados
         * para el tipo de trabajo por registrar.
         * 
         */
        private void CmbTrabajos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrabajoReg = CmbTrabajos.SelectedIndex;
            PnlCualidades.Visible = true;
            switch (TrabajoReg)
            {
                case 0:
                    {
                        TxtDescripcion.Text = null;
                        TxtTiempo.Text = null;
                        TxtTercero.Text = null;
                        LblTercero.Visible = true;
                        TxtTercero.Visible = true;
                        LblTercero.Text = "Puntos de Historia";
                        TxtTercero.Location = new Point(524, 225);
                        TxtTercero.Size = new Size(166, 31);
                        break;
                    }
                case 1:
                    {
                        TxtDescripcion.Text = null;
                        TxtTiempo.Text = null;
                        TxtTercero.Text = null;
                        LblTercero.Visible = false;
                        TxtTercero.Visible = false;
                        break;
                    }
                case 2:
                    {
                        TxtDescripcion.Text = null;
                        TxtTiempo.Text = null;
                        TxtTercero.Text = null;
                        LblTercero.Visible = true;
                        TxtTercero.Visible = true;
                        LblTercero.Text = "Caso de Prueba";
                        TxtTercero.Location = new Point(261, 225);
                        TxtTercero.Size = new Size(429, 90);
                        break;
                    }
            }
        }

        //borra la información que esté en lso textboxes.
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (TrabajoReg == -1)
            {
                MessageBox.Show("Debe seleccionar primero un trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TxtDescripcion.Text = null;
            TxtTiempo.Text = null;
            TxtTercero.Text = null;
        }

        /*
         * Cuando se presiona el botón "registrar" la información en los textboxes se almacena en un
         * objeto del tipo que corresponda. La primera validación es para que, si la lista está vacía,
         * se cree un objeto nulo, pues siempre se me genera un registro en la tabla cuando abro el
         * apartado de consultas, pues en el combobox de Id no logré que no apareciera, de una vez
         * un valor. En fin, lo que decidí fue crear un objeto nulo para que al menos no aparezca por 
         * defecto el primer trabajo ingresado.
         * 
         */
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ClsTrabajo.trabajos.Any())
            {
                ClsTrabajo t = new ClsTrabajo(null, null);
                ClsTrabajo.trabajos.Add(t);
            }

            switch (TrabajoReg)
            {
                case 0:
                    {
                        try
                        {
                            if (TxtDescripcion.Text!="")
                            {
                                string descripcion = TxtDescripcion.Text;
                                double tiempo = Convert.ToDouble(TxtTiempo.Text);
                                int puntos = Convert.ToInt32(TxtTercero.Text);
                                ClsHistoria historia = new ClsHistoria(descripcion, tiempo, puntos);
                                ClsTrabajo.trabajos.Add(historia);
                                MessageBox.Show(String.Format("Historia creada correctamente con el id: {0}", historia.Id), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No puede dejar el espacio Descripción en blanco", "La historia no se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Revise los parámetros ingresados", "La historia no se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case 1:
                    {
                        try
                        {
                            if (TxtDescripcion.Text != "")
                            {
                                string descripcion = TxtDescripcion.Text;
                                double tiempo = Convert.ToDouble(TxtTiempo.Text);
                                ClsCajaT caja = new ClsCajaT(descripcion, tiempo);
                                ClsTrabajo.trabajos.Add(caja);
                                MessageBox.Show(String.Format("Caja de tiempo creada correctamente con el id: {0}", caja.Id), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        else
                            {
                                MessageBox.Show("No puede dejar el espacio Descripción en blanco", "La caja de tiempo no se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Revise los parámetros ingresados", "La caja de tiempo no se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case 2:
                    {
                        try
                        {
                            if (TxtDescripcion.Text != "" && TxtTercero.Text!="")
                            {
                                string descripcion = TxtDescripcion.Text;
                                double tiempo = Convert.ToDouble(TxtTiempo.Text);
                                string casoPrueba = TxtTercero.Text;
                                ClsBug bug = new ClsBug(descripcion, tiempo, casoPrueba);
                                ClsTrabajo.trabajos.Add(bug);
                                MessageBox.Show(String.Format("Bug creado correctamente con el id: {0}", bug.Id), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            }
                            else
                            {
                                MessageBox.Show("No puede dejar el espacio Descripción o Caso de Prueba en blanco", "El bug no se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                           
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Revise los parámetros ingresados", "El bug no se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                default:
                    MessageBox.Show("Debe seleccionar primero un trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        /*
         * Esta función es para el combobox de Ids, en el apartado de consulta.
         * Toma el número elegido en el combobox y lo compara con los Id almacenados
         * en la lista, y despliega la información del item con que haya hecho match.
         * 
         */
        private void CmbIdentif_SelectedIndexChanged(object sender, EventArgs e)
        {
            PnlData.Visible = true;
            foreach (var t in ClsTrabajo.trabajos)
            {
                if (CmbIdentif.SelectedIndex == t.IdTrabajo)
                {
                    DgvInformacion.Rows.Clear();
                    DgvInformacion.Refresh();
                    DgvInformacion.Rows[0].Cells[0].Value = t.IdTrabajo;
                    DgvInformacion.Rows[0].Cells[1].Value = t.Descripcion;
                    DgvInformacion.Rows[0].Cells[2].Value = t.TiempoEst;
                    if (t is ClsHistoria h)
                    {
                        DgvInformacion.Columns[3].Visible = true;
                        DgvInformacion.Columns[3].Width = 70;
                        DgvInformacion.Columns[3].HeaderText = "Puntos";
                        DgvInformacion.Rows[0].Cells[3].Value = h.Puntos;
                        DgvInformacion.Rows[0].Cells[4].Value = "Historia";
                    }
                    else if (t is ClsBug b)
                    {
                        DgvInformacion.Columns[3].Visible = true;
                        DgvInformacion.Columns[3].HeaderText = "Caso";
                        DgvInformacion.Rows[0].Cells[3].Value = b.CasoPrueba;
                        DgvInformacion.Rows[0].Cells[4].Value = "Bug";
                    }
                    else if (t is ClsCajaT c)
                    {
                        DgvInformacion.Columns[3].Visible = false;
                        DgvInformacion.Rows[0].Cells[4].Value = "Caja Tiempo";
                    }
                }
            }
        }

        /*
         * Esta función es la que se lanza cuando se elige un tipo de trabajo en el combobox
         * de consultas. Lo que hace es recorrer toda la lista y buscar un match con el tipo 
         * de trabajo elegido, en cuyo caso imprime la información en el datagridview.
         */
        private void CmbTrab_SelectedIndexChanged(object sender, EventArgs e)
        {
            PnlData.Visible = true;
            DgvInformacion.Columns[4].Visible = false;
            TrabajoCons = CmbTrab.SelectedIndex;
            int n;
            switch (TrabajoCons)
            {
                case 0:
                    DgvInformacion.Rows.Clear();
                    DgvInformacion.Refresh();
                    foreach (var t in ClsTrabajo.trabajos)
                    {
                        if (t is ClsHistoria h)
                        {
                            DgvInformacion.Columns[3].Visible = true;
                            DgvInformacion.Columns[3].Width = 70;
                            DgvInformacion.Columns[3].HeaderText = "Puntos";
                            n = DgvInformacion.Rows.Add();
                            DgvInformacion.Rows[n].Cells[0].Value = h.Id;
                            DgvInformacion.Rows[n].Cells[1].Value = h.Descripcion;
                            DgvInformacion.Rows[n].Cells[2].Value = h.TiempoEst;
                            DgvInformacion.Rows[n].Cells[3].Value = h.Puntos;
                        }
                    }
                    break;
                case 1:
                    DgvInformacion.Rows.Clear();
                    DgvInformacion.Refresh();
                    foreach (var t in ClsTrabajo.trabajos)
                    {
                        if (t is ClsCajaT c)
                        {
                            DgvInformacion.Columns[3].Visible = false;
                            n = DgvInformacion.Rows.Add();
                            DgvInformacion.Rows[n].Cells[0].Value = c.Id;
                            DgvInformacion.Rows[n].Cells[1].Value = c.Descripcion;
                            DgvInformacion.Rows[n].Cells[2].Value = c.TiempoEst;
                        }
                    }
                    break;
                case 2:
                    DgvInformacion.Rows.Clear();
                    DgvInformacion.Refresh();
                    foreach (var t in ClsTrabajo.trabajos)
                    {
                        if (t is ClsBug b)
                        {
                            DgvInformacion.Columns[3].Visible = true;
                            DgvInformacion.Columns[3].HeaderText = "Caso";
                            n = DgvInformacion.Rows.Add();
                            DgvInformacion.Rows[n].Cells[0].Value = b.Id;
                            DgvInformacion.Rows[n].Cells[1].Value = b.Descripcion;
                            DgvInformacion.Rows[n].Cells[2].Value = b.TiempoEst;
                            DgvInformacion.Rows[n].Cells[3].Value = b.CasoPrueba;

                        }
                    }
                    break;

                default:
                    break;
            }
            PnlData.Visible = true;
        }
    }
}
