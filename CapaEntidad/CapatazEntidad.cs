using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class CapatazEntidad:EmpleadoEntidad
    {

        
    

        private int peonesacargo;

        public int PeonesACargo
        {
            get { return peonesacargo; }
            set { peonesacargo = value; }
        }



        public CapatazEntidad(int legajo, string nombre, string apellido, int edad, int PeonesACargo) : base(legajo, nombre, apellido, edad)
        {
            this.PeonesACargo = PeonesACargo;


        }

        public CapatazEntidad() : base()
        {
          

        }

        /*public CapatazBLL(int legajo, string nombre, string apellido, int edad, int PeonesACargo) : base(legajo, nombre, apellido, edad)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.PeonesACargo = peonesacargo;

        }
        */
    }
}
