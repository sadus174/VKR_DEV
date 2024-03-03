namespace VKR_DEV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();

            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();

            if (!AuthClass.IsAuthenticated)
            {
                Application.Exit();
            }

            toolStripStatusLabel1.Text = $"Добро пожаловать {AuthClass.auth_fio}! Ваш код {AuthClass.auth_id.ToString()}";

            switch (AuthClass.auth_role)
            {
                case 3:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    break;
                case 2:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    break;
                case 1:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Ваша роль в системе не определена. Приложение будет закрыто!");
                    Application.Exit();
                    break;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Component_UserMgmt component_UserMgmt = new Component_UserMgmt();
            component_UserMgmt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Component_EmplMgmt component_EmplMgmt = new Component_EmplMgmt();
            component_EmplMgmt.ShowDialog();
        }
    }
}
