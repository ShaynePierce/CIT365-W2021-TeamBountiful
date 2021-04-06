using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMeetingManager.Data;
using MyMeetingManager.Models;
using System.Diagnostics;

namespace MyMeetingManager.Controllers
{
    public class MeetingsController : Controller
    {
        private readonly MeetingContext _context;

        public MeetingsController(MeetingContext context)
        {
            _context = context;
        }

        // GET: Meetings
        public async Task<IActionResult> Index()
        {
            var meetings = await _context.Meetings
                .Include(w => w.Ward)
                .Include(s => s.Speakers)
                .Include(m => m.Presiding)
                .Include(m => m.Chorister)
                .Include(m => m.Organist)
                .Include(m => m.ConductingLeader)
                .Include(h => h.OpeningHymn)
                .Include(m => m.OpeningPrayerMember)
                .Include(h => h.SacramentHymn)
                .Include(m => m.OptionalRestHymnMember)
                .Include(h => h.ClosingHymn)
                .Include(m => m.ClosingPrayerMember)
                .ToListAsync();

            return View(meetings);
        }

        // GET: Meetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var meeting = await _context.Meetings
            //    .FirstOrDefaultAsync(m => m.ID == id);
            var meeting = await _context.Meetings
                .Include(w => w.Ward)
                .Include(s => s.Speakers)
                    .ThenInclude(m => m.Member)
                .Include(m => m.Presiding)
                .Include(m => m.Chorister)
                .Include(m => m.Organist)
                .Include(m => m.ConductingLeader)
                .Include(h => h.OpeningHymn)
                .Include(m => m.OpeningPrayerMember)
                .Include(h => h.SacramentHymn)
                .Include(m => m.OptionalRestHymnMember)
                .Include(h => h.ClosingHymn)
                .Include(m => m.ClosingPrayerMember)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        public async Task<IActionResult> PagePrint(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var meeting = await _context.Meetings
            //    .FirstOrDefaultAsync(m => m.ID == id);
            var meeting = await _context.Meetings
                .Include(w => w.Ward)
                .Include(s => s.Speakers)
                    .ThenInclude(m => m.Member)
                .Include(m => m.Presiding)
                .Include(m => m.Chorister)
                .Include(m => m.Organist)
                .Include(m => m.ConductingLeader)
                .Include(h => h.OpeningHymn)
                .Include(m => m.OpeningPrayerMember)
                .Include(h => h.SacramentHymn)
                .Include(m => m.OptionalRestHymnMember)
                .Include(h => h.ClosingHymn)
                .Include(m => m.ClosingPrayerMember)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // GET: Meetings/Create
        public IActionResult Create()
        {
            var members = _context.Members.OrderBy(m => m.Name).ToList();
            ViewBag.MemberList = members;
            var leaders = _context.Members.Where(l => l.isLeader == true).OrderBy(l => l.Name).ToList();
            ViewBag.LeaderList = leaders;
            var hymns = _context.Hymns.OrderBy(h => h.Number).ToList();
            ViewBag.HymnList = hymns;
            var wards = _context.Wards.OrderBy(w => w.Name).ToList();
            ViewBag.WardList = wards;

            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingDate,OptionalRestHymnTitle")] Meeting meeting)
        {
            meeting.FastAndTestimonyMeeting = (Request.Form["FastMeeting"].Count > 0);
            meeting.Ward = GetSelectedWard("WardSelect");
            meeting.Presiding = GetSelectedMember("PresidingSelect");
            meeting.ConductingLeader = GetSelectedMember("ConductingSelect");
            meeting.Chorister = GetSelectedMember("ChoristerSelect");
            meeting.Organist = GetSelectedMember("OganistSelect");
            meeting.Organist = GetSelectedMember("OrganistSelect");
            meeting.OpeningHymn = GetSelectedHymn("OpeningHymnSelect");
            meeting.OpeningPrayerMember = GetSelectedMember("OpeningPrayerSelect");
            if (Request.Form["Announcements"].Count > 0) { 
                meeting.Announcements = Request.Form["Announcements"][0];
            }
            meeting.SacramentHymn = GetSelectedHymn("SacramentHymnSelect");
            if (Request.Form["RestHymnSelect"].Count > 0)
            {
                meeting.OptionalRestHymnTitle = Request.Form["RestHymnSelect"][0];
            }
            meeting.OptionalRestHymnMember = GetSelectedMember("RestHymnMemberSelect");
            meeting.ClosingHymn = GetSelectedHymn("ClosingHymnSelect");
            meeting.ClosingPrayerMember = GetSelectedMember("ClosingPrayerSelect");

            if (ModelState.IsValid)
            {
                _context.Add(meeting);
                await _context.SaveChangesAsync();

                // Add Speakers
                int count = Request.Form["SpeakerMember"].Count;
                for (int i = 0; i < count; i++)
                {
                    Speaker s = new Speaker
                    {
                        Meeting = meeting,
                        Member = _context.Members.Find(int.Parse(Request.Form["SpeakerMember"][i])),
                        Topic = Request.Form["SpeakerTopic"][i],
                        Minutes = int.Parse(Request.Form["SpeakerMinutes"][i]),
                    };
                    _context.Speakers.Add(s);
                }
                await _context.SaveChangesAsync();
                // End add

                return RedirectToAction(nameof(Index));
            }
            return View(meeting);
        }

        public Member GetSelectedMember(String FormElement)
        {
            Member member = null;
            try
            {
                member = _context.Members.Find(int.Parse(Request.Form[FormElement][0]));
            }
            catch (Exception)
            {
                //do nothing
            }
            return member;
        }

        public Ward GetSelectedWard(String FormElement)
        {
            Ward ward = null;
            try
            {
                ward = _context.Wards.Find(int.Parse(Request.Form[FormElement][0]));
            }
            catch (Exception)
            {
                //do nothing
            }
            return ward;
        }

        public Hymn GetSelectedHymn(String FormElement)
        {
            Hymn hymn = null;
            try
            {
                hymn = _context.Hymns.Find(int.Parse(Request.Form[FormElement][0]));
            }
            catch (Exception)
            {
                //do nothing
            }
            return hymn;
        }

        // GET: Meetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var members = _context.Members.OrderBy(m => m.Name).ToList();
            ViewBag.MemberList = members;
            var leaders = _context.Members.Where(l => l.isLeader == true).OrderBy(l => l.Name).ToList();
            ViewBag.LeaderList = leaders;
            var hymns = _context.Hymns.OrderBy(h => h.Number).ToList();
            ViewBag.HymnList = hymns;
            var wards = _context.Wards.OrderBy(w => w.Name).ToList();
            ViewBag.WardList = wards;
            var speakers = _context.Speakers.OrderBy(w => w.Member).ToList();
            ViewBag.SpeakersList = speakers;

            var meeting = await _context.Meetings.FindAsync(id);
            if (meeting == null)
            {
                return NotFound();
            }
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MeetingDate,OptionalRestHymnTitle")] Meeting meeting)
        {
            if (id != meeting.ID)
            {
                return NotFound();
            }

            meeting.Ward = GetSelectedWard("WardSelect");
            meeting.FastAndTestimonyMeeting = (Request.Form["FastMeeting"].Count > 0);
            meeting.Presiding = GetSelectedMember("PresidingSelect");
            meeting.ConductingLeader = GetSelectedMember("ConductingSelect");
            meeting.Chorister = GetSelectedMember("ChoristerSelect");
            meeting.Organist = GetSelectedMember("OrganistSelect");
            meeting.OpeningHymn = GetSelectedHymn("OpeningHymnSelect");
            meeting.OpeningPrayerMember = GetSelectedMember("OpeningPrayerSelect");
            if (Request.Form["Announcements"].Count > 0)
            {
                meeting.Announcements = Request.Form["Announcements"][0];
            }
            meeting.SacramentHymn = GetSelectedHymn("SacramentHymnSelect");
            if (Request.Form["RestHymnSelect"].Count > 0)
            {
                meeting.OptionalRestHymnTitle = Request.Form["RestHymnSelect"][0];
            }
            meeting.OptionalRestHymnMember = GetSelectedMember("RestHymnMemberSelect");
            meeting.ClosingHymn = GetSelectedHymn("ClosingHymnSelect");
            meeting.ClosingPrayerMember = GetSelectedMember("ClosingPrayerSelect");


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meeting);
                    await _context.SaveChangesAsync();

                    // Remove Speakers
                    var speaker = await _context.Speakers.FindAsync(id);
                    _context.Speakers.Remove(speaker);
                    await _context.SaveChangesAsync();

                    // Add Speakers
                    int count = Request.Form["SpeakerMember"].Count;
                    for (int i = 0; i < count; i++)
                    {
                        Speaker s = new Speaker
                        {
                            Meeting = meeting,
                            Member = _context.Members.Find(int.Parse(Request.Form["SpeakerMember"][i])),
                            Topic = Request.Form["SpeakerTopic"][i],
                            Minutes = int.Parse(Request.Form["SpeakerMinutes"][i]),
                        };
                        _context.Speakers.Add(s);
                    }

                    await _context.SaveChangesAsync();
                    // End add
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingExists(meeting.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(meeting);
        }

        // GET: Meetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(w => w.Ward)
                .Include(s => s.Speakers)
                    .ThenInclude(m => m.Member)
                .Include(m => m.Presiding)
                .Include(m => m.Chorister)
                .Include(m => m.Organist)
                .Include(m => m.ConductingLeader)
                .Include(h => h.OpeningHymn)
                .Include(m => m.OpeningPrayerMember)
                .Include(h => h.SacramentHymn)
                .Include(m => m.OptionalRestHymnMember)
                .Include(h => h.ClosingHymn)
                .Include(m => m.ClosingPrayerMember)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meeting = await _context.Meetings.FindAsync(id);
            _context.Meetings.Remove(meeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingExists(int id)
        {
            return _context.Meetings.Any(e => e.ID == id);
        }

        /*public async  bool IsComplete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(w => w.Ward)
                .Include(s => s.Speakers)
                    .ThenInclude(m => m.Member)
                .Include(m => m.Presiding)
                .Include(m => m.Chorister)
                .Include(m => m.Organist)
                .Include(m => m.ConductingLeader)
                .Include(h => h.OpeningHymn)
                .Include(m => m.OpeningPrayerMember)
                .Include(h => h.SacramentHymn)
                .Include(m => m.OptionalRestHymnMember)
                .Include(h => h.ClosingHymn)
                .Include(m => m.ClosingPrayerMember)
                .ToListAsync();
        }*/
    }
}
