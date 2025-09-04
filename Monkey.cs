using System;

/// <summary>
/// Represents a monkey species with detailed properties based on MonkeyMCP data.
/// </summary>
namespace MyMonkeyApp;

public class Monkey
{
    /// <summary>
    /// The common name of the monkey species.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The scientific name of the monkey species.
    /// </summary>
    public string ScientificName { get; set; } = string.Empty;

    /// <summary>
    /// The continent or region where the monkey is found.
    /// </summary>
    public string Location { get; set; } = string.Empty;

    /// <summary>
    /// The estimated population of the monkey species.
    /// </summary>
    public int? Population { get; set; }

    /// <summary>
    /// The conservation status (e.g., Endangered, Vulnerable).
    /// </summary>
    public string ConservationStatus { get; set; } = string.Empty;

    /// <summary>
    /// The average lifespan in years.
    /// </summary>
    public int? Lifespan { get; set; }

    /// <summary>
    /// The average weight in kilograms.
    /// </summary>
    public double? WeightKg { get; set; }

    /// <summary>
    /// The average height in centimeters.
    /// </summary>
    public double? HeightCm { get; set; }

    /// <summary>
    /// The primary diet of the monkey species.
    /// </summary>
    public string Diet { get; set; } = string.Empty;

    /// <summary>
    /// A brief description or interesting fact about the monkey.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Optional ASCII art for visual representation.
    /// </summary>
    public string? AsciiArt { get; set; }
}
