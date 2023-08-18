using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessário preencher o campo {0}")]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data de Vencimento")]
        [Required(ErrorMessage = "É necessário preencher o campo {0}")]
        public DateTime DateOff { get; set; }

        [Display(Name = "Cor da tarefa")]
        public string Color { get; set; }

        [Display(Name = "Tarefa Concluída ✅")]
        public bool Complet { get; set; }
    }
}
