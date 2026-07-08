namespace RegistroEstudiantesMEspana
{
    partial class frmRegistroEstudiantes
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
            txtCedula = new TextBox();
            Cedula = new Label();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            lblCarrera = new Label();
            cmbCarrera = new ComboBox();
            cmbJornada = new ComboBox();
            lblJornada = new Label();
            btnGrabar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtCedula
            // 
            txtCedula.BackColor = SystemColors.MenuHighlight;
            txtCedula.ForeColor = SystemColors.Window;
            txtCedula.Location = new Point(169, 61);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(132, 23);
            txtCedula.TabIndex = 0;
            // 
            // Cedula
            // 
            Cedula.AutoSize = true;
            Cedula.Location = new Point(119, 69);
            Cedula.Name = "Cedula";
            Cedula.Size = new Size(44, 15);
            Cedula.TabIndex = 4;
            Cedula.Text = "Cedula";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(107, 104);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(58, 15);
            lblNombres.TabIndex = 6;
            lblNombres.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.BackColor = SystemColors.MenuHighlight;
            txtNombres.ForeColor = SystemColors.Window;
            txtNombres.Location = new Point(169, 96);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(291, 23);
            txtNombres.TabIndex = 5;
            txtNombres.TextChanged += textBox1_TextChanged;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(107, 141);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(57, 15);
            lblApellidos.TabIndex = 8;
            lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = SystemColors.MenuHighlight;
            txtApellidos.ForeColor = SystemColors.Window;
            txtApellidos.Location = new Point(169, 133);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(291, 23);
            txtApellidos.TabIndex = 7;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(169, 174);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(262, 23);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(60, 180);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(106, 15);
            lblFechaNacimiento.TabIndex = 10;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(118, 219);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(48, 15);
            lblCarrera.TabIndex = 12;
            lblCarrera.Text = "Carrera";
            // 
            // cmbCarrera
            // 
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "Tecnologia Superior en Accion Pastoral", "Tecnologia Superior en Asistencia Pedagógica", "Tecnologia Superior en Administración", "Tecnologia Superior en Desarrollo de  Software" });
            cmbCarrera.Location = new Point(171, 214);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(260, 23);
            cmbCarrera.TabIndex = 13;
            // 
            // cmbJornada
            // 
            cmbJornada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJornada.FormattingEnabled = true;
            cmbJornada.Items.AddRange(new object[] { "Vespertina", "Nocturna" });
            cmbJornada.Location = new Point(171, 243);
            cmbJornada.Name = "cmbJornada";
            cmbJornada.Size = new Size(260, 23);
            cmbJornada.TabIndex = 15;
            // 
            // lblJornada
            // 
            lblJornada.AutoSize = true;
            lblJornada.Location = new Point(118, 248);
            lblJornada.Name = "lblJornada";
            lblJornada.Size = new Size(50, 15);
            lblJornada.TabIndex = 14;
            lblJornada.Text = "Jornada";
            // 
            // btnGrabar
            // 
            btnGrabar.ForeColor = Color.Green;
            btnGrabar.Location = new Point(171, 309);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 16;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.Goldenrod;
            btnLimpiar.Location = new Point(278, 309);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.ForeColor = Color.FromArgb(192, 0, 0);
            btnSalir.Location = new Point(385, 309);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmRegistroEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGrabar);
            Controls.Add(cmbJornada);
            Controls.Add(lblJornada);
            Controls.Add(cmbCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblApellidos);
            Controls.Add(txtApellidos);
            Controls.Add(lblNombres);
            Controls.Add(txtNombres);
            Controls.Add(Cedula);
            Controls.Add(txtCedula);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRegistroEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registo Estudiantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCedula;
        private Label Cedula;
        private Label lblNombres;
        private TextBox txtNombres;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFechaNacimiento;
        private Label lblCarrera;
        private ComboBox cmbCarrera;
        private ComboBox cmbJornada;
        private Label lblJornada;
        private Button btnGrabar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
