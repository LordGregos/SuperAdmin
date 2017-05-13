namespace SuperAdmin
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
            this.correo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.contrasena = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(140, 159);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.correo.Location = new System.Drawing.Point(12, 61);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(57, 20);
            this.correo.TabIndex = 1;
            this.correo.Text = "Correo";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nombre.Location = new System.Drawing.Point(12, 9);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(65, 20);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Nombre";
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contrasena.Location = new System.Drawing.Point(12, 35);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(92, 20);
            this.contrasena.TabIndex = 3;
            this.contrasena.Text = "Contraseña";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(111, 9);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(210, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(111, 35);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.Size = new System.Drawing.Size(210, 20);
            this.tbContrasena.TabIndex = 5;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(111, 61);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(210, 20);
            this.tbCorreo.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ciudad";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(158, 113);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(48, 20);
            this.tbX.TabIndex = 9;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(273, 113);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(48, 20);
            this.tbY.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cordenadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(136, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(251, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Y";
            // 
            // SuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 193);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.agregar);
            this.Name = "SuperAdmin";
            this.Text = "Administrador Central";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

