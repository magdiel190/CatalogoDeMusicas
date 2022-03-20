using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoDeMusicas.Models
{
    [Table("CatalogoDeMusicas")]
    public class cadastro
    {
        [Display(Name ="Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Título do álbum")]
        [Column("TituloAlbum")]
        public string TituloAlbum { get; set; }

        [Display(Name = "Data lançamento")]
        [Column("DataLancamento")]
        public DateOnly DataLancamento { get; set; }

        [Display(Name ="Nome artista")]
        [Column("NomeArtista")]
        public string NomeArtista { get; set; }

        [Display(Name = "Nome gênero")]
        [Column("NomeGenero")]
        public string NomeGenero { get; set; }

        [Display(Name ="Data Cadastro")]
        [Column("DataCadastro")]
        public DateOnly DataCadastro { get; set; }

        [Display(Name = "Preço")]
        [Column("Preco")]
        public string Preco { get; set; }
    }
}
