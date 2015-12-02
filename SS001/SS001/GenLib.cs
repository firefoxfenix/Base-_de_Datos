using System;
using SS001;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS001
{
    public partial class GenLib : Form
    {
        public GenLib()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void libretaAnual_Click(object sender, EventArgs e)
        {
            LibFinal form = new LibFinal();
            form.Show();
        }

        private void libretaParcial_Click(object sender, EventArgs e)
        {
            LibParcial form= new LibParcial();
            form.Show();
        }
    }
}
