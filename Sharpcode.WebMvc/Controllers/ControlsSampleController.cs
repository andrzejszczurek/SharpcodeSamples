using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sharpcode.WebMvc.ViewModels.ControlsSamples;
using System.Linq;

namespace Sharpcode.WebMvc.Controllers;
public class ControlsSampleController : Controller
{
   [HttpGet]
   public IActionResult Index()
   {
      var comboOptions = ComboDataExtension.CreateSampleComboData();
      var items = comboOptions.Select(x => new SelectListItem(x.Value.ToString(), x.Id.ToString()));
      ViewBag.ComboBoxItems = new SelectList(items, "Value", "Text");

      return View();
   }

   [HttpPost]
   public IActionResult Post(ComboDataFormResultViewModel vm)
   {
      return Json(vm.SelectedComboBoxValue);
   }
}
