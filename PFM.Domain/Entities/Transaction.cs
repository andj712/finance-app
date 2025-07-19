using PFM.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Domain.Entities
{
    internal class Transaction
    {
        [Key]
        public string Id { get; set; } = string.Empty;

        public string BeneficiaryName { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DirectionEnum Direction { get; set; }  

        [Required]
        public decimal Amount { get; set; }


        public string? Description { get; set; }

        [Required]
        public string Currency { get; set; } = "USD";

        public MccCodeEnum? MccCode { get; set; }

        public string Kind { get; set; }
    }
}
