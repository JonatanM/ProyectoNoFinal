using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBueno.Clases
{
    public class CUsuario
    {
        List<CLibro> libros = new List<CLibro>();
        string nombre;
        string contraseña;
        float crédito;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public List<CLibro> Libros { get => libros; set => libros = value; }
        public float Crédito { get => crédito; set => crédito = value; }

        public CUsuario(string nombre, string contraseña, float crédito)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.crédito = crédito;
        }
    }
}
