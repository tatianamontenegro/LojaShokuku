using System;
using System.ComponentModel.DataAnnotations;

namespace LojaShokuku.Dados.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        //get; set; significa leitura e escrita
        //aqui estão as propriedades, ou seja, os campos da tabela
        //o entitity framework core é a tecnologia q usando c# me permite criar as bases de dados e tabelas e tudo oq fiz a bocado
        //o entitity framework core mapeia isto e mete.o automatico e chave primaria

        public string Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Preco { get; set; }

        [Display(Name = "Image")]
        public string UrlDaImagem { get; set; }
        //este é o caminho da imagem, nao onde fica a imagem

        [Display(Name = "Última Compra")]
        public DateTime UltimaCompra { get; set; }

        [Display(Name = "Última Venda")]
        public DateTime UltimaVenda { get; set; }

        [Display(Name = "Disponível")]
        public bool Disponivel { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }
    }
}
