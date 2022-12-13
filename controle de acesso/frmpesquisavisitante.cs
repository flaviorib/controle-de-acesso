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
    public partial class frmpesquisavisitante : Form
    {
        public frmpesquisavisitante()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection(@"Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=""ACESS CONTROL"";Integrated Security=True");

        private void frmpesquisavisitante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'relatoriovisitante1.visitante'. Você pode movê-la ou removê-la conforme necessário.
            this.visitanteTableAdapter.Fill(this.relatoriovisitante1.visitante);
            // TODO: esta linha de código carrega dados na tabela 'relatoriovisitante.visitante'. Você pode movê-la ou removê-la conforme necessário.
           
            // TODO: esta linha de código carrega dados na tabela 'relatoriovisitante.visitante'. Você pode movê-la ou removê-la conforme necessário.
            //this.visitanteTableAdapter.Fill(this.relatoriovisitante.visitante);
            // TODO: esta linha de código carrega dados na tabela 'dataSetvisitante.DataTable1'. Você pode movê-la ou removê-la conforme necessário.


            // conexao.Open();
            // SqlCommand cmd = new SqlCommand();

            // cmd.CommandText = @"SELECT * FROM funcionario  WHERE nome_funcionario = @txtusuario AND senha_funcionario =@txtsenha";
            // string query = @"S ";


            // cmd.Parameters.AddWithValue("@txtusuario", txtusuario.Text);
            //cmd.Parameters.AddWithValue("@txtsenha", txtsenha.Text);

            // SqlDataAdapter dp = new SqlDataAdapter(query, conexao);

            // DataTable dt = new DataTable();





            // TODO: esta linha de código carrega dados na tabela 'dataSetvisitante.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            //this.dataTable1TableAdapter.Fill(this.dataSetvisitante.DataTable1);
            // TODO: esta linha de código carrega dados na tabela 'dataSetvisitante.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            //this.dataTable1TableAdapter.Fill(this.dataSetvisitante.DataTable1);
            // TODO: esta linha de código carrega dados na tabela 'dataSetvisitante.DataTable1'. Você pode movê-la ou removê-la conforme necessário.

            // TODO: esta linha de código carrega dados na tabela 'dataSetvisitante.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            //this.dataTable1TableAdapter.Fill(this.dataSetvisitante.DataTable1);


            this.reportViewer1.RefreshReport();
            frmvisitante visitante = new  frmvisitante();
            visitante.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
