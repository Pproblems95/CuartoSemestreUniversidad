namespace PracticaPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.Btn_Color = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 87);
            this.panel1.TabIndex = 0;
            // 
            // color_picker
            // 
            this.color_picker.Image = ((System.Drawing.Image)(resources.GetObject("color_picker.Image")));
            this.color_picker.InitialImage = ((System.Drawing.Image)(resources.GetObject("color_picker.InitialImage")));
            this.color_picker.Location = new System.Drawing.Point(0, 3);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(115, 81);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 3;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Controls.Add(this.btn_line);
            this.panel3.Controls.Add(this.pic_color);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Controls.Add(this.Btn_Color);
            this.panel3.Controls.Add(this.btn_ellipse);
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Controls.Add(this.btn_pencil);
            this.panel3.Location = new System.Drawing.Point(112, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 81);
            this.panel3.TabIndex = 10;
            // 
            // btn_eraser
            // 
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.Image = ((System.Drawing.Image)(resources.GetObject("btn_eraser.Image")));
            this.btn_eraser.Location = new System.Drawing.Point(583, 18);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(81, 58);
            this.btn_eraser.TabIndex = 10;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_line
            // 
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Image = ((System.Drawing.Image)(resources.GetObject("btn_line.Image")));
            this.btn_line.Location = new System.Drawing.Point(505, 18);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(76, 60);
            this.btn_line.TabIndex = 9;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(9, 19);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(42, 48);
            this.pic_color.TabIndex = 3;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // btn_rect
            // 
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Image = ((System.Drawing.Image)(resources.GetObject("btn_rect.Image")));
            this.btn_rect.Location = new System.Drawing.Point(411, 18);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(88, 59);
            this.btn_rect.TabIndex = 8;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // Btn_Color
            // 
            this.Btn_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.Btn_Color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Color.ForeColor = System.Drawing.Color.White;
            this.Btn_Color.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Color.Image")));
            this.Btn_Color.Location = new System.Drawing.Point(68, 19);
            this.Btn_Color.Name = "Btn_Color";
            this.Btn_Color.Size = new System.Drawing.Size(81, 58);
            this.Btn_Color.TabIndex = 4;
            this.Btn_Color.Text = "Color";
            this.Btn_Color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Color.UseVisualStyleBackColor = true;
            this.Btn_Color.Click += new System.EventHandler(this.Btn_Color_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Image = ((System.Drawing.Image)(resources.GetObject("btn_ellipse.Image")));
            this.btn_ellipse.Location = new System.Drawing.Point(325, 19);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(80, 58);
            this.btn_ellipse.TabIndex = 7;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.Image = ((System.Drawing.Image)(resources.GetObject("btn_fill.Image")));
            this.btn_fill.Location = new System.Drawing.Point(155, 20);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(81, 58);
            this.btn_fill.TabIndex = 5;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.White;
            this.btn_pencil.Image = ((System.Drawing.Image)(resources.GetObject("btn_pencil.Image")));
            this.btn_pencil.Location = new System.Drawing.Point(242, 19);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(77, 58);
            this.btn_pencil.TabIndex = 6;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 92);
            this.panel2.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(701, 57);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(701, 18);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.White;
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(0, 0);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(782, 503);
            this.Pic.TabIndex = 2;
            this.Pic.TabStop = false;
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button Btn_Color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button_clear;
    }
}

