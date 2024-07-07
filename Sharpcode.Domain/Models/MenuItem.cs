using System;

namespace Sharpcode.Domain.Models;

internal class MenuItem
{
   public int Id { get; set; }
   public Guid UniqueId { get; set; }
   public string Name { get; set; }
   public string Hint { get; set; }
}
