using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcosLab01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Rectangulo rectangulo = new Rectangulo();
            rectangulo.Base = 10;
            rectangulo.Altura = 20;

            int area = 0;
            int perimetro = 0¨
            
            area = rectangulo.CalcularArea();
            perimetro = rectangulo.Perimetro();

            Console.WriteLine("El área es: ");
            Console.WriteLine(area);
            Console.WriteLine("El perímetro es: ");
            Console.WriteLine(perimetro);
*/
            string nombre = "David";
            string apellido = "Arcos";

            Persona persona = new Persona()
            {
                Nombres = nombre,
                Apellidos = apellido
            };
            
            Console.WriteLine(persona.NombresCompletos);


        }
    }
}
