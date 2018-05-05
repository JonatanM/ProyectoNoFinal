using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalBueno.Clases;

namespace ProyectoFinalBueno.Forms
{
    public partial class FDarAlta : Form
    {
        public FDarAlta()
        {
            InitializeComponent();
        }

        private void BttnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BttnAlta_Click(object sender, EventArgs e)
        {
            FPrincipal.usuario.Libros.Add(new CLibro(TxtTitulo.Text, TxtAutor.Text, CBLista.SelectedItem.ToString(), float.Parse(TxtPrecio.Text)));
        }
    }
}
