using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyMeetingManager.Models
{
    public class Speaker
    {
        [Column(Order = 0)]
        public int ID { get; set; }

        //[ForeignKey("Member")]
        //[Column(Order = 1)]
        //public int? MemberID { get; set; }
        public Member Member { get; set; }

        //[ForeignKey("Meeting")]
        //[Column(Order = 2)]
        //public int? MeetingID { get; set; }
        public Meeting Meeting { get; set; }

        [Required]
        [Display(Name = "Topics")]
        [StringLength(50, MinimumLength = 3)]
        [Column(Order = 3)]
        public string Topic { get; set; }

        [Required]
        [Range(3, 15)]
        [Column(Order = 4)]
        public int Minutes { get; set; }
    }
}
