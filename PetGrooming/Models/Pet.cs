using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetGrooming.Models
{
    public class Pet
    {

        [Key]
        public int PetID { get; set; }

        public string PetName { get; set; }
        //double data types allow for decimal places. (research and describe further)
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Notes { get; set; }

        //Foreign Key for SpeciesID
        //Represents the Many - (One species to Many Pets)
        public int SpeciesID { get; set; }
        [ForeignKey("SpeciesID")]
        public virtual Species Species { get; set; }
    }
}