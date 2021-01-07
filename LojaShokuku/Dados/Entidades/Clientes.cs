using System;
using System.ComponentModel.DataAnnotations;

namespace LojaShokuku.Dados.Entidades
{
    public class Clientes
    {
        public int Id { get; set; }
        //get; set; significa leitura e escrita
        //aqui estão as propriedades, ou seja, os campos da tabela
        //o entitity framework core é a tecnologia q usando c# me permite criar as bases de dados e tabelas e tudo oq fiz a bocado
        //o entitity framework core mapeia isto e mete.o automatico e chave primaria

        public string Nome { get; set; }

        public string Apelido { get; set; }

        [Display(Name = "Imagem")]
        public string UrlDaImagem { get; set; }
        //este é o caminho da imagem, nao onde fica a imagem

    }
}
