using AForge.Video;
using AForge.Video.DirectShow;
using controle_de_acesso.ACESS_CONTROLDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace controle_de_acesso
{
    public partial class frmvisitante : Form
    {
        FilterInfoCollection _filterInfoCollection;
        VideoCaptureDevice _videoCaptureDevice;

        public frmvisitante()
        {
            InitializeComponent();
            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterinfo in _filterInfoCollection )
            cbseletor.Items.Add(filterinfo.Name);

            cbseletor.SelectedIndex = 0;

            _videoCaptureDevice = new VideoCaptureDevice();
            

        }

        private void visitanteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try

            {
                bool validar = false;
                string cpf = cpf_visitanteMaskedTextBox.Text;

                validar = ValidaCPF.IsCpf(cpf);
                MessageBox.Show(cpf.ToString());
                if (validar)
                {
                    this.Validate();
                    this.visitanteBindingSource1.EndEdit();
                    this.visitanteTableAdapter1.Update(this.aCESS_CONTROLDataSet1.visitante);
                    groupBox1.Enabled = false;
                    MessageBox.Show("registro salvo");
                }
                else
                {
                    MessageBox.Show("cpf invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception erro)
            {

                MessageBox.Show("falha ao salvar" + erro.Message);
            }

        }

        private void frmeditar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aCESS_CONTROLDataSet1.visitante'. Você pode movê-la ou removê-la conforme necessário.
            this.visitanteTableAdapter1.Fill(this.aCESS_CONTROLDataSet1.visitante);
            
       
            // TODO: esta linha de código carrega dados na tabela 'aCESS_CONTROLDataSet.visitante'. Você pode movê-la ou removê-la conforme necessário.


        }

        private void button2_Click(object sender, EventArgs e)
        {
            formendereco endereco = new formendereco();
            endereco.ShowDialog();
        }

        private void visitanteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cpf_visitanteMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            visitanteBindingSource1.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                visitanteBindingSource1.AddNew();
                groupBox1.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("preencha corretamente o formulario");
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("tem certeza que deja deletar", "controle de acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    visitanteBindingSource1.RemoveCurrent();
                    visitanteTableAdapter1.Update(aCESS_CONTROLDataSet1.visitante);
                }

            }
            catch (Exception)
            {

                visitanteTableAdapter.Fill(aCESS_CONTROLDataSet.visitante);
                MessageBox.Show("registro não pode ser excluido");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void foto_visitantePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void codigo_visitanteLabel_Click(object sender, EventArgs e)
        {

        }

        private void nome_visitanteLabel_Click(object sender, EventArgs e)
        {

        }

        private void nome_visitanteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rg_visitanteLabel_Click(object sender, EventArgs e)
        {

        }

        private void rg_visitanteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpf_visitanteLabel_Click(object sender, EventArgs e)
        {

        }

        private void cpf_visitanteMaskedTextBox_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void foto_visitanteLabel_Click(object sender, EventArgs e)
        {

        }

        private void codigo_visitanteLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmpesquisavisitante rel = new frmpesquisavisitante();  
            rel.ShowDialog();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cbseletor.SelectedIndex].MonikerString);

            _videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            _videoCaptureDevice.Start();


        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {

            foto_visitantePictureBox.Image = (Bitmap)e.Frame.Clone();

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetImage(foto_visitantePictureBox.Image);
            _videoCaptureDevice?.Stop();
            foto_visitantePictureBox.Image = Clipboard.GetImage();
            Clipboard.Clear();
        }
    }
}
