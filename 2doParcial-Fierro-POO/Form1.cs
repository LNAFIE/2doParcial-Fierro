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
        public Form1()
        {
            InitializeComponent();
        }

        Empresa empresa = new Empresa();
        public List<Proyectos> ProyectosList = new List<Proyectos>();
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
            TxtHorasTrabajadas.Clear();
            TxtProyectosACargo.Clear();

        }

        //Listas de Empleados y Puestos
       public  List<Empleado> ListaEmpleados = new List<Empleado>();
       public  List<Arquitecto> ListaArquitecto = new List<Arquitecto>();
       public  List<Capataz> ListaCapataz = new List<Capataz>();
       public  List<Peon> ListaPeon = new List<Peon>();


        public void LinkearEmpleados()
        {
            ListaEmpleados.Clear();
            
            foreach(Arquitecto A in ListaArquitecto )
            {
                ListaEmpleados.Add(A);
            }
            
            foreach(Capataz C in ListaCapataz)
            {

                ListaEmpleados.Add(C);
            }

            foreach(Peon P in ListaPeon)
            {
                ListaEmpleados.Add(P);
            }

           
        }


        public void ActualizarMatrizEmpleados()
        {
            LinkearEmpleados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaEmpleados;
        }

        
        private bool Validar()
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


        public void Evento()
        {
            MessageBox.Show("Se ha cargado un empleado");
        }

        string PUESTO;




        private void btnCARGAR_EMPLEADO_Click(object sender, EventArgs e)
        {
            if (Validar() == false)
            {
                if (radioCapataz.Checked == true)
                {
                    PUESTO = radioCapataz.Text;
                    Capataz capataz = new Capataz(int.Parse(TxtLegajo.Text), TxtNombre.Text, TxtApellido.Text, int.Parse(TxtEdad.Text), int.Parse(TxtPeonesACargo.Text), radioCapataz.Text);
                    capataz.CalcularSueldo();
                    ListaCapataz.Add(capataz);

                }
                if (radioPeon.Checked == true)
                {
                    PUESTO = radioPeon.Text;
                    Peon peon = new Peon(int.Parse(TxtLegajo.Text), TxtNombre.Text, TxtApellido.Text, int.Parse(TxtEdad.Text), int.Parse(TxtHorasTrabajadas.Text), radioPeon.Text);
                    peon.CalcularSueldo();
                    ListaPeon.Add(peon);
                    

                }
                if (radioArquitecto.Checked == true)
                {
                    PUESTO = radioArquitecto.Text;
                    Arquitecto arquitecto = new Arquitecto(int.Parse(TxtLegajo.Text), TxtNombre.Text, TxtApellido.Text, int.Parse(TxtEdad.Text), int.Parse(TxtProyectosACargo.Text), radioArquitecto.Text);
                    arquitecto.CalcularSueldo();
                    ListaArquitecto.Add(arquitecto);
                }

                ActualizarMatrizEmpleados();
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

            Proyectos P = new Proyectos(int.Parse(Nro_Proyecto.Text), 
                ArqTemp.legajo,int.Parse(Duracion_Proyecto.Text)); 
           

            foreach(Arquitecto A in empresa.listaemp)
            {
                if(A.legajo==ArqTemp.legajo)
                {
                    P.Legajo_Arquitecto = A.legajo;
                    A.CantProyectos++;
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
        private void AÑADIR_EMPLEADO_A_PROYECTO_Click(object sender, EventArgs e)
        {
            Empleado Etemp = (Empleado)dataGridView1.SelectedRows[0].DataBoundItem;
            Proyectos Ptemp = (Proyectos)dataGridPROYECTOS.SelectedRows[0].DataBoundItem;
            foreach (Proyectos P in ProyectosList)
            {
                if (Ptemp.NroProyecto == P.NroProyecto)
                {
                    if (Etemp.puesto == "Arquitecto")
                    {
                        MessageBox.Show("Error","Ya existe un Arquitecto a cargo del proyecto",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                    else if (Etemp.puesto == "Capataz")
                    {
                        
                        if(P.LisstCapataces.Count <=3)
                        {
                            foreach(Capataz C in empresa.listaemp)
                            {
                                if(Etemp.legajo==C.legajo)
                                {
                                    Proyectos.LisstCapataces.Add(C);
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
                            Peon Pe = new Peon(Etemp.legajo, Etemp.nombre, Etemp.apellido, Etemp.edad, Etemp.puesto);
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

        private void Duracion_Proyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
