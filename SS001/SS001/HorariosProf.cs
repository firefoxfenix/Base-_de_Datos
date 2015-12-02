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
    public partial class HorariosProf : Form
    {
        public HorariosProf()
                 {
   InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (nomProf.SelectedIndex)
            {
                case 0:
                    {
                        label8.Text ="--";
                        label9.Text = "--";
                        label10.Text = "--";
                        label11.Text = "--";
                        label12.Text = "--";

                        label14.Text = "--";
                        label15.Text = "--";
                        label16.Text = "--";
                        label17.Text = "--";
                        label18.Text = "--";

                        label20.Text = "--";
                        label21.Text = "--";
                        label22.Text = "--";
                        label23.Text = "--";
                        label24.Text = "--";

                        label26.Text = "--";
                        label27.Text = "--";
                        label28.Text = "--";
                        label29.Text = "--";
                        label30.Text = "--";

                        label32.Text = "--";
                        label33.Text = "--";
                        label34.Text = "--";
                        label35.Text = "--";
                        label36.Text = "--";

                        label38.Text = "--";
                        label39.Text = "--";
                        label40.Text = "--";
                        label41.Text = "--";
                        label42.Text = "--";
                        break;
                    }
                case 1:
                    {
                        label8.Text = "MATEMATICAS";
                        label9.Text = "MATEMATICAS";
                        label10.Text = "MATEMATICAS";
                        label11.Text = "MATEMATICAS";
                        label12.Text = "MATEMATICAS";

                        label14.Text = "MATEMATICAS";
                        label15.Text = "MATEMATICAS";
                        label16.Text = "MATEMATICAS";
                        label17.Text = "MATEMATICAS";
                        label18.Text = "MATEMATICAS";

                        label20.Text = "MATEMATICAS";
                        label21.Text = "MATEMATICAS";
                        label22.Text = "MATEMATICAS";
                        label23.Text = "MATEMATICAS";
                        label24.Text = "MATEMATICAS";

                        label26.Text = "MATEMATICAS";
                        label27.Text = "MATEMATICAS";
                        label28.Text = "MATEMATICAS";
                        label29.Text = "MATEMATICAS";
                        label30.Text = "MATEMATICAS";

                        label32.Text = "MATEMATICAS";
                        label33.Text = "MATEMATICAS";
                        label34.Text = "MATEMATICAS";
                        label35.Text = "MATEMATICAS";
                        label36.Text = "MATEMATICAS";

                        label38.Text = "MATEMATICAS";
                        label39.Text = "MATEMATICAS";
                        label40.Text = "MATEMATICAS";
                        label41.Text = "MATEMATICAS";
                        label42.Text = "MATEMATICAS";
                        break;

                    }

            }
            
        }
    }
}
