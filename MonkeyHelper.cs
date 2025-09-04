using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMonkeyApp;

/// <summary>
/// Static helper class for managing monkey data and random selection.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys = new()
    {
        new Monkey
        {
            Name = "Golden Lion Tamarin",
            ScientificName = "Leontopithecus rosalia",
            Location = "Brazil",
            Population = 3500,
            ConservationStatus = "Endangered",
            Lifespan = 15,
            WeightKg = 0.7,
            HeightCm = 26,
            Diet = "Fruits, insects",
            Description = "Known for its striking golden-orange fur.",
            AsciiArt = @"  (\_/)
 (o.o)
 />🍌"
        },
        new Monkey
        {
            Name = "Japanese Macaque",
            ScientificName = "Macaca fuscata",
            Location = "Japan",
            Population = 100000,
            ConservationStatus = "Least Concern",
            Lifespan = 27,
            WeightKg = 11,
            HeightCm = 57,
            Diet = "Fruits, seeds, insects",
            Description = "Also known as the snow monkey.",
            AsciiArt = @"  (\_/)
 (o.o)
 />🍎"
        }
        // Add more monkeys as needed
    };

    /// <summary>
    /// Returns a random monkey from the collection, or null if empty.
    /// </summary>
    public static Monkey? GetRandomMonkey()
    {
        if (monkeys.Count == 0)
            return null;
        var rand = new Random();
        return monkeys[rand.Next(monkeys.Count)];
    }

    /// <summary>
    /// Returns all monkeys in the collection.
    /// </summary>
    public static IReadOnlyList<Monkey> GetMonkeys() => monkeys;
}
