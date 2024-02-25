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
    public partial class Frm_cadastro : Form
    {
        Marcas marcas = new Marcas();
        Cores cores = new Cores();
        private Carros carros = new Carros();
        string status;
        bool macaco;
        bool instrucoes;
        bool reserva;
        public string cor;
        public Frm_cadastro()
        {
            InitializeComponent();
            atualizarDataGrid();
            limpar();
        }

        private void atualizarDataGrid()
        {
            MySqlDataReader temp = carros.listarCarros();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtv_carros.DataSource = dt;
        }


        private void Btn_adicionar_Click(object sender, EventArgs e)
        {

            if (Mtb_CodigoCrv.Text == ""
                || Mtb_placa.Text == ""
                || Cbx_Marca.Text == ""
                || Txb_Modelo.Text == ""
                || Convert.ToInt64(Mtb_renavam.Text) == 0
                || Cbx_cor.Text == ""
                || (Rbn_novo.Checked == false && Rbn_usado.Checked == false))
            {
                MessageBox.Show("Nenhum veículo foi escrito ou dados estão incompletos");
            }
            else
            {

                //CADASTRO CARROS
                this.carros.setCodigo_crv(Convert.ToInt32(Mtb_CodigoCrv.Text));
                this.carros.setMarca(Cbx_Marca.Text);
                this.carros.setModelo(Txb_Modelo.Text);
                this.carros.setCor(Cbx_cor.Text);
                this.carros.setPlaca(Mtb_placa.Text);
                this.carros.setRenavam(Convert.ToInt32(Mtb_renavam.Text));

                if (Rbn_novo.Checked == true)
                {
                    this.carros.setStatus("novo");
                }
                else
                {
                    if (Rbn_usado.Checked == true)
                    {
                        this.carros.setStatus("usado");
                    }
                }

                if (Cbx_macaco.Checked == true)
                {
                    this.carros.setMacaco(1);
                }
                else
                {
                    this.carros.setMacaco(0);
                }

                if (Cbx_instrucao.Checked == true)
                {
                    this.carros.setInstrucoes(1);
                }
                else
                {
                    this.carros.setInstrucoes(0);
                }

                if (Cbx_chave.Checked == true)
                {
                    this.carros.setReserva(1);
                }
                else
                {
                    this.carros.setReserva(0);
                }

                this.carros.cadastrarCarros();

                MessageBox.Show("Cadastro realizado com sucesso.");
            }
            atualizarDataGrid();
            limpar();
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {

            Mtb_CodigoCrv.Focus();
            limpar();

        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Dispose();
        }

        private void Btn_pesquisa_Click(object sender, EventArgs e)
        {
            if (Txb_pesquisa.Text != "")
            {
                String filtro = Txb_pesquisa.Text;
                MySqlDataReader temp = this.carros.listarCarroPorOk(filtro);
                DataTable dt = new DataTable();
                dt.Load(temp);
                dtv_carros.DataSource = dt;
            }

            else
            {
                atualizarDataGrid();
            }
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            if (Txb_IdCarro.Text != "")
            {
                this.carros.setId_carro(int.Parse(Txb_IdCarro.Text));
                this.carros.setCodigo_crv(Convert.ToInt32(Mtb_CodigoCrv.Text));
                this.carros.setMarca(Cbx_Marca.Text);
                this.carros.setModelo(Txb_Modelo.Text);
                this.carros.setCor(Cbx_cor.Text);
                this.carros.setPlaca(Mtb_placa.Text);
                this.carros.setRenavam(Convert.ToInt32(Mtb_renavam.Text));
                if (Rbn_novo.Checked == true)
                {
                    this.carros.setStatus("novo");
                }
                else
                {
                    if (Rbn_usado.Checked == true)
                    {
                        this.carros.setStatus("usado");
                    }
                }

                if (Cbx_macaco.Checked == true)
                {
                    this.carros.setMacaco(1);
                }
                else
                {
                    this.carros.setMacaco(0);
                }

                if (Cbx_instrucao.Checked == true)
                {
                    this.carros.setInstrucoes(1);
                }
                else
                {
                    this.carros.setInstrucoes(0);
                }

                if (Cbx_chave.Checked == true)
                {
                    this.carros.setReserva(1);
                }
                else
                {
                    this.carros.setReserva(0);
                }

                this.carros.alterarCadastro();
                MessageBox.Show("Valores alterados com sucesso.");
                limpar();
                atualizarDataGrid();
            }
            else
            {
                MessageBox.Show("O campo de pesquisa está vazio.");
            }
        }


        private void Txb_remover_Click(object sender, EventArgs e)
        {
            if (Mtb_CodigoCrv.Text != "")
            {
                if (MessageBox.Show("Tem certeza que deseja remover carro?", "Confirmar", MessageBoxButtons.
                   YesNoCancel) == DialogResult.Yes)
                {
                    if (Txb_IdCarro.Text != "")
                    {
                        this.carros.setId_carro(int.Parse(this.Txb_IdCarro.Text));
                        this.carros.excluirCadastro();
                        atualizarDataGrid();
                        limpar();
                    }
                }
            }
            else
            {
                MessageBox.Show("O campo de pesquisa está vazio.");
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            limpar();
            //Btn_voltar.Visible = false;
        }

        private void limpar()
        {
            Txb_IdCarro.Clear();
            Mtb_CodigoCrv.Clear();
            Cbx_Marca.Enabled = false;
            Cbx_Marca.Text = "";
            Cbx_Marca.Enabled = true;
            Mtb_placa.Clear();
            Mtb_renavam.Clear();
            Txb_Modelo.Clear();
            Cbx_cor.Enabled = false;
            Cbx_cor.Text = "";
            Cbx_cor.Enabled = true;
            Rbn_novo.Checked = false;
            Rbn_usado.Checked = false;
            Cbx_chave.Checked = false;
            Cbx_instrucao.Checked = false;
            Cbx_macaco.Checked = false;
            atualizarDataGrid();
            carregaMarca();
        }

        private void Frm_cadastro_Load(object sender, EventArgs e)
        {

            timer1 = new Timer();
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            atualizarDataGrid();
            carregaMarca();
            carregaCor();
            limpar();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {

            Frm_config frm_Config = new Frm_config();
            frm_Config.ShowDialog();
        }

        private void dtv_carros_DoubleClick(object sender, EventArgs e)
        {
            int linhaAtual = 0;
            linhaAtual = dtv_carros.CurrentRow.Index;
            try
            {
                Txb_IdCarro.Text = dtv_carros[0, linhaAtual].Value.ToString();
                Mtb_CodigoCrv.Text = dtv_carros[1, linhaAtual].Value.ToString();
                Cbx_Marca.Text = dtv_carros[2, linhaAtual].Value.ToString();
                Txb_Modelo.Text = dtv_carros[3, linhaAtual].Value.ToString();
                Cbx_cor.Text = dtv_carros[4, linhaAtual].Value.ToString();
                Mtb_placa.Text = dtv_carros[5, linhaAtual].Value.ToString();
                Mtb_renavam.Text = dtv_carros[6, linhaAtual].Value.ToString();
                this.status = dtv_carros[7, linhaAtual].Value.ToString();

                if (this.status == "novo")
                {
                    Rbn_novo.Checked = true;
                }
                else
                {
                    if (this.status == "usado")
                    {
                        Rbn_usado.Checked = true;
                    }
                    else
                    {
                        Rbn_novo.Checked = false;
                        Rbn_usado.Checked = false;
                    }
                }

                this.macaco = Convert.ToBoolean(dtv_carros[8, linhaAtual].Value.ToString());
                if (this.macaco == true)
                {
                    Cbx_macaco.Checked = true;
                }
                else
                {
                    Cbx_macaco.Checked = false;
                }

                this.instrucoes = Convert.ToBoolean(dtv_carros[9, linhaAtual].Value.ToString());
                if (this.instrucoes == true)
                {
                    Cbx_instrucao.Checked = true;
                }
                else
                {
                    Cbx_instrucao.Checked = false;
                }

                this.reserva = Convert.ToBoolean(dtv_carros[10, linhaAtual].Value.ToString());
                if (this.reserva == true)
                {
                    Cbx_chave.Checked = true;
                }
                else
                {
                    Cbx_chave.Checked = false;
                }
            }
            catch
            {
                MessageBox.Show("ERRO no preenchimento dos dados.");
            }
        }
        public void trocaTema()
        {
            Color pnlCenter;
            Color pnlBord;
            Color btns;
            Color lblTitle;
            Color txtCenter;
            Color txtBtn;
            switch (Temas.tema)
            {

                case 0:

                    pnlCenter = Color.FromArgb(220, 224, 230);
                    pnlBord = Color.FromArgb(86, 126, 187);
                    btns = Color.FromArgb(220, 224, 230);
                    lblTitle = Color.FromArgb(220, 224, 230);
                    txtCenter = Color.Black;
                    txtBtn = Color.Black;
                    mudarTemas(pnlBord, pnlCenter, btns,
                        lblTitle, txtCenter, txtBtn);
                    break;
                case 1:

                    pnlCenter = Color.White;
                    pnlBord = Color.FromArgb(200, 215, 240);
                    btns = Color.White;
                    lblTitle = Color.FromArgb(86, 126, 187);
                    txtCenter = Color.FromArgb(31, 31, 32);
                    txtBtn = Color.FromArgb(31, 31, 32);
                    mudarTemas(pnlBord, pnlCenter, btns,
                        lblTitle, txtCenter, txtBtn);
                    break;
                case 2:


                    pnlCenter = Color.FromArgb(60, 65, 80);
                    pnlBord = Color.FromArgb(86, 126, 187);
                    btns = Color.FromArgb(60, 65, 80);
                    lblTitle = Color.FromArgb(220, 224, 230);
                    txtCenter = Color.FromArgb(220, 224, 230);
                    txtBtn = Color.FromArgb(220, 224, 230);
                    mudarTemas(pnlBord, pnlCenter, btns,
                        lblTitle, txtCenter, txtBtn);
                    break;
                case 3:

                    pnlCenter = Color.FromArgb(60, 65, 80);
                    pnlBord = Color.FromArgb(20, 25, 30);
                    btns = Color.FromArgb(60, 65, 80);
                    lblTitle = Color.FromArgb(220, 224, 230);
                    txtCenter = Color.FromArgb(220, 224, 230);
                    txtBtn = Color.FromArgb(220, 224, 230);
                    mudarTemas(pnlBord, pnlCenter, btns,
                        lblTitle, txtCenter, txtBtn);

                    break;
            }
            Temas.active = false;
        }

        public void mudarTemas(Color pnlBord, Color pnlCenter, Color btns, Color lblTitle, Color txtCenter,
            Color txtBtn)
        {
            //panel
            pnl_centro.BackColor = pnlCenter;
            pnl_esquerda.BackColor = pnlBord;
            pnl_top.BackColor = pnlBord;

            //buttons
            Btn_remover.BackColor = btns;
            Btn_adicionar.BackColor = btns;
            Btn_alterar.BackColor = btns;
            Btn_limpar.BackColor = btns;

            //label
            label1.ForeColor = lblTitle;
            label2.ForeColor = lblTitle;
            label3.ForeColor = txtCenter;
            label4.ForeColor = txtCenter;
            label5.ForeColor = txtCenter;
            label6.ForeColor = txtCenter;
            label7.ForeColor = txtCenter;
            label8.ForeColor = txtCenter;
            label9.ForeColor = txtCenter;

            //group box
            gbx1.ForeColor = txtCenter;
            gbx2.ForeColor = txtCenter;

            //text Button
            Btn_remover.ForeColor = txtBtn;
            Btn_adicionar.ForeColor = txtBtn;
            Btn_alterar.ForeColor = txtBtn;
            Btn_limpar.ForeColor = txtBtn;
            Btn_pesquisa.ForeColor = txtBtn;

            //text radio button and check box
            Rbn_novo.ForeColor = txtCenter;
            Rbn_usado.ForeColor = txtCenter;
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            if (Temas.active == true)
            {
                trocaTema(); 
                Temas.activeAddMarcas = true;
                Temas.activeSobre = true;
                Temas.activeConfig = true;
                Temas.activeTemas = true;
            }
        }
        public void carregaMarca()
        {

            MySqlDataReader temp = marcas.consultarValor();
            DataTable dt = new DataTable();
            dt.Load(temp);
            Cbx_Marca.DataSource = dt;
            Cbx_Marca.DisplayMember = "nome";
            Cbx_Marca.ValueMember = "id_marca";
        }

        public void carregaCor()
        {
            MySqlDataReader temp = cores.consultarValor();
            DataTable dt = new DataTable();
            dt.Load(temp);
            Cbx_cor.DataSource = dt;
            Cbx_cor.DisplayMember = "nome";
            Cbx_cor.ValueMember = "id_cor";
        }

        private void Cbx_Marca_Click(object sender, EventArgs e)
        {
                carregaMarca();
        }

        private void Cbx_cor_Click(object sender, EventArgs e)
        {
            carregaCor();
        }

        private void Rbn_usado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
