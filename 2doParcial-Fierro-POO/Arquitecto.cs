using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_Fierro_POO
{
   public  class Arquitecto:Empleado,ICalculable
    {
        private int _Proyectos;

        public int Proyectos
        {
            get { return _Proyectos; }
            set { _Proyectos = value; }
        }


        private int _Cant_proyectos;

        public int CantProyectos
        {
            get { return _Cant_proyectos; }
            set { _Cant_proyectos = value; }
        }



        public Arquitecto(int legajo, string nombre, string apellido, int edad, int proyectos, string puesto) : base(legajo, nombre, apellido, edad, puesto)
        {
            this._Proyectos = proyectos;
            this.puesto = "Arquitecto";
        }
    

        public double CalcularSueldo()
        {
            double sueldoTotal = 0;

            sueldoTotal = 12000 + (this.sueldo + 15000) + (this._Proyectos * 10000);
            this.sueldo = sueldoTotal;
            return sueldoTotal;
        }

    }
}
