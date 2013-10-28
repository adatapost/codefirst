using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Conference.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }

        [Required(ErrorMessage="{0} is required")]
        [Display(Name="Speaker name")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name="Email")]
        [Required(ErrorMessage = "{0} is required")]
        public string EmailAddress { get; set; }

        public virtual List<Session> Sessions { get; set; }
    }
}
