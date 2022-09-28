using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookTheShowEntity
{
    public class Theatrev
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TheatrevId { get; set; }
        public string TheatrevName { get; set; }

        public string TheatrevAddress { get; set; }

        public string TheatrevComments { get; set; }
    }
}
