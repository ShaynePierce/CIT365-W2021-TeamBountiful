using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMeetingManager.Models
{
    public class Hymn
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Title")]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [Range(1, 341)]
        public int Number { get; set; }

    }
}
