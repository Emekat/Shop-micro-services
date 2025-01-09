namespace Catalog.API.Products.CreateProduct
{
	//application business logic
	public record CreateProductCommand(string Name, List<string> Category, decimal Price, string Description, string ImageFile);

	public class CreateProductHandler
	{
	}
}
