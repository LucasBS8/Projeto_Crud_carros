namespace atv1
{
    partial class Frm_addMarcas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tcl_main = new System.Windows.Forms.TabControl();
            this.Tcl_marcas = new System.Windows.Forms.TabPage();
            this.Dtv_marcas = new System.Windows.Forms.DataGridView();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.Btn_pesquisaMarca = new System.Windows.Forms.Button();
            this.Txb_pesquisaMarca = new System.Windows.Forms.TextBox();
            this.lblMarca1 = new System.Windows.Forms.Label();
            this.Txb_idMarca = new System.Windows.Forms.TextBox();
            this.Txb_NomeMarca = new System.Windows.Forms.TextBox();
            this.lblMarca3 = new System.Windows.Forms.Label();
            this.Btn_adicionarMarca = new System.Windows.Forms.Button();
            this.Btn_alterarMarca = new System.Windows.Forms.Button();
            this.Btn_removerMarca = new System.Windows.Forms.Button();
            this.Btn_limparMarca = new System.Windows.Forms.Button();
            this.Tcl_cores = new System.Windows.Forms.TabPage();
            this.Dtv_cor = new System.Windows.Forms.DataGridView();
            this.Txb_nomeCor = new System.Windows.Forms.TextBox();
            this.lblCor2 = new System.Windows.Forms.Label();
            this.Btn_pesquisaCor = new System.Windows.Forms.Button();
            this.Txb_pesquisaCor = new System.Windows.Forms.TextBox();
            this.lblCor1 = new System.Windows.Forms.Label();
            this.Txb_idCor = new System.Windows.Forms.TextBox();
            this.lblCor3 = new System.Windows.Forms.Label();
            this.Btn_adicionarCor = new System.Windows.Forms.Button();
            this.Btn_alterarCor = new System.Windows.Forms.Button();
            this.Btn_removerCor = new System.Windows.Forms.Button();
            this.Btn_limparCor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tcl_main.SuspendLayout();
            this.Tcl_marcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_marcas)).BeginInit();
            this.Tcl_cores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_cor)).BeginInit();
            this.SuspendLayout();
            // 
            // Tcl_main
            // 
            this.Tcl_main.Controls.Add(this.Tcl_marcas);
            this.Tcl_main.Controls.Add(this.Tcl_cores);
            this.Tcl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tcl_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcl_main.Location = new System.Drawing.Point(0, 0);
            this.Tcl_main.Name = "Tcl_main";
            this.Tcl_main.SelectedIndex = 0;
            this.Tcl_main.Size = new System.Drawing.Size(515, 422);
            this.Tcl_main.TabIndex = 0;
            this.Tcl_main.TabStop = false;
            // 
            // Tcl_marcas
            // 
            this.Tcl_marcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Tcl_marcas.Controls.Add(this.Dtv_marcas);
            this.Tcl_marcas.Controls.Add(this.lblMarca2);
            this.Tcl_marcas.Controls.Add(this.Btn_pesquisaMarca);
            this.Tcl_marcas.Controls.Add(this.Txb_pesquisaMarca);
            this.Tcl_marcas.Controls.Add(this.lblMarca1);
            this.Tcl_marcas.Controls.Add(this.Txb_idMarca);
            this.Tcl_marcas.Controls.Add(this.Txb_NomeMarca);
            this.Tcl_marcas.Controls.Add(this.lblMarca3);
            this.Tcl_marcas.Controls.Add(this.Btn_adicionarMarca);
            this.Tcl_marcas.Controls.Add(this.Btn_alterarMarca);
            this.Tcl_marcas.Controls.Add(this.Btn_removerMarca);
            this.Tcl_marcas.Controls.Add(this.Btn_limparMarca);
            this.Tcl_marcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcl_marcas.Location = new System.Drawing.Point(4, 29);
            this.Tcl_marcas.Name = "Tcl_marcas";
            this.Tcl_marcas.Padding = new System.Windows.Forms.Padding(3);
            this.Tcl_marcas.Size = new System.Drawing.Size(507, 389);
            this.Tcl_marcas.TabIndex = 0;
            this.Tcl_marcas.Text = "Marcas";
            // 
            // Dtv_marcas
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtv_marcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_marcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtv_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_marcas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dtv_marcas.Location = new System.Drawing.Point(3, 225);
            this.Dtv_marcas.Name = "Dtv_marcas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_marcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dtv_marcas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dtv_marcas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dtv_marcas.Size = new System.Drawing.Size(501, 161);
            this.Dtv_marcas.TabIndex = 8;
            this.Dtv_marcas.DoubleClick += new System.EventHandler(this.Dtv_marcas_DoubleClick);
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca2.Location = new System.Drawing.Point(176, 9);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(142, 20);
            this.lblMarca2.TabIndex = 59;
            this.lblMarca2.Text = "Pesquisar nome:";
            // 
            // Btn_pesquisaMarca
            // 
            this.Btn_pesquisaMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Btn_pesquisaMarca.BackgroundImage = global::atv1.Properties.Resources.procurar;
            this.Btn_pesquisaMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_pesquisaMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_pesquisaMarca.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_pesquisaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_pesquisaMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_pesquisaMarca.Location = new System.Drawing.Point(470, 4);
            this.Btn_pesquisaMarca.Name = "Btn_pesquisaMarca";
            this.Btn_pesquisaMarca.Size = new System.Drawing.Size(31, 31);
            this.Btn_pesquisaMarca.TabIndex = 2;
            this.Btn_pesquisaMarca.UseVisualStyleBackColor = false;
            this.Btn_pesquisaMarca.Click += new System.EventHandler(this.Btn_pesquisaMarca_Click);
            // 
            // Txb_pesquisaMarca
            // 
            this.Txb_pesquisaMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Txb_pesquisaMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_pesquisaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_pesquisaMarca.Location = new System.Drawing.Point(326, 6);
            this.Txb_pesquisaMarca.Name = "Txb_pesquisaMarca";
            this.Txb_pesquisaMarca.Size = new System.Drawing.Size(175, 26);
            this.Txb_pesquisaMarca.TabIndex = 1;
            // 
            // lblMarca1
            // 
            this.lblMarca1.AutoSize = true;
            this.lblMarca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca1.Location = new System.Drawing.Point(12, 10);
            this.lblMarca1.Name = "lblMarca1";
            this.lblMarca1.Size = new System.Drawing.Size(30, 20);
            this.lblMarca1.TabIndex = 56;
            this.lblMarca1.Text = "Id:";
            // 
            // Txb_idMarca
            // 
            this.Txb_idMarca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txb_idMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_idMarca.Enabled = false;
            this.Txb_idMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_idMarca.Location = new System.Drawing.Point(48, 6);
            this.Txb_idMarca.Name = "Txb_idMarca";
            this.Txb_idMarca.ReadOnly = true;
            this.Txb_idMarca.Size = new System.Drawing.Size(49, 26);
            this.Txb_idMarca.TabIndex = 55;
            // 
            // Txb_NomeMarca
            // 
            this.Txb_NomeMarca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txb_NomeMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_NomeMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_NomeMarca.Location = new System.Drawing.Point(246, 89);
            this.Txb_NomeMarca.Name = "Txb_NomeMarca";
            this.Txb_NomeMarca.Size = new System.Drawing.Size(129, 26);
            this.Txb_NomeMarca.TabIndex = 3;
            // 
            // lblMarca3
            // 
            this.lblMarca3.AutoSize = true;
            this.lblMarca3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca3.Location = new System.Drawing.Point(101, 91);
            this.lblMarca3.Name = "lblMarca3";
            this.lblMarca3.Size = new System.Drawing.Size(139, 20);
            this.lblMarca3.TabIndex = 54;
            this.lblMarca3.Text = "Nome da marca:";
            // 
            // Btn_adicionarMarca
            // 
            this.Btn_adicionarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btn_adicionarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_adicionarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_adicionarMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_adicionarMarca.FlatAppearance.BorderSize = 0;
            this.Btn_adicionarMarca.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_adicionarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_adicionarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_adicionarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_adicionarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_adicionarMarca.Location = new System.Drawing.Point(21, 162);
            this.Btn_adicionarMarca.Name = "Btn_adicionarMarca";
            this.Btn_adicionarMarca.Size = new System.Drawing.Size(95, 30);
            this.Btn_adicionarMarca.TabIndex = 4;
            this.Btn_adicionarMarca.Text = "Adicionar";
            this.Btn_adicionarMarca.UseVisualStyleBackColor = false;
            this.Btn_adicionarMarca.Click += new System.EventHandler(this.Btn_adicionarMarca_Click);
            // 
            // Btn_alterarMarca
            // 
            this.Btn_alterarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btn_alterarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_alterarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_alterarMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_alterarMarca.FlatAppearance.BorderSize = 0;
            this.Btn_alterarMarca.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_alterarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_alterarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_alterarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_alterarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_alterarMarca.Location = new System.Drawing.Point(271, 162);
            this.Btn_alterarMarca.Name = "Btn_alterarMarca";
            this.Btn_alterarMarca.Size = new System.Drawing.Size(95, 30);
            this.Btn_alterarMarca.TabIndex = 6;
            this.Btn_alterarMarca.Text = "Alterar dados";
            this.Btn_alterarMarca.UseVisualStyleBackColor = false;
            this.Btn_alterarMarca.Click += new System.EventHandler(this.Btn_alterarMarca_Click);
            // 
            // Btn_removerMarca
            // 
            this.Btn_removerMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btn_removerMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_removerMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_removerMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_removerMarca.FlatAppearance.BorderSize = 0;
            this.Btn_removerMarca.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_removerMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_removerMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_removerMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_removerMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_removerMarca.Location = new System.Drawing.Point(146, 162);
            this.Btn_removerMarca.Name = "Btn_removerMarca";
            this.Btn_removerMarca.Size = new System.Drawing.Size(95, 30);
            this.Btn_removerMarca.TabIndex = 5;
            this.Btn_removerMarca.Text = "Remover cadastro";
            this.Btn_removerMarca.UseVisualStyleBackColor = false;
            this.Btn_removerMarca.Click += new System.EventHandler(this.Btn_removerMarca_Click);
            // 
            // Btn_limparMarca
            // 
            this.Btn_limparMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btn_limparMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_limparMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_limparMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_limparMarca.FlatAppearance.BorderSize = 0;
            this.Btn_limparMarca.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_limparMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_limparMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_limparMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limparMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_limparMarca.Location = new System.Drawing.Point(396, 162);
            this.Btn_limparMarca.Name = "Btn_limparMarca";
            this.Btn_limparMarca.Size = new System.Drawing.Size(95, 30);
            this.Btn_limparMarca.TabIndex = 7;
            this.Btn_limparMarca.Text = "Limpar";
            this.Btn_limparMarca.UseVisualStyleBackColor = false;
            this.Btn_limparMarca.Click += new System.EventHandler(this.Btn_limparMarca_Click);
            // 
            // Tcl_cores
            // 
            this.Tcl_cores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Tcl_cores.Controls.Add(this.Dtv_cor);
            this.Tcl_cores.Controls.Add(this.Txb_nomeCor);
            this.Tcl_cores.Controls.Add(this.lblCor2);
            this.Tcl_cores.Controls.Add(this.Btn_pesquisaCor);
            this.Tcl_cores.Controls.Add(this.Txb_pesquisaCor);
            this.Tcl_cores.Controls.Add(this.lblCor1);
            this.Tcl_cores.Controls.Add(this.Txb_idCor);
            this.Tcl_cores.Controls.Add(this.lblCor3);
            this.Tcl_cores.Controls.Add(this.Btn_adicionarCor);
            this.Tcl_cores.Controls.Add(this.Btn_alterarCor);
            this.Tcl_cores.Controls.Add(this.Btn_removerCor);
            this.Tcl_cores.Controls.Add(this.Btn_limparCor);
            this.Tcl_cores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcl_cores.Location = new System.Drawing.Point(4, 22);
            this.Tcl_cores.Name = "Tcl_cores";
            this.Tcl_cores.Padding = new System.Windows.Forms.Padding(3);
            this.Tcl_cores.Size = new System.Drawing.Size(507, 396);
            this.Tcl_cores.TabIndex = 1;
            this.Tcl_cores.Text = "Cores";
            // 
            // Dtv_cor
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtv_cor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_cor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dtv_cor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_cor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dtv_cor.Location = new System.Drawing.Point(3, 232);
            this.Dtv_cor.Name = "Dtv_cor";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_cor.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Dtv_cor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dtv_cor.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Dtv_cor.Size = new System.Drawing.Size(501, 161);
            this.Dtv_cor.TabIndex = 8;
            this.Dtv_cor.DoubleClick += new System.EventHandler(this.Dtv_cor_DoubleClick);
            // 
            // Txb_nomeCor
            // 
            this.Txb_nomeCor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txb_nomeCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_nomeCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_nomeCor.Location = new System.Drawing.Point(231, 89);
            this.Txb_nomeCor.Name = "Txb_nomeCor";
            this.Txb_nomeCor.Size = new System.Drawing.Size(129, 26);
            this.Txb_nomeCor.TabIndex = 3;
            // 
            // lblCor2
            // 
            this.lblCor2.AutoSize = true;
            this.lblCor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor2.Location = new System.Drawing.Point(176, 9);
            this.lblCor2.Name = "lblCor2";
            this.lblCor2.Size = new System.Drawing.Size(142, 20);
            this.lblCor2.TabIndex = 68;
            this.lblCor2.Text = "Pesquisar nome:";
            // 
            // Btn_pesquisaCor
            // 
            this.Btn_pesquisaCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Btn_pesquisaCor.BackgroundImage = global::atv1.Properties.Resources.procurar;
            this.Btn_pesquisaCor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_pesquisaCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_pesquisaCor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_pesquisaCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_pesquisaCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_pesquisaCor.Location = new System.Drawing.Point(470, 4);
            this.Btn_pesquisaCor.Name = "Btn_pesquisaCor";
            this.Btn_pesquisaCor.Size = new System.Drawing.Size(31, 31);
            this.Btn_pesquisaCor.TabIndex = 2;
            this.Btn_pesquisaCor.UseVisualStyleBackColor = false;
            this.Btn_pesquisaCor.Click += new System.EventHandler(this.Btn_pesquisaCor_Click);
            // 
            // Txb_pesquisaCor
            // 
            this.Txb_pesquisaCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.Txb_pesquisaCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_pesquisaCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_pesquisaCor.Location = new System.Drawing.Point(326, 6);
            this.Txb_pesquisaCor.Name = "Txb_pesquisaCor";
            this.Txb_pesquisaCor.Size = new System.Drawing.Size(175, 26);
            this.Txb_pesquisaCor.TabIndex = 1;
            // 
            // lblCor1
            // 
            this.lblCor1.AutoSize = true;
            this.lblCor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor1.Location = new System.Drawing.Point(12, 10);
            this.lblCor1.Name = "lblCor1";
            this.lblCor1.Size = new System.Drawing.Size(30, 20);
            this.lblCor1.TabIndex = 65;
            this.lblCor1.Text = "Id:";
            // 
            // Txb_idCor
            // 
            this.Txb_idCor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txb_idCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_idCor.Enabled = false;
            this.Txb_idCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_idCor.Location = new System.Drawing.Point(48, 6);
            this.Txb_idCor.Name = "Txb_idCor";
            this.Txb_idCor.ReadOnly = true;
            this.Txb_idCor.Size = new System.Drawing.Size(49, 26);
            this.Txb_idCor.TabIndex = 64;
            // 
            // lblCor3
            // 
            this.lblCor3.AutoSize = true;
            this.lblCor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor3.Location = new System.Drawing.Point(110, 91);
            this.lblCor3.Name = "lblCor3";
            this.lblCor3.Size = new System.Drawing.Size(115, 20);
            this.lblCor3.TabIndex = 63;
            this.lblCor3.Text = "Nome da cor:";
            // 
            // Btn_adicionarCor
            // 
            this.Btn_adicionarCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btn_adicionarCor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_adicionarCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_adicionarCor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_adicionarCor.FlatAppearance.BorderSize = 0;
            this.Btn_adicionarCor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_adicionarCor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_adicionarCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_adicionarCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_adicionarCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_adicionarCor.Location = new System.Drawing.Point(21, 162);
            this.Btn_adicionarCor.Name = "Btn_adicionarCor";
            this.Btn_adicionarCor.Size = new System.Drawing.Size(95, 30);
            this.Btn_adicionarCor.TabIndex = 4;
            this.Btn_adicionarCor.Text = "Adicionar";
            this.Btn_adicionarCor.UseVisualStyleBackColor = false;
            this.Btn_adicionarCor.Click += new System.EventHandler(this.Btn_adicionarCor_Click);
            // 
            // Btn_alterarCor
            // 
            this.Btn_alterarCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btn_alterarCor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_alterarCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_alterarCor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_alterarCor.FlatAppearance.BorderSize = 0;
            this.Btn_alterarCor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_alterarCor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_alterarCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_alterarCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_alterarCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_alterarCor.Location = new System.Drawing.Point(271, 162);
            this.Btn_alterarCor.Name = "Btn_alterarCor";
            this.Btn_alterarCor.Size = new System.Drawing.Size(95, 30);
            this.Btn_alterarCor.TabIndex = 6;
            this.Btn_alterarCor.Text = "Alterar dados";
            this.Btn_alterarCor.UseVisualStyleBackColor = false;
            this.Btn_alterarCor.Click += new System.EventHandler(this.Btn_alterarCor_Click);
            // 
            // Btn_removerCor
            // 
            this.Btn_removerCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btn_removerCor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_removerCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_removerCor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_removerCor.FlatAppearance.BorderSize = 0;
            this.Btn_removerCor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_removerCor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_removerCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_removerCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_removerCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_removerCor.Location = new System.Drawing.Point(146, 162);
            this.Btn_removerCor.Name = "Btn_removerCor";
            this.Btn_removerCor.Size = new System.Drawing.Size(95, 30);
            this.Btn_removerCor.TabIndex = 5;
            this.Btn_removerCor.Text = "Remover cadastro";
            this.Btn_removerCor.UseVisualStyleBackColor = false;
            this.Btn_removerCor.Click += new System.EventHandler(this.Btn_removerCor_Click);
            // 
            // Btn_limparCor
            // 
            this.Btn_limparCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btn_limparCor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_limparCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_limparCor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_limparCor.FlatAppearance.BorderSize = 0;
            this.Btn_limparCor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.Btn_limparCor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.Btn_limparCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_limparCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limparCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Btn_limparCor.Location = new System.Drawing.Point(396, 162);
            this.Btn_limparCor.Name = "Btn_limparCor";
            this.Btn_limparCor.Size = new System.Drawing.Size(95, 30);
            this.Btn_limparCor.TabIndex = 7;
            this.Btn_limparCor.Text = "Limpar";
            this.Btn_limparCor.UseVisualStyleBackColor = false;
            this.Btn_limparCor.Click += new System.EventHandler(this.Btn_limparCor_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_addMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(515, 422);
            this.Controls.Add(this.Tcl_main);
            this.Name = "Frm_addMarcas";
            this.Text = "Frm_addMarcas";
            this.Load += new System.EventHandler(this.Frm_addMarcas_Load);
            this.Tcl_main.ResumeLayout(false);
            this.Tcl_marcas.ResumeLayout(false);
            this.Tcl_marcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_marcas)).EndInit();
            this.Tcl_cores.ResumeLayout(false);
            this.Tcl_cores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_cor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tcl_main;
        private System.Windows.Forms.TabPage Tcl_marcas;
        private System.Windows.Forms.TabPage Tcl_cores;
        private System.Windows.Forms.Button Btn_adicionarMarca;
        private System.Windows.Forms.Button Btn_alterarMarca;
        private System.Windows.Forms.Button Btn_removerMarca;
        private System.Windows.Forms.Button Btn_limparMarca;
        public System.Windows.Forms.Label lblMarca1;
        public System.Windows.Forms.TextBox Txb_idMarca;
        public System.Windows.Forms.TextBox Txb_NomeMarca;
        public System.Windows.Forms.Label lblMarca3;
        public System.Windows.Forms.Label lblCor1;
        public System.Windows.Forms.TextBox Txb_idCor;
        public System.Windows.Forms.Label lblCor3;
        private System.Windows.Forms.Button Btn_adicionarCor;
        private System.Windows.Forms.Button Btn_alterarCor;
        private System.Windows.Forms.Button Btn_removerCor;
        private System.Windows.Forms.Button Btn_limparCor;
        private System.Windows.Forms.Button Btn_pesquisaMarca;
        public System.Windows.Forms.TextBox Txb_pesquisaMarca;
        private System.Windows.Forms.Button Btn_pesquisaCor;
        public System.Windows.Forms.TextBox Txb_pesquisaCor;
        public System.Windows.Forms.Label lblMarca2;
        public System.Windows.Forms.Label lblCor2;
        public System.Windows.Forms.TextBox Txb_nomeCor;
        private System.Windows.Forms.DataGridView Dtv_marcas;
        private System.Windows.Forms.DataGridView Dtv_cor;
        private System.Windows.Forms.Timer timer1;
    }
}