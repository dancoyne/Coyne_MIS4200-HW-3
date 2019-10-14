using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Coyne_MIS4200.Models
{
    public class Appoitment
    {
        [Display(Name = "Appoitment Number")]
        public int appoitmentID  { get; set; }
        [Display(Name = "Type of Service")]
        public int appoitmentDescription { get; set; }
        [Display(Name = "Appotment Price")]
        public int appoitmentPrice { get; set; }
        
        public int carId { get; set; }
       
        public virtual Car Car { get; set; }
        
        public int ownerID { get; set; }
       
        public virtual Owner Owner { get; set; }

    }
}