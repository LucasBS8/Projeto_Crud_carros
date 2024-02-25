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
    public partial class Frm_sobre : Form
    {
        public Frm_sobre()
        {
            InitializeComponent();
            trocaTema();
        }
        public void trocaTema()
        {
            Color pnlCenter;
            Color txtCenter;
            switch (Temas.tema)
            {

                case 0:

                    pnlCenter = Color.FromArgb(220, 224, 230);
                    txtCenter = Color.FromArgb(60, 65, 80);
                    mudarTemas(pnlCenter, txtCenter);
                    break;
                case 1:

                    pnlCenter = Color.White;
                    txtCenter = Color.FromArgb(31, 31, 32);
                    mudarTemas(pnlCenter, txtCenter);
                    break;
                case 2:


                    pnlCenter = Color.FromArgb(60, 65, 80);
                    txtCenter = Color.FromArgb(220, 224, 230);
                    mudarTemas(pnlCenter, txtCenter);
                    break;
                case 3:

                    pnlCenter = Color.FromArgb(60, 65, 80);
                    txtCenter = Color.FromArgb(220, 224, 230);
                    mudarTemas(pnlCenter, txtCenter);
                    break;
            }
        }

        public void mudarTemas(Color pnlCenter, Color txtCenter)
        {
            //frm
            BackColor = pnlCenter;

            //label

            label1.ForeColor = txtCenter;
            label2.ForeColor = txtCenter;
        }

        private void Frm_sobre_Load(object sender, EventArgs e)
        {
            trocaTema();
        }
    }
}
