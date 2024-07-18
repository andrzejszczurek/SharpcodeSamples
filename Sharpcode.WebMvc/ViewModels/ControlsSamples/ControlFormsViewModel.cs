using System;
using System.ComponentModel.DataAnnotations;

namespace Sharpcode.WebMvc.ViewModels.ControlsSamples;

public enum Gender
{
   Male,
   Female
}

public class ControlFormsViewModel
{
   [Display(Name = "Imię")]
   public string Name { get; set; }
   public string Surname { get; set; }
   public int Age { get; set; }
   public DateTime Birtdate { get; set; }
   public string Gender { get; set; }
}
