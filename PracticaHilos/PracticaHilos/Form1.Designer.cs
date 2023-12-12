namespace PracticaHilos
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
            this.btn_cuadros = new System.Windows.Forms.Button();
            this.btn_circulos = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btn_cuadros
            // 
            this.btn_cuadros.Location = new System.Drawing.Point(75, 55);
            this.btn_cuadros.Name = "btn_cuadros";
            this.btn_cuadros.Size = new System.Drawing.Size(75, 23);
            this.btn_cuadros.TabIndex = 0;
            this.btn_cuadros.Text = "Cuadros";
            this.btn_cuadros.UseVisualStyleBackColor = true;
            this.btn_cuadros.Click += new System.EventHandler(this.btn_cuadros_Click);
            // 
            // btn_circulos
            // 
            this.btn_circulos.Location = new System.Drawing.Point(214, 55);
            this.btn_circulos.Name = "btn_circulos";
            this.btn_circulos.Size = new System.Drawing.Size(75, 23);
            this.btn_circulos.TabIndex = 1;
            this.btn_circulos.Text = "Circulos";
            this.btn_circulos.UseVisualStyleBackColor = true;
            this.btn_circulos.Click += new System.EventHandler(this.btn_circulos_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(618, 240);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(75, 23);
            this.btn_exportar.TabIndex = 2;
            this.btn_exportar.Text = "Exportar archivos";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.Location = new System.Drawing.Point(504, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 161);
            this.textBox1.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(593, 179);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 31);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_circulos);
            this.Controls.Add(this.btn_cuadros);
            this.Name = "Form1";
            this.Text = "Practica hilos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cuadros;
        private System.Windows.Forms.Button btn_circulos;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

