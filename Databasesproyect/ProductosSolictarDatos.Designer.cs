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
            this.btnAcpetar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpProducto = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.gpCode.SuspendLayout();
            this.gpProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpCode
            // 
            this.gpCode.Controls.Add(this.btnAcpetar);
            this.gpCode.Controls.Add(this.btnCancelar);
            this.gpCode.Controls.Add(this.txtCodigo);
            this.gpCode.Controls.Add(this.label1);
            this.gpCode.Location = new System.Drawing.Point(40, 12);
            this.gpCode.Name = "gpCode";
            this.gpCode.Size = new System.Drawing.Size(679, 174);
            this.gpCode.TabIndex = 6;
            this.gpCode.TabStop = false;
            // 
            // btnAcpetar
            // 
            this.btnAcpetar.Location = new System.Drawing.Point(199, 82);
            this.btnAcpetar.Name = "btnAcpetar";
            this.btnAcpetar.Size = new System.Drawing.Size(106, 48);
            this.btnAcpetar.TabIndex = 2;
            this.btnAcpetar.Text = "Aceptar";
            this.btnAcpetar.UseVisualStyleBackColor = true;
            this.btnAcpetar.Click += new System.EventHandler(this.btnAcpetar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(378, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 48);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(273, 18);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(287, 29);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce codigo del producto:";
            // 
            // gpProducto
            // 
            this.gpProducto.Controls.Add(this.txtMarca);
            this.gpProducto.Controls.Add(this.txtCode);
            this.gpProducto.Controls.Add(this.label6);
            this.gpProducto.Controls.Add(this.label5);
            this.gpProducto.Controls.Add(this.button2);
            this.gpProducto.Controls.Add(this.txtNombre);
            this.gpProducto.Controls.Add(this.txtDes);
            this.gpProducto.Controls.Add(this.txtPrecio);
            this.gpProducto.Controls.Add(this.label4);
            this.gpProducto.Controls.Add(this.label3);
            this.gpProducto.Controls.Add(this.label2);
            this.gpProducto.Location = new System.Drawing.Point(27, 192);
            this.gpProducto.Name = "gpProducto";
            this.gpProducto.Size = new System.Drawing.Size(719, 297);
            this.gpProducto.TabIndex = 7;
            this.gpProducto.TabStop = false;
            this.gpProducto.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(163, 170);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 32);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDes
            // 
            this.txtDes.Enabled = false;
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(163, 112);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(140, 32);
            this.txtDes.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(158, 58);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(140, 32);
            this.txtPrecio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Codigo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Marca: ";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(436, 58);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(140, 27);
            this.txtCode.TabIndex = 11;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(436, 112);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(140, 32);
            this.txtMarca.TabIndex = 12;
            // 
            // ProductosSolictarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.gpProducto);
            this.Controls.Add(this.gpCode);
            this.Name = "ProductosSolictarDatos";
            this.Text = "ProductosSolictarDatos";
            this.gpCode.ResumeLayout(false);
            this.gpCode.PerformLayout();
            this.gpProducto.ResumeLayout(false);
            this.gpProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCode;
        private System.Windows.Forms.Button btnAcpetar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpProducto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}