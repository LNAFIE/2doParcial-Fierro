using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class PeonBLL:Empleado,ICalculable
    {


        public List<PeonBLL> ListaPeon = new List<PeonBLL>();


        private int horastrabajadas;

        public int Horastrabajadas
        {
            get { return horastrabajadas; }
            set { horastrabajadas = value; }
        }



        public PeonBLL(int legajo, string nombre, string apellido, int edad, string puesto, int horastrabajadas) : base(legajo, nombre, apellido, edad)
        {
            this.Horastrabajadas = horastrabajadas;

            puesto = "Peon";
        }



        public double CalcularSueldo()
        {
            double sueldoTotal = 0;
            sueldoTotal = 12000 + (this.Horastrabajadas * 450);
            this.sueldo = sueldoTotal;
            return sueldoTotal;

        }
    }
}

