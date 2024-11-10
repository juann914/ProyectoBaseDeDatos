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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Total Venta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(448, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(579, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 126);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "%Desc.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "SubTotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 11;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butEditar);
            this.Controls.Add(this.butBorrar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}