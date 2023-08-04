using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeStore.EL
{
    public class NewsLetter
    {
        [Key]

        public int NewsLetterId { get; set; }
       // public string? NewsLetterMail { get;}
       // public string? Mail { get;}
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
    }
}
