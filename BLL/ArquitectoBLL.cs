using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace BLL
{
   public class ArquitectoBLL:Empleado,ICalculable
    {


        public List<ArquitectoBLL> ListaArquitecto = new List<ArquitectoBLL>();
       
        private int cantproyectos;

        public int Cantproyectos
        {
            get { return proyectos; }
            set { proyectos = value; }
        }


        private int proyectos;

        public int Proyectos
        {
            get { return proyectos; }
            set { proyectos = value; }
        }

        public ArquitectoBLL(int legajo, string nombre, string apellido, int edad, int proyectos, int cantproyectos) : base(legajo, nombre, apellido, edad)
        {
            this.Proyectos = proyectos;

        }


        public double CalcularSueldo()
        {
            double sueldoTotal = 0;

            sueldoTotal = 12000 + (this.sueldo + 15000) + (this.Proyectos * 10000);
            this.sueldo = sueldoTotal;
            return sueldoTotal;
        }

    }

}
