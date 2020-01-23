using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomBooking
    {

        [Key]
        //grabbing the values and then setting/defining them.
        public int BookingID { get; set; }
        public int Date { get; set; }
        public int Time { get; set; }
        public int Price { get; set; }

    }
}