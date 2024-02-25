using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv1
{
    internal class Carros
    {
        public int id_carro;
        public int codigo_crv;
        public string marca;
        public string modelo;
        public string cor;
        public string placa;
        public int renavam;

        public string status;
        public int macaco;
        public int instrucoes;
        public int reserva;
        private ConexaoBanco banco;

        //CONSTRUTOR
        public Carros()
        {
            
            this.codigo_crv = 0;
            this.marca = "";
            this.modelo = "";
            this.cor = "";
            this.placa = "";
            this.renavam = 0;

            this.status = "";
            this.macaco = 0;
            this.instrucoes = 0;
            this.reserva = 0;

            this.banco = new ConexaoBanco();
        }

        //set
        public void setStatus(string novo)
        {
            this.status = novo;
        }
        public void setMacaco(int novo)
        {
            this.macaco = novo;
        }
        public void setInstrucoes(int novo)
        {
            this.instrucoes = novo;
        }
        public void setReserva(int novo)
        {
            this.reserva = novo;
        }
        //----
        public void setId_carro(int novo)
        {
            this.id_carro = novo;
        }
        public void setCodigo_crv(int novo)
        {
            this.codigo_crv = novo;
        }
        public void setMarca(string novo)
        {
            this.marca = novo;
        }
        public void setModelo(string novo)
        {
            this.modelo = novo;
        }
        public void setCor(string novo)
        {
            this.cor = novo;
        }
        public void setPlaca(string novo)
        {
            this.placa = novo;
        }
        public void setRenavam(int novo)
        {
            this.renavam = novo;
        }
        //get
        public int getId_carro()
        {
            return this.id_carro;
        }
        public int getCodigo_crv()
        {
            return this.codigo_crv;
        }
        public string getMarca()
        {
            return this.marca;
        }
        public string getModelo()
        {
            return this.modelo;
        }
        public string getCor()
        {
            return this.cor;
        }
        public string getPlaca()
        {
            return this.placa;
        }
        public int getRenavam()
        {
            return this.renavam;
        }
        //----
        public string getStatus()
        {
            return this.status;
        }
        public int getMacaco()
        {
            return this.macaco;
        }
        public int getInstrucoes()
        {
            return this.instrucoes;
        }
        public int getReserva()
        {
            return this.reserva;
        }

        //---INSERIR---
        public void cadastrarCarros()
        {
            MySqlDataReader reader;
            this.banco.conectar();
            this.banco.nonQuery("insert into carros (codigo_crv,marca,modelo,cor,placa,renavam,status_carro,macaco,instrucoes,reserva)  values " +
                "('" + this.getCodigo_crv() + "', '" +
                this.getMarca() + "','" +
                this.getModelo() + "','" +
                this.getCor() + "','" +
                this.getPlaca() + "','" +
                this.getRenavam() + "','" +

                this.getStatus() + "','" +
                this.getMacaco() + "','" +
                this.getInstrucoes() + "','" +
                this.getReserva() + "')");

             reader = this.banco.Query("select id_carro from carros where" +
                " codigo_crv='" + this.getCodigo_crv() +
                "' and marca='" + this.getMarca() +
                "' and modelo='" + this.getModelo() +
                "' and cor='" + this.getCor() +
                "' and placa='" + this.getPlaca() +
                "' and renavam='" + this.getRenavam() +
                "' and status_carro='" + this.getStatus() +
                "' and macaco='" + this.getMacaco() +
                "' and instrucoes='" + this.getInstrucoes() +
                "' and reserva='" + this.getReserva() + "';");
            reader.Read();
            //int carros = reader.GetInt32(0);
            //this.setId_carro(carros);
            
            this.banco.close();
        }

        //---ALTERAR---
        public void alterarCadastro()
        {
            this.banco.conectar();
            this.banco.nonQuery("UPDATE `cadastro_carros`.`carros` SET " +
                "`codigo_crv` = '" + this.getCodigo_crv() +
                "', `marca` = '" + this.getMarca() +
                "', `modelo` = '" + this.getModelo() +
                "', `cor` = '" + this.getCor() +
                "', `placa` = '" + this.getPlaca() +
                "', `renavam` = '" + this.getRenavam() +
                 "', `status_carro`= '" + this.getStatus() +
                  "', `macaco` = '" + this.getMacaco() +
                   "', `instrucoes` = '" + this.getInstrucoes() +
                    "', `reserva` = '" + this.getReserva() +
                "' WHERE `id_carro` = '" + this.getId_carro() + "';");
            this.banco.close();
        }

        //---EXCLUIR---
        public void excluirCadastro()
        {
            this.banco.conectar();
            this.banco.nonQuery("Delete from carros where id_carro = '" + this.getId_carro() + "';");
            this.banco.close();
        }
        // CRIAR METODO PARA BUSCAR CARROS PARA O GRID

        public MySqlDataReader listarCarros()
        {
            this.banco.conectar();
            return this.banco.Query("SELECT id_carro as 'ID', codigo_crv as 'CRV',marca,modelo,cor,placa,renavam,status_carro as 'status',macaco,instrucoes as 'instrucoes',reserva as 'chave reserva' FROM carros;");
        }
        // CRIAR METODO PARA BUSCAR CARROS PELO BOTÃO PESQUISAR
        public MySqlDataReader listarCarroPorOk(string filtro)
        {
            this.banco.conectar();
            return this.banco.Query("select * from carros " +
                " where id_carro like '%" + filtro + "%';");
        }
    }
}
