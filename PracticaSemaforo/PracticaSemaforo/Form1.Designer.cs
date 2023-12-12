namespace PracticaSemaforo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_encender = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_detener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Controles = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Controles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticaSemaforo.Properties.Resources.Verde;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_encender
            // 
            this.btn_encender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_encender.Location = new System.Drawing.Point(70, 40);
            this.btn_encender.Name = "btn_encender";
            this.btn_encender.Size = new System.Drawing.Size(75, 23);
            this.btn_encender.TabIndex = 1;
            this.btn_encender.Text = "Encender";
            this.btn_encender.UseVisualStyleBackColor = false;
            this.btn_encender.Click += new System.EventHandler(this.btn_encender_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_apagar.Location = new System.Drawing.Point(70, 96);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(75, 23);
            this.btn_apagar.TabIndex = 2;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_detener
            // 
            this.btn_detener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_detener.Location = new System.Drawing.Point(70, 156);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(75, 23);
            this.btn_detener.TabIndex = 3;
            this.btn_detener.Text = "Detener";
            this.btn_detener.UseVisualStyleBackColor = false;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "estado";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Controles
            // 
            this.Controles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controles.Controls.Add(this.label2);
            this.Controles.Controls.Add(this.btn_encender);
            this.Controles.Controls.Add(this.btn_apagar);
            this.Controles.Controls.Add(this.btn_detener);
            this.Controles.Location = new System.Drawing.Point(292, 143);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(212, 215);
            this.Controles.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Controles";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PracticaSemaforo.Properties.Resources.Verde;
            this.pictureBox2.Location = new System.Drawing.Point(563, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 363);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Semaforo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Controles.ResumeLayout(false);
            this.Controles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_encender;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Controles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

