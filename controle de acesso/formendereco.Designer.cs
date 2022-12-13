namespace controle_de_acesso
{
    partial class formendereco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_enderecoLabel;
            System.Windows.Forms.Label ent_dataLabel;
            System.Windows.Forms.Label id_visitanteLabel1;
            System.Windows.Forms.Label ent_horarioLabel1;
            System.Windows.Forms.Label ag_totalLabel;
            this.aCESS_CONTROLDataSet = new controle_de_acesso.ACESS_CONTROLDataSet();
            this.enderecoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoTableAdapter = new controle_de_acesso.ACESS_CONTROLDataSetTableAdapters.enderecoTableAdapter();
            this.tableAdapterManager = new controle_de_acesso.ACESS_CONTROLDataSetTableAdapters.TableAdapterManager();
            this.id_enderecoLabel1 = new System.Windows.Forms.Label();
            this.visitanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitanteTableAdapter = new controle_de_acesso.ACESS_CONTROLDataSetTableAdapters.visitanteTableAdapter();
            this.aCESSCONTROLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ag_totalComboBox = new System.Windows.Forms.ComboBox();
            this.lbldata = new System.Windows.Forms.Label();
            this.ent_horarioLabel2 = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblvisitante = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.id_visitanteLabel2 = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_enderecoLabel = new System.Windows.Forms.Label();
            ent_dataLabel = new System.Windows.Forms.Label();
            id_visitanteLabel1 = new System.Windows.Forms.Label();
            ent_horarioLabel1 = new System.Windows.Forms.Label();
            ag_totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aCESS_CONTROLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSCONTROLDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_enderecoLabel
            // 
            id_enderecoLabel.AutoSize = true;
            id_enderecoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_enderecoLabel.Location = new System.Drawing.Point(-3, 27);
            id_enderecoLabel.Name = "id_enderecoLabel";
            id_enderecoLabel.Size = new System.Drawing.Size(91, 16);
            id_enderecoLabel.TabIndex = 1;
            id_enderecoLabel.Text = " Id Endereco:";
            // 
            // ent_dataLabel
            // 
            ent_dataLabel.AutoSize = true;
            ent_dataLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ent_dataLabel.Location = new System.Drawing.Point(6, 74);
            ent_dataLabel.Name = "ent_dataLabel";
            ent_dataLabel.Size = new System.Drawing.Size(63, 16);
            ent_dataLabel.TabIndex = 3;
            ent_dataLabel.Text = "ent data:";
            // 
            // id_visitanteLabel1
            // 
            id_visitanteLabel1.AutoSize = true;
            id_visitanteLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_visitanteLabel1.Location = new System.Drawing.Point(6, 154);
            id_visitanteLabel1.Name = "id_visitanteLabel1";
            id_visitanteLabel1.Size = new System.Drawing.Size(80, 16);
            id_visitanteLabel1.TabIndex = 10;
            id_visitanteLabel1.Text = "id visitante:";
            // 
            // ent_horarioLabel1
            // 
            ent_horarioLabel1.AutoSize = true;
            ent_horarioLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ent_horarioLabel1.Location = new System.Drawing.Point(6, 116);
            ent_horarioLabel1.Name = "ent_horarioLabel1";
            ent_horarioLabel1.Size = new System.Drawing.Size(81, 16);
            ent_horarioLabel1.TabIndex = 14;
            ent_horarioLabel1.Text = "ent horario:";
            // 
            // ag_totalLabel
            // 
            ag_totalLabel.AutoSize = true;
            ag_totalLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ag_totalLabel.Location = new System.Drawing.Point(145, 27);
            ag_totalLabel.Name = "ag_totalLabel";
            ag_totalLabel.Size = new System.Drawing.Size(71, 16);
            ag_totalLabel.TabIndex = 17;
            ag_totalLabel.Text = "Endereço:";
            // 
            // aCESS_CONTROLDataSet
            // 
            this.aCESS_CONTROLDataSet.DataSetName = "ACESS_CONTROLDataSet";
            this.aCESS_CONTROLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enderecoBindingSource
            // 
            this.enderecoBindingSource.DataMember = "endereco";
            this.enderecoBindingSource.DataSource = this.aCESS_CONTROLDataSet;
            // 
            // enderecoTableAdapter
            // 
            this.enderecoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.enderecoTableAdapter = this.enderecoTableAdapter;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = controle_de_acesso.ACESS_CONTROLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.visitanteTableAdapter = null;
            // 
            // id_enderecoLabel1
            // 
            this.id_enderecoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecoBindingSource, "id_endereco", true));
            this.id_enderecoLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_enderecoLabel1.Location = new System.Drawing.Point(110, 20);
            this.id_enderecoLabel1.Name = "id_enderecoLabel1";
            this.id_enderecoLabel1.Size = new System.Drawing.Size(59, 23);
            this.id_enderecoLabel1.TabIndex = 2;
            this.id_enderecoLabel1.Click += new System.EventHandler(this.id_enderecoLabel1_Click);
            // 
            // visitanteBindingSource
            // 
            this.visitanteBindingSource.DataMember = "visitante";
            this.visitanteBindingSource.DataSource = this.aCESS_CONTROLDataSet;
            // 
            // visitanteTableAdapter
            // 
            this.visitanteTableAdapter.ClearBeforeFill = true;
            // 
            // aCESSCONTROLDataSetBindingSource
            // 
            this.aCESSCONTROLDataSetBindingSource.DataSource = this.aCESS_CONTROLDataSet;
            this.aCESSCONTROLDataSetBindingSource.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(ag_totalLabel);
            this.groupBox1.Controls.Add(this.ag_totalComboBox);
            this.groupBox1.Controls.Add(this.lbldata);
            this.groupBox1.Controls.Add(this.ent_horarioLabel2);
            this.groupBox1.Controls.Add(ent_horarioLabel1);
            this.groupBox1.Controls.Add(this.lblcpf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblvisitante);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(id_visitanteLabel1);
            this.groupBox1.Controls.Add(this.id_visitanteLabel2);
            this.groupBox1.Controls.Add(this.id_enderecoLabel1);
            this.groupBox1.Controls.Add(id_enderecoLabel);
            this.groupBox1.Controls.Add(ent_dataLabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(270, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 311);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ag_totalComboBox
            // 
            this.ag_totalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecoBindingSource, "ag_total", true));
            this.ag_totalComboBox.FormattingEnabled = true;
            this.ag_totalComboBox.Items.AddRange(new object[] {
            "apt 01",
            "apt 02",
            "apt 05",
            "apt 07",
            "apt 08",
            "apt 09",
            "apt 10"});
            this.ag_totalComboBox.Location = new System.Drawing.Point(219, 27);
            this.ag_totalComboBox.Name = "ag_totalComboBox";
            this.ag_totalComboBox.Size = new System.Drawing.Size(66, 21);
            this.ag_totalComboBox.TabIndex = 18;
            // 
            // lbldata
            // 
            this.lbldata.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecoBindingSource, "ag_total", true));
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(75, 64);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(389, 23);
            this.lbldata.TabIndex = 17;
            this.lbldata.Text = "data";
            // 
            // ent_horarioLabel2
            // 
            this.ent_horarioLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecoBindingSource, "ent_horario", true));
            this.ent_horarioLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ent_horarioLabel2.Location = new System.Drawing.Point(93, 115);
            this.ent_horarioLabel2.Name = "ent_horarioLabel2";
            this.ent_horarioLabel2.Size = new System.Drawing.Size(100, 23);
            this.ent_horarioLabel2.TabIndex = 16;
            this.ent_horarioLabel2.Text = "label7";
            this.ent_horarioLabel2.VisibleChanged += new System.EventHandler(this.ent_horarioLabel2_Click);
            this.ent_horarioLabel2.Click += new System.EventHandler(this.ent_horarioLabel2_Click);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(216, 197);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(0, 13);
            this.lblcpf.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cpf:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cpf:";
            // 
            // lblvisitante
            // 
            this.lblvisitante.AutoSize = true;
            this.lblvisitante.Location = new System.Drawing.Point(79, 193);
            this.lblvisitante.Name = "lblvisitante";
            this.lblvisitante.Size = new System.Drawing.Size(50, 13);
            this.lblvisitante.TabIndex = 14;
            this.lblvisitante.Text = "Visitante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Visitante:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.button1.Location = new System.Drawing.Point(42, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Liberar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_visitanteLabel2
            // 
            this.id_visitanteLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecoBindingSource, "id_visitante", true));
            this.id_visitanteLabel2.Location = new System.Drawing.Point(92, 154);
            this.id_visitanteLabel2.Name = "id_visitanteLabel2";
            this.id_visitanteLabel2.Size = new System.Drawing.Size(100, 23);
            this.id_visitanteLabel2.TabIndex = 11;
            this.id_visitanteLabel2.Text = "label1";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnpesquisar.Location = new System.Drawing.Point(37, 296);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(167, 23);
            this.btnpesquisar.TabIndex = 14;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(99, 249);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(95, 22);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cpf:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cpf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Foto Visitante";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(70, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 135);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(70, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 135);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // formendereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(754, 340);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formendereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formendereco";
            this.Load += new System.EventHandler(this.formendereco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aCESS_CONTROLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSCONTROLDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ACESS_CONTROLDataSet aCESS_CONTROLDataSet;
        private System.Windows.Forms.BindingSource enderecoBindingSource;
        private ACESS_CONTROLDataSetTableAdapters.enderecoTableAdapter enderecoTableAdapter;
        private ACESS_CONTROLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label id_enderecoLabel1;
        private System.Windows.Forms.BindingSource visitanteBindingSource;
        private ACESS_CONTROLDataSetTableAdapters.visitanteTableAdapter visitanteTableAdapter;
        private System.Windows.Forms.BindingSource aCESSCONTROLDataSetBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label id_visitanteLabel2;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ent_horarioLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.ComboBox ag_totalComboBox;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblvisitante;
    }
}