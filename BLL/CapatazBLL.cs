using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace BLL
{
   public class CapatazBLL:Empleado,ICalculable
    {

        CapatazEntidad CapEntidad = new CapatazEntidad();

        //Metodo a nivel negocio 
        public double CalcularSueldo()
        {
            double SueldoTotal = 0;
            //This no va porque ya no se encuentra en este entorno, ahora va CapEntidad
            SueldoTotal = 12000 + (CapEntidad.PeonesACargo * 3500);
            
            this.sueldo = SueldoTotal;
            return SueldoTotal;
        }


    }


}

