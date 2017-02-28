using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCSafety.Models
{
    public class Item
    {

        public int ID { get; set; }

        [Display(Name = "Area")]
        [Required(ErrorMessage = "You cannot leave the area name empty")]
        public string itemArea { get; set; }

        [Display(Name = "Hazard Description")]
        [Required(ErrorMessage = "You cannot leave the hazard description empty")]
        public string itemHazComment { get; set; }

        [Display(Name = "Corrective Action Due Date")]
        [Required(ErrorMessage = "You cannot leave the corrective action due date empty")]
        public DateTime itemCorrActionDt { get; set; }

        [Display(Name = "Corrective Action Completion Date")]
        public DateTime itemCorrActionCompleted { get; set; }

        [Display(Name = "Additional Comment")]
        public string itemComment { get; set; }

        public int InspectionID { get; set; }

        public virtual Inspection Inspection { get; set; }
        public virtual ICollection<Hazard> Hazards { get; set; }

    }
}