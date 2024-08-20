using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcosLab01
{
    public class Program
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

            string nombre = "David";
            string apellido = "Arcos";

            Persona persona = new Persona()
            {
                Nombres = nombre,
                Apellidos = apellido
            };

            Estudiante estudiante = new Estudiante()
            {
                Nombres = "Jose",
                Apellidos = "Arcos",
                CodigoEstudiante = "123456789"
            };

            Console.WriteLine(estudiante.CodigoEstudiante);
            
            */

            Rectangulo rectangulo = new Rectangulo()
            {
                puntoA = new Coordenada() { Abscisa = 0, Ordenada = 8 },
                puntoB = new Coordenada() { Abscisa = 4, Ordenada = 8 },
                puntoC = new Coordenada() { Abscisa = 4, Ordenada = 0 },
                puntoD = new Coordenada() { Abscisa = 0, Ordenada = 0 },
            };


            Console.WriteLine(rectangulo.CalcularArea());
            Console.WriteLine(rectangulo.Perimetro());
            Console.Read();



        }
    }
}
