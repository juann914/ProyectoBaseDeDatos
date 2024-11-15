namespace Databasesproyect
{
    partial class ProductosSolictarDatos
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
            this.gpCode = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAcpetar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpProducto = new System.Windows.Forms.GroupBox();
            this.gpCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.gpProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpCode
            // 
            this.gpCode.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gpCode.Controls.Add(this.button1);
            this.gpCode.Controls.Add(this.btnAcpetar);
            this.gpCode.Controls.Add(this.btnCancelar);
            this.gpCode.Controls.Add(this.txtCodigo);
            this.gpCode.Controls.Add(this.label1);
            this.gpCode.Location = new System.Drawing.Point(40, 12);
            this.gpCode.Name = "gpCode";
            this.gpCode.Size = new System.Drawing.Size(1176, 174);
            this.gpCode.TabIndex = 6;
            this.gpCode.TabStop = false;
            this.gpCode.Enter += new System.EventHandler(this.gpCode_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAcpetar
            // 
            this.btnAcpetar.Location = new System.Drawing.Point(635, 90);
            this.btnAcpetar.Name = "btnAcpetar";
            this.btnAcpetar.Size = new System.Drawing.Size(106, 48);
            this.btnAcpetar.TabIndex = 2;
            this.btnAcpetar.Text = "Aceptar";
            this.btnAcpetar.UseVisualStyleBackColor = true;
            this.btnAcpetar.Click += new System.EventHandler(this.btnAcpetar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(202, 90);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 48);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(554, 21);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(287, 29);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por codigo:";
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AllowUserToOrderColumns = true;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.CodigoBarra,
            this.Nombre,
            this.Precio,
            this.Marca,
            this.Descripcion,
            this.cantidad});
            this.dataGridProductos.Location = new System.Drawing.Point(0, 21);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.RowHeadersWidth = 51;
            this.dataGridProductos.RowTemplate.Height = 24;
            this.dataGridProductos.Size = new System.Drawing.Size(1041, 241);
            this.dataGridProductos.TabIndex = 0;
            this.dataGridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 125;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.HeaderText = "CodigoBarra";
            this.CodigoBarra.MinimumWidth = 6;
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 125;
            // 
            // gpProducto
            // 
            this.gpProducto.Controls.Add(this.dataGridProductos);
            this.gpProducto.Location = new System.Drawing.Point(27, 192);
            this.gpProducto.Name = "gpProducto";
            this.gpProducto.Size = new System.Drawing.Size(1207, 297);
            this.gpProducto.TabIndex = 7;
            this.gpProducto.TabStop = false;
            this.gpProducto.Enter += new System.EventHandler(this.gpProducto_Enter);
            // 
            // ProductosSolictarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 483);
            this.Controls.Add(this.gpProducto);
            this.Controls.Add(this.gpCode);
            this.Name = "ProductosSolictarDatos";
            this.Text = "ProductosSolictarDatos";
            this.gpCode.ResumeLayout(false);
            this.gpCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.gpProducto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCode;
        private System.Windows.Forms.Button btnAcpetar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridProductos;
        public System.Windows.Forms.GroupBox gpProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
    }
}