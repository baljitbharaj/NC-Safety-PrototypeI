using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCSafety.Models
{
    public class Lab
    {
        public int ID { get; set; }

        [Display(Name = "Lab Building")]
        [Required(ErrorMessage = "You cannot leave the lab building empty")]
        public string labBuilding { get; set; }

        [Display(Name = "Lab Number")]
        [Required(ErrorMessage = "You cannot leave the lab number empty")]
        public string labNumber { get; set; }

        [Display(Name = "School")]
        [Required(ErrorMessage = "You must select a school.")]
        public int schID { get; set; }

        public virtual ICollection<Hazard> Hazards { get; set; }

        public virtual ICollection<Equipment> Equipments { get; set; }

        public virtual School School { get; set; }
    }
}