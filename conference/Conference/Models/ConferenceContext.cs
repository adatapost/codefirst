using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class ConferenceContext : DbContext
    {
        public ConferenceContext() : base("ConferenceDb")
        { }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
    }
}