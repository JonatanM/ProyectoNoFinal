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
using ProyectoFinalBueno.Forms;

namespace ProyectoFinalBueno
{
    public partial class FPrincipal : Form
    {
        FDarAlta fDarAlta = new FDarAlta();
        public static CUsuario usuario = new CUsuario("Nombresote", "papas", 500);
        
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void BttnDarAlta_Click(object sender, EventArgs e)
        {
            fDarAlta.ShowDialog();
        }
    }
}
