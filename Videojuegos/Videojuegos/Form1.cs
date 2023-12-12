using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Videojuegos.VideojuegosDataSetTableAdapters;
using System.IO;

namespace Videojuegos
{
    public partial class Form1 : Form
    {
        int ID;
        string nombre;
        int año;
        string genero;
        string desarrolladora;


        public Form1()
        {
            InitializeComponent();
            LlenarGrid();
        }

        void Limpiar() 
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        SqlConnection conection = new SqlConnection("Data Source=LAPTOP-O1T2A85B;Initial Catalog=Videojuegos;Integrated Security=True");
        public void LlenarGrid() 
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from JUEGOS", conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videojuegosDataSet2.JUEGOS' table. You can move, or remove it, as needed.
            this.jUEGOSTableAdapter1.Fill(this.videojuegosDataSet2.JUEGOS);
            // TODO: This line of code loads data into the 'videojuegosDataSet1.JUEGOS' table. You can move, or remove it, as needed.
            this.jUEGOSTableAdapter.Fill(this.videojuegosDataSet1.JUEGOS);
            //DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            //dgvImage.HeaderText = "Imagen";
            //dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            

            //DataGridViewTextBoxColumn dgvId = new DataGridViewTextBoxColumn();
            //dgvId.HeaderText = "Id";

            //dataGridView1.Columns.Add(dgvId);
            //dataGridView1.Columns.Add(dgvImage);

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.AllowUserToAddRows = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            conection.Open();
            SqlCommand alta = new SqlCommand("insert into JUEGOS(NOMBRE, AÑO, GENERO, DESARROLLADORA, Imagen, NOMBRE_IMAGEN) values (@NOMBRE, @AÑO, @GENERO, @DESARROLLADORA, @Imagen, @NOMBRE_IMAGEN)", conection);
            alta.Parameters.AddWithValue("NOMBRE", textBox2.Text);
            alta.Parameters.AddWithValue("Genero", textBox4.Text);
            alta.Parameters.AddWithValue("DESARROLLADORA", textBox3.Text);
            alta.Parameters.AddWithValue("AÑO", textBox5.Text);

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            alta.Parameters.AddWithValue("Imagen", img);
            alta.Parameters.AddWithValue("NOMBRE_IMAGEN", textBox6.Text);
            alta.ExecuteNonQuery();
            imagenDataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Limpiar();
            LlenarGrid();
            
            

            
            conection.Close();
        }
        void Borrar() 
        {
            conection.Open();
            string baja = "delete from JUEGOS where id = @id";
            SqlCommand Baja = new SqlCommand(baja, conection);
            Baja.Parameters.AddWithValue("id", ID = 2);
            LlenarGrid();
            Baja.ExecuteNonQuery();
            conection.Close();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Selecciona una imagen (*.jpg;*.png;*.gif) |*.jpg; *.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK) 
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            conection.Open();
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conection.Close();
        }
    }
}
