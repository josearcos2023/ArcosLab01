using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArcosLab01
{
    public class Rectangulo
    {

        public double Base { get; set; }
        public double Altura { get; set; }

        public Coordenada puntoA { get; set; }
        public Coordenada puntoB { get; set; }
        public Coordenada puntoC { get; set; }
        public Coordenada puntoD { get; set; }

        public double CalcularLadoSuperior()
        {
            return Math.Sqrt(Math.Pow((puntoA.Abscisa - puntoB.Abscisa), 2) + Math.Pow((puntoA.Ordenada- puntoB.Ordenada), 2));
        }

        public double CalcularLadoLateral()
        {
            return Math.Sqrt(Math.Pow((puntoB.Abscisa- puntoC.Abscisa), 2) + Math.Pow((puntoB.Ordenada- puntoC.Ordenada), 2));
        }

        public double CalcularArea()
        {
            return CalcularLadoLateral() * CalcularLadoSuperior();
        }

        public double Perimetro()
        {
            return 2 * (CalcularLadoSuperior()+ CalcularLadoLateral());
        }
    }
}
