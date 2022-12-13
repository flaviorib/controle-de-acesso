namespace controle_de_acesso
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelateral = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnvisitante = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncadastro = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.panelcentral = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.panelateral.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.panelcentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelateral
            // 
            this.panelateral.BackColor = System.Drawing.Color.LightGray;
            this.panelateral.Controls.Add(this.button3);
            this.panelateral.Controls.Add(this.btnvisitante);
            this.panelateral.Controls.Add(this.btneditar);
            this.panelateral.Controls.Add(this.btncadastro);
            this.panelateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelateral.ForeColor = System.Drawing.Color.Black;
            this.panelateral.Location = new System.Drawing.Point(0, 0);
            this.panelateral.Name = "panelateral";
            this.panelateral.Size = new System.Drawing.Size(170, 450);
            this.panelateral.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MediumBlue;
            this.button3.Location = new System.Drawing.Point(12, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "Relatorio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnvisitante
            // 
            this.btnvisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvisitante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvisitante.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnvisitante.Location = new System.Drawing.Point(12, 159);
            this.btnvisitante.Name = "btnvisitante";
            this.btnvisitante.Size = new System.Drawing.Size(140, 62);
            this.btnvisitante.TabIndex = 2;
            this.btnvisitante.Text = "Visitante";
            this.btnvisitante.UseVisualStyleBackColor = true;
            this.btnvisitante.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // btneditar
            // 
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btneditar.Location = new System.Drawing.Point(12, 247);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(140, 62);
            this.btneditar.TabIndex = 1;
            this.btneditar.Text = "Liberar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncadastro
            // 
            this.btncadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastro.ForeColor = System.Drawing.Color.MediumBlue;
            this.btncadastro.Location = new System.Drawing.Point(12, 72);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(140, 62);
            this.btncadastro.TabIndex = 0;
            this.btncadastro.Text = "Inicio";
            this.btncadastro.UseVisualStyleBackColor = true;
            this.btncadastro.Click += new System.EventHandler(this.btncadastro_Click);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.SkyBlue;
            this.paneltop.Controls.Add(this.btnsair);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(170, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(630, 43);
            this.paneltop.TabIndex = 1;
            // 
            // panelcentral
            // 
            this.panelcentral.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelcentral.Controls.Add(this.pictureBox1);
            this.panelcentral.Controls.Add(this.webBrowser1);
            this.panelcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentral.Location = new System.Drawing.Point(170, 43);
            this.panelcentral.Name = "panelcentral";
            this.panelcentral.Size = new System.Drawing.Size(630, 407);
            this.panelcentral.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(630, 407);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.youtube.com/watch?v=8KGXSjtS5pk", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::controle_de_acesso.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnsair
            // 
            this.btnsair.BackgroundImage = global::controle_de_acesso.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Location = new System.Drawing.Point(605, 3);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(25, 34);
            this.btnsair.TabIndex = 0;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcentral);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelateral.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.panelcentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelateral;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panelcentral;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnvisitante;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

