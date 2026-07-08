namespace RegistroEstudiantesMEspana
{
    public partial class frmRegistroEstudiantes : Form
    {
        public frmRegistroEstudiantes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtCedula.Text = "";
            this.txtNombres.Text = "";
            this.txtApellidos.Text = "";
            this.dtpFechaNacimiento.Value = DateTime.Now;
            this.cmbCarrera.SelectedIndex = -1;
            this.cmbJornada.SelectedIndex = -1;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validaRegistro())
            {
                MessageBox.Show($"Estudiante {txtNombres.Text} Ingresado Correctamente!");
                btnLimpiar_Click(sender, e);
            }
        }

        private Boolean validaRegistro()
        {
            if (txtCedula.Text.Length < 10) 
            {
                MessageBox.Show("Ingrese una cédula válida");
                txtCedula.Focus();
                return false;
            }

            if (txtNombres.Text.Length == 0)
            {
                MessageBox.Show("Ingrese un nombre válido");
                txtCedula.Focus();
                return false;
            }

            if (txtApellidos.Text.Length == 0)
            {
                MessageBox.Show("Ingrese un apellido válida");
                txtCedula.Focus();
                return false;
            }




            return true;
        }
    }
}
