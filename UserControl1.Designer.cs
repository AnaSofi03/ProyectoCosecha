namespace GeneradorQr1
{
    partial class UserControl1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerarQR = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generador de QR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label2.Location = new System.Drawing.Point(106, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label3.Location = new System.Drawing.Point(58, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label4.Location = new System.Drawing.Point(58, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido:";
            // 
            // btnGenerarQR
            // 
            this.btnGenerarQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.btnGenerarQR.Location = new System.Drawing.Point(242, 346);
            this.btnGenerarQR.Name = "btnGenerarQR";
            this.btnGenerarQR.Size = new System.Drawing.Size(220, 63);
            this.btnGenerarQR.TabIndex = 4;
            this.btnGenerarQR.Text = "Generar QR";
            this.btnGenerarQR.UseVisualStyleBackColor = true;
            this.btnGenerarQR.Click += new System.EventHandler(this.btnGenerarQR_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtDNI.Location = new System.Drawing.Point(211, 112);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(289, 34);
            this.txtDNI.TabIndex = 5;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.textNombre.Location = new System.Drawing.Point(201, 196);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(299, 34);
            this.textNombre.TabIndex = 6;
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.textApellido.Location = new System.Drawing.Point(201, 271);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(299, 34);
            this.textApellido.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(189, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 203);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnGenerarQR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(667, 667);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerarQR;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
