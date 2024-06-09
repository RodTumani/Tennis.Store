using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        string menuStr = @"
************************************************
How can we help you today? (Press the number)
1. Rackets
2. Shoes
3. Clothes
4. Strings
5. Overgrips
6. Your cart
Press other keys to exit
************************************************
";

        var racketModel = new Dictionary<string, List<string>>()
        {
            { "Wilson", new List<string> { "Blade", "Ultra", "Pro Staff", "Clash", "Shift" } },
            { "Head", new List<string> { "Speed", "Gravity", "Radical", "Prestige", "Boom", "Extreme" } },
            { "Babolat", new List<string> { "Pure Aero", "Pure Drive", "Pure Strike" } },
            { "Yonex", new List<string> { "Vcore", "Percept", "Ezone" } }
        };

        var racketPrices = new Dictionary<string, decimal>()
        {
            { "Blade", 199.99m},
            { "Ultra", 189.99m},
            { "Pro Staff", 249.99m},
            { "Clash", 229.99m},
            { "Shift", 219.99m},
            { "Speed", 219.99m},
            { "Gravity", 209.99m},
            { "Radical", 199.99m},
            { "Prestige", 249.99m},
            { "Boom", 199.99m},
            { "Extreme", 189.99m},
            { "Pure Aero", 229.99m},
            { "Pure Drive", 219.99m},
            { "Pure Strike", 209.99m},
            { "Vcore", 229.99m},
            { "Percept", 219.99m},
            { "Ezone", 209.99m}
        };

        var shoeModels = new Dictionary<string, List<string>>()
        {
            {"Wilson", new List<string> {"Rush Pro 3.5", "Kaos 3.0", "Rush Pro Ace", "Kaos Swift", "Rush Comp"} },
            {"Asics", new List<string> { "Gel-Resolution 8", "Gel-Resolution 9", "Court FF 2", "Gel-Challenger 13", "Solution Speed FF 2", "Gel-Dedicate 7" } },
            {"Nike", new List<string> {"Air Zoom Vapor Pro", "React Vapor NXT", "Air Zoom GP Turbo", "Court Air Zoom Zero", "Court Lite 2"} },
            {"Babolat", new List<string> {"Jet Mach III", "Propulse Fury", "SFX3", "Jet Tere", "Propulse Blast"} },
            {"Adidas", new List<string> { "Adizero Ubersonic 4", "Barricade 2022", "SoleCourt Boost", "CourtJam Bounce", "GameCourt 2" } }
        };

        var shoePrices = new Dictionary<string, decimal>()
        {
            { "Rush Pro 3.5", 129.99m },
            { "Kaos 3.0", 119.99m },
            { "Rush Pro Ace", 139.99m },
            { "Kaos Swift", 109.99m },
            { "Rush Comp", 99.99m },
            { "Gel-Resolution 8", 159.99m },
            { "Court FF 2", 169.99m },
            { "Gel-Challenger 13", 129.99m },
            { "Solution Speed FF 2", 139.99m },
            { "Gel-Dedicate 7", 89.99m },
            { "Jet Mach III", 149.99m },
            { "Propulse Fury", 139.99m },
            { "SFX3", 119.99m },
            { "Jet Tere", 99.99m },
            { "Propulse Blast", 109.99m },
            { "Adizero Ubersonic 4", 159.99m },
            { "Barricade 2022", 149.99m },
            { "SoleCourt Boost", 179.99m },
            { "CourtJam Bounce", 109.99m },
            { "GameCourt 2", 89.99m },
            { "Air Zoom Vapor Pro", 159.99m },
            { "React Vapor NXT", 169.99m },
            { "Air Zoom GP Turbo", 179.99m },
            { "Court Air Zoom Zero", 139.99m },
            { "Court Lite 2", 89.99m }
        };

        var clothingModels = new Dictionary<string, List<string>>()
        {
            {"Wilson", new List<string> {"Pro Staff Polo", "Blade T-Shirt", "Ultra Cap", "Rush Shorts", "Kaos Hoodie"} },
            {"Asics", new List<string> {"Gel-Resolution Polo", "Court FF T-Shirt", "Gel-Resolution Cap", "Challenger Shorts", "Solution Speed Hoodie"} },
            {"Nike", new List<string> {"Court Dri-FIT Polo", "Court Advantage T-Shirt", "Heritage86 Hat", "Flex Ace Shorts", "Court Victory Hoodie"} },
            {"Babolat", new List<string> {"Performance Polo", "Exercise T-Shirt", "Team Cap", "Play Shorts", "Training Hoodie"} },
            {"Adidas", new List<string> {"Barricade Polo", "Club T-Shirt", "Adizero Cap", "Freelift Shorts", "MatchCode Hoodie"} }
        };

        var clothingPrices = new Dictionary<string, decimal>()
        {
            { "Pro Staff Polo", 59.99m },
            { "Blade T-Shirt", 39.99m },
            { "Ultra Cap", 24.99m },
            { "Rush Shorts", 49.99m },
            { "Kaos Hoodie", 69.99m },
            { "Gel-Resolution Polo", 59.99m },
            { "Court FF T-Shirt", 39.99m },
            { "Gel-Resolution Cap", 24.99m },
            { "Challenger Shorts", 49.99m },
            { "Solution Speed Hoodie", 69.99m },
            { "Court Dri-FIT Polo", 69.99m },
            { "Court Advantage T-Shirt", 44.99m },
            { "Heritage86 Hat", 29.99m },
            { "Flex Ace Shorts", 54.99m },
            { "Court Victory Hoodie", 79.99m },
            { "Performance Polo", 59.99m },
            { "Exercise T-Shirt", 39.99m },
            { "Team Cap", 24.99m },
            { "Play Shorts", 49.99m },
            { "Training Hoodie", 69.99m },
            { "Barricade Polo", 69.99m },
            { "Club T-Shirt", 44.99m },
            { "Adizero Cap", 29.99m },
            { "Freelift Shorts", 54.99m },
            { "MatchCode Hoodie", 79.99m }
        };

        var stringModels = new Dictionary<string, List<string>>()
        {
            {"Wilson", new List<string> {"NXT Power", "NXT Control", "Synthetic Gut Power", "Revolve", "Luxilon ALU Power"} },
            {"Asics", new List<string> {"Poly Power", "Poly Spin", "Synthetic Gut", "Control Poly", "Hybrid Spin"} },
            {"Nike", new List<string> {"Court Synthetic", "Pro Feel", "Durability Max", "Spin Control", "Power Play"} },
            {"Babolat", new List<string> {"RPM Blast", "Xcel", "Pro Hurricane", "Addiction", "VS Touch"} },
            {"Adidas", new List<string> {"Poly Tour", "Syn Gut", "Durability Tour", "Spin Max", "Power Fiber"} }
        };

        var stringPrices = new Dictionary<string, decimal>()
        {
            { "NXT Power", 19.99m },
            { "NXT Control", 18.99m },
            { "Synthetic Gut Power", 9.99m },
            { "Revolve", 16.99m },
            { "Luxilon ALU Power", 24.99m },
            { "Poly Power", 14.99m },
            { "Poly Spin", 13.99m },
            { "Synthetic Gut", 8.99m },
            { "Control Poly", 15.99m },
            { "Hybrid Spin", 19.99m },
            { "Court Synthetic", 12.99m },
            { "Pro Feel", 14.99m },
            { "Durability Max", 17.99m },
            { "Spin Control", 16.99m },
            { "Power Play", 18.99m },
            { "RPM Blast", 19.99m },
            { "Xcel", 21.99m },
            { "Pro Hurricane", 14.99m },
            { "Addiction", 16.99m },
            { "VS Touch", 39.99m },
            { "Poly Tour", 15.99m },
            { "Syn Gut", 9.99m },
            { "Durability Tour", 18.99m },
            { "Spin Max", 17.99m },
            { "Power Fiber", 19.99m }
        };

        var overgripModels = new Dictionary<string, List<string>>()
        {
            {"Wilson", new List<string> {"Pro Overgrip", "Comfort Overgrip", "Ultra Wrap", "Shock Shield", "Cushion-Aire"} },
            {"Asics", new List<string> {"Pro Feel", "Super Tacky", "Control Dry", "Comfort Grip", "Durability Wrap"} },
            {"Nike", new List<string> {"GripMax", "Nike Pro Tacky", "Durability Feel", "Comfort Wrap", "Control Pro"} },
            {"Babolat", new List<string> {"Pro Tour", "VS Grip", "My Grip", "Pro Tacky", "Comfort Plus"} },
            {"Adidas", new List<string> {"Performance Grip", "Pro Wrap", "Comfort Feel", "Tour Grip", "Tacky Touch"} }
        };

        var overgripPrices = new Dictionary<string, decimal>()
        {
            { "Pro Overgrip", 6.99m },
            { "Comfort Overgrip", 5.99m },
            { "Ultra Wrap", 7.99m },
            { "Shock Shield", 8.99m },
            { "Cushion-Aire", 6.49m },
            { "Pro Feel", 5.99m },
            { "Super Tacky", 4.99m },
            { "Control Dry", 7.49m },
            { "Comfort Grip", 6.99m },
            { "Durability Wrap", 7.99m },
            { "GripMax", 6.99m },
            { "Nike Pro Tacky", 5.49m },
            { "Durability Feel", 7.49m },
            { "Comfort Wrap", 6.99m },
            { "Control Pro", 8.49m },
            { "Pro Tour", 6.99m },
            { "VS Grip", 8.99m },
            { "My Grip", 5.49m },
            { "Pro Tacky", 5.99m },
            { "Comfort Plus", 7.49m },
            { "Performance Grip", 6.49m },
            { "Pro Wrap", 5.99m },
            { "Comfort Feel", 7.99m },
            { "Tour Grip", 6.99m },
            { "Tacky Touch", 7.49m }
        };

        var cart = new List<(string category, string brand, string model, decimal price)>();

        bool showMenu = true;

        while (showMenu)
        {
            Console.Clear();
            Console.WriteLine(menuStr);
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddItemToCart("Rackets", racketModel, racketPrices, cart);
                    break;
                case "2":
                    AddItemToCart("Shoes", shoeModels, shoePrices, cart);
                    break;
                case "3":
                    AddItemToCart("Clothes", clothingModels, clothingPrices, cart);
                    break;
                case "4":
                    AddItemToCart("Strings", stringModels, stringPrices, cart);
                    break;
                case "5":
                    AddItemToCart("Overgrips", overgripModels, overgripPrices, cart);
                    break;
                case "6":
                    ViewCart(cart);
                    break;
                default:
                    showMenu = false;
                    break;
            }
        }

        DisplayThankYouMessage(cart);
    }

    static void AddItemToCart(string category, Dictionary<string, List<string>> models, Dictionary<string, decimal> prices, List<(string category, string brand, string model, decimal price)> cart)
    {
        Console.WriteLine($"\nAvailable {category}:\n");
        foreach (var brand in models.Keys)
        {
            Console.WriteLine($"{brand}: {string.Join(", ", models[brand])}");
        }

        Console.WriteLine($"\nEnter the brand of the {category}:");
        var brandInput = Console.ReadLine();

        if (!models.ContainsKey(brandInput))
        {
            Console.WriteLine("Invalid brand.");
            return;
        }

        Console.WriteLine($"\nEnter the model of the {category}:");
        var modelInput = Console.ReadLine();

        if (!models[brandInput].Contains(modelInput))
        {
            Console.WriteLine("Invalid model.");
            return;
        }

        var price = prices[modelInput];
        cart.Add((category, brandInput, modelInput, price));
        Console.WriteLine($"{modelInput} added to cart. Price: ${price}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void ViewCart(List<(string category, string brand, string model, decimal price)> cart)
    {
        Console.Clear();
        Console.WriteLine("Your cart:");
        decimal subtotal = 0;

        foreach (var item in cart)
        {
            Console.WriteLine($"{item.category} - {item.brand} {item.model}: ${item.price}");
            subtotal += item.price;
        }

        Console.WriteLine($"Subtotal: ${subtotal}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void DisplayThankYouMessage(List<(string category, string brand, string model, decimal price)> cart)
    {
        Console.Clear();
        Console.WriteLine("Thank you for shopping with us!");
        decimal total = 0;

        foreach (var item in cart)
        {
            total += item.price;
        }

        Console.WriteLine($"Your total purchase amount is: ${total}");
    }
}
