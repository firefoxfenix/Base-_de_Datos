using System;
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
    public partial class MenuNotas : Form
    {
        public MenuNotas()
        {
            InitializeComponent();
        }

        private void crearAlumno_Click(object sender, EventArgs e)
        {
            NotasInEs form = new NotasInEs();
            this.Close();
            form.Show();
        }

        private void alumnoExistente_Click(object sender, EventArgs e)
        {
            NotasInCol form = new NotasInCol();
            this.Close();
            form.Show();
        }
    }
}
