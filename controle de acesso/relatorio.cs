using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_acesso
{
    public partial class relatorio : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=""ACESS CONTROL"";Integrated Security=True");
        
        public relatorio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")

            {
                try
                {
                    conexao.Open();
                    string query = @"SELECT * FROM visitante  WHERE cpf_visitante LIKE ('" + textBox1.Text + "%'  )";
                    SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
                    DataTable da = new DataTable();
                    dp.Fill(da);
                    dataGridView1.DataSource = da;
                    conexao.Close();

                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                }




            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
    }
}
