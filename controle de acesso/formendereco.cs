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
    public partial class formendereco : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=""ACESS CONTROL"";Integrated Security=True");
        public formendereco()
        {
            InitializeComponent();
        }

        private void enderecoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.enderecoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aCESS_CONTROLDataSet);

        }

        private void formendereco_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aCESS_CONTROLDataSet.visitante'. Você pode movê-la ou removê-la conforme necessário.
            this.visitanteTableAdapter.Fill(this.aCESS_CONTROLDataSet.visitante);
            // TODO: esta linha de código carrega dados na tabela 'aCESS_CONTROLDataSet.endereco'. Você pode movê-la ou removê-la conforme necessário.
            
            lbldata.Text = DateTime.Now.ToString("D");

        }

        private void id_visitanteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }


        private void ag_totalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_visitanteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_visitanteLabel1_Click(object sender, EventArgs e)
        {

        }

        private void id_enderecoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ent_dataDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
            
        }

        private void ent_horarioDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ent_horarioTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ent_horarioLabel2_Click(object sender, EventArgs e)
        {

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ent_horarioLabel2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {

           
            
            conexao.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;

            // cmd.CommandText = @"SELECT * FROM funcionario  WHERE nome_funcionario = @txtusuario AND senha_funcionario =@txtsenha";
            string query = @"SELECT *  FROM visitante  WHERE cpf_visitante = '" + maskedTextBox1.Text + "' ";
            cmd.Connection = conexao;
            cmd.CommandText = query;
            dt = cmd.ExecuteReader();

            // cmd.Parameters.AddWithValue("@txtusuario", txtusuario.Text);
            //cmd.Parameters.AddWithValue("@txtsenha", txtsenha.Text);



            
            
            
            if (!dt.HasRows)

            {
                MessageBox.Show("cpf não cadastrado ", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                maskedTextBox1.Select();

            }

            else
            {
                groupBox1.Enabled = true;
                dt.Read();
               // pictureBox2.Image = dt["foto_visitante"]
               lblcpf.Text = dt["cpf_visitante"].ToString();
                lblvisitante.Text = dt["nome_visitante"].ToString();
                id_visitanteLabel2.Text = dt["codigo_visitante"].ToString();

                
            }
            conexao.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            try
            {
                string horario = DateTime.Now.ToString("HH:mm:ss");
                string data = DateTime.Now.ToString("dd/MM/yyyy") ;
                MessageBox.Show(horario);
                MessageBox.Show(data);
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                

                // cmd.CommandText = @"SELECT * FROM funcionario  WHERE nome_funcionario = @txtusuario AND senha_funcionario =@txtsenha";
                string query = @"INSERT INTO endereco (ent_data ,ent_horario ,ag_total ,id_visitante) VALUES ('"+ data +"','"+horario+ "','"+ag_totalComboBox.Text+"', '"+ id_visitanteLabel2.Text+ "') ";
                cmd.Connection = conexao;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();


                // enderecoBindingSource.AddNew();
                //lbldata.Text = DateTime.Now.ToString("D");
                //this.Validate();
                //this.enderecoBindingSource.EndEdit();
                //this.enderecoTableAdapter.Update(this.aCESS_CONTROLDataSet.endereco);
                //groupBox1.Enabled = false;
                MessageBox.Show("registro salvo");
                groupBox1.Enabled = false;
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("falha ao salvar" + erro.Message);
            }

            lbldata.Text = DateTime.Now.ToString("D");

            
        }
    }
}
