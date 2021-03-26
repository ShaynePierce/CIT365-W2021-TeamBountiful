using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyMeetingManager.Models
{
    public enum Salutation
    {
        Brother, Sister, Bishop, President, Elder
    }

    public class Member
    {
        [Column(Order = 0)]
        public int ID { get; set; }

        [Required]
        [Column(Order = 1)]
        [Display(Name = "Salutation")]
        public Salutation Salutation { get; set; }

        //[DisplayFormat(NullDisplayText = "None")]
        //[Column(Order = 2)]
        //public string Title { get; set; } //if set, this person is a leader (can conduct)
        [Display(Name = "Leader")]
        public Boolean isLeader { get; set; } = false;

        [Required]
        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 3)]
        [Column(Order = 3)]
        public string Name { get; set; }
    }
}
