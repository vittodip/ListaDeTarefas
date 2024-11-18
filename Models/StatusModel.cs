using System.ComponentModel.DataAnnotations;

namespace ListaDeTarefasProjeto.Models
{
    public class StatusModel
    {
        [Key]
        public string StatusId { get; set; }
        public string Nome { get; set; }
    }
}
