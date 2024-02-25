using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv1
{
    public partial class Frm_config : Form
    {
        public Frm_config()
        {
            InitializeComponent();
            trocaTema();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //método genérico para abrir formulários no panel de conteúdo
        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = pnl_conteudo.Controls.OfType<Forms>().FirstOrDefault();
            {
                if (formulario == null)
                {
                    formulario = new Forms();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    pnl_conteudo.Controls.Add(formulario);
                    pnl_conteudo.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                }
                else
                {
                    if (formulario.WindowState == FormWindowState.Minimized)
                    {
                        formulario.WindowState = FormWindowState.Normal;
                    }
                    formulario.BringToFront();
                }
            }
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {

            AbrirFormNoPanel<Frm_temas>();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Frm_addMarcas>();
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Frm_sobre>();
        }

        private void Frm_config_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Temas.active == true)
            {
                trocaTema();
            }
        }
        public void trocaTema()
        {
            Color pnlCenter;
            Color pnlBord;
            Color btns;
            Color lblTitle;
            Color txtBtn;
            switch (Temas.tema)
            {
                case 0:
                    pnlCenter = Color.FromArgb(220, 224, 230);
                    pnlBord = Color.FromArgb(86, 126, 187);
                    btns = Color.FromArgb(220, 224, 230);
                    lblTitle = Color.FromArgb(220, 224, 230);
                    txtBtn = Color.FromArgb(31, 31, 32);
                    mudarTemas(pnlBord, pnlCenter, btns,
                        lblTitle, txtBtn);
                    break;
                case 1:
                    pnlCenter = Color.White;
                    pnlBord = Color.FromArgb(200, 215, 240);
                    btns = Color.White;
                    lblTitle = Color.FromArgb(86, 126, 187);
                    txtBtn = Color.FromArgb(31, 31, 32);
                    mudarTemas(pnlBord, pnlCenter, btns,
                        lblTitle, txtBtn);
                    break;
                case 2:
                    pnlCenter = Color.FromArgb(60, 65, 80);
                    pnlBord = Color.FromArgb(86, 126, 187);
                    btns = Color.FromArgb(60, 65, 80);
                    lblTitle = Color.FromArgb(220, 224, 230);
                    txtBtn = Color.FromArgb(220, 224, 230);
                    mudarTemas(pnlBord, pnlCenter, btns,
                        lblTitle, txtBtn);
                    break;
                case 3:
                    pnlCenter = Color.FromArgb(60, 65, 80);
                    pnlBord = Color.FromArgb(20, 25, 30);
                    btns = Color.FromArgb(60, 65, 80);
                    lblTitle = Color.FromArgb(220, 224, 230);
                    txtBtn = Color.FromArgb(220, 224, 230);
                    mudarTemas(pnlBord, pnlCenter, btns,
                        lblTitle, txtBtn);
                    break;
            }
            Temas.activeConfig = false;
        }

        public void mudarTemas(Color pnlBord, Color pnlCenter, Color btns, Color lblTitle,
            Color txtBtn)
        {
            //panel
            panel1.BackColor = pnlBord;
            pnl_conteudo.BackColor = pnlCenter;

            //buttons
            Btn_add.BackColor = btns;
            Btn_Fundo.BackColor = btns;
            Btn_voltar.BackColor = btns;
            btn_sobre.BackColor = btns;

            //label
            label1.ForeColor = lblTitle;

            //text Button
            Btn_add.ForeColor = txtBtn;
            Btn_Fundo.ForeColor = txtBtn;
            Btn_voltar.ForeColor = txtBtn;
            btn_sobre.ForeColor = txtBtn;
        }

    }
}
