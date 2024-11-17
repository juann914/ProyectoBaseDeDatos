namespace Databasesproyect
{
    partial class ClienteModificar
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
            this.gpId = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpCliente = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.IdProductoddd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpId.SuspendLayout();
            this.gpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gpId
            // 
            this.gpId.Controls.Add(this.button2);
            this.gpId.Controls.Add(this.button1);
            this.gpId.Controls.Add(this.txtId);
            this.gpId.Controls.Add(this.label1);
            this.gpId.Location = new System.Drawing.Point(12, 28);
            this.gpId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpId.Name = "gpId";
            this.gpId.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpId.Size = new System.Drawing.Size(884, 206);
            this.gpId.TabIndex = 0;
            this.gpId.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 116);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(395, 41);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(188, 29);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introdue el id del cliente a modificar :\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.button4);
            this.gpCliente.Controls.Add(this.button3);
            this.gpCliente.Controls.Add(this.txtCorreo);
            this.gpCliente.Controls.Add(this.txtApellidos);
            this.gpCliente.Controls.Add(this.txtNombre);
            this.gpCliente.Controls.Add(this.label4);
            this.gpCliente.Controls.Add(this.label3);
            this.gpCliente.Controls.Add(this.label2);
            this.gpCliente.Location = new System.Drawing.Point(24, 327);
            this.gpCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpCliente.Size = new System.Drawing.Size(872, 253);
            this.gpCliente.TabIndex = 1;
            this.gpCliente.TabStop = false;
            this.gpCliente.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(614, 103);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(441, 103);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(120, 159);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 29);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(120, 103);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(241, 29);
            this.txtApellidos.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 44);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 29);
            this.txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Correo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.AllowUserToOrderColumns = true;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProductoddd,
            this.CodigoBarra,
            this.Nombre,
            this.Precio,
            this.Marca});
            this.dataGridCliente.Location = new System.Drawing.Point(14, 239);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.RowHeadersWidth = 51;
            this.dataGridCliente.RowTemplate.Height = 24;
            this.dataGridCliente.Size = new System.Drawing.Size(882, 83);
            this.dataGridCliente.TabIndex = 9;
            this.dataGridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCliente_CellContentClick);
            // 
            // IdProductoddd
            // 
            this.IdProductoddd.HeaderText = "IdUsuario";
            this.IdProductoddd.MinimumWidth = 6;
            this.IdProductoddd.Name = "IdProductoddd";
            this.IdProductoddd.Width = 125;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.HeaderText = "Nombre";
            this.CodigoBarra.MinimumWidth = 6;
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Apellido";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Correo";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "RFC";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // ClienteModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 603);
            this.Controls.Add(this.dataGridCliente);
            this.Controls.Add(this.gpCliente);
            this.Controls.Add(this.gpId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClienteModificar";
            this.Text = "ClienteModificar";
            this.Load += new System.EventHandler(this.ClienteModificar_Load);
            this.gpId.ResumeLayout(false);
            this.gpId.PerformLayout();
            this.gpCliente.ResumeLayout(false);
            this.gpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox gpCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductoddd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
    }
}