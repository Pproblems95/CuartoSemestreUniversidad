using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSemaforo
{
    public partial class Form1 : Form
    {
        int caso = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = PracticaSemaforo.Properties.Resources.Apagado;
            btn_apagar.Enabled = false;
            btn_detener.Enabled = false;
        }

        private void btn_encender_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btn_encender.Enabled = false;
            btn_apagar.Enabled = true;
            btn_detener.Enabled = true;
            label1.Text = "Ahora esta encendido";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (caso)
            {
                case 0:
                    pictureBox1.Image = PracticaSemaforo.Properties.Resources.Verde;
                    timer1.Interval = 5000;
                    pictureBox2.Image = PracticaSemaforo.Properties.Resources.Rojo;
                    caso = 1;
                    break;
                case 1:
                    pictureBox1.Image= PracticaSemaforo.Properties.Resources.Amarillo;
                    timer1.Interval = 2000;
                    pictureBox2.Image = PracticaSemaforo.Properties.Resources.Amarillo;
                    caso = 2;
                    break;
                case 2: 
                    pictureBox1.Image= PracticaSemaforo.Properties.Resources.Rojo;
                    timer1.Interval = 5000;
                    pictureBox2.Image = PracticaSemaforo.Properties.Resources.Verde;
                    caso = 0;
                    break;
                default:
                    break;
            }
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            if (btn_detener.Text == "Detener")
            {
                timer1.Enabled = false;
                btn_detener.Text = "Reanudar";
                label1.Text = "Ahora detenido";
            }
            else
            {
                if (btn_detener.Text == "Reanudar")
                {
                    timer1.Enabled = true;
                    btn_detener.Text = "Detener";
                    label1.Text = "Ahora encendido";
                }
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btn_detener.Enabled = false;
            btn_apagar.Enabled = false;
            btn_encender.Enabled = true;
            pictureBox1.Image = PracticaSemaforo.Properties.Resources.Apagado;
            pictureBox2.Image = PracticaSemaforo.Properties.Resources.Apagado;
            label1.Text = "Semaforo apagado";
        }
    }
}
