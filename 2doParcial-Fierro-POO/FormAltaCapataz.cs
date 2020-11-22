using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using CapaEntidad;
//Agregar la referencia 


namespace _2doParcial_Fierro_POO
{
    public partial class FormAltaCapataz : Form
    {
        //instanciar el proyecto BLL para poder llamar a la list capataz en la linea 40
        //BLL.CapatazBLL capatazBLL = new CapatazBLL();

        Empleado Entidad = new Empleado();
        EmpleadoEntidad EmpleadoEnti = new EmpleadoEntidad();
        CapatazBLL CapatazBLL = new CapatazBLL();

        CapatazEntidad CAPENTIDAD = new CapatazEntidad();

        public FormAltaCapataz()
        {
            InitializeComponent();
        }


    


        private void btnCARGAR_EMPLEADO_Click(object sender, EventArgs e)
        {

        }

        public void ActualizarMatrizCapataz()
        {

            dataGridCapataz.DataSource = null;
           //Para que la lista siempre este con los datos conservados 
           dataGridCapataz.DataSource = CAPENTIDAD.ListaCapataz;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnCARGAR_EMPLEADO_Click_1(object sender, EventArgs e)
        {


            //Cargar Capataz
             CapatazEntidad CapE  = new CapatazEntidad(int.Parse(TxtLegajo.Text), TxtNombre.Text, TxtApellido.Text, int.Parse(TxtEdad.Text),int.Parse(TxtPeonesACargo.Text));
           
            CapatazBLL.CalcularSueldo();
            //La list la llamo de entidad y el obj Capataz esta independientemente de la lista  
            CAPENTIDAD.ListaCapataz.Add(CapE);
          //MyCapataz.ListaCapataz.Add(MyCapataz);
            ActualizarMatrizCapataz();


        }

        private void FormAltaCapataz_Load(object sender, EventArgs e)
        {

            ActualizarMatrizCapataz();



        }
    }
}
