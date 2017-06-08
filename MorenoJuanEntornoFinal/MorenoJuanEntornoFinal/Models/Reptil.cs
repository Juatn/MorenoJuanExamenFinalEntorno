using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorenoJuanEntornoFinal.Models
{
    class Reptil:Animal
    {

        //atributos
        private String especie;
        private Boolean venenoso = false;

        //constructor
        public Reptil(string nombre, string fechanacimiento, double peso, string comentarios,String especie, Boolean venenoso) : base(nombre, fechanacimiento, peso, comentarios)
        {
            this.Especie = especie;
            this.Venenoso = venenoso;
        }

        //getters and setters
        public string Especie
        {
            get
            {
                return especie;
            }

            set
            {
                especie = value;
            }
        }

        public bool Venenoso
        {
            get
            {
                return venenoso;
            }

            set
            {
                venenoso = value;
            }
        }

        public override void Pesable(double peso)
        {
            throw new NotImplementedException();
        }



        public new String ToString()
        {
            return "Reptil especie=" + Especie + ", venenoso=" + Venenoso + ", nombre=" + nombre + ", fechanacimiento="
                    + fechanacimiento + ", peso=" + peso + ", comentarios=" + comentarios;
        }

    }

}
