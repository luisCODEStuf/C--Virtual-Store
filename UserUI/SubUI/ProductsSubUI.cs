using Store.Models;
using Store.Services;

namespace Store.UI.SubUI
{
    public class ProductsSubUI
    {
        public void ListProducts()
        {   
            GenerateProducts generateProducts = new GenerateProducts();
            var products = generateProducts.CreateSampleProducts();
            Console.WriteLine(string.Join("\n", products.Select(p => $"{p.Category}-[{p.Id}] {p.Name} - R$ {p.Price:F2}")));
        }

        public void ListProductsByCategory()
        {   
            string category = Console.ReadLine() ?? string.Empty;
            GenerateProducts generateProducts = new GenerateProducts();
            var products = generateProducts.CreateSampleProducts();
            var filteredProducts = products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();

            if (filteredProducts.Count == 0)
            {
                Console.WriteLine($"No products found in category: {category}");
            }
            else
            {
                Console.WriteLine(string.Join("\n", filteredProducts.Select(p => $"[{p.Id}] {p.Name} - R$ {p.Price:F2}")));
            }
        }    
        
        public void Search(Cart cart)
        {   

            string searchTerm = Console.ReadLine() ?? string.Empty;
            if(int.TryParse(searchTerm, out int productId))
            {
                GenerateProducts generateProducts = new GenerateProducts();
                var products = generateProducts.CreateSampleProducts();
                var product = products.FirstOrDefault(p => p.Id == productId);

                if (product == null)
                {
                    Console.WriteLine($"No product found with ID: {productId}");
                }
                else
                {
                    Console.WriteLine($"[{product.Id}] {product.Name} - R$ {product.Price:F2}");
                    Console.Write("Would you like to add this product to your cart? (yes/no): ");
                    string response = Console.ReadLine() ?? string.Empty;
                    if (response.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {   
                        CartServices cartServices = new CartServices();
                        cartServices.AddProduct(cart, product);
                        Console.WriteLine($"{product.Name} has been added to your cart.");
                    }
                    else
                    {
                        Console.WriteLine("Product not added to cart.");
                    }
                }
                return;
            }else{
            GenerateProducts generateProducts = new GenerateProducts();
            var products = generateProducts.CreateSampleProducts();
            var searchResults = products.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();

            if (searchResults.Count == 0)
            {
                Console.WriteLine($"No products found matching: {searchTerm}");
            }
            else
            {
                Console.WriteLine(string.Join("\n", searchResults.Select(p => $"[{p.Id}] {p.Name} - R$ {p.Price:F2}")));
            }
        }
            }

            public void ReturnToMenu()
            {
                Console.WriteLine("Returning to main menu...");
                Console.Clear();
            }
        }
}