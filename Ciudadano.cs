using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voto_Electronico
{
    class Ciudadano
    {
        int DNI;
        int barrio;
        int depto;
        string Nombre;
        string Apellido;
        string direccion;
        bool sexo;

        public int DNI1
        {
            get
            {
                return DNI;
            }

            set
            {
                DNI = value;
            }
        }

        public int Barrio1
        {
            get
            {
                return barrio;
            }

            set
            {
                barrio = value;
            }
        }

        public int Depto1
        {
            get
            {
                return depto;
            }

            set
            {
                depto = value;
            }
        }

        public string Nombre1
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }

        public string Apellido1
        {
            get
            {
                return Apellido;
            }

            set
            {
                Apellido = value;
            }
        }

        public string Direccion1
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public bool Sexo1
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public Ciudadano()
        {
            DNI1 = 0;
            Barrio1 = 0;
            Depto1 = 0;
            Nombre1 = "";
            Apellido1 = "";
            Direccion1 = "";
            Sexo1 = false;
        }

        public string ToString()
        {
            return " " + DNI1 + " - " + Apellido1 + " - " + Nombre1 + " - " + Direccion1 + " - " + Depto1;
        }

    }
}
