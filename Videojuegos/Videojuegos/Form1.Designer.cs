namespace Videojuegos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.jUEGOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videojuegosDataSet1 = new Videojuegos.VideojuegosDataSet1();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jUEGOSTableAdapter = new Videojuegos.VideojuegosDataSet1TableAdapters.JUEGOSTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.videojuegosDataSet2 = new Videojuegos.VideojuegosDataSet2();
            this.jUEGOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jUEGOSTableAdapter1 = new Videojuegos.VideojuegosDataSet2TableAdapters.JUEGOSTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aÑODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESARROLLADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nOMBREIMAGENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jUEGOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jUEGOSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(801, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(801, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 22);
            this.textBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIDEOJUEGOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Desarrolladora";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(815, 310);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(126, 28);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(815, 344);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(126, 28);
            this.btn_borrar.TabIndex = 10;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // jUEGOSBindingSource
            // 
            this.jUEGOSBindingSource.DataMember = "JUEGOS";
            this.jUEGOSBindingSource.DataSource = this.videojuegosDataSet1;
            // 
            // videojuegosDataSet1
            // 
            this.videojuegosDataSet1.DataSetName = "VideojuegosDataSet1";
            this.videojuegosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(815, 415);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(126, 28);
            this.btn_modificar.TabIndex = 12;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(815, 378);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(126, 28);
            this.btn_consultar.TabIndex = 13;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(105, 223);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 22);
            this.textBox5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID";
            // 
            // jUEGOSTableAdapter
            // 
            this.jUEGOSTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(730, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_image
            // 
            this.btn_image.Location = new System.Drawing.Point(815, 276);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(126, 28);
            this.btn_image.TabIndex = 17;
            this.btn_image.Text = "Buscar imagen";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(815, 250);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 28);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "añadir foto";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(801, 107);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(162, 22);
            this.textBox6.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(775, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.aÑODataGridViewTextBoxColumn,
            this.gENERODataGridViewTextBoxColumn,
            this.dESARROLLADORADataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn,
            this.nOMBREIMAGENDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jUEGOSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 335);
            this.dataGridView1.TabIndex = 21;
            // 
            // videojuegosDataSet2
            // 
            this.videojuegosDataSet2.DataSetName = "VideojuegosDataSet2";
            this.videojuegosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jUEGOSBindingSource1
            // 
            this.jUEGOSBindingSource1.DataMember = "JUEGOS";
            this.jUEGOSBindingSource1.DataSource = this.videojuegosDataSet2;
            // 
            // jUEGOSTableAdapter1
            // 
            this.jUEGOSTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // aÑODataGridViewTextBoxColumn
            // 
            this.aÑODataGridViewTextBoxColumn.DataPropertyName = "AÑO";
            this.aÑODataGridViewTextBoxColumn.HeaderText = "AÑO";
            this.aÑODataGridViewTextBoxColumn.Name = "aÑODataGridViewTextBoxColumn";
            // 
            // gENERODataGridViewTextBoxColumn
            // 
            this.gENERODataGridViewTextBoxColumn.DataPropertyName = "GENERO";
            this.gENERODataGridViewTextBoxColumn.HeaderText = "GENERO";
            this.gENERODataGridViewTextBoxColumn.Name = "gENERODataGridViewTextBoxColumn";
            // 
            // dESARROLLADORADataGridViewTextBoxColumn
            // 
            this.dESARROLLADORADataGridViewTextBoxColumn.DataPropertyName = "DESARROLLADORA";
            this.dESARROLLADORADataGridViewTextBoxColumn.HeaderText = "DESARROLLADORA";
            this.dESARROLLADORADataGridViewTextBoxColumn.Name = "dESARROLLADORADataGridViewTextBoxColumn";
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            // 
            // nOMBREIMAGENDataGridViewTextBoxColumn
            // 
            this.nOMBREIMAGENDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_IMAGEN";
            this.nOMBREIMAGENDataGridViewTextBoxColumn.HeaderText = "NOMBRE_IMAGEN";
            this.nOMBREIMAGENDataGridViewTextBoxColumn.Name = "nOMBREIMAGENDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1294, 818);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jUEGOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jUEGOSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private VideojuegosDataSet1 videojuegosDataSet1;
        private System.Windows.Forms.BindingSource jUEGOSBindingSource;
        private VideojuegosDataSet1TableAdapters.JUEGOSTableAdapter jUEGOSTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VideojuegosDataSet2 videojuegosDataSet2;
        private System.Windows.Forms.BindingSource jUEGOSBindingSource1;
        private VideojuegosDataSet2TableAdapters.JUEGOSTableAdapter jUEGOSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aÑODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESARROLLADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREIMAGENDataGridViewTextBoxColumn;
    }
}

