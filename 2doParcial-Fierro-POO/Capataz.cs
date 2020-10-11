using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_Fierro_POO
{
    public class Capataz: Empleado,ICalculable
    {
        private int _PeonesACargo;
       

        public int PeonesACargo
        {
            get { return _PeonesACargo; }
            set { _PeonesACargo = value; }
        }   

       
      

        public Capataz(int legajo, string nombre, string apellido, int edad, int PeonesACargo,string puesto) : base(legajo, nombre, apellido, edad, puesto)
        {
            this._PeonesACargo = PeonesACargo;
            this.puesto = "Capataz";

        }

        public double CalcularSueldo()
        {
            double SueldoTotal = 0;
            SueldoTotal = 12000 + (this._PeonesACargo * 3500);
            this.sueldo = SueldoTotal;
            return SueldoTotal;
        }


    }
}
