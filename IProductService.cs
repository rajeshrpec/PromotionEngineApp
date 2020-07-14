namespace PromotionEngine
{
    public interface IProductService
    {
        //Interface method which calculates the final price once promotion applied for selected items.
        int GetTotalPrice(List<Product> products);
    }
}
