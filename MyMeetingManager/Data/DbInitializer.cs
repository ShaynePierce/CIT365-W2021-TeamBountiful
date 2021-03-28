using MyMeetingManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMeetingManager.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MeetingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Members.Any())
            {
                return;   // DB has been seeded
            }

            Hymn[] hymns = DbInitializeHymns.InitializeHymns(context);

            var members = new Member[]
            {
            new Member{Salutation=Salutation.Elder, Name="Tommy Knorr", isLeader=true},
            new Member{Salutation=Salutation.President, Name="Kevin Nielsen", isLeader=true},
            new Member{Salutation=Salutation.Bishop, Name="Kyle Johnson", isLeader=true},
            new Member{Salutation=Salutation.Brother, Name="Shayne Pierce", isLeader=true},
            new Member{Salutation=Salutation.Brother, Name="Parker Hall", isLeader=true},
            new Member{Salutation=Salutation.Sister, Name="Janis Maxwell"},
            new Member{Salutation=Salutation.Brother, Name="Greg Adams"},
            new Member{Salutation=Salutation.Sister, Name="Helen Black"},
            new Member{Salutation=Salutation.Brother, Name="Curtis Jones"},
            new Member{Salutation=Salutation.Brother, Name="Kelly Allmen"},
            new Member{Salutation=Salutation.Sister, Name="Sharon Cooper"},
            new Member{Salutation=Salutation.Brother, Name="Steve Jenson"},
            new Member{Salutation=Salutation.Sister, Name="Maggie Warner"},
            new Member{Salutation=Salutation.Brother, Name="Jeff Perkins"},
            new Member{Salutation=Salutation.Sister, Name="Stephanie Bronson"},
            new Member{Salutation=Salutation.Brother, Name="Glen Thomas"},
            new Member{Salutation=Salutation.Brother, Name="Mark Traver"},
            new Member{Salutation=Salutation.Sister, Name="Amy McDonald"},
            new Member{Salutation=Salutation.Brother, Name="Jason Marcus"},
            new Member{Salutation=Salutation.Sister, Name="Sheila Givens"},
            new Member{Salutation=Salutation.Brother, Name="Daniel Bell"},
            new Member{Salutation=Salutation.Sister, Name="Julie Johnson"},
            new Member{Salutation=Salutation.Brother, Name="Thomas Cane"},
            new Member{Salutation=Salutation.Sister, Name="Heidi Honaker"},
            new Member{Salutation=Salutation.Brother, Name="Gerald Donavan"},
            };
            foreach (Member m in members)
            {
                context.Members.Add(m);
            }
            context.SaveChanges();

            var AnnouncementQuotes = new string[]
            {
                "Reminder: no basketball this week.",
                "Sunday School will start at 10:30 AM next week.",
                "Baptism next Saturday at 3:00 PM at the stake center.",
                "Tithing Settlement is coming up. Book your appointment.",
                "Temple Prep class offered on Sundays at 4:00 PM at Brother Wayne's House.",
            };

            Ward w = new Ward { Name = "Mount Pleasant First Ward" };
            context.Wards.Add(w);

            //we have members, leaders, ward, hymns - time to make some meetings and assign some speakers
            List<Meeting> meetings = new List<Meeting>();

            DateTime startDate = DateTime.Now.Date;
            startDate = startDate.AddDays(-49);
            while (!startDate.DayOfWeek.Equals(DayOfWeek.Sunday))
            {
                startDate = startDate.AddDays(1);
            }

            //for (int i = 0; i < hymns.Length; i++)
            //{
            //    System.Diagnostics.Debug.WriteLine(i.ToString() + " " + hymns[i].Number.ToString() + " " + hymns[i].Title);
            //}

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Meeting meet = new Meeting();
                meet.MeetingDate = startDate;
                meet.FastAndTestimonyMeeting = (((i + 1) % 4) == 0);
                meet.Ward = w;
                meet.Presiding = members[rand.Next(3)];
                meet.ConductingLeader = members[rand.Next(2, 5)];
                meet.Chorister = members[rand.Next(3, members.Length)];
                meet.Organist = members[rand.Next(3, members.Length)];
                if (rand.Next(1, 2) == 1)
                {
                    meet.Announcements = AnnouncementQuotes[rand.Next(AnnouncementQuotes.Length)];
                }
                meet.OpeningHymn = hymns[rand.Next(184)];
                meet.OpeningPrayerMember = members[rand.Next(4, members.Length)];
                meet.SacramentHymn = hymns[rand.Next(185, 212)];
                if (i % 3 != 0)
                {//add optional rest hymn
                    if (!meet.FastAndTestimonyMeeting) //only add if not a fast Sunday
                    {
                        meet.OptionalRestHymnMember = members[rand.Next(4, members.Length)];
                        meet.OptionalRestHymnTitle = hymns[rand.Next(184)].Title;
                    }
                }
                meet.ClosingHymn = hymns[rand.Next(184)];
                meet.ClosingPrayerMember = members[rand.Next(4, members.Length)];
                meetings.Add(meet);
                startDate = startDate.AddDays(7);
            }
            foreach (Meeting meet in meetings)
            {
                context.Meetings.Add(meet);
            }
            context.SaveChanges();

            //now we have a bunch of meetings - need to add speakers
            var topics = new string[]
            {
                "Atonement",
                "Prophets",
                "Tithing",
                "Forgiveness",
                "Holy Ghost",
                "Covenants",
                "Priesthood",
                "Salvation",
                "Gifts of the Spirit",
                "Motherhood",
                "Family Proclamation",
                "Restoration",
                "Baptism",
                "Pioneers",
                "Sacrifice",
                "Virtue",
                "Charity",
                "Service",
                "Repentance",
                "Temple Ordinances",
                "Missionary Service",
                "Miracles",
                "Book of Mormon",
                "Word of Wisdom"
            };

            foreach (Meeting meet in meetings)
            {
                if (!meet.FastAndTestimonyMeeting)
                {
                    //1 to 4 speakers
                    for (int i = 0; i < rand.Next(2, 6); i++)
                    {
                        Speaker s = new Speaker
                        {
                            Meeting = meet,
                            Member = members[rand.Next(members.Length)],
                            Topic = topics[rand.Next(topics.Length)],
                            Minutes = rand.Next(1, 6) * 3
                        };
                        context.Speakers.Add(s);
                    }
                }
            }
            context.SaveChanges();
        }
    }
}