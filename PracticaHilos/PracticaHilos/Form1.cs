using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaHilos
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cuadros_Click(object sender, EventArgs e)
        {
            Thread hilo1 = new Thread(CrearCuadrosM);
            hilo1.Start();
        }
        void CrearCuadrosM() 
        {
            Random r1 = new Random();
            Graphics g1 = CreateGraphics();
            for (int i = 0; i < 10; i++)
            {
                int r1x = r1.Next(1, 301);
                int r1y = r1.Next(1, 501);
                Thread.Sleep(200);
                g1.DrawRectangle(new Pen(Color.Purple, 3), r1x, r1y, 12, 12);
                MessageBox.Show(" " + Thread.CurrentThread.Name + " terminó su trabajo", "Mensaje: ");
            }
        }

        private void btn_circulos_Click(object sender, EventArgs e)
        {
            Thread hilo2 = new Thread(CrearCirculosM);
            hilo2.Start();
        }
        void CrearCirculosM() 
        {
            Random r = new Random();
            Graphics g = CreateGraphics();
            for (int i = 0; i < 10; i++)
            {
                int rx = r.Next(1, 301);
                int ry = r.Next(1, 501);
                Thread.Sleep(200);
                g.DrawEllipse(new Pen(Color.Purple, 3), rx, ry, 12, 12);
                MessageBox.Show(" " + Thread.CurrentThread.Name + " terminó su trabajo", "Mensaje: ");
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 10000;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Blocks;
            Thread hilo3 = new Thread(Exportar);
            hilo3.Start();
        }
        void Exportar() 
        {
            FileInfo f = new FileInfo(@"C:\Users\blakd\OneDrive\Escritorio\4to semestre\Topicos\PracticaHilos\MiTexto.txt");
            StreamWriter w = f.CreateText();
            for (int i = 0; i < 10; i++)
            {
                textBox1.Invoke((MethodInvoker)(() => textBox1.AppendText(" " + i + " cuadro es " + i * i + "\r\n")));
                w.WriteLine(" " + Thread.CurrentThread.Name + " esta imprimiendo " + i + " cuadro es = " + i*i);
                progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value = i));
            }
            w.Close();
            MessageBox.Show(" " + " El exportador de archivos terminó su trabajo", "Mensaje: ");
        }
    }
}
