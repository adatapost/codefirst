using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Conference.Models
{
    public class ConferenceContextInitializer : DropCreateDatabaseIfModelChanges<ConferenceContext>
    {
        
        protected override void Seed(ConferenceContext context)
        {
            context.Sessions.Add(
                new Session()
                {
                    Title = "Speaking about Nari Shakti",
                    Venue = "Mehsana",
                    Abstract = "The life and times of women in india",
                     Speaker = context.Speakers.Add(
                      new Speaker(){ Name="KV Prajapati", EmailAddress="adatapost@gmail.com"})
                });
            context.SaveChanges();
        }
    }
}