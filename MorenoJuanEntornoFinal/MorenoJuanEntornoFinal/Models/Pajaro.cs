using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorenoJuanEntornoFinal.Models
{
    class Pajaro:Animal
    {

        // ATRIBUTOS
        private String especie;
        private Boolean cantor;

     
        //CONSTRUCTOR
        public Pajaro(string nombre, string fechanacimiento, double peso, string comentarios,String especie,Boolean cantorr) : base(nombre, fechanacimiento, peso, comentarios)
        {
            this.comentarios = comentarios;
            this.Cantor =cantorr;
        }
        //GETTERS AND SETTERS
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

        public bool Cantor
        {
            get
            {
                return cantor;
            }

            set
            {
                cantor = value;
            }
        }
        public override void Pesable(double peso)
        {
            throw new NotImplementedException();
        }

        public override String ToString()
        {
            return "Pajaro especie=" + especie + ", cantor=" + cantor + ", nombre=" + nombre + ", fechanacimiento="
                    + fechanacimiento + ", peso=" + peso + ", comentarios=" + comentarios;
        }

    }
}
