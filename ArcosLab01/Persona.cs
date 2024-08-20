using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcosLab01
{
    internal class Persona
    {

        public Persona(string nombres, string apellidos)
        {
            Nombres = nombres;
            Apellidos = apellidos;
        }
        public Persona() { }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombresCompletos{ get; set; }
        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + ' ' + Apellidos;
        }
    }
}
