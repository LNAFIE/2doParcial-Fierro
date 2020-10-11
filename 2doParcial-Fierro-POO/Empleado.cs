﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_Fierro_POO
{
    public abstract  class Empleado:IComparable
    {
        private int _legajo;

        public int legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private int _edad;

        public int edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        private string _puesto;

        public string puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }

        private double _sueldo;

        public double sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }





        public Empleado(int legajo, string nombre, string apellido, int edad, string puesto)
        {
            
            this._legajo = legajo;
            this._nombre = nombre;
            this.apellido = apellido;
            this._edad = edad;
            this._puesto = puesto;
        }


        public int CompareTo(object obj)
        {
            //instancio la clase 
            Empleado emp = (Empleado)obj;
            return this._edad.CompareTo(emp.edad);
        }


        //Metodo TOSTRING();
        // y sirve para mostrar a ese objeto convertido a texto
        public override string ToString()
        {
            return this.nombre;
        }








    }
}
