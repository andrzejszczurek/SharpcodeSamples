using Microsoft.AspNetCore.Mvc;
using Sharpcode.WebMvc.ViewModels;

namespace Sharpcode.WebMvc.Controllers;
public class DataTransferSampleController : Controller
{
   public IActionResult Index()
   {
      return View();
   }

   public IActionResult SampleModelNotSet()
   {
      var vm = new DataTransferSampleViewModel();
      vm.IsModelSet = false;
      return View("Index", vm);
   }

   [HttpGet("{id:int}")]
   public IActionResult ModelSetWithId(int id)
   {
      var vm = new DataTransferSampleViewModel();
      vm.IsModelSet = true;
      vm.Id = id;
      return View("Index", vm);
   }
}
