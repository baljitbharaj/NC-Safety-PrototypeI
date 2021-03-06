﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace NCSafety.Models
{
    
    public class Equipment
    {
        public int ID { get; set; }

        [Display(Name = "Equipment Name")]
        [Required(ErrorMessage = "You cannot leave the equipment name empty")]
        public string eqName { get; set; }

        [Display(Name = "Lab")]
        [Required(ErrorMessage = "You must select a lab.")]
        public int labID { get; set; }

        public virtual Lab Lab { get; set; }
    }
}