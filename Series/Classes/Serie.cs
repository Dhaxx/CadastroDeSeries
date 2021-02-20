using System;
using System.Collections.Generic;
using System.Text;

namespace Series
{
    class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }

        private Criterios Criterio { get; set; }

        private Classificacao Classificacao { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Status { get; set; }

        //Metodos

        public Serie(int id, Genero genero, Classificacao classificacao, 
            Criterios criterio, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Classificacao = classificacao;
            this.Criterio = criterio;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Status = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Classificacao: " + this.Classificacao + Environment.NewLine;
            retorno += "Criterios: " + this.Criterio + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Status: " + this.Status + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaStatus()
        {
            return this.Status;
        }

        public void Excluir()
        {
            this.Status = true;
        }
    }
}
