using Core.Entities;

namespace Task.ViewModels;

public class HomeViewModel
{
    public IEnumerable<SlideItem> SlideItems { get; set; } = null!;
    public IEnumerable<ShippingItem2> ShippingItem2s { get; set; } =null!;
}
