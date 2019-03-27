namespace DesktopDICOM
{
    partial class Form1
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
            this.CargarMensaje = new System.Windows.Forms.Button();
            this.BuscarPaciente = new System.Windows.Forms.Button();
            this.AgendarSolictud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CargarMensaje
            // 
            this.CargarMensaje.Location = new System.Drawing.Point(139, 42);
            this.CargarMensaje.Margin = new System.Windows.Forms.Padding(2);
            this.CargarMensaje.Name = "CargarMensaje";
            this.CargarMensaje.Size = new System.Drawing.Size(144, 35);
            this.CargarMensaje.TabIndex = 0;
            this.CargarMensaje.Text = "Cargar Mensaje";
            this.CargarMensaje.UseVisualStyleBackColor = true;
            this.CargarMensaje.Click += new System.EventHandler(this.CargarMensaje_Click);
            // 
            // BuscarPaciente
            // 
            this.BuscarPaciente.Location = new System.Drawing.Point(139, 137);
            this.BuscarPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarPaciente.Name = "BuscarPaciente";
            this.BuscarPaciente.Size = new System.Drawing.Size(143, 37);
            this.BuscarPaciente.TabIndex = 2;
            this.BuscarPaciente.Text = "Buscar Paciente";
            this.BuscarPaciente.UseVisualStyleBackColor = true;
            this.BuscarPaciente.Click += new System.EventHandler(this.BuscarPaciente_Click);
            // 
            // AgendarSolictud
            // 
            this.AgendarSolictud.Location = new System.Drawing.Point(138, 90);
            this.AgendarSolictud.Margin = new System.Windows.Forms.Padding(2);
            this.AgendarSolictud.Name = "AgendarSolictud";
            this.AgendarSolictud.Size = new System.Drawing.Size(144, 35);
            this.AgendarSolictud.TabIndex = 1;
            this.AgendarSolictud.Text = "Admitir Paciente";
            this.AgendarSolictud.UseVisualStyleBackColor = true;
            this.AgendarSolictud.Click += new System.EventHandler(this.AgendarSolictud_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.BuscarPaciente);
            this.Controls.Add(this.AgendarSolictud);
            this.Controls.Add(this.CargarMensaje);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "APP DICOM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CargarMensaje;
        private System.Windows.Forms.Button BuscarPaciente;
        private System.Windows.Forms.Button AgendarSolictud;
    }
}

