﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Groomer
    {

        [Key]
        public int GroomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateofBirth { get; set; }
        public int PhoneNumber { get; set; }
        public int HourlyRate { get; set; }


    }
}