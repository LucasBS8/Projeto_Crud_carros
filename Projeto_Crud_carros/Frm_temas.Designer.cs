namespace atv1
{
    partial class Frm_temas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbn_normal = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbn_claro = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbn_escuro = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.rbn_escuroTotal = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUNDO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.panel1.Location = new System.Drawing.Point(-20, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 5);
            this.panel1.TabIndex = 1;
            // 
            // rbn_normal
            // 
            this.rbn_normal.AutoSize = true;
            this.rbn_normal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbn_normal.Location = new System.Drawing.Point(59, 132);
            this.rbn_normal.Name = "rbn_normal";
            this.rbn_normal.Size = new System.Drawing.Size(86, 17);
            this.rbn_normal.TabIndex = 1;
            this.rbn_normal.TabStop = true;
            this.rbn_normal.Text = "Tema normal";
            this.rbn_normal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbn_normal.UseVisualStyleBackColor = true;
            this.rbn_normal.Click += new System.EventHandler(this.rbn_normal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::atv1.Properties.Resources.brancoNormal;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(59, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rbn_claro
            // 
            this.rbn_claro.AutoSize = true;
            this.rbn_claro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbn_claro.Location = new System.Drawing.Point(316, 132);
            this.rbn_claro.Name = "rbn_claro";
            this.rbn_claro.Size = new System.Drawing.Size(78, 17);
            this.rbn_claro.TabIndex = 2;
            this.rbn_claro.TabStop = true;
            this.rbn_claro.Text = "Tema claro";
            this.rbn_claro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbn_claro.UseVisualStyleBackColor = true;
            this.rbn_claro.Click += new System.EventHandler(this.rbn_claro_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::atv1.Properties.Resources.brancoTotal;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(316, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 65);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // rbn_escuro
            // 
            this.rbn_escuro.AutoSize = true;
            this.rbn_escuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbn_escuro.Location = new System.Drawing.Point(59, 336);
            this.rbn_escuro.Name = "rbn_escuro";
            this.rbn_escuro.Size = new System.Drawing.Size(87, 17);
            this.rbn_escuro.TabIndex = 3;
            this.rbn_escuro.TabStop = true;
            this.rbn_escuro.Text = "Tema escuro";
            this.rbn_escuro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbn_escuro.UseVisualStyleBackColor = true;
            this.rbn_escuro.Click += new System.EventHandler(this.rbn_escuro_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::atv1.Properties.Resources.normalEscuro;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(59, 359);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 65);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // rbn_escuroTotal
            // 
            this.rbn_escuroTotal.AutoSize = true;
            this.rbn_escuroTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbn_escuroTotal.Location = new System.Drawing.Point(316, 336);
            this.rbn_escuroTotal.Name = "rbn_escuroTotal";
            this.rbn_escuroTotal.Size = new System.Drawing.Size(110, 17);
            this.rbn_escuroTotal.TabIndex = 4;
            this.rbn_escuroTotal.TabStop = true;
            this.rbn_escuroTotal.Text = "Tema escuro total";
            this.rbn_escuroTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbn_escuroTotal.UseVisualStyleBackColor = true;
            this.rbn_escuroTotal.Click += new System.EventHandler(this.rbn_escuroTotal_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::atv1.Properties.Resources.totalEscuro;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(316, 359);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 65);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.panel2.Location = new System.Drawing.Point(-11, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 5);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Temas escuros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Temas claros";
            // 
            // Frm_temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(531, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.rbn_escuroTotal);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.rbn_escuro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rbn_claro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbn_normal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_temas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_temas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbn_normal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbn_claro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbn_escuro;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton rbn_escuroTotal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}