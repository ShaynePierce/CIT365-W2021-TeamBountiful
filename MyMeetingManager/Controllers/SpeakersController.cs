using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMeetingManager.Data;
using MyMeetingManager.Models;

namespace MyMeetingManager.Controllers
{
    public class SpeakersController : Controller
    {
        private readonly MeetingContext _context;

        public SpeakersController(MeetingContext context)
        {
            _context = context;
        }

        // GET: Speakers
        public async Task<IActionResult> Index()
        {
            var speakers = await _context.Speakers
                .Include(m => m.Member)
                .Include(m => m.Meeting)
                .AsNoTracking()
                .OrderBy(s => s.Meeting.MeetingDate).ThenBy(m => m.Member.Name)
                .ToListAsync();
            return View(speakers);
        }

        // GET: Speakers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speakers
                .Include(m => m.Member)
                .Include(m => m.Meeting)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (speaker == null)
            {
                return NotFound();
            }

            return View(speaker);
        }

        // GET: Speakers/Create
        public IActionResult Create()
        {
            var members = _context.Members.OrderBy(m => m.Name).ToList();
            ViewBag.MemberList = members;
            var meetings = _context.Meetings.Where(d => d.MeetingDate > DateTime.Now.AddDays(-1)).OrderBy(d => d.MeetingDate).ToList();
            ViewBag.MeetingList = meetings;
            return View();
        }

        // POST: Speakers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Topic,Minutes")] Speaker speaker)
        {
            speaker.Member = GetSelectedMember("MemberSelect");
            speaker.Meeting = GetSelectedMeeting("MeetingSelect");

            if (ModelState.IsValid)
            {
                _context.Add(speaker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(speaker);
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
        public Meeting GetSelectedMeeting(String FormElement)
        {
            Meeting meeting = null;
            try
            {
                meeting = _context.Meetings.Find(int.Parse(Request.Form[FormElement][0]));
            }
            catch (Exception)
            {
                //do nothing
            }
            return meeting;
        }


        // GET: Speakers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speakers.FindAsync(id);
            if (speaker == null)
            {
                return NotFound();
            }

            var members = _context.Members.OrderBy(m => m.Name).ToList();
            ViewBag.MemberList = members;
            var meetings = _context.Meetings.OrderBy(d => d.MeetingDate).ToList();
            ViewBag.MeetingList = meetings;

            return View(speaker);
        }

        // POST: Speakers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Topic,Minutes")] Speaker speaker)
        {
            if (id != speaker.ID)
            {
                return NotFound();
            }

            speaker.Member = GetSelectedMember("MemberSelect");
            speaker.Meeting = GetSelectedMeeting("MeetingSelect");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(speaker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpeakerExists(speaker.ID))
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
            return View(speaker);
        }

        // GET: Speakers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speakers
                .Include(m => m.Member)
                .Include(m => m.Meeting)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (speaker == null)
            {
                return NotFound();
            }

            return View(speaker);
        }

        // POST: Speakers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var speaker = await _context.Speakers.FindAsync(id);
            _context.Speakers.Remove(speaker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpeakerExists(int id)
        {
            return _context.Speakers.Any(e => e.ID == id);
        }
    }
}
