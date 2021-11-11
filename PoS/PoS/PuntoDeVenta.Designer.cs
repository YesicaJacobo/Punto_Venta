
namespace PoS
{
    partial class PuntoDeVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuntoDeVenta));
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.labelHoraFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.labelPaseCodigo = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.perdido = new System.Windows.Forms.PictureBox();
            this.leatiende = new System.Windows.Forms.Label();
            this.menuCaf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdido)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.labelBienvenida.Font = new System.Drawing.Font("Mat Saleh", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.labelBienvenida.Location = new System.Drawing.Point(226, 30);
            this.labelBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(685, 50);
            this.labelBienvenida.TabIndex = 0;
            this.labelBienvenida.Text = "Bienvenido a Super del Sur";
            // 
            // labelHoraFecha
            // 
            this.labelHoraFecha.AutoSize = true;
            this.labelHoraFecha.Font = new System.Drawing.Font("Mat Saleh", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHoraFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.labelHoraFecha.Location = new System.Drawing.Point(423, 672);
            this.labelHoraFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHoraFecha.Name = "labelHoraFecha";
            this.labelHoraFecha.Size = new System.Drawing.Size(263, 40);
            this.labelHoraFecha.TabIndex = 2;
            this.labelHoraFecha.Text = "Hora y Fecha";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tablaProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(197)))), ((int)(((byte)(150)))));
            this.tablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(170)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tempus Sans ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.id});
            this.tablaProductos.EnableHeadersVisualStyles = false;
            this.tablaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.tablaProductos.Location = new System.Drawing.Point(81, 185);
            this.tablaProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaProductos.Name = "tablaProductos";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tempus Sans ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tablaProductos.RowHeadersVisible = false;
            this.tablaProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.NullValue = null;
            this.tablaProductos.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.tablaProductos.RowTemplate.Height = 60;
            this.tablaProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaProductos.Size = new System.Drawing.Size(469, 263);
            this.tablaProductos.TabIndex = 3;
            this.tablaProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tablaProductos_KeyPress);
            // 
            // Column1
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(228)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(228)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column1.HeaderText = "Cantidad";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(228)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column2.HeaderText = "Producto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(228)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle11.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column3.HeaderText = "Precio";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(228)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(228)))), ((int)(((byte)(149)))));
            this.codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigo.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.codigo.Location = new System.Drawing.Point(676, 275);
            this.codigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(142, 64);
            this.codigo.TabIndex = 4;
            this.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Mat Saleh", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.labelTotal.Location = new System.Drawing.Point(867, 458);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(161, 54);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(937, 77);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 150);
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // labelPaseCodigo
            // 
            this.labelPaseCodigo.AutoSize = true;
            this.labelPaseCodigo.Font = new System.Drawing.Font("Mat Saleh", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPaseCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.labelPaseCodigo.Location = new System.Drawing.Point(-1, 562);
            this.labelPaseCodigo.Name = "labelPaseCodigo";
            this.labelPaseCodigo.Size = new System.Drawing.Size(1248, 50);
            this.labelPaseCodigo.TabIndex = 7;
            this.labelPaseCodigo.Text = "Por favor pase el codigo del producto en el escaner";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // perdido
            // 
            this.perdido.BackColor = System.Drawing.Color.Transparent;
            this.perdido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("perdido.BackgroundImage")));
            this.perdido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.perdido.Location = new System.Drawing.Point(937, 252);
            this.perdido.Name = "perdido";
            this.perdido.Size = new System.Drawing.Size(150, 150);
            this.perdido.TabIndex = 8;
            this.perdido.TabStop = false;
            this.perdido.Visible = false;
            // 
            // leatiende
            // 
            this.leatiende.AutoSize = true;
            this.leatiende.Font = new System.Drawing.Font("Mat Saleh", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leatiende.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.leatiende.Location = new System.Drawing.Point(17, 87);
            this.leatiende.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leatiende.Name = "leatiende";
            this.leatiende.Size = new System.Drawing.Size(298, 53);
            this.leatiende.TabIndex = 9;
            this.leatiende.Text = "Le atiende:";
            // 
            // menuCaf
            // 
            this.menuCaf.BackgroundImage = global::PoS.Properties.Resources.menucaf;
            this.menuCaf.Font = new System.Drawing.Font("Mat Saleh", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuCaf.Location = new System.Drawing.Point(723, 103);
            this.menuCaf.Name = "menuCaf";
            this.menuCaf.Size = new System.Drawing.Size(180, 100);
            this.menuCaf.TabIndex = 10;
            this.menuCaf.UseVisualStyleBackColor = true;
            this.menuCaf.Click += new System.EventHandler(this.menuCaf_Click);
            // 
            // PuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.menuCaf);
            this.Controls.Add(this.leatiende);
            this.Controls.Add(this.perdido);
            this.Controls.Add(this.labelPaseCodigo);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.labelHoraFecha);
            this.Controls.Add(this.labelBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PuntoDeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuntoDeVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PuntoDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelHoraFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label labelPaseCodigo;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox perdido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        public System.Windows.Forms.Label leatiende;
        private System.Windows.Forms.Label menuCafes;
        private System.Windows.Forms.Button menuCaf;
    }
}