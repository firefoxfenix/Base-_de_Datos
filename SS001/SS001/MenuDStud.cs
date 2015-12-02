using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SS001;

namespace SS001
{
    public partial class MenuDStud : Form
    {
        public MenuDStud()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void alumnoExistente_Click(object sender, EventArgs e)
        {

        }

        private void crearAlumno_Click(object sender, EventArgs e)
        {
            DataStudent form = new DataStudent();
            this.Close();
            form.Show();
        }
    }
}
