using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_Fierro_POO
{
    public class Empresa
    {
        public List<Empleado> listaemp = new List<Empleado> { };

        public List<Empleado> getListaEmp()
        {
            //devolver lista Empleados
            return this.listaemp;           

        }


        public void AgregarEmpLista(Empleado emp)
        {
            this.listaemp.Add(emp);
            


        }


        //METODO RECUDACION TOTAL
        public double RecaudacionTotal()
        {
            double RecauTotal = 0;
            // por cada uno en la lista de empleados acumular sueldo

            foreach (var item in listaemp)
            {
                RecauTotal = RecauTotal + item.sueldo;

            }
            return RecauTotal;
        }


    


        public string CategoriaConMasEmpleados()
        {
            //CONTADORES
            int totalPeon = 0;
            int totalArquitecto = 0;
            int totalCapataz = 0;

            //Bucle que recorra la lista de empleados 
            foreach (var item in listaemp)
            {
                if (item is Peon)
                {
                    totalPeon++;
                }
                else if (item is Capataz)
                {
                    totalCapataz++;
                }
                else
                {
                    totalArquitecto++;
                }

            }//fin del foreach


            if (totalPeon > totalCapataz && totalPeon > totalArquitecto)
            {
                return "Peon";
            }
            else if (totalCapataz > totalArquitecto)
            {
                return "Capataz";
            }
            else
            {
                return "Arquitecto";
            }

        }
    }
}
