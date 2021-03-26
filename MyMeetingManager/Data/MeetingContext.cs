using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMeetingManager.Models;
using Microsoft.EntityFrameworkCore;

namespace MyMeetingManager.Data
{
    public class MeetingContext : DbContext
    {
        public MeetingContext(DbContextOptions<MeetingContext> options) : base(options)
        {
        }

        public DbSet<Hymn> Hymns { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Ward> Wards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hymn>().ToTable("Hymns");
            modelBuilder.Entity<Meeting>().ToTable("Meetings");
            modelBuilder.Entity<Member>().ToTable("Members");
            modelBuilder.Entity<Speaker>().ToTable("Speakers");
            modelBuilder.Entity<Ward>().ToTable("Wards");
        }
    }
}
