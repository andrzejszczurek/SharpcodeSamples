using System;

namespace Sharpcode.WebMvc.ViewModels;

public class MenuItemViewModel
{
   public int Id { get; set; }
   public string Name { get; set; }
   public string Hint { get; set; }

   public string Controller { get; set; }
   public string Action { get; set; }
}
