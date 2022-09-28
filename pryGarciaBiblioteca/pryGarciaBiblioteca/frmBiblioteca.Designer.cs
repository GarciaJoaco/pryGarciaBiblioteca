namespace pryGarciaBiblioteca
{
    partial class frmBiblioteca
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.dgvConsultaLibros = new System.Windows.Forms.DataGridView();
            this.codLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDistribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(512, 91);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 36);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(593, 91);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 36);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Adelante ";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // dgvConsultaLibros
            // 
            this.dgvConsultaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLibro,
            this.nombLibro,
            this.codEditorial,
            this.codAutor,
            this.codDistribuidor});
            this.dgvConsultaLibros.Location = new System.Drawing.Point(0, 3);
            this.dgvConsultaLibros.Name = "dgvConsultaLibros";
            this.dgvConsultaLibros.Size = new System.Drawing.Size(668, 82);
            this.dgvConsultaLibros.TabIndex = 6;
            // 
            // codLibro
            // 
            this.codLibro.HeaderText = "Codigo";
            this.codLibro.Name = "codLibro";
            // 
            // nombLibro
            // 
            this.nombLibro.HeaderText = "Nombre";
            this.nombLibro.MinimumWidth = 50;
            this.nombLibro.Name = "nombLibro";
            this.nombLibro.Width = 200;
            // 
            // codEditorial
            // 
            this.codEditorial.HeaderText = "Codigo Editorial";
            this.codEditorial.Name = "codEditorial";
            // 
            // codAutor
            // 
            this.codAutor.HeaderText = "Codigo Autor";
            this.codAutor.Name = "codAutor";
            // 
            // codDistribuidor
            // 
            this.codDistribuidor.HeaderText = "Codigo Distribuidor";
            this.codDistribuidor.Name = "codDistribuidor";
            this.codDistribuidor.Width = 200;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(676, 132);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dgvConsultaLibros);
            this.Name = "frmBiblioteca";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dgvConsultaLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDistribuidor;
    }
}