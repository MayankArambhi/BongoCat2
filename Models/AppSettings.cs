namespace TinyBongo.Models;

/// <summary>
/// Persisted user preferences for window placement and behavior.
/// </summary>
public sealed class AppSettings
{
    public double WindowX { get; set; } = 100;
    public double WindowY { get; set; } = 100;
    public double Scale { get; set; } = 1.0;
    public bool ClickThrough { get; set; }
    public bool AlwaysOnTop { get; set; } = true;
    public bool IsVisible { get; set; } = true;
    public long ClickCount { get; set; }
}
