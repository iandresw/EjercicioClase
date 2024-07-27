using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    internal class SuperHeroe
    {
        public string nombre {  get; set; }
        public string idetentidadSecreta {  get; set; }
        public string ciudad {  get; set; }
        public bool puedeVolar {  get; set; }

        public SuperPoder SuperPoder { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("\n");
            Console.WriteLine("_________Super Heroe___________");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Identidad Secreta: {idetentidadSecreta}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Puede Volar: {puedeVolar}");
            Console.WriteLine($"Super Poder: {SuperPoder.nombre}");
            Console.WriteLine($"Descripcion: {SuperPoder.descripcion}");
            Console.WriteLine($"Nivel: {SuperPoder.nivel}");
        }
        public SuperHeroe()
        {
            SuperPoder = new SuperPoder();
        }
    }
}
