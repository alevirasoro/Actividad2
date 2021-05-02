
namespace Presentacion
{
    partial class Gestor
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.lFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 48);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 25;
            this.dgvArticulos.Size = new System.Drawing.Size(771, 380);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvArticulos_MouseClick);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(789, 11);
            this.pbArticulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(306, 417);
            this.pbArticulo.TabIndex = 1;
            this.pbArticulo.TabStop = false;
            // 
            // lFiltro
            // 
            this.lFiltro.AutoSize = true;
            this.lFiltro.Location = new System.Drawing.Point(288, 18);
            this.lFiltro.Name = "lFiltro";
            this.lFiltro.Size = new System.Drawing.Size(106, 20);
            this.lFiltro.TabIndex = 2;
            this.lFiltro.Text = "Filtrar Nombre";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(400, 13);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(383, 27);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(12, 11);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(86, 31);
            this.bAgregar.TabIndex = 5;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(104, 11);
            this.bEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(86, 31);
            this.bEditar.TabIndex = 6;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(196, 11);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(86, 31);
            this.bEliminar.TabIndex = 8;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 440);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lFiltro);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Gestor";
            this.Text = "Gestor Comercial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Label lFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bEliminar;
    }
}

