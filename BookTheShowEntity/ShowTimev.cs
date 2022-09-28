using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookTheShowEntity
{
    public class ShowTimev
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShowvId { get; set; }

        [ForeignKey("moviev")]
        public int MovievId { get; set; }

        public Moviev moviev { get; set; }

        [ForeignKey("theatrev")]
        public int TheatrevId { get; set; }

        public Theatrev theatrev { get; set; } // foreign key should have same object name

        public DateTime ShowTimevv { get; set; }
    }
}
