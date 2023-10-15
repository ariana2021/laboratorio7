using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio7
{
    public class Estudiantes
    {
        public string Name {  get; set; }
        public string Ciclo { get; set; }
        public string seccion {  get; set; }
        public string Edad { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
