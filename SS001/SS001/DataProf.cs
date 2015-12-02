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
    public partial class DataProf : Form
    {
        int var2 = 0;
        Validacion val = new Validacion();
        int edad = 0;
        public DataProf()
        {
            
            InitializeComponent();
            horario.Items.Add("");
            horario2.Items.Add("");
            horario3.Items.Add("");
            horario4.Items.Add("");
            horario.Items.Add("Lun");
            horario.Items.Add("Mar");
            horario.Items.Add("Mie");
            horario.Items.Add("Jue");
            horario.Items.Add("Vie");
            horario4.Items.Add("7:30-8:30");
            horario4.Items.Add("8:30-9:30");
            horario4.Items.Add("9:30-10:30");
            horario4.Items.Add("11:00-12:00");
            horario4.Items.Add("12:00-13:00");
            horario.SelectedIndex = 0;
            horario4.SelectedIndex = 0;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void anadir_Click(object sender, EventArgs e)
        {
            if (curso.Text != "" && horario.Text != "" && horario4.Text != "")
            {
                if (horario2.Text != "" && horario3.Text != "")
                {
                    if (!(listBox4.Items.Contains(horario4.Text)))
                    {
                        listCurso.Items.Add(curso.Text);
                        listBox1.Items.Add(horario.Text);
                        listBox2.Items.Add(horario2.Text);
                        listBox3.Items.Add(horario3.Text);
                        listBox4.Items.Add(horario4.Text);
                    }
                }
                else
                {
                    if (horario2.Text != "")
                    {
                        if (!(listBox4.Items.Contains(horario4.Text)))
                        {
                            listCurso.Items.Add(curso.Text);
                            listBox1.Items.Add(horario.Text);
                            listBox2.Items.Add(horario2.Text);
                            listBox3.Items.Add("");
                            listBox4.Items.Add(horario4.Text);
                        }
                        else
                        {
                            if (!((listBox1.Items.Contains(horario.Text)) || (listBox1.Items.Contains(horario2.Text))  || (listBox2.Items.Contains(horario.Text)) || (listBox2.Items.Contains(horario2.Text)) || (listBox3.Items.Contains(horario.Text)) || (listBox3.Items.Contains(horario2.Text))))
                            {
                                listCurso.Items.Add(curso.Text);
                                listBox1.Items.Add(horario.Text);
                                listBox2.Items.Add(horario2.Text);
                                listBox3.Items.Add("");
                                listBox4.Items.Add(horario4.Text);
                            }
                        }
                    }
                    else
                    {
                        if (!(listBox4.Items.Contains(horario4.Text)))
                        {
                            listCurso.Items.Add(curso.Text);
                            listBox1.Items.Add(horario.Text);
                            listBox2.Items.Add("");
                            listBox3.Items.Add("");
                            listBox4.Items.Add(horario4.Text);
                        }
                        else
                        {
                            if (!((listBox1.Items.Contains(horario.Text)) || (listBox2.Items.Contains(horario.Text)) || (listBox3.Items.Contains(horario.Text)) ))
                            {
                                listCurso.Items.Add(curso.Text);
                                listBox1.Items.Add(horario.Text);
                                listBox2.Items.Add("");
                                listBox3.Items.Add("");
                                listBox4.Items.Add(horario4.Text);
                            }
                        }
                    }
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (horario.SelectedIndex != 0 && horario.SelectedIndex != 5)
            {
                horario3.Items.Clear();
                horario3.Enabled = false;
                horario2.Enabled = true;
                switch (horario.SelectedIndex)
                {
                    case 1:
                        horario2.Items.Clear();
                        horario2.Items.Add("");
                        horario2.Items.Add("Mar");
                        horario2.Items.Add("Mie");
                        horario2.Items.Add("Jue");
                        horario2.Items.Add("Vie");
                        var2 = 1;
                        break;
                    case 2:
                        horario2.Items.Clear();
                        horario2.Items.Add("");
                        horario2.Items.Add("Mie");
                        horario2.Items.Add("Jue");
                        horario2.Items.Add("Vie");
                        var2 = 2;
                        break;
                    case 3:
                        horario2.Items.Clear();
                        horario2.Items.Add("");
                        horario2.Items.Add("Jue");
                        horario2.Items.Add("Vie");
                        var2 = 3;
                        break;
                    case 4:
                        horario2.Items.Clear();
                        horario2.Items.Add("");
                        horario2.Items.Add("Vie");
                        var2 = 4;
                        break;
                }
            }
            else
            {
                horario2.Items.Clear();
                horario2.Enabled = false;
                horario3.Items.Clear();
                horario3.Enabled = false;
                var2 = 0;
            }
        }

        private void horario2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (horario2.SelectedIndex != 0)
            {
                horario3.Enabled = true;
                switch (var2)
                {
                    case 1:
                        switch (horario2.SelectedIndex)
                        {
                            case 1:
                                horario3.Items.Clear();
                                horario3.Items.Add("");
                                horario3.Items.Add("Mie");
                                horario3.Items.Add("Jue");
                                horario3.Items.Add("Vie");
                                break;
                            case 2:
                                horario3.Items.Clear();
                                horario3.Items.Add("");
                                horario3.Items.Add("Jue");
                                horario3.Items.Add("Vie");
                                break;
                            case 3:
                                horario3.Items.Clear();
                                horario3.Items.Add("");
                                horario3.Items.Add("Vie");
                                break;
                            case 4:
                                horario3.Items.Clear();
                                horario3.Enabled = false;
                                break;
                        }
                    break;
                    case 2:
                    switch (horario2.SelectedIndex)
                    {
                        case 1:
                            horario3.Items.Clear();
                            horario3.Items.Add("");
                            horario3.Items.Add("Jue");
                            horario3.Items.Add("Vie");
                            break;
                        case 2:
                            horario3.Items.Clear();
                            horario3.Items.Add("");
                            horario3.Items.Add("Vie");
                            break;
                        case 3:
                            horario3.Items.Clear();
                            horario3.Enabled = false;
                            break;
                    }
                    break;
                    case 3:
                    switch (horario2.SelectedIndex)
                    {
                        case 1:
                            horario3.Items.Clear();
                            horario3.Items.Add("");
                            horario3.Items.Add("Vie");
                            break;
                        case 2:
                            horario3.Items.Clear();
                            horario3.Enabled = false;
                            break;
                    }
                    break;
                    case 4:
                        horario3.Items.Clear();
                        horario3.Enabled = false;
                            break;
                }
            }
            else
            {
                horario3.Items.Clear();
                horario3.Enabled = false;
                var2 = 0;
            }
        }

        private void curso_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letras(e);
        }

        private void birthDate_ValueChanged(object sender, EventArgs e)
        {
            edad = 2015 - birthDate.Value.Year;
            edadT.Text = edad.ToString();
        }
    }
}
