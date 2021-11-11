
namespace PoS
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cafeCH = new System.Windows.Forms.Button();
            this.cafeM = new System.Windows.Forms.Button();
            this.cafeG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mat Saleh", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(128, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la talla del cafe";
            // 
            // cafeCH
            // 
            this.cafeCH.BackgroundImage = global::PoS.Properties.Resources.cafeC;
            this.cafeCH.Location = new System.Drawing.Point(150, 200);
            this.cafeCH.Name = "cafeCH";
            this.cafeCH.Size = new System.Drawing.Size(100, 150);
            this.cafeCH.TabIndex = 1;
            this.cafeCH.UseVisualStyleBackColor = true;
            this.cafeCH.Click += new System.EventHandler(this.button1_Click);
            // 
            // cafeM
            // 
            this.cafeM.BackgroundImage = global::PoS.Properties.Resources.cafeM;
            this.cafeM.Location = new System.Drawing.Point(400, 200);
            this.cafeM.Name = "cafeM";
            this.cafeM.Size = new System.Drawing.Size(100, 150);
            this.cafeM.TabIndex = 2;
            this.cafeM.UseVisualStyleBackColor = true;
            this.cafeM.Click += new System.EventHandler(this.button2_Click);
            // 
            // cafeG
            // 
            this.cafeG.BackgroundImage = global::PoS.Properties.Resources.cafeG;
            this.cafeG.Location = new System.Drawing.Point(650, 200);
            this.cafeG.Name = "cafeG";
            this.cafeG.Size = new System.Drawing.Size(100, 150);
            this.cafeG.TabIndex = 3;
            this.cafeG.UseVisualStyleBackColor = true;
            this.cafeG.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(878, 484);
            this.Controls.Add(this.cafeG);
            this.Controls.Add(this.cafeM);
            this.Controls.Add(this.cafeCH);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cafeCH;
        private System.Windows.Forms.Button cafeM;
        private System.Windows.Forms.Button cafeG;
    }
}