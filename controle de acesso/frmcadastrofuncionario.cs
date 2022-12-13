using controle_de_acesso.ACESS_CONTROLDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_acesso
{
   
    public partial class frmcadastrofuncionario : Form


    {
        SqlConnection conexao = new SqlConnection(@"Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=""ACESS CONTROL"";Integrated Security=True");

        public frmcadastrofuncionario()
        {
            InitializeComponent();
            groupBox1.Enabled = true;
            nome_funcionarioTextBox.Text = "";
            rg_funcionarioTextBox.Text = "";
            cpf_funcionarioMaskedTextBox.Text = "";
            senha_funcionarioTextBox.Text = "";
            groupBox1.Enabled = false;

        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bool validar = false;
            string cpf = cpf_funcionarioMaskedTextBox.Text;

            validar = ValidaCPF.IsCpf(cpf);
            MessageBox.Show(cpf.ToString());

            if (validar)
            {

                try
                {
                    string senha = senha_funcionarioTextBox.Text;
                    Cryptography cry = new Cryptography("encryptionKey");
                    senha = cry.Encrypt(senha);
                    senha_funcionarioTextBox.Text = senha;

                    




                    this.Validate();
                    this.funcionarioBindingSource.EndEdit();
                    this.funcionarioTableAdapter.Update(this.aCESS_CONTROLDataSet.funcionario);
                    groupBox1.Enabled = false;
                    MessageBox.Show("registro salvo");
                }
                catch (Exception erro)
                {

                    MessageBox.Show("falha ao salvar" + erro.Message);
                }

            }
            else
            {
                MessageBox.Show("seu cpf não e valido", "cpf invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmcadastrofuncionario_Load(object sender, EventArgs e)
        {
            
            this.funcionarioTableAdapter.Fill(this.aCESS_CONTROLDataSet.funcionario);

        }

        private void funcionarioBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.CancelEdit();
            groupBox1.Enabled=false;    
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
          

            try
            {
                funcionarioBindingSource.AddNew();
                groupBox1.Enabled = true;
                
            }
            catch (Exception)
            {

                MessageBox.Show("preencha corretamente o formulario");
            }


            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            try
            {
                
                groupBox1.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("não foi possivel limpar a lista");
            }
            
           
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("tem certeza que deja deletar","controle de acesso", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    funcionarioBindingSource.RemoveCurrent();
                    funcionarioTableAdapter.Update(aCESS_CONTROLDataSet.funcionario);
                }

            }
            catch (Exception)
            {

                funcionarioTableAdapter.Fill(aCESS_CONTROLDataSet.funcionario);
                MessageBox.Show("registro não pode ser excluido");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btnfoto_Click(object sender, EventArgs e)
        {
            
        }

        private void foto_funcionarioPictureBox_Click(object sender, EventArgs e)
        {
           
        }

        private void Btnfoto_Click(object sender, EventArgs e, OpenFileDialog openFileDialog1)
        {
          //  try
            //{
              //  openFileDialog1.Filter = "Fotos (.jpg;.png;) | *.jpg; *.png";

                //if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    foto_funcionarioPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                //}
            //}
            //catch (Exception)
            //{

              //  MessageBox.Show(" Erro ao carregar o arquivo de imagem ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
