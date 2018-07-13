using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;            //Definimos la variable "Nombre" de tipo string.
            int Clave, Antiguedad;    //Definimos las variables "Clave" y "Antiguedad" pero aun no le damos un valor absoluto.

            Console.WriteLine("**********************************************");
            Console.WriteLine("Bienvenido al sistema vacacional de Coca Cola");     //El siguiente mensaje da la bienvenida y pregunta el nombre al usuario
            Console.WriteLine("¿Cual es su nombre?");
            Console.WriteLine("**********************************************");
            Nombre = Console.ReadLine();                                            //La consola lee lo que fue escrito por el usuario y lo alamcena en la variable "Nombre"

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("**********************************************");
            Console.WriteLine("¿Cual es la clave de su departamento?");             //Pregunta la clave del departamento
            Console.WriteLine("**********************************************");
            Clave = int.Parse(Console.ReadLine());                                  //La int.Parse nos ayuda a convertir un valor numerico a un entero, es decir convertirlo en un tipo de daro (int, double, byte, long, etc.
                                                                                    //En este caso la variable definida por el usuario sera "Clave"
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("**********************************************");
            Console.WriteLine("¿Cual es su antiguedad en años?");                   //Pregunta la antiguedad y la solicita en "años"
            Console.WriteLine("**********************************************");
            Antiguedad = int.Parse(Console.ReadLine());                             //En este caso la variable definida por el usuario sera "Antiguedad"

            if (Clave == 1)               //Si el usuario ingresa el valor "1" en la variable Clave
            {
                if(Antiguedad == 1)       //Si el usuario ingresa el valor "1" en la variable Antiguedad
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted tiene derecho a 6 dias de vacaciones", Nombre);  // Da el siguiente mensaje
                }
                else if(Antiguedad >=2 && Antiguedad <= 6)  //Si el usuario ingresa un valor mayor o igual que 2 pero menor o igual que 6 
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted tiene derecho a 14 dias de vacaciones", Nombre);  // Da el siguiente mensaje
                }
                else if(Antiguedad == 7)   //Si el usuario ingresa el valor "7" en la variable Antiguedad
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted tiene derecho a 20 dias de vacaciones", Nombre);  // Da el siguiente mensaje
                }
                else                       //Si el usuario no ingresa un valor mayor o igual a 1 pero menor o igual a 7
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted no tiene derecho a dias de vacaciones", Nombre);  // Da el siguiente mensaje
                }

            }

            else if(Clave == 2)           //Si el usuario ingresa el valor "2" en la variable Clave
            {
                if (Antiguedad == 1)      //Si el usuario ingresa el valor "1" en la variable Antiguedad
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted tiene derecho a 7 dias de vacaciones", Nombre);  // Da el siguiente mensaje
                }
                else if (Antiguedad >= 2 && Antiguedad <= 6)  //Si el usuario ingresa un valor mayor o igual que 2 pero menor o igual que 6
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted tiene derecho a 15 dias de vacaciones", Nombre);  // Da el siguiente mensaje
                }
                else if (Antiguedad == 7)   //Si el usuario ingresa el valor "7" en la variable Antiguedad
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted tiene derecho a 21 dias de vacaciones", Nombre);  // Da el siguiente mensaje
                }
                else                       //Si el usuario no ingresa un valor mayor o igual a 1 pero menor o igual a 7
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted no tiene derecho a dias de vacaciones", Nombre);  // Da el siguiente mensaje
                }

            }

            else if(Clave == 3)          //Si el usuario ingresa el valor "3" en la variable Clave
            {
                if (Antiguedad == 1)     //Si el usuario ingresa el valor "1" en la variable Antiguedad
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted tiene derecho a 10 dias de vacaciones", Nombre);
                }
                else if (Antiguedad >= 2 && Antiguedad <= 6)  //Si el usuario ingresa un valor mayor o igual que 2 pero menor o igual que 6
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted tiene derecho a 20 dias de vacaciones", Nombre);
                }
                else if (Antiguedad == 7)   //Si el usuario ingresa el valor "7" en la variable Antiguedad
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted tiene derecho a 30 dias de vacaciones", Nombre);
                }
                else                       //Si el usuario no ingresa un valor mayor o igual a 1 pero menor o igual a 7
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0}, usted no tiene derecho a dias de vacaciones", Nombre);  // Da el siguiente mensaje
                }

            }

            else         //Si el usuario no ingresa un valor mayor o igual a 1 pero menor o igual a 7 en la variable Antiguedad o un valor mayor o igual a 1 pero menor o igual que 3 en la variable Clave
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("**********************************************");
                Console.WriteLine("Error 404");  //Da el siguiente mensaje
            }

            Console.ReadLine();



        }


        
    }
}
