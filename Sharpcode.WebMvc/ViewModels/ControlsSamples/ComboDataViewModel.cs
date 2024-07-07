using System;
using System.Collections.Generic;
using System.Linq;

namespace Sharpcode.WebMvc.ViewModels.ControlsSamples;


public enum ComboOptionValue
{
   First,
   Second,
   Third
}

public class ComboDataFormResultViewModel
{
    public string SelectedComboBoxValue { get; set; }
}

   public class ComboDataViewModel
{
    public int Id { get; set; }
    public ComboOptionValue Value { get; set; }
}

public static class ComboDataExtension
{
   public static IEnumerable<ComboDataViewModel> CreateSampleComboData()
   {
      var options = Enum.GetValues<ComboOptionValue>().ToArray();
      return Enumerable.Range(0, 3).Select(x => new ComboDataViewModel() { Id = x + 1, Value = options[x] });
   }
}
