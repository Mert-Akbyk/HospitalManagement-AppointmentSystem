namespace HospitalManagement_AppointmentSystem
{
    public partial class FrmLogins : Form
    {
        public FrmLogins()
        {
            InitializeComponent();
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            FrmPatientLogin frmPatientLogin = new FrmPatientLogin();
            frmPatientLogin.Show();
            this.Hide();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin frmDoctorLogin = new FrmDoctorLogin();
            frmDoctorLogin.Show();
            this.Hide();
        }

        private void BtnSecretary_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin frmSecretaryLogin = new FrmSecretaryLogin();
            frmSecretaryLogin.Show();
            this.Hide();
        }
    }
}
