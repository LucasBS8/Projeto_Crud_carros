namespace atv1
{
     partial class Frm_cadastro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadastro));
            this.Btn_limpar = new System.Windows.Forms.Button();
            this.Btn_alterar = new System.Windows.Forms.Button();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.Btn_pesquisa = new System.Windows.Forms.Button();
            this.Txb_pesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_remover = new System.Windows.Forms.Button();
            this.pnl_esquerda = new System.Windows.Forms.Panel();
            this.btn_config = new System.Windows.Forms.Button();
            this.Btn_adicionar = new System.Windows.Forms.Button();
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.Mtb_renavam = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_CodigoCrv = new System.Windows.Forms.MaskedTextBox();
            this.Txb_Modelo = new System.Windows.Forms.TextBox();
            this.Cbx_Marca = new System.Windows.Forms.ComboBox();
            this.Mtb_placa = new System.Windows.Forms.MaskedTextBox();
            this.Txb_IdCarro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtv_carros = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.gbx2 = new System.Windows.Forms.GroupBox();
            this.Cbx_chave = new System.Windows.Forms.CheckBox();
            this.Cbx_instrucao = new System.Windows.Forms.CheckBox();
            this.Cbx_macaco = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.Rbn_usado = new System.Windows.Forms.RadioButton();
            this.Rbn_novo = new System.Windows.Forms.RadioButton();
            this.Cbx_cor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_top.SuspendLayout();
            this.pnl_esquerda.SuspendLayout();
            this.pnl_centro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_carros)).BeginInit();
            this.gbx2.SuspendLayout();
            this.gbx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Btn_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_limpar.FlatAppearance.BorderSize = 0;
            this.Btn_limpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_limpar.Location = new System.Drawing.Point(12, 415);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(168, 47);
            this.Btn_limpar.TabIndex = 19;
            this.Btn_limpar.Text = "Limpar";
            this.Btn_limpar.UseVisualStyleBackColor = false;
            this.Btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // Btn_alterar
            // 
            this.Btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Btn_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_alterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_alterar.FlatAppearance.BorderSize = 0;
            this.Btn_alterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_alterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_alterar.Location = new System.Drawing.Point(12, 181);
            this.Btn_alterar.Name = "Btn_alterar";
            this.Btn_alterar.Size = new System.Drawing.Size(168, 47);
            this.Btn_alterar.TabIndex = 17;
            this.Btn_alterar.Text = "Alterar dados";
            this.Btn_alterar.UseVisualStyleBackColor = false;
            this.Btn_alterar.Click += new System.EventHandler(this.Btn_alterar_Click);
            // 
            // Btn_sair
            // 
            this.Btn_sair.BackColor = System.Drawing.Color.Firebrick;
            this.Btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_sair.FlatAppearance.BorderSize = 2;
            this.Btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sair.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_sair.Location = new System.Drawing.Point(120, 551);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(60, 40);
            this.Btn_sair.TabIndex = 21;
            this.Btn_sair.Text = "Sair";
            this.Btn_sair.UseVisualStyleBackColor = false;
            this.Btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.pnl_top.Controls.Add(this.Btn_pesquisa);
            this.pnl_top.Controls.Add(this.Txb_pesquisa);
            this.pnl_top.Controls.Add(this.label2);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1151, 101);
            this.pnl_top.TabIndex = 0;
            // 
            // Btn_pesquisa
            // 
            this.Btn_pesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Btn_pesquisa.BackgroundImage = global::atv1.Properties.Resources.procurar;
            this.Btn_pesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_pesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_pesquisa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_pesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_pesquisa.Location = new System.Drawing.Point(1089, 44);
            this.Btn_pesquisa.Name = "Btn_pesquisa";
            this.Btn_pesquisa.Size = new System.Drawing.Size(31, 31);
            this.Btn_pesquisa.TabIndex = 1;
            this.Btn_pesquisa.UseVisualStyleBackColor = false;
            this.Btn_pesquisa.Click += new System.EventHandler(this.Btn_pesquisa_Click);
            // 
            // Txb_pesquisa
            // 
            this.Txb_pesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Txb_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_pesquisa.Location = new System.Drawing.Point(858, 44);
            this.Txb_pesquisa.Name = "Txb_pesquisa";
            this.Txb_pesquisa.Size = new System.Drawing.Size(262, 31);
            this.Txb_pesquisa.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(854, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Pesquisar por ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cadastro de carros";
            // 
            // Btn_remover
            // 
            this.Btn_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_remover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_remover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_remover.FlatAppearance.BorderSize = 0;
            this.Btn_remover.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_remover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_remover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_remover.Location = new System.Drawing.Point(12, 298);
            this.Btn_remover.Name = "Btn_remover";
            this.Btn_remover.Size = new System.Drawing.Size(168, 47);
            this.Btn_remover.TabIndex = 18;
            this.Btn_remover.Text = "Remover cadastro";
            this.Btn_remover.UseVisualStyleBackColor = false;
            this.Btn_remover.Click += new System.EventHandler(this.Txb_remover_Click);
            // 
            // pnl_esquerda
            // 
            this.pnl_esquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.pnl_esquerda.Controls.Add(this.btn_config);
            this.pnl_esquerda.Controls.Add(this.Btn_adicionar);
            this.pnl_esquerda.Controls.Add(this.Btn_alterar);
            this.pnl_esquerda.Controls.Add(this.Btn_remover);
            this.pnl_esquerda.Controls.Add(this.Btn_limpar);
            this.pnl_esquerda.Controls.Add(this.Btn_sair);
            this.pnl_esquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_esquerda.Location = new System.Drawing.Point(0, 101);
            this.pnl_esquerda.Name = "pnl_esquerda";
            this.pnl_esquerda.Size = new System.Drawing.Size(199, 606);
            this.pnl_esquerda.TabIndex = 15;
            // 
            // btn_config
            // 
            this.btn_config.BackgroundImage = global::atv1.Properties.Resources.definicoes;
            this.btn_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_config.Location = new System.Drawing.Point(27, 552);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(40, 40);
            this.btn_config.TabIndex = 20;
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // Btn_adicionar
            // 
            this.Btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_adicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_adicionar.FlatAppearance.BorderSize = 0;
            this.Btn_adicionar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_adicionar.Location = new System.Drawing.Point(12, 64);
            this.Btn_adicionar.Name = "Btn_adicionar";
            this.Btn_adicionar.Size = new System.Drawing.Size(168, 47);
            this.Btn_adicionar.TabIndex = 16;
            this.Btn_adicionar.Text = "Adicionar";
            this.Btn_adicionar.UseVisualStyleBackColor = false;
            this.Btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click);
            // 
            // pnl_centro
            // 
            this.pnl_centro.Controls.Add(this.Mtb_renavam);
            this.pnl_centro.Controls.Add(this.Mtb_CodigoCrv);
            this.pnl_centro.Controls.Add(this.Txb_Modelo);
            this.pnl_centro.Controls.Add(this.Cbx_Marca);
            this.pnl_centro.Controls.Add(this.Mtb_placa);
            this.pnl_centro.Controls.Add(this.Txb_IdCarro);
            this.pnl_centro.Controls.Add(this.label3);
            this.pnl_centro.Controls.Add(this.dtv_carros);
            this.pnl_centro.Controls.Add(this.label5);
            this.pnl_centro.Controls.Add(this.gbx2);
            this.pnl_centro.Controls.Add(this.label7);
            this.pnl_centro.Controls.Add(this.label6);
            this.pnl_centro.Controls.Add(this.label9);
            this.pnl_centro.Controls.Add(this.label4);
            this.pnl_centro.Controls.Add(this.gbx1);
            this.pnl_centro.Controls.Add(this.Cbx_cor);
            this.pnl_centro.Controls.Add(this.label8);
            this.pnl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centro.Location = new System.Drawing.Point(199, 101);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(952, 606);
            this.pnl_centro.TabIndex = 1;
            // 
            // Mtb_renavam
            // 
            this.Mtb_renavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Mtb_renavam.Location = new System.Drawing.Point(385, 146);
            this.Mtb_renavam.Mask = "000000000";
            this.Mtb_renavam.Name = "Mtb_renavam";
            this.Mtb_renavam.Size = new System.Drawing.Size(120, 26);
            this.Mtb_renavam.TabIndex = 5;
            // 
            // Mtb_CodigoCrv
            // 
            this.Mtb_CodigoCrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Mtb_CodigoCrv.Location = new System.Drawing.Point(385, 58);
            this.Mtb_CodigoCrv.Mask = "000000000";
            this.Mtb_CodigoCrv.Name = "Mtb_CodigoCrv";
            this.Mtb_CodigoCrv.Size = new System.Drawing.Size(120, 26);
            this.Mtb_CodigoCrv.TabIndex = 2;
            // 
            // Txb_Modelo
            // 
            this.Txb_Modelo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txb_Modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Modelo.Location = new System.Drawing.Point(661, 58);
            this.Txb_Modelo.Name = "Txb_Modelo";
            this.Txb_Modelo.Size = new System.Drawing.Size(207, 26);
            this.Txb_Modelo.TabIndex = 3;
            // 
            // Cbx_Marca
            // 
            this.Cbx_Marca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cbx_Marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cbx_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Marca.Enabled = false;
            this.Cbx_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_Marca.FormattingEnabled = true;
            this.Cbx_Marca.Location = new System.Drawing.Point(661, 145);
            this.Cbx_Marca.Name = "Cbx_Marca";
            this.Cbx_Marca.Size = new System.Drawing.Size(207, 28);
            this.Cbx_Marca.TabIndex = 6;
            this.Cbx_Marca.Click += new System.EventHandler(this.Cbx_Marca_Click);
            // 
            // Mtb_placa
            // 
            this.Mtb_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_placa.Location = new System.Drawing.Point(118, 146);
            this.Mtb_placa.Mask = "AAA 0000";
            this.Mtb_placa.Name = "Mtb_placa";
            this.Mtb_placa.Size = new System.Drawing.Size(129, 26);
            this.Mtb_placa.TabIndex = 4;
            // 
            // Txb_IdCarro
            // 
            this.Txb_IdCarro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txb_IdCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_IdCarro.Enabled = false;
            this.Txb_IdCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_IdCarro.Location = new System.Drawing.Point(118, 58);
            this.Txb_IdCarro.Name = "Txb_IdCarro";
            this.Txb_IdCarro.ReadOnly = true;
            this.Txb_IdCarro.Size = new System.Drawing.Size(129, 26);
            this.Txb_IdCarro.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "ID:";
            // 
            // dtv_carros
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtv_carros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_carros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtv_carros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtv_carros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtv_carros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtv_carros.Location = new System.Drawing.Point(0, 325);
            this.dtv_carros.Name = "dtv_carros";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_carros.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtv_carros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtv_carros.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtv_carros.Size = new System.Drawing.Size(952, 281);
            this.dtv_carros.TabIndex = 14;
            this.dtv_carros.DoubleClick += new System.EventHandler(this.dtv_carros_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Modelo do carro:*";
            // 
            // gbx2
            // 
            this.gbx2.Controls.Add(this.Cbx_chave);
            this.gbx2.Controls.Add(this.Cbx_instrucao);
            this.gbx2.Controls.Add(this.Cbx_macaco);
            this.gbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx2.Location = new System.Drawing.Point(360, 199);
            this.gbx2.Name = "gbx2";
            this.gbx2.Size = new System.Drawing.Size(260, 100);
            this.gbx2.TabIndex = 9;
            this.gbx2.TabStop = false;
            this.gbx2.Text = "Extras:";
            // 
            // Cbx_chave
            // 
            this.Cbx_chave.AutoSize = true;
            this.Cbx_chave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cbx_chave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_chave.Location = new System.Drawing.Point(16, 26);
            this.Cbx_chave.Name = "Cbx_chave";
            this.Cbx_chave.Size = new System.Drawing.Size(129, 24);
            this.Cbx_chave.TabIndex = 10;
            this.Cbx_chave.Text = "Chave reserva";
            this.Cbx_chave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cbx_chave.UseVisualStyleBackColor = true;
            // 
            // Cbx_instrucao
            // 
            this.Cbx_instrucao.AutoSize = true;
            this.Cbx_instrucao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cbx_instrucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_instrucao.Location = new System.Drawing.Point(155, 26);
            this.Cbx_instrucao.Name = "Cbx_instrucao";
            this.Cbx_instrucao.Size = new System.Drawing.Size(95, 24);
            this.Cbx_instrucao.TabIndex = 11;
            this.Cbx_instrucao.Text = "Instrução";
            this.Cbx_instrucao.UseVisualStyleBackColor = true;
            // 
            // Cbx_macaco
            // 
            this.Cbx_macaco.AutoSize = true;
            this.Cbx_macaco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cbx_macaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_macaco.Location = new System.Drawing.Point(16, 61);
            this.Cbx_macaco.Name = "Cbx_macaco";
            this.Cbx_macaco.Size = new System.Drawing.Size(84, 24);
            this.Cbx_macaco.TabIndex = 12;
            this.Cbx_macaco.Text = "Macaco";
            this.Cbx_macaco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cbx_macaco.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Número do renavam:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Número da placa:*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(657, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Cor:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Código do CRV:*";
            // 
            // gbx1
            // 
            this.gbx1.Controls.Add(this.Rbn_usado);
            this.gbx1.Controls.Add(this.Rbn_novo);
            this.gbx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx1.ForeColor = System.Drawing.Color.Black;
            this.gbx1.Location = new System.Drawing.Point(118, 199);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(164, 91);
            this.gbx1.TabIndex = 7;
            this.gbx1.TabStop = false;
            this.gbx1.Text = "Status do carro:*";
            // 
            // Rbn_usado
            // 
            this.Rbn_usado.AutoSize = true;
            this.Rbn_usado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rbn_usado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbn_usado.Location = new System.Drawing.Point(25, 23);
            this.Rbn_usado.Name = "Rbn_usado";
            this.Rbn_usado.Size = new System.Drawing.Size(114, 24);
            this.Rbn_usado.TabIndex = 8;
            this.Rbn_usado.TabStop = true;
            this.Rbn_usado.Text = "Carro usado";
            this.Rbn_usado.UseVisualStyleBackColor = true;
            this.Rbn_usado.CheckedChanged += new System.EventHandler(this.Rbn_usado_CheckedChanged);
            // 
            // Rbn_novo
            // 
            this.Rbn_novo.AutoSize = true;
            this.Rbn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rbn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbn_novo.Location = new System.Drawing.Point(25, 51);
            this.Rbn_novo.Name = "Rbn_novo";
            this.Rbn_novo.Size = new System.Drawing.Size(104, 24);
            this.Rbn_novo.TabIndex = 45;
            this.Rbn_novo.TabStop = true;
            this.Rbn_novo.Text = "Carro novo";
            this.Rbn_novo.UseVisualStyleBackColor = true;
            // 
            // Cbx_cor
            // 
            this.Cbx_cor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cbx_cor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cbx_cor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_cor.Enabled = false;
            this.Cbx_cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_cor.FormattingEnabled = true;
            this.Cbx_cor.Location = new System.Drawing.Point(661, 232);
            this.Cbx_cor.Name = "Cbx_cor";
            this.Cbx_cor.Size = new System.Drawing.Size(207, 28);
            this.Cbx_cor.TabIndex = 13;
            this.Cbx_cor.Click += new System.EventHandler(this.Cbx_cor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(657, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Marca do carro:*";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_cadastro
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1151, 707);
            this.Controls.Add(this.pnl_centro);
            this.Controls.Add(this.pnl_esquerda);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar veículos";
            this.Load += new System.EventHandler(this.Frm_cadastro_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_esquerda.ResumeLayout(false);
            this.pnl_centro.ResumeLayout(false);
            this.pnl_centro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_carros)).EndInit();
            this.gbx2.ResumeLayout(false);
            this.gbx2.PerformLayout();
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_limpar;
        private System.Windows.Forms.Button Btn_alterar;
        private System.Windows.Forms.Button Btn_sair;
        private System.Windows.Forms.Button Btn_remover;
        public System.Windows.Forms.TextBox Txb_pesquisa;
        private System.Windows.Forms.Button Btn_pesquisa;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button Btn_adicionar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnl_top;
        public System.Windows.Forms.Panel pnl_esquerda;
        public System.Windows.Forms.TextBox Txb_Modelo;
        protected System.Windows.Forms.ComboBox Cbx_Marca;
        private System.Windows.Forms.MaskedTextBox Mtb_placa;
        public System.Windows.Forms.TextBox Txb_IdCarro;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtv_carros;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.GroupBox gbx2;
        private System.Windows.Forms.CheckBox Cbx_chave;
        private System.Windows.Forms.CheckBox Cbx_instrucao;
        private System.Windows.Forms.CheckBox Cbx_macaco;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.RadioButton Rbn_usado;
        private System.Windows.Forms.RadioButton Rbn_novo;
        private System.Windows.Forms.ComboBox Cbx_cor;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox Mtb_CodigoCrv;
        private System.Windows.Forms.MaskedTextBox Mtb_renavam;
    }
}

