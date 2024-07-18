using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sharpcode.WebMvc.ViewModels.ControlsSamples;
using System;
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

   [HttpGet]
   public IActionResult Controls()
   {
      ViewBag.GenderComboBoxItems = Enum.GetNames<Gender>()
         .Select(v => new SelectListItem() { Value = v, Text = v })
         .ToList();

      return View();
   }

   [HttpGet]
   public IActionResult Toasts()
   {
      return View();
   }


   [HttpPost]
   public IActionResult ControlsForm(ControlFormsViewModel vm)
   {
      return Json(vm);
   }
}
