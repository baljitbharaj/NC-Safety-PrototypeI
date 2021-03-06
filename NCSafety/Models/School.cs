﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCSafety.Models
{
    public class School
    {
        public int ID { get; set; }

        [Display(Name = "School Name")]
        [Required(ErrorMessage = "You cannot leave the school name empty")]
        public string schName { get; set; }

        [Display(Name = "Associate Dean First Name")]
        public string ascDeanFirst { get; set; }

        [Display(Name = "Associate Dean Last Name")]
        public string ascDeanLast { get; set; }

        [Display(Name = "Associate Dean Email")]
        public string ascDeanEmail { get; set; }

        [Display(Name = "Associate Dean Assistant Email")]
        public string ascDeanAssistantEmail { get; set; }



        public virtual ICollection<Lab> Labs { get; set; }
    }
}