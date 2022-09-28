using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookTheShowEntity
{
    public class Moviev
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovievId { get; set; }
        public string MovievName { get; set; }

        public string MovievDesc { get; set; }

        public string MovievType { get; set; }
    }
}
