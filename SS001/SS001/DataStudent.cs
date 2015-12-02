using SS001;
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
    public partial class DataStudent : Form
    {
        Validacion val = new Validacion();
        int edad = 0;
        
        public DataStudent()
        {
            InitializeComponent();
            enfText.Visible = false;
            enfPlus.Visible = false;
            enfList.Visible = false;
            becasL.Visible = false;
            becasT.Visible = false;
            edadT.Enabled = false;
            edadT.Text = edad.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            edad = 2015-birthDate.Value.Year;
            edadT.Text = edad.ToString();
        }

        private void enferCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (enferCheck.Checked)
            {
                enfText.Visible = true;
                enfPlus.Visible = true;
                enfList.Visible = true;
                
            }
            else
            {
                enfText.Visible = false;
                enfPlus.Visible = false;
                enfList.Visible = false;
            }
        }

        private void enfPlus_Click(object sender, EventArgs e)
        {
            if (enfText.Text != "" && enfText.Text != null)
            {
                if (enfList.Items.IndexOf(enfText.Text) == -1)
                {
                    enfList.Items.Add(enfText.Text);
                }
                
            }
            else
            {
                MessageBox.Show("Error de ingreso", "Error!!",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void becasCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (becasCheck.Checked)
            {
                becasL.Visible = true;
                becasT.Visible = true;
            }
            else
            {
                becasL.Visible = false;
                becasT.Visible = false;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            famAp.Text = "";
            famCel.Text = "";
            famDom.Text = "";
            famEst.Text = "";
            famNac.Text = "";
            famNom.Text = "";
            famOfc.Text = "";
            famT.Text = "";
            famTra.Text = "";
            famTT.Text = "";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letrasSinEspacios(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letrasSinEspacios(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letrasSinEspacios(e);
        }

        private void enfText_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letrasSinEspacios(e);
        }

        private void famNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void famNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letrasSinEspacios(e);
        }

        private void famNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void famAp_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void famEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letrasSinEspacios(e);
        }

        private void famOfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letrasSinEspacios(e);
        }

        private void famTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void famTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void famDom_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void famT_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void famCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void cedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void edadT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
