using SSS01;
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
    public partial class MainAdm : Form
    {
        public MainAdm(string usuario)
        {
            InitializeComponent();
            label1.Text = ("Bienvenido " + usuario);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataStu_Click(object sender, EventArgs e)
        {
            DataStudent f6 = new DataStudent();
            f6.Show();
        }

        private void datosProf_Click_1(object sender, EventArgs e)
        {
            DataProf f5 = new DataProf();
            f5.Show();
        }

        private void horariosClase_Click(object sender, EventArgs e)
        {
            HorariosClases nf = new HorariosClases();
            nf.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void libretaEstu_Click(object sender, EventArgs e)
        {
            GenLib nf3 = new GenLib();
            nf3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void anadirNota_Click_2(object sender, EventArgs e)
        {
            MenuNotas form = new MenuNotas();
            form.Show();
        }

        private void horarioProf_Click(object sender, EventArgs e)
        {
            HorariosProf form = new HorariosProf();
            form.Show();
        }

        private void MainAdm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
