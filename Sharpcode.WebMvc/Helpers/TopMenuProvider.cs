using Sharpcode.WebMvc.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Sharpcode.WebMvc.Helpers;

public class TopMenuProvider
{
   private static IEnumerable<MenuItemViewModel> _topMenuItems = new List<MenuItemViewModel>()
   {
      new MenuItemViewModel() { Id = 1, Name = "Home", Hint = "Home_Hint", Controller = "Home", Action = "Index" },
      new MenuItemViewModel() { Id = 2, Name = "Data transfer", Hint = "", Controller = "DataTransferSample", Action = "Index" },
      new MenuItemViewModel() { Id = 3, Name = "Controls", Hint = "", Controller = "ControlsSample", Action = "Index" },
      new MenuItemViewModel() { Id = 4, Name = "Form", Hint = "", Controller = "ControlsSample", Action = "Controls" },
      new MenuItemViewModel() { Id = 5, Name = "Toasts", Hint = "", Controller = "ControlsSample", Action = "Toasts" },

   };

   public IEnumerable<MenuItemViewModel> GetTopMenuItems() 
      => _topMenuItems.ToList();
}
