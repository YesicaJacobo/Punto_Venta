
namespace PoS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alerta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mat Saleh", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(464, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mat Saleh", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(399, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(228)))), ((int)(((byte)(149)))));
            this.usuario.Location = new System.Drawing.Point(617, 168);
            this.usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(215, 31);
            this.usuario.TabIndex = 2;
            // 
            // contraseña
            // 
            this.contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(228)))), ((int)(((byte)(149)))));
            this.contraseña.Location = new System.Drawing.Point(617, 240);
            this.contraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '•';
            this.contraseña.Size = new System.Drawing.Size(215, 31);
            this.contraseña.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(228)))), ((int)(((byte)(149)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.button1.Location = new System.Drawing.Point(550, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Conectarse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(77, 168);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(230, 247);
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelBienvenida.Font = new System.Drawing.Font("Mat Saleh", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelBienvenida.Location = new System.Drawing.Point(31, 55);
            this.labelBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(339, 50);
            this.labelBienvenida.TabIndex = 7;
            this.labelBienvenida.Text = "Bienvenido a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(419, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Introduca los datos que se piden";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(6, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 497);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // alerta
            // 
            this.alerta.AutoSize = true;
            this.alerta.BackColor = System.Drawing.Color.Transparent;
            this.alerta.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.alerta.ForeColor = System.Drawing.Color.Maroon;
            this.alerta.Location = new System.Drawing.Point(510, 327);
            this.alerta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alerta.Name = "alerta";
            this.alerta.Size = new System.Drawing.Size(268, 40);
            this.alerta.TabIndex = 12;
            this.alerta.Text = "Datos incomplertos";
            this.alerta.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(879, 490);
            this.Controls.Add(this.alerta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label alerta;
    }
}

