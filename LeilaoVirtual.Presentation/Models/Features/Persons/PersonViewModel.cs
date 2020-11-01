using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeilaoVirtual.Presentation.Models.Features.Persons
{
    public class PersonViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Age { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Name { get; set; }
    }
}
