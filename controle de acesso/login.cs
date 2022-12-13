using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace controle_de_acesso
{
   
    public partial class frmlogin : Form
    {

        public bool verdade = true;

        SqlConnection conexao = new SqlConnection(@"Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=""ACESS CONTROL"";Integrated Security=True");
        public frmlogin()
        {
            InitializeComponent();
            
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

            txtusuario.Select();
        }

        private void txtlogin_Click(object sender, EventArgs e)
        {

            string senha = txtsenha.Text;
            Cryptography cry = new Cryptography("encryptionKey");
            senha = cry.Encrypt(senha);
            

            conexao.Open();
            SqlCommand cmd = new SqlCommand();

            // cmd.CommandText = @"SELECT * FROM funcionario  WHERE nome_funcionario = @txtusuario AND senha_funcionario =@txtsenha";
            string query = @"SELECT cargo_funcionario FROM funcionario  WHERE nome_funcionario = '" + txtusuario.Text + "' AND senha_funcionario = '" + senha + "'";
            string acesso = @"SELECT cargo_funcionario FROM funcionario  WHERE nome_funcionario = '" + txtusuario.Text + "' AND senha_funcionario = '" + senha + "' AND cargo_funcionario = 'administrador'";

            // cmd.Parameters.AddWithValue("@txtusuario", txtusuario.Text);
            //cmd.Parameters.AddWithValue("@txtsenha", txtsenha.Text);

            SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
            SqlDataAdapter dc = new SqlDataAdapter(acesso, conexao);
            DataTable dt = new DataTable();
            DataTable dd = new DataTable();
            dp.Fill(dt);
            dc.Fill(dd);
            int cargo = dd.Rows.Count;
            MessageBox.Show(cargo.ToString());
            if (cargo > 0)
            {
              Form1 frm = new Form1();

                frm.Verifica(verdade);
                
            }

            
            
            

            

            if (dt.Rows.Count >= 1)

            {


                Form1 principal = new Form1();

                this.Hide();
                principal.Show();


            }

            else
            {
                MessageBox.Show("senha  ou usuario incorreto", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Text = "";
                txtsenha.Text = "";
                txtusuario.Select();

            }
            conexao.Close();
            


            

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string senha = txtsenha.Text;
            Cryptography cry = new Cryptography("encryptionKey");
            senha = cry.Encrypt(senha);




            conexao.Open();
            SqlCommand cmd = new SqlCommand();

            // cmd.CommandText = @"SELECT * FROM funcionario  WHERE nome_funcionario = @txtusuario AND senha_funcionario =@txtsenha";
            string query = @"SELECT cargo_funcionario FROM funcionario  WHERE nome_funcionario = '" + txtusuario.Text + "' AND senha_funcionario = '" + senha + "'AND cargo_funcionario = 'administrador'";
           

            // cmd.Parameters.AddWithValue("@txtusuario", txtusuario.Text);
            //cmd.Parameters.AddWithValue("@txtsenha", txtsenha.Text);

            SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
            
            DataTable dt = new DataTable();
            
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)

            {


                frmcadastrofuncionario principal = new frmcadastrofuncionario();

                this.Hide();
                principal.Show();


            }

            else
            {
                MessageBox.Show("sem permissão para cadastro", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Text = "";
                txtsenha.Text = "";
                txtusuario.Select();

            }
            conexao.Close();


        }
    }
}
