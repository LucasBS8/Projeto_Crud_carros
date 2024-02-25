using MySql.Data.MySqlClient;
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
    public partial class Frm_addMarcas : Form
    {
        Marcas marcas = new Marcas();
        Cores cores = new Cores();  
        public Frm_addMarcas()
        {
            InitializeComponent();
            atualizarDataGridMarcas();
            atualizarDataGridCores();
            trocaTema();
        }

        private void limpar()
        {
            Txb_idMarca.Text = "";
            Txb_NomeMarca.Text = "";
            Txb_pesquisaMarca.Text = "";
            Txb_idCor.Text = "";
            Txb_nomeCor.Text = "";
            Txb_pesquisaCor.Text = "";
        }

        //CRUD marcas
        private void atualizarDataGridMarcas()
        {
            MySqlDataReader temp = marcas.listarMarcas();
            DataTable dt = new DataTable();
            dt.Load(temp);
            Dtv_marcas.DataSource = dt;
        }
        private void Dtv_marcas_DoubleClick(object sender, EventArgs e)
        {
            int linhaAtual = 0;
            linhaAtual = Dtv_marcas.CurrentRow.Index;
            try
            {
                Txb_idMarca.Text = Dtv_marcas[0, linhaAtual].Value.ToString();
                Txb_NomeMarca.Text = Dtv_marcas[1, linhaAtual].Value.ToString();
            }
            catch
            {
                MessageBox.Show("ERRO no preenchimento dos dados.");
            }
        }

        private void Btn_alterarMarca_Click(object sender, EventArgs e)
        {
            if (Txb_idMarca.Text != "")
            {
                this.marcas.nome = Txb_NomeMarca.Text;
                this.marcas.id = Convert.ToInt32(Txb_idMarca.Text);

                this.marcas.alterarCadastro();
                MessageBox.Show("Valores alterados com sucesso.");
                limpar();
                atualizarDataGridMarcas();
            }
            else
            {
                MessageBox.Show("O campo de pesquisa está vazio.");
            }
        }

        private void Btn_limparMarca_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void Btn_removerMarca_Click(object sender, EventArgs e)
        {
            if (Txb_NomeMarca.Text != "")
            {
                if (MessageBox.Show("Tem certeza que deseja remover essa marca?", "Confirmar", MessageBoxButtons.
                   YesNoCancel) == DialogResult.Yes)
                {
                    if (Txb_idMarca.Text != "")
                    {
                        this.marcas.id = int.Parse(this.Txb_idMarca.Text);
                        this.marcas.excluirCadastro();
                        atualizarDataGridMarcas();
                        limpar();
                    }
                }
            }
            else
            {
                MessageBox.Show("O campo de pesquisa está vazio.");
            }
        }

        private void Btn_adicionarMarca_Click(object sender, EventArgs e)
        {
            if (Txb_NomeMarca.Text == "")
            {
                MessageBox.Show("Nenhuma marca foi escrita");
            }
            else
            {

                this.marcas.nome = Txb_NomeMarca.Text;

                this.marcas.cadastrarMarcas();

                MessageBox.Show("Cadastro realizado com sucesso.");
            }
            atualizarDataGridMarcas();
            limpar();
            marcas.attCbx = true;
        }

        private void Btn_pesquisaMarca_Click(object sender, EventArgs e)
        {
            if (Txb_pesquisaMarca.Text != "")
            {
                String filtro = Txb_pesquisaMarca.Text;
                MySqlDataReader temp = this.marcas.listarMarcaPorOk(filtro);
                DataTable dt = new DataTable();
                dt.Load(temp);
                Dtv_marcas.DataSource = dt;
            }

            else
            {
                atualizarDataGridMarcas();
            }
        }

        //CRUD cores
        private void atualizarDataGridCores()
        {
            MySqlDataReader temp = cores.listarCores();
            DataTable dt = new DataTable();
            dt.Load(temp);
            Dtv_cor.DataSource = dt;
        }
        private void Dtv_cor_DoubleClick(object sender, EventArgs e)
        {
            int linhaAtual = 0;
            linhaAtual = Dtv_cor.CurrentRow.Index;
            try
            {
                Txb_idCor.Text = Dtv_cor[0, linhaAtual].Value.ToString();
                Txb_nomeCor.Text = Dtv_cor[1, linhaAtual].Value.ToString();
            }
            catch
            {
                MessageBox.Show("ERRO no preenchimento dos dados.");
            }
        }

        private void Btn_alterarCor_Click(object sender, EventArgs e)
        {
            if (Txb_idCor.Text != "")
            {
                //CADASTRO CARROS
                this.cores.nome = Txb_nomeCor.Text;
                this.cores.id = Convert.ToInt32(Txb_idCor.Text);

                this.cores.alterarCadastro();
                MessageBox.Show("Valor alterados com sucesso.");
                limpar();
                atualizarDataGridCores();
            }
            else
            {
                MessageBox.Show("O campo de pesquisa está vazio.");
            }
        }

        private void Btn_limparCor_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void Btn_removerCor_Click(object sender, EventArgs e)
        {
            if (Txb_nomeCor.Text != "")
            {
                if (MessageBox.Show("Tem certeza que deseja remover essa cor?", "Confirmar", MessageBoxButtons.
                   YesNoCancel) == DialogResult.Yes)
                {
                    if (Txb_idCor.Text != "")
                    {
                        this.cores.id = int.Parse(this.Txb_idCor.Text);
                        this.cores.excluirCadastro();
                        atualizarDataGridCores();
                        limpar();
                    }
                }
            }
            else
            {
                MessageBox.Show("O campo de pesquisa está vazio.");
            }
        }

        private void Btn_adicionarCor_Click(object sender, EventArgs e)
        {
            if (Txb_nomeCor.Text == "")
            {
                MessageBox.Show("Nenhuma cor foi escrita");
            }
            else
            {

                //CADASTRO CARROS
                this.cores.nome = Txb_nomeCor.Text;

                this.cores.cadastrarCores();

                MessageBox.Show("Cadastro realizado com sucesso.");
            }
            atualizarDataGridCores();
            limpar();
            cores.attCbx = true;
        }

        private void Btn_pesquisaCor_Click(object sender, EventArgs e)
        {
            if (Txb_pesquisaMarca.Text != "")
            {
                String filtro = Txb_pesquisaCor.Text;
                MySqlDataReader temp = this.cores.listarCorPorOk(filtro);
                DataTable dt = new DataTable();
                dt.Load(temp);
                Dtv_marcas.DataSource = dt;
            }

            else
            {
                atualizarDataGridCores();
            }
        }

        public void trocaTema()
        {
            Color tclCenter;
            Color btns;
            Color lblTitle;
            Color txtCenter;
            Color txtBtn;
            switch (Temas.tema)
            {

                case 0:

                    tclCenter = Color.FromArgb(220, 224, 230);
                    btns = Color.FromArgb(86, 126, 187);
                    lblTitle = Color.FromArgb(220, 224, 230);
                    txtCenter = Color.FromArgb(31, 31, 32);
                    txtBtn = Color.FromArgb(31, 31, 32);
                    mudarTemas(tclCenter, btns,
                        lblTitle, txtCenter, txtBtn);
                    break;
                case 1:

                    tclCenter = Color.White;
                    btns = Color.FromArgb(86, 126, 187);
                    lblTitle = Color.FromArgb(86, 126, 187);
                    txtCenter = Color.FromArgb(31, 31, 32);
                    txtBtn = Color.FromArgb(31, 31, 32);
                    mudarTemas(tclCenter, btns,
                        lblTitle, txtCenter, txtBtn);
                    break;
                case 2:


                    tclCenter = Color.FromArgb(60, 65, 80);
                    btns = Color.FromArgb(86, 126, 187);
                    lblTitle = Color.FromArgb(220, 224, 230);
                    txtCenter = Color.FromArgb(220, 224, 230);
                    txtBtn = Color.FromArgb(220, 224, 230);
                    mudarTemas(tclCenter, btns,
                        lblTitle, txtCenter, txtBtn);
                    break;
                case 3:

                    tclCenter = Color.FromArgb(60, 65, 80);
                    btns = Color.FromArgb(20, 25, 30);
                    lblTitle = Color.FromArgb(220, 224, 230);
                    txtCenter = Color.FromArgb(220, 224, 230);
                    txtBtn = Color.FromArgb(220, 224, 230);
                    mudarTemas(tclCenter, btns,
                        lblTitle, txtCenter, txtBtn);

                    break;
            }
            Temas.activeAddMarcas = false;
        }

        public void mudarTemas(Color tclCenter, Color btns, Color lblTitle, Color txtCenter,
            Color txtBtn)
        {
            //Tcl
            BackColor = tclCenter;
            Tcl_marcas.BackColor = tclCenter;
            Tcl_cores.BackColor = tclCenter;
            Tcl_main.BackColor = tclCenter;

            //buttons
            Btn_removerMarca.BackColor = btns;
            Btn_removerCor.BackColor = btns;
            Btn_adicionarMarca.BackColor = btns;
            Btn_adicionarCor.BackColor = btns;
            Btn_alterarMarca.BackColor = btns;
            Btn_alterarCor.BackColor = btns;
            Btn_limparMarca.BackColor = btns;
            Btn_limparCor.BackColor = btns;

            //label
            lblMarca1.ForeColor = lblTitle;
            lblCor1.ForeColor = lblTitle;
            lblMarca3.ForeColor = txtCenter;
            lblCor3.ForeColor = txtCenter;
            lblMarca2.ForeColor = txtCenter;
            lblCor2.ForeColor = txtCenter;

            //text Button
            Btn_removerMarca.ForeColor = txtBtn;
            Btn_removerCor.ForeColor = txtBtn;
            Btn_adicionarMarca.ForeColor = txtBtn;
            Btn_adicionarCor.ForeColor = txtBtn;
            Btn_alterarMarca.ForeColor = txtBtn;
            Btn_alterarCor.ForeColor = txtBtn;
            Btn_limparMarca.ForeColor = txtBtn;
            Btn_limparCor.ForeColor = txtBtn;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Temas.active == true)
            {
                trocaTema();
            }
        }

        private void Frm_addMarcas_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
    }
}
