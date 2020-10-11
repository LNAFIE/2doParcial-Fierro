using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_Fierro_POO
{
    public class Proyectos
    {
        public List<Capataz> LisstCapataces;

        public List<Peon> LisstPeones;

        private int _NroProyecto;

        public int NroProyecto

        {
            get { return _NroProyecto; }
            set { _NroProyecto = value; }
        }


        private double _Costo;

        public double Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
        }

        private int _DuracionProyecto;

        public int DuracionProyecto
        {
            get { return _DuracionProyecto; }
            set { _DuracionProyecto = value; }
        }


        private int _LegajoArquitecto;

        public int Legajo_Arquitecto

        {
            get { return _LegajoArquitecto; }
            set { _LegajoArquitecto = value; }
        }
        /*
        public int _Cant_Proyectos;

        public int Cant_proyectos
        {
            get { return _Cant_Proyectos; }
            set { _Cant_Proyectos = value; }
        }*/

        public Proyectos(int pNro, int pLegajoArq, int pDuracion)
        {
            this.NroProyecto = pNro;
            this.Legajo_Arquitecto = pLegajoArq;
            this.DuracionProyecto = pDuracion;
            this.Costo = 0;
            this.LisstCapataces = new List<Capataz>();
            this.LisstPeones = new List<Peon>();
        }


        
      




    }
}
