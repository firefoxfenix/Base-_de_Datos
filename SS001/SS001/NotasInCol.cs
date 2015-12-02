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
    public partial class NotasInCol : Form
    {
        Validacion val = new Validacion();

        public NotasInCol()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label21_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float prom = float.Parse(textBox1.Text) + float.Parse(textBox2.Text) + float.Parse(textBox3.Text) + float.Parse(textBox4.Text) + float.Parse(textBox5.Text);
            float por80 = ((float.Parse(textBox19.Text) + float.Parse(textBox20.Text) + float.Parse(textBox21.Text) + float.Parse(textBox12.Text) + float.Parse(textBox11.Text)) * 80)/100;
            float por20 = (float.Parse(textBox22.Text) * 20) / 100;
            float quim1 = (float.Parse(textBox1.Text) + float.Parse(textBox2.Text) + float.Parse(textBox3.Text) + float.Parse(textBox4.Text) + float.Parse(textBox5.Text) + float.Parse(textBox14.Text) + float.Parse(textBox15.Text) + float.Parse(textBox16.Text) + float.Parse(textBox17.Text) + float.Parse(textBox18.Text) + float.Parse(textBox19.Text) + float.Parse(textBox20.Text) + float.Parse(textBox21.Text) + float.Parse(textBox12.Text) + float.Parse(textBox11.Text) + float.Parse(textBox22.Text))/4;
            label8.Text = (prom / 5).ToString();
            label21.Text = textBox27.Text;
            label36.Text = textBox7.Text;
            label37.Text = textBox8.Text;
            label38.Text = textBox9.Text;
            label53.Text = por80.ToString();
            label52.Text = por20.ToString();
            label19.Text = quim1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float prom = float.Parse(textBox14.Text) + float.Parse(textBox15.Text) + float.Parse(textBox16.Text) + float.Parse(textBox17.Text) + float.Parse(textBox18.Text);
            float por80 = ((float.Parse(textBox19.Text) + float.Parse(textBox20.Text) + float.Parse(textBox21.Text) + float.Parse(textBox12.Text) + float.Parse(textBox11.Text)) * 80) / 100;
            float por20 = (float.Parse(textBox22.Text) * 20) / 100;
            float quim1 = (float.Parse(textBox1.Text) + float.Parse(textBox2.Text) + float.Parse(textBox3.Text) + float.Parse(textBox4.Text) + float.Parse(textBox5.Text) + float.Parse(textBox14.Text) + float.Parse(textBox15.Text) + float.Parse(textBox16.Text) + float.Parse(textBox17.Text) + float.Parse(textBox18.Text) + float.Parse(textBox19.Text) + float.Parse(textBox20.Text) + float.Parse(textBox21.Text) + float.Parse(textBox12.Text) + float.Parse(textBox11.Text) + float.Parse(textBox22.Text)) / 4;
            label11.Text = (prom / 5).ToString();
            label21.Text = textBox27.Text;
            label36.Text = textBox7.Text;
            label37.Text = textBox8.Text;
            label38.Text = textBox9.Text;
            label53.Text = por80.ToString();
            label52.Text = por20.ToString();
            label19.Text = quim1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float prom = float.Parse(textBox19.Text) + float.Parse(textBox20.Text) + float.Parse(textBox21.Text) + float.Parse(textBox12.Text) + float.Parse(textBox11.Text);
            float por80 = (prom * 80) / 100;
            float por20 = (float.Parse(textBox22.Text) * 20) / 100;
            float quim1 = (float.Parse(textBox1.Text) + float.Parse(textBox2.Text) + float.Parse(textBox3.Text) + float.Parse(textBox4.Text) + float.Parse(textBox5.Text) + float.Parse(textBox14.Text) + float.Parse(textBox15.Text) + float.Parse(textBox16.Text) + float.Parse(textBox17.Text) + float.Parse(textBox18.Text) + float.Parse(textBox19.Text) + float.Parse(textBox20.Text) + float.Parse(textBox21.Text) + float.Parse(textBox12.Text) + float.Parse(textBox11.Text) + float.Parse(textBox22.Text)) / 4;
            label52.Text = (prom / 5).ToString();
            label21.Text = textBox27.Text;
            label36.Text = textBox7.Text;
            label37.Text = textBox8.Text;
            label38.Text = textBox9.Text;
            label53.Text = por80.ToString();
            label52.Text = por20.ToString();
            label19.Text = quim1.ToString();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }
    }
}
