using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_acesso
{
    public partial class Form1 : Form
    {

        public bool Cargo = false;
        frmlogin ff = new frmlogin();


        public Form1()
        {
            InitializeComponent();
        }




        public void Verifica(bool valor)
        {

            Cargo = valor;
        }



        private void button3_Click(object sender, EventArgs e)
        {
           relatorio cadastrar =  new relatorio();
            cadastrar.TopLevel = false;
            cadastrar.Dock = DockStyle.Fill;
            panelcentral.Controls.Clear();
            panelcentral.Controls.Add(cadastrar);
            cadastrar.Show();

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncadastro_Click(object sender, EventArgs e)

        {

               inicio cadastrar = new inicio();
                cadastrar.TopLevel = false;
                cadastrar.Dock = DockStyle.Fill;
                panelcentral.Controls.Clear();
                panelcentral.Controls.Add(cadastrar);
                cadastrar.Show();
    
                
            


        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            frmvisitante pesquisa = new frmvisitante();
            pesquisa.TopLevel = false;
            pesquisa.Dock = DockStyle.Fill;
            panelcentral.Controls.Clear();
            panelcentral.Controls.Add(pesquisa);
            pesquisa.Show();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            formendereco cadastrar = new formendereco();
            cadastrar.TopLevel = false;
            cadastrar.Dock = DockStyle.Fill;
            panelcentral.Controls.Clear();
            panelcentral.Controls.Add(cadastrar);
            cadastrar.Show();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
