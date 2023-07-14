namespace test_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e) {

            var form2 = new Form2();

            if (txtLogin.Text == "") {

                lblMsg1.ForeColor = Color.Red;
                lblMsg1.Text = "O login é necessário!";
                lblMsg1.Visible = true;

            } else if (txtSenha.Text == "") {

                lblMsg2.ForeColor = Color.Red;
                lblMsg2.Text = "A senha é necessária!";
                lblMsg2.Visible = true;

            } else {

                form2.Show();

                lblMsg1.Hide();
                lblMsg2.Hide();

            }

        }
    }
}