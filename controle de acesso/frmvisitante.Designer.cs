namespace controle_de_acesso
{
    partial class frmvisitante
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
            System.Windows.Forms.Label codigo_visitanteLabel;
            System.Windows.Forms.Label nome_visitanteLabel;
            System.Windows.Forms.Label rg_visitanteLabel;
            System.Windows.Forms.Label cpf_visitanteLabel;
            System.Windows.Forms.Label foto_visitanteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvisitante));
            this.visitanteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.visitanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCESS_CONTROLDataSet = new controle_de_acesso.ACESS_CONTROLDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.visitanteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btneditar = new System.Windows.Forms.ToolStripButton();
            this.btncancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codigo_visitanteLabel1 = new System.Windows.Forms.Label();
            this.visitanteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aCESS_CONTROLDataSet1 = new controle_de_acesso.ACESS_CONTROLDataSet1();
            this.nome_visitanteTextBox = new System.Windows.Forms.TextBox();
            this.rg_visitanteTextBox = new System.Windows.Forms.TextBox();
            this.cpf_visitanteMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.foto_visitantePictureBox = new System.Windows.Forms.PictureBox();
            this.visitanteTableAdapter = new controle_de_acesso.ACESS_CONTROLDataSetTableAdapters.visitanteTableAdapter();
            this.tableAdapterManager = new controle_de_acesso.ACESS_CONTROLDataSetTableAdapters.TableAdapterManager();
            this.visitanteTableAdapter1 = new controle_de_acesso.ACESS_CONTROLDataSet1TableAdapters.visitanteTableAdapter();
            this.tableAdapterManager1 = new controle_de_acesso.ACESS_CONTROLDataSet1TableAdapters.TableAdapterManager();
            this.cbseletor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            codigo_visitanteLabel = new System.Windows.Forms.Label();
            nome_visitanteLabel = new System.Windows.Forms.Label();
            rg_visitanteLabel = new System.Windows.Forms.Label();
            cpf_visitanteLabel = new System.Windows.Forms.Label();
            foto_visitanteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingNavigator)).BeginInit();
            this.visitanteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESS_CONTROLDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESS_CONTROLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_visitantePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo_visitanteLabel
            // 
            codigo_visitanteLabel.AutoSize = true;
            codigo_visitanteLabel.Location = new System.Drawing.Point(12, 31);
            codigo_visitanteLabel.Name = "codigo_visitanteLabel";
            codigo_visitanteLabel.Size = new System.Drawing.Size(100, 16);
            codigo_visitanteLabel.TabIndex = 0;
            codigo_visitanteLabel.Text = "codigo visitante:";
            codigo_visitanteLabel.Click += new System.EventHandler(this.codigo_visitanteLabel_Click);
            // 
            // nome_visitanteLabel
            // 
            nome_visitanteLabel.AutoSize = true;
            nome_visitanteLabel.Location = new System.Drawing.Point(18, 79);
            nome_visitanteLabel.Name = "nome_visitanteLabel";
            nome_visitanteLabel.Size = new System.Drawing.Size(94, 16);
            nome_visitanteLabel.TabIndex = 2;
            nome_visitanteLabel.Text = "nome visitante:";
            nome_visitanteLabel.Click += new System.EventHandler(this.nome_visitanteLabel_Click);
            // 
            // rg_visitanteLabel
            // 
            rg_visitanteLabel.AutoSize = true;
            rg_visitanteLabel.Location = new System.Drawing.Point(27, 113);
            rg_visitanteLabel.Name = "rg_visitanteLabel";
            rg_visitanteLabel.Size = new System.Drawing.Size(73, 16);
            rg_visitanteLabel.TabIndex = 4;
            rg_visitanteLabel.Text = "rg visitante:";
            rg_visitanteLabel.Click += new System.EventHandler(this.rg_visitanteLabel_Click);
            // 
            // cpf_visitanteLabel
            // 
            cpf_visitanteLabel.AutoSize = true;
            cpf_visitanteLabel.Location = new System.Drawing.Point(21, 144);
            cpf_visitanteLabel.Name = "cpf_visitanteLabel";
            cpf_visitanteLabel.Size = new System.Drawing.Size(79, 16);
            cpf_visitanteLabel.TabIndex = 6;
            cpf_visitanteLabel.Text = "cpf visitante:";
            cpf_visitanteLabel.Click += new System.EventHandler(this.cpf_visitanteLabel_Click);
            // 
            // foto_visitanteLabel
            // 
            foto_visitanteLabel.AutoSize = true;
            foto_visitanteLabel.Location = new System.Drawing.Point(21, 171);
            foto_visitanteLabel.Name = "foto_visitanteLabel";
            foto_visitanteLabel.Size = new System.Drawing.Size(83, 16);
            foto_visitanteLabel.TabIndex = 8;
            foto_visitanteLabel.Text = "foto visitante:";
            foto_visitanteLabel.Click += new System.EventHandler(this.foto_visitanteLabel_Click);
            // 
            // visitanteBindingNavigator
            // 
            this.visitanteBindingNavigator.AddNewItem = null;
            this.visitanteBindingNavigator.BindingSource = this.visitanteBindingSource;
            this.visitanteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.visitanteBindingNavigator.DeleteItem = null;
            this.visitanteBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.visitanteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.visitanteBindingNavigatorSaveItem,
            this.btneditar,
            this.btncancelar,
            this.toolStripButton1});
            this.visitanteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.visitanteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visitanteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visitanteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visitanteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visitanteBindingNavigator.Name = "visitanteBindingNavigator";
            this.visitanteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visitanteBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.visitanteBindingNavigator.Size = new System.Drawing.Size(614, 39);
            this.visitanteBindingNavigator.TabIndex = 0;
            this.visitanteBindingNavigator.Text = "bindingNavigator1";
            // 
            // visitanteBindingSource
            // 
            this.visitanteBindingSource.DataMember = "visitante";
            this.visitanteBindingSource.DataSource = this.aCESS_CONTROLDataSet;
            this.visitanteBindingSource.CurrentChanged += new System.EventHandler(this.visitanteBindingSource_CurrentChanged);
            // 
            // aCESS_CONTROLDataSet
            // 
            this.aCESS_CONTROLDataSet.DataSetName = "ACESS_CONTROLDataSet";
            this.aCESS_CONTROLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // visitanteBindingNavigatorSaveItem
            // 
            this.visitanteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.visitanteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("visitanteBindingNavigatorSaveItem.Image")));
            this.visitanteBindingNavigatorSaveItem.Name = "visitanteBindingNavigatorSaveItem";
            this.visitanteBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.visitanteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.visitanteBindingNavigatorSaveItem.Click += new System.EventHandler(this.visitanteBindingNavigatorSaveItem_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(73, 36);
            this.btneditar.Text = "Editar";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(89, 36);
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::controle_de_acesso.Properties.Resources.baixados;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbseletor);
            this.groupBox1.Controls.Add(codigo_visitanteLabel);
            this.groupBox1.Controls.Add(this.codigo_visitanteLabel1);
            this.groupBox1.Controls.Add(nome_visitanteLabel);
            this.groupBox1.Controls.Add(this.nome_visitanteTextBox);
            this.groupBox1.Controls.Add(rg_visitanteLabel);
            this.groupBox1.Controls.Add(this.rg_visitanteTextBox);
            this.groupBox1.Controls.Add(cpf_visitanteLabel);
            this.groupBox1.Controls.Add(this.cpf_visitanteMaskedTextBox);
            this.groupBox1.Controls.Add(foto_visitanteLabel);
            this.groupBox1.Controls.Add(this.foto_visitantePictureBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 327);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro visitante";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // codigo_visitanteLabel1
            // 
            this.codigo_visitanteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource1, "codigo_visitante", true));
            this.codigo_visitanteLabel1.Location = new System.Drawing.Point(118, 31);
            this.codigo_visitanteLabel1.Name = "codigo_visitanteLabel1";
            this.codigo_visitanteLabel1.Size = new System.Drawing.Size(100, 23);
            this.codigo_visitanteLabel1.TabIndex = 1;
            this.codigo_visitanteLabel1.Text = "label1";
            this.codigo_visitanteLabel1.Click += new System.EventHandler(this.codigo_visitanteLabel1_Click);
            // 
            // visitanteBindingSource1
            // 
            this.visitanteBindingSource1.DataMember = "visitante";
            this.visitanteBindingSource1.DataSource = this.aCESS_CONTROLDataSet1;
            // 
            // aCESS_CONTROLDataSet1
            // 
            this.aCESS_CONTROLDataSet1.DataSetName = "ACESS_CONTROLDataSet1";
            this.aCESS_CONTROLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nome_visitanteTextBox
            // 
            this.nome_visitanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource1, "nome_visitante", true));
            this.nome_visitanteTextBox.Location = new System.Drawing.Point(118, 73);
            this.nome_visitanteTextBox.Name = "nome_visitanteTextBox";
            this.nome_visitanteTextBox.Size = new System.Drawing.Size(229, 22);
            this.nome_visitanteTextBox.TabIndex = 3;
            this.nome_visitanteTextBox.TextChanged += new System.EventHandler(this.nome_visitanteTextBox_TextChanged);
            // 
            // rg_visitanteTextBox
            // 
            this.rg_visitanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource1, "rg_visitante", true));
            this.rg_visitanteTextBox.Location = new System.Drawing.Point(118, 107);
            this.rg_visitanteTextBox.Name = "rg_visitanteTextBox";
            this.rg_visitanteTextBox.Size = new System.Drawing.Size(157, 22);
            this.rg_visitanteTextBox.TabIndex = 5;
            this.rg_visitanteTextBox.TextChanged += new System.EventHandler(this.rg_visitanteTextBox_TextChanged);
            // 
            // cpf_visitanteMaskedTextBox
            // 
            this.cpf_visitanteMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource1, "cpf_visitante", true));
            this.cpf_visitanteMaskedTextBox.Location = new System.Drawing.Point(118, 141);
            this.cpf_visitanteMaskedTextBox.Name = "cpf_visitanteMaskedTextBox";
            this.cpf_visitanteMaskedTextBox.Size = new System.Drawing.Size(157, 22);
            this.cpf_visitanteMaskedTextBox.TabIndex = 7;
            this.cpf_visitanteMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpf_visitanteMaskedTextBox_MaskInputRejected_1);
            // 
            // foto_visitantePictureBox
            // 
            this.foto_visitantePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.visitanteBindingSource1, "foto_visitante", true));
            this.foto_visitantePictureBox.Location = new System.Drawing.Point(353, 41);
            this.foto_visitantePictureBox.Name = "foto_visitantePictureBox";
            this.foto_visitantePictureBox.Size = new System.Drawing.Size(196, 143);
            this.foto_visitantePictureBox.TabIndex = 9;
            this.foto_visitantePictureBox.TabStop = false;
            this.foto_visitantePictureBox.Click += new System.EventHandler(this.foto_visitantePictureBox_Click);
            // 
            // visitanteTableAdapter
            // 
            this.visitanteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.enderecoTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = controle_de_acesso.ACESS_CONTROLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.visitanteTableAdapter = this.visitanteTableAdapter;
            // 
            // visitanteTableAdapter1
            // 
            this.visitanteTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.enderecoTableAdapter = null;
            this.tableAdapterManager1.funcionarioTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = controle_de_acesso.ACESS_CONTROLDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.visitanteTableAdapter = this.visitanteTableAdapter1;
            // 
            // cbseletor
            // 
            this.cbseletor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbseletor.FormattingEnabled = true;
            this.cbseletor.Location = new System.Drawing.Point(371, 190);
            this.cbseletor.Name = "cbseletor";
            this.cbseletor.Size = new System.Drawing.Size(138, 24);
            this.cbseletor.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "capturar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // frmvisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.visitanteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmvisitante";
            this.Text = "frmvisitante";
            this.Load += new System.EventHandler(this.frmeditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingNavigator)).EndInit();
            this.visitanteBindingNavigator.ResumeLayout(false);
            this.visitanteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESS_CONTROLDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESS_CONTROLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_visitantePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ACESS_CONTROLDataSet aCESS_CONTROLDataSet;
        private System.Windows.Forms.BindingSource visitanteBindingSource;
        private ACESS_CONTROLDataSetTableAdapters.visitanteTableAdapter visitanteTableAdapter;
        private ACESS_CONTROLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator visitanteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton visitanteBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton btneditar;
        private System.Windows.Forms.ToolStripButton btncancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private ACESS_CONTROLDataSet1 aCESS_CONTROLDataSet1;
        private System.Windows.Forms.BindingSource visitanteBindingSource1;
        private ACESS_CONTROLDataSet1TableAdapters.visitanteTableAdapter visitanteTableAdapter1;
        private ACESS_CONTROLDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label codigo_visitanteLabel1;
        private System.Windows.Forms.TextBox nome_visitanteTextBox;
        private System.Windows.Forms.TextBox rg_visitanteTextBox;
        private System.Windows.Forms.MaskedTextBox cpf_visitanteMaskedTextBox;
        private System.Windows.Forms.PictureBox foto_visitantePictureBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbseletor;
        private System.Windows.Forms.Button button2;
    }
}