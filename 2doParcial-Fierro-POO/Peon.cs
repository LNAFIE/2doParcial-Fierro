using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_Fierro_POO
{
   public  class Peon:Empleado,ICalculable
    {

        private int _horasTrbajadas;
      

        public int horasTrabajadas
        {
            get { return _horasTrbajadas; }
            set { _horasTrbajadas = value; }
        }


        public Peon(int legajo, string nombre, string apellido, int edad, int horasTrabajadas,string puesto) : base(legajo, nombre, apellido, edad, puesto)
        {
            this._horasTrbajadas = horasTrabajadas;
            this.puesto = "Peon";
        }

        public double CalcularSueldo()
        {
            double sueldoTotal = 0;
            sueldoTotal = 12000 + (this._horasTrbajadas * 450);
            this.sueldo = sueldoTotal;
            return sueldoTotal;

        }
    }
}
