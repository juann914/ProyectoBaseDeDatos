namespace Databasesproyect
{
    partial class Ventas
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
            this.LaClave = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LaImporte = new System.Windows.Forms.Label();
            this.LaDescripción = new System.Windows.Forms.Label();
            this.LaPrecio = new System.Windows.Forms.Label();
            this.LaUnidad = new System.Windows.Forms.Label();
            this.LaCantidad = new System.Windows.Forms.Label();
            this.butAgregar = new System.Windows.Forms.Button();
            this.butBorrar = new System.Windows.Forms.Button();
            this.butEditar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LaClave
            // 
            this.LaClave.AutoSize = true;
            this.LaClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaClave.Location = new System.Drawing.Point(3, 0);
            this.LaClave.Name = "LaClave";
            this.LaClave.Size = new System.Drawing.Size(80, 29);
            this.LaClave.TabIndex = 0;
            this.LaClave.Text = "Clave ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.68932F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.31068F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.LaImporte, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.LaDescripción, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LaPrecio, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.LaUnidad, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LaCantidad, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LaClave, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 130);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 102);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LaImporte
            // 
            this.LaImporte.AutoSize = true;
            this.LaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaImporte.Location = new System.Drawing.Point(610, 0);
            this.LaImporte.Name = "LaImporte";
            this.LaImporte.Size = new System.Drawing.Size(95, 29);
            this.LaImporte.TabIndex = 3;
            this.LaImporte.Text = "Importe";
            // 
            // LaDescripción
            // 
            this.LaDescripción.AutoSize = true;
            this.LaDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaDescripción.Location = new System.Drawing.Point(321, 0);
            this.LaDescripción.Name = "LaDescripción";
            this.LaDescripción.Size = new System.Drawing.Size(141, 29);
            this.LaDescripción.TabIndex = 2;
            this.LaDescripción.Text = "Descripción";
            // 
            // LaPrecio
            // 
            this.LaPrecio.AutoSize = true;
            this.LaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaPrecio.Location = new System.Drawing.Point(491, 0);
            this.LaPrecio.Name = "LaPrecio";
            this.LaPrecio.Size = new System.Drawing.Size(83, 29);
            this.LaPrecio.TabIndex = 2;
            this.LaPrecio.Text = "Precio";
            // 
            // LaUnidad
            // 
            this.LaUnidad.AutoSize = true;
            this.LaUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaUnidad.Location = new System.Drawing.Point(222, 0);
            this.LaUnidad.Name = "LaUnidad";
            this.LaUnidad.Size = new System.Drawing.Size(90, 29);
            this.LaUnidad.TabIndex = 2;
            this.LaUnidad.Text = "Unidad";
            this.LaUnidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // LaCantidad
            // 
            this.LaCantidad.AutoSize = true;
            this.LaCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaCantidad.Location = new System.Drawing.Point(99, 0);
            this.LaCantidad.Name = "LaCantidad";
            this.LaCantidad.Size = new System.Drawing.Size(109, 29);
            this.LaCantidad.TabIndex = 2;
            this.LaCantidad.Text = "Cantidad";
            this.LaCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(20, 335);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(75, 23);
            this.butAgregar.TabIndex = 2;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            // 
            // butBorrar
            // 
            this.butBorrar.Location = new System.Drawing.Point(116, 335);
            this.butBorrar.Name = "butBorrar";
            this.butBorrar.Size = new System.Drawing.Size(75, 23);
            this.butBorrar.TabIndex = 3;
            this.butBorrar.Text = "Borrar";
            this.butBorrar.UseVisualStyleBackColor = true;
            // 
            // butEditar
            // 
            this.butEditar.Location = new System.Drawing.Point(227, 335);
            this.butEditar.Name = "butEditar";
            this.butEditar.Size = new System.Drawing.Size(75, 23);
            this.butEditar.TabIndex = 4;
            this.butEditar.Text = "Editar";
            this.butEditar.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butEditar);
            this.Controls.Add(this.butBorrar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LaClave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LaCantidad;
        private System.Windows.Forms.Label LaUnidad;
        private System.Windows.Forms.Label LaDescripción;
        private System.Windows.Forms.Label LaImporte;
        private System.Windows.Forms.Label LaPrecio;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Button butBorrar;
        private System.Windows.Forms.Button butEditar;
    }
}