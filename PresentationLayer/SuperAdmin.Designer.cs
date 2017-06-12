namespace PresentationLayer
{
    partial class SuperAdmin
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(122, 103);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(117, 12);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(187, 20);
            this.nombre.TabIndex = 6;
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(117, 38);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(187, 20);
            this.correo.TabIndex = 7;
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(117, 64);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(187, 20);
            this.contrasena.TabIndex = 8;
            // 
            // SuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 143);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agregar);
            this.Name = "SuperAdmin";
            this.Text = "SuperAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox contrasena;
    }
}

