﻿using AspireDemo.Shared;

namespace AspireDemo.Web.Services;

public class ProductService(HttpClient httpClient, ILogger<ProductService> logger)
{
	public async Task<List<Product>> GetProducts()
    {
        List<Product>? products = null;
		try
		{
	    	var response = await httpClient.GetAsync("/api/Product");
	    	var responseText = await response.Content.ReadAsStringAsync();

			logger.LogInformation($"Http status code: {response.StatusCode}");
    	    logger.LogInformation($"Http response content: {responseText}");

		    if (response.IsSuccessStatusCode)
		    {
			    products = await response.Content.ReadFromJsonAsync(ProductSerializerContext.Default.ListProduct);
		    }
		}
		catch (Exception ex)
		{
			logger.LogError(ex, "Error during GetProducts.");
		}

		return products ?? [];
    }
    
}
