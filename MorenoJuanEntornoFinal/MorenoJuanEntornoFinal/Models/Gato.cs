using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorenoJuanEntornoFinal.Models
{
    class Gato : Animal
    {
        // ATRIBUTOS
        private String raza;
        private String microchip;



        //CONSTRUCTOR
        public Gato(string nombre, string fechanacimiento, double peso, string comentarios, String raza, String microchip) : base(nombre, fechanacimiento, peso, comentarios)
        {
            this.Raza = raza;
            this.Microchip = microchip;
        }


        //getters and setters
        public string Raza
        {
            get
            {
                return raza;
            }

            set
            {
                raza = value;
            }
        }

        public string Microchip
        {
            get
            {
                return microchip;
            }

            set
            {
                microchip = value;
            }
        }

        public override void Pesable(double peso)
        {
            throw new NotImplementedException();
        }

        public  String ToStringGato()
        {
            return "Gato raza=" + raza + ", microchip=" + microchip + ", nombre=" + nombre + ", fecha nacimiento="
                    + fechanacimiento + ", peso=" + peso + ", comentarios=" + comentarios;
        }
    }

}
