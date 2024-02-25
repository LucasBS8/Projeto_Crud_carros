using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv1
{
    internal class Marcas
    {
        public bool attCbx { get; set; }
        public int id { get; set; }
        public string nome { get; set; }
        private ConexaoBanco banco;
        public Marcas() 
        {
            this.banco = new ConexaoBanco();
        }
        //---INSERIR---
        public void cadastrarMarcas()
        {
            MySqlDataReader reader;
            this.banco.conectar();
            this.banco.nonQuery($"insert into marcas (nome)  values ('{this.nome}');");

            reader = this.banco.Query($"select id_marca from marcas where nome='{this.nome}';");
            reader.Read();
            //int carros = reader.GetInt32(0);
            //this.setId_carro(carros);

            this.banco.close();
        }
        //---ALTERAR---
        public void alterarCadastro()
        {
            this.banco.conectar();
            this.banco.nonQuery($"UPDATE `cadastro_carros`.`marcas` SET `nome` = '{this.nome}' WHERE (`id_marca` = '{this.id}');");
            this.banco.close();
        }
        //---EXCLUIR---
        public void excluirCadastro()
        {
            this.banco.conectar();
            this.banco.nonQuery($"Delete from marcas where id_marca = '{this.id}';");
            this.banco.close();
        }

        // CRIAR METODO PARA BUSCAR CARROS PARA O GRID

        public MySqlDataReader listarMarcas()
        {
            this.banco.conectar();
            return this.banco.Query("SELECT id_marca as 'ID', nome FROM marcas;");
        }
        // CRIAR METODO PARA BUSCAR CARROS PELO BOTÃO PESQUISAR
        public MySqlDataReader listarMarcaPorOk(string filtro)
        {
            this.banco.conectar();
            return this.banco.Query($"select * from marcas where id_marca like '%{filtro}%';");
        }

        public MySqlDataReader consultarValor()
        {
            this.banco.conectar();
            string sql = "select * from marcas;";
            MySqlDataReader ds = banco.Query(sql);
            return ds;
        }
    }
}
