using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv1
{
    internal class Cores
    {
        public bool attCbx { get; set; }
        public int id { get; set; }
        public string nome { get; set; }
        private ConexaoBanco banco;
        public Cores()
        {
            this.id = 0;
            this.nome = "";
            this.banco = new ConexaoBanco();
        }
        //---INSERIR---
        public void cadastrarCores()
        {
            MySqlDataReader reader;
            this.banco.conectar();
            this.banco.nonQuery($"insert into cores (nome)  values ('{this.nome}');");

            reader = this.banco.Query($"select id_cor from cores where nome='{this.nome}';");
            reader.Read();
            //int carros = reader.GetInt32(0);
            //this.setId_carro(carros);

            this.banco.close();
        }
        //---ALTERAR---
        public void alterarCadastro()
        {
            this.banco.conectar();
            this.banco.nonQuery($"UPDATE `cadastro_carros`.`cores` SET " +
                $"`nome` = '{this.nome}' WHERE (`id_cor` = '{this.id}');");
            this.banco.close();
        }
        //---EXCLUIR---
        public void excluirCadastro()
        {
            this.banco.conectar();
            this.banco.nonQuery($"Delete from cores where id_cor = '{this.id}';");
            this.banco.close();
        }
        // CRIAR METODO PARA BUSCAR CARROS PARA O GRID

        public MySqlDataReader listarCores()
        {
            this.banco.conectar();
            return this.banco.Query("SELECT id_cor as 'ID', nome FROM cores;");
        }
        // CRIAR METODO PARA BUSCAR CARROS PELO BOTÃO PESQUISAR
        public MySqlDataReader listarCorPorOk(string filtro)
        {
            this.banco.conectar();
            return this.banco.Query($"select * from cores where id_cor like '%{filtro}%';");
        }
        public MySqlDataReader consultarValor()
        {
            this.banco.conectar();
            string sql = "select * from cores;";
            MySqlDataReader ds = banco.Query(sql);
            return ds;
        }
    }
}
