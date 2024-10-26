namespace S10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrarEstudiantes = new Button();
            lstEstudiantes = new ListBox();
            lstAsignaturas = new ListBox();
            btnMostrarAsignaturas = new Button();
            SuspendLayout();
            // 
            // btnMostrarEstudiantes
            // 
            btnMostrarEstudiantes.Location = new Point(50, 50);
            btnMostrarEstudiantes.Name = "btnMostrarEstudiantes";
            btnMostrarEstudiantes.Size = new Size(187, 45);
            btnMostrarEstudiantes.TabIndex = 0;
            btnMostrarEstudiantes.Text = "Mostrar Estudiantes";
            btnMostrarEstudiantes.UseVisualStyleBackColor = true;
            btnMostrarEstudiantes.Click += btnMostrarEstudiantes_Click;
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.Location = new Point(315, 50);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new Size(637, 164);
            lstEstudiantes.TabIndex = 1;
            // 
            // lstAsignaturas
            // 
            lstAsignaturas.FormattingEnabled = true;
            lstAsignaturas.Location = new Point(315, 241);
            lstAsignaturas.Name = "lstAsignaturas";
            lstAsignaturas.Size = new Size(637, 164);
            lstAsignaturas.TabIndex = 3;
            // 
            // btnMostrarAsignaturas
            // 
            btnMostrarAsignaturas.Location = new Point(50, 241);
            btnMostrarAsignaturas.Name = "btnMostrarAsignaturas";
            btnMostrarAsignaturas.Size = new Size(187, 45);
            btnMostrarAsignaturas.TabIndex = 2;
            btnMostrarAsignaturas.Text = "Mostrar Asignaturas";
            btnMostrarAsignaturas.UseVisualStyleBackColor = true;
            btnMostrarAsignaturas.Click += btnMostrarAsignaturas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 450);
            Controls.Add(lstAsignaturas);
            Controls.Add(btnMostrarAsignaturas);
            Controls.Add(lstEstudiantes);
            Controls.Add(btnMostrarEstudiantes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrarEstudiantes;
        private ListBox lstEstudiantes;
        private ListBox lstAsignaturas;
        private Button btnMostrarAsignaturas;
    }
}
