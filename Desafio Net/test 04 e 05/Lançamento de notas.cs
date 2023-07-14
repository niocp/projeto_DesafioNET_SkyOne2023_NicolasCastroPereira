using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test_04
{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            double nota1, nota2, media;

            nota1 = Convert.ToInt32(string.IsNullOrEmpty(txtNota1.Text) ? null : txtNota1.Text);
            nota2 = Convert.ToInt32(string.IsNullOrEmpty(txtNota2.Text) ? null : txtNota2.Text);
            media = (nota1 + nota2) / 2;

            if (txtNome.Text == "")

            {
                lblMsgNome.ForeColor = Color.Red;
                lblMsgNome.Text = "O preenchimento do nome é obrigatório!";
                lblMsgNome.Visible = true;

            }
            else if (txtNota1.Text == "")
            {

                lblMsgNota1.ForeColor = Color.Red;
                lblMsgNota1.Text = "A nota é obrigatória!";
                lblMsgNota1.Visible = true;

            }
            else if (txtNota2.Text == "")
            {

                lblMsgNota2.ForeColor = Color.Red;
                lblMsgNota2.Text = "A nota é obrigatória!";
                lblMsgNota2.Visible = true;

            }

            else if (media < 6.5)
            {

                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Reprovado";
                lblResultado.Visible = true;

                lblMsgNome.Hide();
                lblMsgNota1.Hide();
                lblMsgNota2.Hide();


                SqlConnection con = new SqlConnection("Data Source=PC1\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into DADOSWF(nome, notasemestre1, notasemestre2) values('" + txtNome.Text + "','" + txtNota1.Text + "','" + txtNota2.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados salvos");
                con.Close();


            }
            else if (media >= 6.5)
            {

                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = "Aprovado";
                lblResultado.Visible = true;

                lblMsgNome.Hide();
                lblMsgNota1.Hide();
                lblMsgNota2.Hide();


                SqlConnection con = new SqlConnection("Data Source=PC1\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into DADOSWF(nome, notasemestre1, notasemestre2) values('" + txtNome.Text + "','" + txtNota1.Text + "','" + txtNota2.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados salvos");
                con.Close();


            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();

            lblMsgNome.Hide();
            lblMsgNota1.Hide();
            lblMsgNota2.Hide();
            lblResultado.ForeColor = Color.SlateGray;
            lblResultado.Text = "Nota ainda não enviada.";

        }

    }
}
