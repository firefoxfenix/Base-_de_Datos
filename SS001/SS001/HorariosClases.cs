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
    public partial class HorariosClases : Form
    {
        public HorariosClases()
        {
            InitializeComponent();
            comboBox1.Items.Add("<Seleccione un curso>");
            comboBox1.Items.Add("Primero");
            comboBox1.Items.Add("Segundo");
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Add("<Seleccione un Paralelo>");
            comboBox2.Items.Add("A");
            comboBox2.Items.Add("B");
            comboBox2.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        Materia1.Text = "Materia 1";
                        Materia2.Text = "Materia 2";
                        Materia3.Text = "Materia 3";
                        Materia4.Text = "Materia 4";
                        Materia5.Text = "Materia 5";
                        Materia6.Text = "Materia 1";
                        Materia7.Text = "Materia 2";
                        Materia8.Text = "Materia 3";
                        Materia9.Text = "Materia 4";
                        Materia10.Text = "Materia 5";
                        Materia11.Text = "Materia 1";
                        Materia12.Text = "Materia 2";
                        Materia13.Text = "Materia 3";
                        Materia14.Text = "Materia 4";
                        Materia15.Text = "Materia 5";
                        Materia16.Text = "Materia 1";
                        Materia17.Text = "Materia 2";
                        Materia18.Text = "Materia 3";
                        Materia19.Text = "Materia 4";
                        Materia20.Text = "Materia 5";
                        Materia21.Text = "Materia 1";
                        Materia22.Text = "Materia 2";
                        Materia23.Text = "Materia 3";
                        Materia24.Text = "Materia 4";
                        Materia25.Text = "Materia 5";
                        Materia26.Text = "Materia 1";
                        Materia27.Text = "Materia 2";
                        Materia28.Text = "Materia 3";
                        Materia29.Text = "Materia 4";
                        Materia30.Text = "Materia 5";
                        break;
                    case 1:
                        Materia1.Text = "Inglés";
                        Materia2.Text = "Inglés";
                        Materia3.Text = "Inglés";
                        Materia4.Text = "Inglés";
                        Materia5.Text = "Inglés";
                        Materia6.Text = "Inglés";
                        Materia7.Text = "Inglés";
                        Materia8.Text = "Inglés";
                        Materia9.Text = "Inglés";
                        Materia10.Text = "Inglés";
                        Materia11.Text = "Inglés";
                        Materia12.Text = "Inglés";
                        Materia13.Text = "Inglés";
                        Materia14.Text = "Inglés";
                        Materia15.Text = "Inglés";
                        Materia16.Text = "Inglés";
                        Materia17.Text = "Inglés";
                        Materia18.Text = "Inglés";
                        Materia19.Text = "Inglés";
                        Materia20.Text = "Inglés";
                        Materia21.Text = "Inglés";
                        Materia22.Text = "Inglés";
                        Materia23.Text = "Inglés";
                        Materia24.Text = "Inglés";
                        Materia25.Text = "Inglés";
                        Materia26.Text = "Inglés";
                        Materia27.Text = "Inglés";
                        Materia28.Text = "Inglés";
                        Materia29.Text = "Inglés";
                        Materia30.Text = "Inglés";
                        break;
                    case 2:
                        Materia1.Text = "Física";
                        Materia2.Text = "Física";
                        Materia3.Text = "Física";
                        Materia4.Text = "Física";
                        Materia5.Text = "Física";
                        Materia6.Text = "Física";
                        Materia7.Text = "Física";
                        Materia8.Text = "Física";
                        Materia9.Text = "Física";
                        Materia10.Text = "Física";
                        Materia11.Text = "Física";
                        Materia12.Text = "Física";
                        Materia13.Text = "Física";
                        Materia14.Text = "Física";
                        Materia15.Text = "Física";
                        Materia16.Text = "Física";
                        Materia17.Text = "Física";
                        Materia18.Text = "Física";
                        Materia19.Text = "Física";
                        Materia20.Text = "Física";
                        Materia21.Text = "Física";
                        Materia22.Text = "Física";
                        Materia23.Text = "Física";
                        Materia24.Text = "Física";
                        Materia25.Text = "Física";
                        Materia26.Text = "Física";
                        Materia27.Text = "Física";
                        Materia28.Text = "Física";
                        Materia29.Text = "Física";
                        Materia30.Text = "Física";
                        break;
                }
            }
            if (comboBox2.SelectedIndex == 2)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        Materia1.Text = "Materia 1";
                        Materia2.Text = "Materia 2";
                        Materia3.Text = "Materia 3";
                        Materia4.Text = "Materia 4";
                        Materia5.Text = "Materia 5";
                        Materia6.Text = "Materia 1";
                        Materia7.Text = "Materia 2";
                        Materia8.Text = "Materia 3";
                        Materia9.Text = "Materia 4";
                        Materia10.Text = "Materia 5";
                        Materia11.Text = "Materia 1";
                        Materia12.Text = "Materia 2";
                        Materia13.Text = "Materia 3";
                        Materia14.Text = "Materia 4";
                        Materia15.Text = "Materia 5";
                        Materia16.Text = "Materia 1";
                        Materia17.Text = "Materia 2";
                        Materia18.Text = "Materia 3";
                        Materia19.Text = "Materia 4";
                        Materia20.Text = "Materia 5";
                        Materia21.Text = "Materia 1";
                        Materia22.Text = "Materia 2";
                        Materia23.Text = "Materia 3";
                        Materia24.Text = "Materia 4";
                        Materia25.Text = "Materia 5";
                        Materia26.Text = "Materia 1";
                        Materia27.Text = "Materia 2";
                        Materia28.Text = "Materia 3";
                        Materia29.Text = "Materia 4";
                        Materia30.Text = "Materia 5";
                        break;
                    case 1:
                        Materia1.Text = "Inglés";
                        Materia2.Text = "Inglés";
                        Materia3.Text = "Inglés";
                        Materia4.Text = "Inglés";
                        Materia5.Text = "Inglés";
                        Materia6.Text = "Inglés";
                        Materia7.Text = "Inglés";
                        Materia8.Text = "Inglés";
                        Materia9.Text = "Inglés";
                        Materia10.Text = "Inglés";
                        Materia11.Text = "Inglés";
                        Materia12.Text = "Inglés";
                        Materia13.Text = "Inglés";
                        Materia14.Text = "Inglés";
                        Materia15.Text = "Inglés";
                        Materia16.Text = "Inglés";
                        Materia17.Text = "Inglés A";
                        Materia18.Text = "Inglés";
                        Materia19.Text = "Inglés";
                        Materia20.Text = "Inglés";
                        Materia21.Text = "Inglés";
                        Materia22.Text = "Inglés";
                        Materia23.Text = "Inglés";
                        Materia24.Text = "Inglés";
                        Materia25.Text = "Inglés";
                        Materia26.Text = "Inglés";
                        Materia27.Text = "Inglés";
                        Materia28.Text = "Inglés";
                        Materia29.Text = "Inglés";
                        Materia30.Text = "Inglés";
                        break;
                    case 2:
                        Materia1.Text = "Física";
                        Materia2.Text = "Física";
                        Materia3.Text = "Física";
                        Materia4.Text = "Física";
                        Materia5.Text = "Física";
                        Materia6.Text = "Física";
                        Materia7.Text = "Física";
                        Materia8.Text = "Física";
                        Materia9.Text = "Física";
                        Materia10.Text = "Física";
                        Materia11.Text = "Física";
                        Materia12.Text = "Física";
                        Materia13.Text = "Física";
                        Materia14.Text = "Física";
                        Materia15.Text = "Física";
                        Materia16.Text = "Física";
                        Materia17.Text = "Física A";
                        Materia18.Text = "Física";
                        Materia19.Text = "Física";
                        Materia20.Text = "Física";
                        Materia21.Text = "Física";
                        Materia22.Text = "Física";
                        Materia23.Text = "Física";
                        Materia24.Text = "Física";
                        Materia25.Text = "Física";
                        Materia26.Text = "Física";
                        Materia27.Text = "Física";
                        Materia28.Text = "Física";
                        Materia29.Text = "Física";
                        Materia30.Text = "Física";
                        break;
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        Materia1.Text = "Materia 1";
                        Materia2.Text = "Materia 2";
                        Materia3.Text = "Materia 3";
                        Materia4.Text = "Materia 4";
                        Materia5.Text = "Materia 5";
                        Materia6.Text = "Materia 1";
                        Materia7.Text = "Materia 2";
                        Materia8.Text = "Materia 3";
                        Materia9.Text = "Materia 4";
                        Materia10.Text = "Materia 5";
                        Materia11.Text = "Materia 1";
                        Materia12.Text = "Materia 2";
                        Materia13.Text = "Materia 3";
                        Materia14.Text = "Materia 4";
                        Materia15.Text = "Materia 5";
                        Materia16.Text = "Materia 1";
                        Materia17.Text = "Materia 2";
                        Materia18.Text = "Materia 3";
                        Materia19.Text = "Materia 4";
                        Materia20.Text = "Materia 5";
                        Materia21.Text = "Materia 1";
                        Materia22.Text = "Materia 2";
                        Materia23.Text = "Materia 3";
                        Materia24.Text = "Materia 4";
                        Materia25.Text = "Materia 5";
                        Materia26.Text = "Materia 1";
                        Materia27.Text = "Materia 2";
                        Materia28.Text = "Materia 3";
                        Materia29.Text = "Materia 4";
                        Materia30.Text = "Materia 5";
                        break;
                    case 1:
                        Materia1.Text = "Inglés";
                        Materia2.Text = "Inglés";
                        Materia3.Text = "Inglés";
                        Materia4.Text = "Inglés";
                        Materia5.Text = "Inglés";
                        Materia6.Text = "Inglés";
                        Materia7.Text = "Inglés";
                        Materia8.Text = "Inglés";
                        Materia9.Text = "Inglés";
                        Materia10.Text = "Inglés";
                        Materia11.Text = "Inglés";
                        Materia12.Text = "Inglés";
                        Materia13.Text = "Inglés";
                        Materia14.Text = "Inglés";
                        Materia15.Text = "Inglés";
                        Materia16.Text = "Inglés";
                        Materia17.Text = "Inglés";
                        Materia18.Text = "Inglés";
                        Materia19.Text = "Inglés";
                        Materia20.Text = "Inglés";
                        Materia21.Text = "Inglés";
                        Materia22.Text = "Inglés";
                        Materia23.Text = "Inglés";
                        Materia24.Text = "Inglés";
                        Materia25.Text = "Inglés";
                        Materia26.Text = "Inglés";
                        Materia27.Text = "Inglés";
                        Materia28.Text = "Inglés";
                        Materia29.Text = "Inglés";
                        Materia30.Text = "Inglés";
                        break;
                    case 2:
                        Materia1.Text = "Física";
                        Materia2.Text = "Física";
                        Materia3.Text = "Física";
                        Materia4.Text = "Física";
                        Materia5.Text = "Física";
                        Materia6.Text = "Física";
                        Materia7.Text = "Física";
                        Materia8.Text = "Física";
                        Materia9.Text = "Física";
                        Materia10.Text = "Física";
                        Materia11.Text = "Física";
                        Materia12.Text = "Física";
                        Materia13.Text = "Física";
                        Materia14.Text = "Física";
                        Materia15.Text = "Física";
                        Materia16.Text = "Física";
                        Materia17.Text = "Física A";
                        Materia18.Text = "Física";
                        Materia19.Text = "Física";
                        Materia20.Text = "Física";
                        Materia21.Text = "Física";
                        Materia22.Text = "Física";
                        Materia23.Text = "Física";
                        Materia24.Text = "Física";
                        Materia25.Text = "Física";
                        Materia26.Text = "Física";
                        Materia27.Text = "Física";
                        Materia28.Text = "Física";
                        Materia29.Text = "Física";
                        Materia30.Text = "Física";
                        break;
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        Materia1.Text = "Materia 1";
                        Materia2.Text = "Materia 2";
                        Materia3.Text = "Materia 3";
                        Materia4.Text = "Materia 4";
                        Materia5.Text = "Materia 5";
                        Materia6.Text = "Materia 1";
                        Materia7.Text = "Materia 2";
                        Materia8.Text = "Materia 3";
                        Materia9.Text = "Materia 4";
                        Materia10.Text = "Materia 5";
                        Materia11.Text = "Materia 1";
                        Materia12.Text = "Materia 2";
                        Materia13.Text = "Materia 3";
                        Materia14.Text = "Materia 4";
                        Materia15.Text = "Materia 5";
                        Materia16.Text = "Materia 1";
                        Materia17.Text = "Materia 2";
                        Materia18.Text = "Materia 3";
                        Materia19.Text = "Materia 4";
                        Materia20.Text = "Materia 5";
                        Materia21.Text = "Materia 1";
                        Materia22.Text = "Materia 2";
                        Materia23.Text = "Materia 3";
                        Materia24.Text = "Materia 4";
                        Materia25.Text = "Materia 5";
                        Materia26.Text = "Materia 1";
                        Materia27.Text = "Materia 2";
                        Materia28.Text = "Materia 3";
                        Materia29.Text = "Materia 4";
                        Materia30.Text = "Materia 5";
                        break;
                    case 1:
                        Materia1.Text = "Inglés";
                        Materia2.Text = "Inglés";
                        Materia3.Text = "Inglés";
                        Materia4.Text = "Inglés";
                        Materia5.Text = "Inglés";
                        Materia6.Text = "Inglés";
                        Materia7.Text = "Inglés";
                        Materia8.Text = "Inglés";
                        Materia9.Text = "Inglés";
                        Materia10.Text = "Inglés";
                        Materia11.Text = "Inglés";
                        Materia12.Text = "Inglés";
                        Materia13.Text = "Inglés";
                        Materia14.Text = "Inglés";
                        Materia15.Text = "Inglés";
                        Materia16.Text = "Inglés";
                        Materia17.Text = "Inglés A";
                        Materia18.Text = "Inglés";
                        Materia19.Text = "Inglés";
                        Materia20.Text = "Inglés";
                        Materia21.Text = "Inglés";
                        Materia22.Text = "Inglés";
                        Materia23.Text = "Inglés";
                        Materia24.Text = "Inglés";
                        Materia25.Text = "Inglés";
                        Materia26.Text = "Inglés";
                        Materia27.Text = "Inglés";
                        Materia28.Text = "Inglés";
                        Materia29.Text = "Inglés";
                        Materia30.Text = "Inglés";
                        break;
                    case 2:
                        Materia1.Text = "Física";
                        Materia2.Text = "Física";
                        Materia3.Text = "Física";
                        Materia4.Text = "Física";
                        Materia5.Text = "Física";
                        Materia6.Text = "Física";
                        Materia7.Text = "Física";
                        Materia8.Text = "Física";
                        Materia9.Text = "Física";
                        Materia10.Text = "Física";
                        Materia11.Text = "Física";
                        Materia12.Text = "Física";
                        Materia13.Text = "Física";
                        Materia14.Text = "Física";
                        Materia15.Text = "Física";
                        Materia16.Text = "Física";
                        Materia17.Text = "Física A";
                        Materia18.Text = "Física";
                        Materia19.Text = "Física";
                        Materia20.Text = "Física";
                        Materia21.Text = "Física";
                        Materia22.Text = "Física";
                        Materia23.Text = "Física";
                        Materia24.Text = "Física";
                        Materia25.Text = "Física";
                        Materia26.Text = "Física";
                        Materia27.Text = "Física";
                        Materia28.Text = "Física";
                        Materia29.Text = "Física";
                        Materia30.Text = "Física";
                        break;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Materia5_Click(object sender, EventArgs e)
        {

        }

        private void Materia28_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
