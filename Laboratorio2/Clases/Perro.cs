using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.Clases
{
    internal class Perro
    {
        private String Nombre, Color, Raza, Sexo;
        private decimal Edad, Peso;

        public Perro()
        {
            this.Nombre = "";
            this.Color = "";
            this.Raza = "";
            this.Sexo = "";
            this.Edad = 0;
            this.Peso = 0;
        }

        public Perro(string nombre, string color, string raza, string sexo, decimal edad, decimal peso)
        {
            this.Nombre = nombre;
            this.Color = color;
            this.Raza = raza;
            this.Sexo = sexo;
            this.Edad = edad;
            this.Peso = peso;
        }

        //CREAMOS LOS GET Y LOS SET

        public void setNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }

        public String getNombre()
        {
            return this.Nombre;
        }

        public void setColor(String Color) {
            this.Color = Color;
        }

        public String getColor() {
            return this.Color;
        }

        public void setRaza(String Raza)
        {
            this.Raza = Raza;
        }
        public String getRaza() {
            return this.Raza;
        }

        public void setSexo(String Sexo)
        {
            this.Sexo = Sexo;
        }

        public String getSexo() {
            return this.Sexo;
        }

        public void setEdad(decimal Edad)
        {
            this.Edad = Edad;
        }

        public decimal getEdad()
        {
            return this.Edad;
        }


        public void setPeso(decimal Peso)
        {
            this.Peso = Peso;
        }

        public decimal getPeso()
        {
            return this.Peso;
        }

        //CREAMOS LOS MÉTODOS

        public string Comer()
        {
            return "EL PERRO "+Nombre+" DE RAZA "+this.Raza+" ESTÁ COMIENDO";
        }

        public string Respirar(String Respirando)//SI RESPIRA O NO
        {
            return "EL PERRO "+Nombre+" DE RAZA "+this.Raza+" " + Respirando + " ESTÁ RESPIRANDO";
        }

        public string Ladrar ()
        {
            return "EL PERRO "+Nombre+" DE RAZA "+this.Raza+" ESTÁ LADRANDO";
        }

        public string Correr()
        {
            return "EL PERRO "+Nombre+" DE RAZA "+this.Raza+" ESTÁ CORRIENDO";
        }



    }
}
