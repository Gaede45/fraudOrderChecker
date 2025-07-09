string[] idOrders = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

// Detect fraudulent orders whose ID starts with 'B'
foreach (string id in idOrders)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine($"(!) Fraudulent order found: {id}");
    }
}
