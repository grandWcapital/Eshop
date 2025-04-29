namespace EShop.ModelViews
{
    public class ProductCreateDto
    {
        
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string Image { get; set; }
            public int NumberInStock { get; set; }
            public List<int> CategoryIds { get; set; }
        
    

}
}
