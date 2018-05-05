using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBueno.Clases
{
     public class CLibro
    {
        string titulo;
        string autor;
        string genero;
        float precio;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Genero { get => genero; set => genero = value; }
        public float Precio { get => precio; set => precio = value; }

        public CLibro(string titulo, string autor, string genero, float precio)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.precio = precio;
        }
    }
}
