namespace EShop.ModelViews
{
    public class CreateProductViewModel
    {
        public ProductDataModelView ProductData { get; set; } = new();
        public CategorySelectModelView CategorySelect { get; set; } = new();
    }
}
