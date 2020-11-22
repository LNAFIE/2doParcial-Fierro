using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _2doParcial_Fierro_POO
{
    public partial class Form1 : Form
    {

       // Proyectos P = new Proyectos();
        public Form1()
        {
            InitializeComponent();
        }

        //Empresa empresa = new Empresa();
       // public List<Proyectos> ProyectosList = new List<Proyectos>();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //Permite que cuando haces clic en una celda de la grilla, seleccione toda la fila 
            dataGridPROYECTOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        void Limpiar()
        {
            TxtLegajo.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtEdad.Clear();
            TxtPeonesACargo.Clear();
            // TxtHorasTrabajadas.Clear();
            TxtProyectosACargo.Clear();

        }

        //Listas de Empleados y Puestos
        //public List<Empleado> ListaEmpleados = new List<Empleado>();







        public void ActualizarMatrizEmpleados()
        {


            if (radioPeon.Checked)
            {
                dataGridView1.DataSource = null;
                //  dataGridView1.DataSource = ListaPeon;
            }
            else if (radioCapataz.Checked)
            {
                dataGridView1.DataSource = null;
                //dataGridView1.DataSource = ListaCapataz;
            }
            else
            {
                dataGridView1.DataSource = null;
                //  dataGridView1.DataSource = ListaArquitecto;
            }

        }


        /* private bool Validar()
         {
             bool bandera = false;

             foreach (Empleado item in empresa.getListaEmp())
             {
                 if (item.legajo == int.Parse(TxtLegajo.Text))
                 {
                     bandera = true;
                 }
             }

             return bandera;
         }

 */
        public void Evento()
        {
            MessageBox.Show("Se ha cargado un empleado");
        }

        string PUESTO;

        private void capatazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaCapataz FRMCapataz = new FormAltaCapataz();
            FRMCapataz.Show();
        }




        /* private void btnCARGAR_EMPLEADO_Click(object sender, EventArgs e)
         {
             if (Validar() == false)
             {

                 if (radioPeon.Checked == true)
                 {
                     PUESTO = radioPeon.Text;
                     //Esto se usa!
                    // Peon peon = new Peon(int.Parse(TxtLegajo.Text), TxtNombre.Text, TxtApellido.Text, int.Parse(TxtEdad.Text), radioPeon.Text, int.Parse(TxtHorasTrabajadas.Text));
                     //peon.CalcularSueldo();
                    // ListaPeon.Add(peon);


                 }

                 //Esto usarlo!!
               /*   if (radioArquitecto.Checked == true)
                 {
                     PUESTO = radioArquitecto.Text;
                     Arquitecto arquitecto = new Arquitecto(int.Parse(TxtLegajo.Text), TxtNombre.Text, TxtApellido.Text, int.Parse(TxtEdad.Text), radioArquitecto.Text, int.Parse(TxtProyectosACargo.Text),int.Parse(Cant_Proyecto.Text));
                     arquitecto.CalcularSueldo();
                     ListaArquitecto.Add(arquitecto);
                 }
               */
        /* ActualizarMatrizEmpleados();
         txtRecaudacionTOTAL.Text = empresa.RecaudacionTotal().ToString();
         txtCategoriaMASEmpleados.Text = empresa.CategoriaConMasEmpleados();

         Limpiar();
         Evento();
     }
     else
     {
         MessageBox.Show("Legajo existente", "ERROR");
     }

 }

 private void groupBox3_Enter(object sender, EventArgs e)
 {

 }

 private void btnCARGRA_PROYECTO_Click(object sender, EventArgs e)
 {
     //Arq temporal

     Arquitecto ArqTemp = (Arquitecto)dataGridView1.SelectedRows[0].DataBoundItem;

     Proyectos P = new Proyectos(int.Parse(Nro_Proyecto.Text), int.Parse(TxtLegajo.Text), int.Parse(Duracion_Proyecto.Text), int.Parse(Cant_Proyecto.Text));



     foreach (Arquitecto A in empresa.listaemp)
     {
         if (A.legajo == ArqTemp.legajo)
         {
             P.Legajo_Arquitecto = A.legajo;
             A.Cantproyectos++;

         }
         break;
     }
     ProyectosList.Add(P);
     ActualizarMatrizEmpleados();
     ActualizarMatrizProyectos();
 }

 private void ActualizarMatrizProyectos()
 {
     dataGridPROYECTOS.DataSource = null;
     dataGridPROYECTOS.DataSource = ProyectosList;
 }
 /// <summary>
 /// 
 /// </summary>
 /// <param name="sender"></param>
 /// <param name="e"></param>
/* private void AÑADIR_EMPLEADO_A_PROYECTO_Click(object sender, EventArgs e)
 {
     Empleado Etemp = (Empleado)dataGridView1.SelectedRows[0].DataBoundItem;

 */





        /*if (Etemp.puesto == "Arquitecto")
        {
            Proyectos Myproyect = new Proyectos();
            Myproyect.Legajo_Arquitecto = Etemp.legajo;
            Myproyect.DuracionProyecto = int.Parse(Duracion_Proyecto.Text);
            Myproyect.NroProyecto = int.Parse(Nro_Proyecto.Text);
            Myproyect.Cantproyecto = int.Parse(Cant_Proyecto.Text);

            ProyectosList.Add(Myproyect);





        }

        */

        /* foreach (Proyectos P in ProyectosList)
         {
             if (Ptemp.NroProyecto == P.NroProyecto)
             {
                 if (Ptemp.puesto== "Arquitecto")
                 {
                     MessageBox.Show("Error","Ya existe un Arquitecto a cargo del proyecto",MessageBoxButtons.OK,MessageBoxIcon.Error);
                 }

                 else if (CEtemp.puesto == "Capataz")
                 {

                     if(P.LisstCapataces.Count <=3)
                     {
                         foreach(Capataz C in empresa.listaemp)
                         {
                             if(CEtemp.legajo==C.legajo)
                             {

                                 P.LisstCapataces.Add(C);
                             }
                             break;

                         }



                     }
                     else
                     {
                         MessageBox.Show("Error","Cantidad maxima de Capataces existentes superada",MessageBoxButtons.OK,MessageBoxIcon.Error);
                     }


                 }
                 else
                 {

                     if(P.LisstPeones.Count <= 10)
                     {
                         Peon Pe = new Peon(PeonEtemp.legajo, PeonEtemp.nombre, PeonEtemp.apellido, PeonEtemp.edad, PeonEtemp.puesto, PeonEtemp.Horastrabajadas);
                         P.LisstPeones.Add(Pe);
                         ActualizarMatrizProyectos();
                     }
                     else
                     {
                         MessageBox.Show("Error", "Cantidad maxima de Peones existentes superada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }

                 }
                 break;
             }
         }

     }
        */


    }
}
    /*
        private void radioArquitecto_CheckedChanged(object sender, EventArgs e)
        {
            Nro_Proyecto.Enabled = true;
            Duracion_Proyecto.Enabled = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void capatazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaCapataz FrmAltaCapataz = new FormAltaCapataz();

            FrmAltaCapataz.Show();


        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnCARGAR_EMPLEADO_Click_1(object sender, EventArgs e)
        {

        }

        private void peonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaPeon frmAltaPeon = new FormAltaPeon();
            frmAltaPeon.Show();
        }

        private void arquitectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaArquitecto frmAltaArquitecto = new FormAltaArquitecto();
            frmAltaArquitecto.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
*/