using LeilaoVirtual.Domain.Features.Auctions;
using LeilaoVirtual.Domain.Features.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeilaoVirtual.Presentation.Models.Features.Moves
{
    public class MoveViewModel
    {
        public int PersonId { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double MoveValue { get; set; }

        public int AuctionId { get; set; }
    }
}
