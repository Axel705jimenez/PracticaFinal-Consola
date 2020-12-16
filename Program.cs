using System;

namespace ProyectoAxel_Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            bool endApp = false;
           
            Console.WriteLine("TEST");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                string resultado = "";

                Console.WriteLine(" ¿Quén dijo la frase ´´oye, tranquilo viejo´´? ");
                Console.WriteLine("\ta - Bugs Bunny");
                Console.WriteLine("\tb - Drake Parker");
                Console.WriteLine("\tc - Bart Simpson");
                resultado = Console.ReadLine();
                Console.WriteLine("\t - la respuesta es: ´´Drake Parker´´");
                Console.WriteLine("\t. - Presiona ´´Enter´´ ir a la siguiente pregunta");

                Console.WriteLine(" ¿Cómo se llama el personaje principal de Dragon Ball? ");
                Console.WriteLine("\ta - Vegetta");
                Console.WriteLine("\tb - Goku");
                Console.WriteLine("\tc - Picollo");
                resultado = Console.ReadLine();
                Console.WriteLine("\t - la respuesta es: ´´Goku´´");
                Console.WriteLine("\t. - Presiona ´´Enter´´ ir a la siguiente pregunta");
               

                Console.WriteLine(" ¿Cómo se llama la mascota de Bob Esponja? ");
                Console.WriteLine("\ta - Gary");
                Console.WriteLine("\tb - Tiro al Blanco");
                Console.WriteLine("\tc - Patricio");
                resultado = Console.ReadLine();
                Console.WriteLine("\t - la respuesta es: ´´Gary´´");
                Console.WriteLine("\t. - Presiona ´´Enter´´ para dar siguiente");
                resultado = Console.ReadLine();
                Console.WriteLine("\t. - Gracias por su atencion");
                Console.WriteLine("\t. - creado por Axel Guadalupe Jimenez Maltos");
                Console.WriteLine("\t. - I20050018");
                Console.WriteLine("\t. - semestre 1 programacion");
                resultado = Console.ReadLine();

            }
            
        }

    }

}

