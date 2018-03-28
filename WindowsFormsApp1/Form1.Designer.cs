namespace WindowsFormsApp1
{
    partial class Form1
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
            this.labelnombre = new System.Windows.Forms.Label();
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.labelNota = new System.Windows.Forms.Label();
            this.aluNota = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelLista = new System.Windows.Forms.Label();
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(38, 33);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(81, 13);
            this.labelnombre.TabIndex = 0;
            this.labelnombre.Text = "Nombre alumno";
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(36, 58);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(292, 20);
            this.aluNombre.TabIndex = 1;
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(358, 33);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(30, 13);
            this.labelNota.TabIndex = 2;
            this.labelNota.Text = "Nota";
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(361, 58);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(106, 20);
            this.aluNota.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar alumno";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Location = new System.Drawing.Point(40, 97);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(86, 13);
            this.labelLista.TabIndex = 5;
            this.labelLista.Text = "Lista de alumnos";
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(43, 121);
            this.listaAlumnos.Multiline = true;
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(613, 270);
            this.listaAlumnos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 412);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.aluNombre);
            this.Controls.Add(this.labelnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.TextBox aluNombre;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.TextBox aluNota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.TextBox listaAlumnos;
    }
}

