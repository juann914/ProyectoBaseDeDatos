namespace Databasesproyect.Vistas
{
    partial class ReporteMes
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaFinal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvVentasMensuales = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMensuales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce el rango de las fechas del mes\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "De:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(105, 85);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(115, 20);
            this.txtFechaInicio.TabIndex = 2;
            this.txtFechaInicio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "A";
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.Location = new System.Drawing.Point(246, 85);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(119, 20);
            this.txtFechaFinal.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvVentasMensuales
            // 
            this.dgvVentasMensuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasMensuales.Location = new System.Drawing.Point(60, 147);
            this.dgvVentasMensuales.Name = "dgvVentasMensuales";
            this.dgvVentasMensuales.Size = new System.Drawing.Size(673, 234);
            this.dgvVentasMensuales.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReporteMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvVentasMensuales);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFechaFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReporteMes";
            this.Text = "ReporteMes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMensuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaFinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvVentasMensuales;
        private System.Windows.Forms.Button button2;
    }
}