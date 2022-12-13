namespace controle_de_acesso
{
    partial class frmcadastrofuncionario
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
            System.Windows.Forms.Label cargo_funcionarioLabel1;
            System.Windows.Forms.Label id_funcionarioLabel;
            System.Windows.Forms.Label nome_funcionarioLabel;
            System.Windows.Forms.Label celular_funcionarioLabel;
            System.Windows.Forms.Label rg_funcionarioLabel;
            System.Windows.Forms.Label cpf_funcionarioLabel;
            System.Windows.Forms.Label foto_funcionarioLabel;
            System.Windows.Forms.Label senha_funcionarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcadastrofuncionario));
            this.aCESS_CONTROLDataSet = new controle_de_acesso.ACESS_CONTROLDataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new controle_de_acesso.ACESS_CONTROLDataSetTableAdapters.funcionarioTableAdapter();
            this.tableAdapterManager = new controle_de_acesso.ACESS_CONTROLDataSetTableAdapters.TableAdapterManager();
            this.funcionarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnfoto = new System.Windows.Forms.Button();
            this.id_funcionarioLabel1 = new System.Windows.Forms.Label();
            this.nome_funcionarioTextBox = new System.Windows.Forms.TextBox();
            this.celular_funcionarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rg_funcionarioTextBox = new System.Windows.Forms.TextBox();
            this.cpf_funcionarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.senha_funcionarioTextBox = new System.Windows.Forms.TextBox();
            this.cargo_funcionarioComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.funcionarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btneditar = new System.Windows.Forms.ToolStripButton();
            this.btncancel = new System.Windows.Forms.ToolStripButton();
            this.btnexcluir = new System.Windows.Forms.ToolStripButton();
            this.foto_funcionarioPictureBox = new System.Windows.Forms.PictureBox();
            cargo_funcionarioLabel1 = new System.Windows.Forms.Label();
            id_funcionarioLabel = new System.Windows.Forms.Label();
            nome_funcionarioLabel = new System.Windows.Forms.Label();
            celular_funcionarioLabel = new System.Windows.Forms.Label();
            rg_funcionarioLabel = new System.Windows.Forms.Label();
            cpf_funcionarioLabel = new System.Windows.Forms.Label();
            foto_funcionarioLabel = new System.Windows.Forms.Label();
            senha_funcionarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aCESS_CONTROLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).BeginInit();
            this.funcionarioBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_funcionarioPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cargo_funcionarioLabel1
            // 
            cargo_funcionarioLabel1.AutoSize = true;
            cargo_funcionarioLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cargo_funcionarioLabel1.Location = new System.Drawing.Point(315, 320);
            cargo_funcionarioLabel1.Name = "cargo_funcionarioLabel1";
            cargo_funcionarioLabel1.Size = new System.Drawing.Size(109, 16);
            cargo_funcionarioLabel1.TabIndex = 0;
            cargo_funcionarioLabel1.Text = "cargo funcionario:";
            // 
            // id_funcionarioLabel
            // 
            id_funcionarioLabel.AutoSize = true;
            id_funcionarioLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_funcionarioLabel.Location = new System.Drawing.Point(81, 77);
            id_funcionarioLabel.Name = "id_funcionarioLabel";
            id_funcionarioLabel.Size = new System.Drawing.Size(87, 16);
            id_funcionarioLabel.TabIndex = 18;
            id_funcionarioLabel.Text = "id funcionario:";
            // 
            // nome_funcionarioLabel
            // 
            nome_funcionarioLabel.AutoSize = true;
            nome_funcionarioLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_funcionarioLabel.Location = new System.Drawing.Point(63, 122);
            nome_funcionarioLabel.Name = "nome_funcionarioLabel";
            nome_funcionarioLabel.Size = new System.Drawing.Size(109, 16);
            nome_funcionarioLabel.TabIndex = 20;
            nome_funcionarioLabel.Text = "nome funcionario:";
            // 
            // celular_funcionarioLabel
            // 
            celular_funcionarioLabel.AutoSize = true;
            celular_funcionarioLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celular_funcionarioLabel.Location = new System.Drawing.Point(58, 174);
            celular_funcionarioLabel.Name = "celular_funcionarioLabel";
            celular_funcionarioLabel.Size = new System.Drawing.Size(115, 16);
            celular_funcionarioLabel.TabIndex = 22;
            celular_funcionarioLabel.Text = "celular funcionario:";
            // 
            // rg_funcionarioLabel
            // 
            rg_funcionarioLabel.AutoSize = true;
            rg_funcionarioLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rg_funcionarioLabel.Location = new System.Drawing.Point(80, 219);
            rg_funcionarioLabel.Name = "rg_funcionarioLabel";
            rg_funcionarioLabel.Size = new System.Drawing.Size(88, 16);
            rg_funcionarioLabel.TabIndex = 24;
            rg_funcionarioLabel.Text = "rg funcionario:";
            // 
            // cpf_funcionarioLabel
            // 
            cpf_funcionarioLabel.AutoSize = true;
            cpf_funcionarioLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpf_funcionarioLabel.Location = new System.Drawing.Point(74, 268);
            cpf_funcionarioLabel.Name = "cpf_funcionarioLabel";
            cpf_funcionarioLabel.Size = new System.Drawing.Size(94, 16);
            cpf_funcionarioLabel.TabIndex = 26;
            cpf_funcionarioLabel.Text = "cpf funcionario:";
            // 
            // foto_funcionarioLabel
            // 
            foto_funcionarioLabel.AutoSize = true;
            foto_funcionarioLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foto_funcionarioLabel.Location = new System.Drawing.Point(472, 141);
            foto_funcionarioLabel.Name = "foto_funcionarioLabel";
            foto_funcionarioLabel.Size = new System.Drawing.Size(98, 16);
            foto_funcionarioLabel.TabIndex = 28;
            foto_funcionarioLabel.Text = "foto funcionario:";
            // 
            // senha_funcionarioLabel
            // 
            senha_funcionarioLabel.AutoSize = true;
            senha_funcionarioLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senha_funcionarioLabel.Location = new System.Drawing.Point(58, 320);
            senha_funcionarioLabel.Name = "senha_funcionarioLabel";
            senha_funcionarioLabel.Size = new System.Drawing.Size(112, 16);
            senha_funcionarioLabel.TabIndex = 30;
            senha_funcionarioLabel.Text = "senha funcionario:";
            // 
            // aCESS_CONTROLDataSet
            // 
            this.aCESS_CONTROLDataSet.DataSetName = "ACESS_CONTROLDataSet";
            this.aCESS_CONTROLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.aCESS_CONTROLDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.enderecoTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = controle_de_acesso.ACESS_CONTROLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.visitanteTableAdapter = null;
            // 
            // funcionarioBindingNavigator
            // 
            this.funcionarioBindingNavigator.AddNewItem = null;
            this.funcionarioBindingNavigator.BindingSource = this.funcionarioBindingSource;
            this.funcionarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionarioBindingNavigator.DeleteItem = null;
            this.funcionarioBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.funcionarioBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.funcionarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.funcionarioBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.btneditar,
            this.btncancel,
            this.btnexcluir});
            this.funcionarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.funcionarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.funcionarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.funcionarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.funcionarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.funcionarioBindingNavigator.Name = "funcionarioBindingNavigator";
            this.funcionarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funcionarioBindingNavigator.Size = new System.Drawing.Size(633, 39);
            this.funcionarioBindingNavigator.TabIndex = 0;
            this.funcionarioBindingNavigator.Text = "bindingNavigator1";
            this.funcionarioBindingNavigator.RefreshItems += new System.EventHandler(this.funcionarioBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.btnfoto);
            this.groupBox1.Controls.Add(id_funcionarioLabel);
            this.groupBox1.Controls.Add(this.id_funcionarioLabel1);
            this.groupBox1.Controls.Add(nome_funcionarioLabel);
            this.groupBox1.Controls.Add(this.nome_funcionarioTextBox);
            this.groupBox1.Controls.Add(celular_funcionarioLabel);
            this.groupBox1.Controls.Add(this.celular_funcionarioMaskedTextBox);
            this.groupBox1.Controls.Add(rg_funcionarioLabel);
            this.groupBox1.Controls.Add(this.rg_funcionarioTextBox);
            this.groupBox1.Controls.Add(cpf_funcionarioLabel);
            this.groupBox1.Controls.Add(this.cpf_funcionarioMaskedTextBox);
            this.groupBox1.Controls.Add(foto_funcionarioLabel);
            this.groupBox1.Controls.Add(this.foto_funcionarioPictureBox);
            this.groupBox1.Controls.Add(senha_funcionarioLabel);
            this.groupBox1.Controls.Add(this.senha_funcionarioTextBox);
            this.groupBox1.Controls.Add(cargo_funcionarioLabel1);
            this.groupBox1.Controls.Add(this.cargo_funcionarioComboBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 394);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnfoto
            // 
            this.btnfoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfoto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfoto.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnfoto.Location = new System.Drawing.Point(454, 306);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(120, 40);
            this.btnfoto.TabIndex = 32;
            this.btnfoto.Text = "Adicionar";
            this.btnfoto.UseVisualStyleBackColor = true;
            // 
            // id_funcionarioLabel1
            // 
            this.id_funcionarioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "id_funcionario", true));
            this.id_funcionarioLabel1.Location = new System.Drawing.Point(174, 77);
            this.id_funcionarioLabel1.Name = "id_funcionarioLabel1";
            this.id_funcionarioLabel1.Size = new System.Drawing.Size(120, 23);
            this.id_funcionarioLabel1.TabIndex = 19;
            this.id_funcionarioLabel1.Text = "label1";
            // 
            // nome_funcionarioTextBox
            // 
            this.nome_funcionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "nome_funcionario", true));
            this.nome_funcionarioTextBox.Location = new System.Drawing.Point(178, 122);
            this.nome_funcionarioTextBox.Name = "nome_funcionarioTextBox";
            this.nome_funcionarioTextBox.Size = new System.Drawing.Size(277, 20);
            this.nome_funcionarioTextBox.TabIndex = 21;
            // 
            // celular_funcionarioMaskedTextBox
            // 
            this.celular_funcionarioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "celular_funcionario", true));
            this.celular_funcionarioMaskedTextBox.Location = new System.Drawing.Point(177, 170);
            this.celular_funcionarioMaskedTextBox.Mask = "(00)00000-0000";
            this.celular_funcionarioMaskedTextBox.Name = "celular_funcionarioMaskedTextBox";
            this.celular_funcionarioMaskedTextBox.Size = new System.Drawing.Size(178, 20);
            this.celular_funcionarioMaskedTextBox.TabIndex = 23;
            // 
            // rg_funcionarioTextBox
            // 
            this.rg_funcionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "rg_funcionario", true));
            this.rg_funcionarioTextBox.Location = new System.Drawing.Point(178, 216);
            this.rg_funcionarioTextBox.Name = "rg_funcionarioTextBox";
            this.rg_funcionarioTextBox.Size = new System.Drawing.Size(177, 20);
            this.rg_funcionarioTextBox.TabIndex = 25;
            // 
            // cpf_funcionarioMaskedTextBox
            // 
            this.cpf_funcionarioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "cpf_funcionario", true));
            this.cpf_funcionarioMaskedTextBox.Location = new System.Drawing.Point(178, 264);
            this.cpf_funcionarioMaskedTextBox.Mask = "000.000.000-00";
            this.cpf_funcionarioMaskedTextBox.Name = "cpf_funcionarioMaskedTextBox";
            this.cpf_funcionarioMaskedTextBox.Size = new System.Drawing.Size(177, 20);
            this.cpf_funcionarioMaskedTextBox.TabIndex = 27;
            // 
            // senha_funcionarioTextBox
            // 
            this.senha_funcionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "senha_funcionario", true));
            this.senha_funcionarioTextBox.Location = new System.Drawing.Point(61, 348);
            this.senha_funcionarioTextBox.Name = "senha_funcionarioTextBox";
            this.senha_funcionarioTextBox.Size = new System.Drawing.Size(120, 20);
            this.senha_funcionarioTextBox.TabIndex = 31;
            // 
            // cargo_funcionarioComboBox
            // 
            this.cargo_funcionarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "cargo_funcionario", true));
            this.cargo_funcionarioComboBox.FormattingEnabled = true;
            this.cargo_funcionarioComboBox.Items.AddRange(new object[] {
            "recepcionista",
            "segurança",
            "administrador"});
            this.cargo_funcionarioComboBox.Location = new System.Drawing.Point(318, 347);
            this.cargo_funcionarioComboBox.Name = "cargo_funcionarioComboBox";
            this.cargo_funcionarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.cargo_funcionarioComboBox.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // funcionarioBindingNavigatorSaveItem
            // 
            this.funcionarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionarioBindingNavigatorSaveItem.Image")));
            this.funcionarioBindingNavigatorSaveItem.Name = "funcionarioBindingNavigatorSaveItem";
            this.funcionarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.funcionarioBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.funcionarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionarioBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(94, 36);
            this.toolStripButton1.Text = "Adicionar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(73, 36);
            this.btneditar.Text = "Editar";
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncancel
            // 
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(89, 36);
            this.btncancel.Text = "Cancelar";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluir.Image")));
            this.btnexcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(78, 36);
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // foto_funcionarioPictureBox
            // 
            this.foto_funcionarioPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.funcionarioBindingSource, "foto_funcionario", true));
            this.foto_funcionarioPictureBox.Location = new System.Drawing.Point(454, 174);
            this.foto_funcionarioPictureBox.Name = "foto_funcionarioPictureBox";
            this.foto_funcionarioPictureBox.Size = new System.Drawing.Size(120, 122);
            this.foto_funcionarioPictureBox.TabIndex = 29;
            this.foto_funcionarioPictureBox.TabStop = false;
            this.foto_funcionarioPictureBox.Click += new System.EventHandler(this.foto_funcionarioPictureBox_Click);
            // 
            // frmcadastrofuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 465);
            this.Controls.Add(this.funcionarioBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcadastrofuncionario";
            this.Text = "frmcadastrofuncionario";
            this.Load += new System.EventHandler(this.frmcadastrofuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aCESS_CONTROLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).EndInit();
            this.funcionarioBindingNavigator.ResumeLayout(false);
            this.funcionarioBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_funcionarioPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ACESS_CONTROLDataSet aCESS_CONTROLDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private ACESS_CONTROLDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private ACESS_CONTROLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionarioBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton funcionarioBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton btneditar;
        private System.Windows.Forms.ToolStripButton btncancel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cargo_funcionarioComboBox;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.Label id_funcionarioLabel1;
        private System.Windows.Forms.TextBox nome_funcionarioTextBox;
        private System.Windows.Forms.MaskedTextBox celular_funcionarioMaskedTextBox;
        private System.Windows.Forms.TextBox rg_funcionarioTextBox;
        private System.Windows.Forms.MaskedTextBox cpf_funcionarioMaskedTextBox;
        private System.Windows.Forms.PictureBox foto_funcionarioPictureBox;
        private System.Windows.Forms.TextBox senha_funcionarioTextBox;
        private System.Windows.Forms.ToolStripButton btnexcluir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}