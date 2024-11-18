using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ListaDeTarefasProjeto.Models
{
    public class TarefaModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha a Descrição!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preencha a data de vencimento!")]
        public DateTime? DataDeVencimento { get; set; }

        [Required(ErrorMessage = "Selecione a categoria!")]
        public string CategoriaId { get; set; }

        [ValidateNever]
        public CategoriaModel Categoria { get; set; }

        [Required(ErrorMessage = "Selecione um status!")]
        public string StatusId { get; set; }

        [ValidateNever]
        public StatusModel Status { get; set; }
        public bool Atrasado => StatusId == "aberto" && DataDeVencimento < DateTime.Today;
    }
}
