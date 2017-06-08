using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorenoJuanEntornoFinal.Models
{
   public abstract class Animal: Interface.IPesable
    {
        //ATRIBUTOS
        
        protected String nombre;
        protected String fechanacimiento;
        protected double peso;
        protected String comentarios;


        // CONSTRUCTOR
        public Animal(String nombre, String fechanacimiento, double peso, String comentarios)
        {
            this.nombre = nombre;
            this.fechanacimiento = fechanacimiento;
            this.peso = peso;
            this.comentarios = comentarios;
        }
        // getters ans setters

    
        public String setComentario(String comentario)
        {
            return this.comentarios = comentario;
        }
        public override String ToString()
        {
            String p=" Nombre: "+nombre+"\n"+ "Fecha nacimiento: "+fechanacimiento+"\n"+"Peso: "+peso+"/n"+"Comentarios: "+comentarios+"n";

            return p;
        }
        public abstract void Pesable(double peso);
    }
}
