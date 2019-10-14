using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Coyne_MIS4200.Models
{
    public class Car
    {
        [Display(Name = "Car ID number")]
        public int carId { get; set; }

        [Display(Name = "Model Year")]
        [Required(ErrorMessage ="Model Year is required")]
        public int modelYear { get; set; }
        
        [Display(Name = "Make")]
        public string make { get; set; }


        [Display(Name = "Model")]
        public string model { get; set; }



        [Display(Name = "Number of Seats")]

        public int seatNumber { get; set; }

    }
}