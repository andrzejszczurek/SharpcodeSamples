namespace Sharpcode.WebMvc.ViewModels;

public enum DataTransferSampleAction
{
   SetId,
}

public class DataTransferSampleViewModel
{
   public bool IsModelSet { get; set; }
   public int Id { get; set; }
   public DataTransferSampleAction Type { get; set; }
}
