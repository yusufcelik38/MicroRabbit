using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Models
{
    public class TransferViewModel
    {
        [Display(Name ="Transfer Note")]
        public string TransferNote { get; set; }
        [Display(Name = "From Transfer")]
        public int FromAccount { get; set; }
        [Display(Name = "To Transfer")]
        public int ToAccount { get; set; }
        [Display(Name = "Transfer Amount")]
        public decimal TransferAmount { get; set; }
    }
}
