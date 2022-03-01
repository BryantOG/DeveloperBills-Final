using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            gridCliente.Visible=true;
            btnOculCli.Visible = true;
            textBusCli.Visible =true;
            labelBus.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panelClave.Visible=true;



            /*
            Form form = new ClaveAdmin();
            form.Show();

            
            ModificarCli1.Visible = false;
            modificarCli2.Visible = true;
            */



        }

        private void button5_Click(object sender, EventArgs e)
        {
            gridCliente.Visible = false;
            textBusCli.Visible = false;
            labelBus.Visible = false;
            btnOculCli.Visible = false;
            modificarCli2.Visible = false;
            ModificarCli1.Visible = true;
        }

        private void modificarCli2_Click(object sender, EventArgs e)
        {
           
        }

        public void Modificar3_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string contraseña = "admin";

            if (textClave.Text == contraseña)
            {
                modificarCli2.Visible = true;
                ModificarCli1.Visible = false;
                panelClave.Visible = false;

                gridCliente.Visible = true;
                textBusCli.Visible = true;
                labelBus.Visible = true;
                btnOculCli.Visible = true;

                textClave.Text = "";


            }
            else
            {
                MessageBox.Show("El usuario o contraseña esta incorrecto");
                textClave.Text = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
