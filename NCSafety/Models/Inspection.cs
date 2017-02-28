using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCSafety.Models
{
    public class Inspection
    {
        public int ID { get; set; }

        [Display(Name = "School")]
        [Required(ErrorMessage = "You must select a school.")]
        public int schID { get; set; }

        [Display(Name = "Lab")]
        [Required(ErrorMessage = "You must select a lab.")]
        public int labID { get; set; }

        [Display(Name = "Inspection Date")]
        [Required(ErrorMessage = "You cannot leave the inspection date empty")]
        public DateTime inspDate { get; set; }


        public virtual ICollection<Item> Items { get; set; }
        public virtual School School { get; set; }
        public virtual Lab Lab { get; set; }
    }
}