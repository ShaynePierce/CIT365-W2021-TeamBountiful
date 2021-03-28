using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMeetingManager.Models
{
    public class Meeting
    {
        [Column(Order = 0)]
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Meeting Date")]
        [Column(Order = 1)]
        public DateTime MeetingDate { get; set; }
        [Display(Name = "Fast And Testimony Meeting")]
        public Boolean FastAndTestimonyMeeting { get; set; }
        [Display(Name = "Announcements")]
        public String Announcements { get; set; }
        public Ward Ward { get; set; }
        [Display(Name = "Presiding")]
        public Member Presiding { get; set; }
        [Display(Name = "Conducting")]
        public Member ConductingLeader { get; set; }
        [Display(Name = "Chorister")]
        public Member Chorister { get; set; }
        [Display(Name = "Organist")]
        public Member Organist { get; set; }
        [Display(Name = "Opening Hymn")]
        public Hymn OpeningHymn { get; set; }
        [Display(Name = "Opening Prayer")]
        public Member OpeningPrayerMember { get; set; }
        [Display(Name = "Sacrament Hymn")]
        public Hymn SacramentHymn { get; set; }
        public ICollection<Speaker> Speakers { get; set; }

        [Display(Name = "Rest Hymn")]
        [StringLength(200)]
        [DisplayFormat(NullDisplayText = "None")]
        public string OptionalRestHymnTitle { get; set; }
        [Display(Name = "Performer")]
        public Member OptionalRestHymnMember { get; set; }
        [Display(Name = "Closing Hymn")]
        public Hymn ClosingHymn { get; set; }
        [Display(Name = "Closing Prayer")]
        public Member ClosingPrayerMember { get; set; }

    }
}