namespace WinFormsApp1
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
            this.listaSocios = new System.Windows.Forms.ListBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.labNombre = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.labTelefono = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.labLista = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listaSocios
            // 
            this.listaSocios.BackColor = System.Drawing.SystemColors.Menu;
            this.listaSocios.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listaSocios.FormattingEnabled = true;
            this.listaSocios.ItemHeight = 20;
            this.listaSocios.Location = new System.Drawing.Point(31, 110);
            this.listaSocios.Name = "listaSocios";
            this.listaSocios.Size = new System.Drawing.Size(873, 444);
            this.listaSocios.Sorted = true;
            this.listaSocios.TabIndex = 5;
            this.listaSocios.Tag = "";
            this.listaSocios.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(810, 75);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(94, 29);
            this.botonGuardar.TabIndex = 6;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(31, 20);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(64, 20);
            this.labNombre.TabIndex = 7;
            this.labNombre.Text = "Nombre";
            this.labNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Location = new System.Drawing.Point(311, 20);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(72, 20);
            this.labApellido.TabIndex = 9;
            this.labApellido.Text = "Apellidos";
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Location = new System.Drawing.Point(646, 20);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(67, 20);
            this.labTelefono.TabIndex = 11;
            this.labTelefono.Text = "Teléfono";
            this.labTelefono.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTelefono.Location = new System.Drawing.Point(719, 17);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(185, 28);
            this.tbTelefono.TabIndex = 10;
            // 
            // labLista
            // 
            this.labLista.AutoSize = true;
            this.labLista.Location = new System.Drawing.Point(31, 87);
            this.labLista.Name = "labLista";
            this.labLista.Size = new System.Drawing.Size(86, 20);
            this.labLista.TabIndex = 12;
            this.labLista.Text = "Lista Socios";
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbApellido.Location = new System.Drawing.Point(389, 17);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(233, 28);
            this.tbApellido.TabIndex = 13;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNombre.Location = new System.Drawing.Point(101, 17);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(185, 28);
            this.tbNombre.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 592);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.labLista);
            this.Controls.Add(this.labTelefono);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.listaSocios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listaSocios;
        private Button botonGuardar;
        private Label labNombre;
        private Label labApellido;
        private Label labTelefono;
        private TextBox tbTelefono;
        private Label labLista;
        private TextBox tbApellido;
        private TextBox tbNombre;
    }
}