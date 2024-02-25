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
    public partial class Frm_temas : Form

    {
        public Frm_temas()
        {
            InitializeComponent();
            trocaTema();
        }

        private void rbn_claro_Click(object sender, EventArgs e)
        {
            Temas.tema = 1;
            Temas.active = true;
            trocaTema();
        }

        private void rbn_escuroTotal_Click(object sender, EventArgs e)
        {
            Temas.tema = 3;
            Temas.active = true;
            trocaTema();

        }

        private void rbn_escuro_Click(object sender, EventArgs e)
        {
            Temas.tema = 2;
            Temas.active = true;
            trocaTema();
        }

        private void rbn_normal_Click(object sender, EventArgs e)
        {
            Temas.tema = 0;
            Temas.active = true;
            trocaTema();

        }

        public void trocaTema()
        {
            Color frm;
            Color panel;
            Color lblTitle;
            Color txtRbns;
            switch (Temas.tema)
            {

                case 0:
                    rbn_normal.Checked = true;
                    frm = Color.FromArgb(220, 224, 230);
                    panel = Color.FromArgb(86, 126, 187);
                    lblTitle = Color.FromArgb(60, 65, 80);
                    txtRbns = Color.FromArgb(60, 65, 80);
                    mudarTemas(frm, txtRbns, lblTitle, panel);
                    break;
                case 1:
                    rbn_claro.Checked = true;
                    frm = Color.White;
                    panel = Color.FromArgb(200, 215, 240);
                    lblTitle = Color.FromArgb(86, 126, 187);
                    txtRbns = Color.FromArgb(31, 31, 32);
                    mudarTemas(frm, txtRbns, lblTitle, panel);
                    break;
                case 2:

                    rbn_escuro.Checked = true;
                    frm = Color.FromArgb(60, 65, 80);
                    panel = Color.FromArgb(86, 126, 187);
                    lblTitle = Color.FromArgb(220, 224, 230);
                    txtRbns = Color.FromArgb(220, 224, 230);
                    mudarTemas(frm, txtRbns, lblTitle, panel);
                    break;
                case 3:
                    rbn_escuroTotal.Checked = true;
                    frm = Color.FromArgb(60, 65, 80);
                    panel = Color.FromArgb(20, 25, 30);
                    lblTitle = Color.FromArgb(220, 224, 230);
                    txtRbns = Color.FromArgb(220, 224, 230);
                    mudarTemas(frm, txtRbns, lblTitle, panel);
                    break;
            }
            Temas.activeTemas = false;
        }


        public void mudarTemas(Color frm, Color txtRbns, Color lblTitle, Color panel)
        {
            
            //frm
            BackColor = frm;
            ForeColor = lblTitle;

            //buttons
            rbn_normal.ForeColor = txtRbns;
            rbn_claro.ForeColor = txtRbns;
            rbn_escuro.ForeColor = txtRbns;
            rbn_escuroTotal.ForeColor = txtRbns;

            //label
            label1.ForeColor = lblTitle;
            label2.ForeColor = lblTitle;
            label3.ForeColor = lblTitle;

            //panel
            panel1.BackColor = panel;
            panel2.BackColor = panel;
        }
    }
}
