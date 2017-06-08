using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MorenoJuanEntornoFinal.Models
{
    class Clinica
    {
        //ATRIBUTOS
        System.Collections.Generic.List<Animal>listaAnimales;
        private String nombreclinica;
        
        // CONSTRUCTOR
        public Clinica(String nombreclinica)
        {
          listaAnimales = new System.Collections.Generic.List<Animal>();
           this.nombreclinica = nombreclinica;
        }

        //METODOS
        /// <summary>
        /// Modifica el comentario del animal
        /// </summary>
        public void ModificarComentario()
        {
            String nombre = "";
            String comentario = "";

            if (listaAnimales.Count() == 0)
            {
                Console.WriteLine("No hay animales");
            }
            else
            {
                Console.Write("Introduce nombre animal :");
                nombre = Console.ReadLine();
                foreach (Animal a in listaAnimales)
                {
                    if (listaAnimales.Contains(listaAnimales.IndexOf(nombre)))
                    {
                        Console.Write("Introduce nuevo comentario: ");
                        comentario = Console.ReadLine();
                        a.setComentario(comentario);
                        break;
                    }

                }        

            }
        }
        /// <summary>
        /// Busca al bicho
        /// </summary>
        /// <param name="nombre"></param>
        public void BuscarAnimal(Animal nombre)
        {
            if (listaAnimales.Contains(nombre))
            {
               
                Console.WriteLine(listaAnimales.IndexOf(nombre));
            }
            

        }
        /// <summary>
        /// Inserta animal en clinica
        /// </summary>
        /// <param name="i"></param>
        private void InsertarAnimal(Animal i)
        {
            if (listaAnimales.Contains(i))
            {

               Console.WriteLine("Este animal ya se encuentra en la clinica");
            }
            else
            {
                listaAnimales.Add(i);
            }

        }

        /// <summary>
        /// Imprime los animales dentro de la clinica.
        /// </summary>
        public void ImprimirAnimal()
        {

            

            if (listaAnimales.Count == 0)
            {
                Console.WriteLine("No hay animales dentro");
            }
            else
            {
                foreach (Animal anim in listaAnimales)
                {
                    Console.WriteLine(anim);
                }
            }

        }
        /// <summary>
        /// Agrega un pajaro
        /// </summary>
        public void AnadirPajaro()
        {
            bool ok = true;
            String nombre, fechanacimiento, comentarios, especie;
            double peso=0;
            Boolean cantor = false;
            int canta = 0;
            Console.Write("Nombre:");
            nombre = Console.ReadLine();
            Console.Write("Fecha de Nacimiento:");
            fechanacimiento = Console.ReadLine();
            Console.Write("Especie:");
            especie = Console.ReadLine();
            Console.Write("Peso:");
            peso = Valida.valida.ValidarDouble(peso);
            Console.Write("Canta?:[1 si, 2 no]");
            do
            {
                canta = Valida.valida.ValidarInt(canta);
                if (canta > 2 || canta<1)
                {
                    ok = true;
                }
            } while (ok);
            if (canta == 1)
            {
                cantor = true;
            }
            if (canta == 2)
            {
                cantor = false;
            }
            Console.Write("Comentario:");
            comentarios = Console.ReadLine();

            Animal Pajaro = new Pajaro(nombre, fechanacimiento, peso, comentarios, especie, cantor);
            InsertarAnimal(Pajaro);
        }
        /// <summary>
        /// agrega un reptil
        /// </summary>
        public void AnadirReptil()
        {
            bool ok = true;
            String nombre, fechanacimiento, comentarios, especie;
            double peso = 0;
            Boolean venenoso = false;
            int veneno = 0;
            Console.Write("Nombre:");
            nombre = Console.ReadLine();
            Console.Write("Fecha de Nacimiento:");
            fechanacimiento = Console.ReadLine();
            Console.Write("Especie:");
            especie = Console.ReadLine();
            Console.Write("Peso:");
            peso = Valida.valida.ValidarDouble(peso);
            Console.Write("¿Es venenoso?: [1 si, 2 no]");
            do
            {
                veneno = Valida.valida.ValidarInt(veneno);
                if (veneno > 2 || veneno < 1)
                {
                    ok = false;
                }
            } while (ok);
            if (veneno == 1)
            {
                venenoso = true;
            }
            if (veneno == 2)
            {
                venenoso = false;
            }
            Console.Write("Comentario:");
            comentarios = Console.ReadLine();

            Animal Reptil = new Reptil(nombre, fechanacimiento, peso, comentarios, especie, venenoso);
            InsertarAnimal(Reptil);

        }
        /// <summary>
        /// agrega un gato
        /// </summary>
        public void AnadirGato()
        {
            String nombre, fechanacimiento, comentarios, raza, microchip;
            double peso = 0 ;
            Console.Write("Nombre:");
            nombre = Console.ReadLine();
            Console.Write("Fecha de Nacimiento:");
            fechanacimiento = Console.ReadLine();
            Console.Write("Raza:");
            raza = Console.ReadLine();
            Console.Write("Peso:");
            peso = Valida.valida.ValidarDouble(peso);
            Console.Write("Microchip:");
            microchip = Console.ReadLine();
            Console.Write("Comentario:");
            comentarios = Console.ReadLine();

            Animal Gato = new Gato(nombre, fechanacimiento, peso, comentarios, raza, microchip);
            InsertarAnimal(Gato);
        }
        /// <summary>
        /// agrega un perro
        /// </summary>
        public void AnadirPerro()
        {
            String nombre, fechanacimiento, comentarios, raza, microchip;
            double peso = 0;
            Console.Write("Nombre:");
            nombre = Console.ReadLine();
            Console.Write("Fecha de Nacimiento:");
            fechanacimiento = Console.ReadLine();
            Console.Write("Raza:");
            raza = Console.ReadLine();
            Console.Write("Peso:");
            peso = Valida.valida.ValidarDouble(peso);
            Console.Write("Microchip:");
            microchip = Console.ReadLine();
            Console.Write("Comentario:");
            comentarios = Console.ReadLine();

            Animal Perro = new Perro(nombre, fechanacimiento, peso, comentarios, raza, microchip);
            InsertarAnimal(Perro);
        }
        /// <summary>
        /// Menu Principal de la app
        /// </summary>
        public void MenuPrincipal()
        {
            int opcion = 0;
            do
            {

                Console.WriteLine("====Clinica Veterinaria===");
                Console.WriteLine("Opciones:");
                Console.WriteLine("1-Anadir animales");
                Console.WriteLine("2-Modificar comentario animal");
                Console.WriteLine("3-Imprimir Lista animales");
                Console.WriteLine("4- Ir a casa...");
                opcion = Valida.valida.ValidarInt(opcion);

                switch (opcion)
                {
                    case 1:
                        MenuAnadirAnimal();
                        break;
                    case 2:
                        ModificarComentario();
                        break;
                    case 3:
                        ImprimirAnimal();
                        break;

                    case 4:
                        Console.WriteLine("Hasta pronto!!");
                        break;
                    default:
                        Console.WriteLine("Error, no ha seleccionado ninguna opcion valida");
                        break;

                }
            } while (opcion != 4);
        }
        /// <summary>
        /// Menu para agregar un animal
        /// </summary>
        public void MenuAnadirAnimal()
        {
            int opcion = 0;
            Console.WriteLine("Que tipo de animal desea Anadir:");
            Console.WriteLine("1-Perro");
            Console.WriteLine("2-Gato");
            Console.WriteLine("3-Reptil");
            Console.WriteLine("4-Pajaro");
            opcion = Valida.valida.ValidarInt(opcion);

            switch (opcion)
            {
                case 1:
                    AnadirPerro();
                    break;
                case 2:
                    AnadirGato();
                    break;
                case 3:
                    AnadirReptil();
                    break;
                case 4:
                    AnadirPajaro();
                    break;
                default:
                    Console.WriteLine("No ha elegido ninguna opcion correcta.");
                    break;
                   
            }

        }




    }
}
