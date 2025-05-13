using System.ComponentModel.DataAnnotations; // dla atrybutu [DataType]
namespace ProjektZadanie2.Data.Models;

public class Movie
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; } // "?" oznacza że może być null
    public string? Description { get; set; }
    public int? ReleaseYear { get; set; } // int? oznacza, że może być null

    [DataType(DataType.Date)]
    public DateTime? ReleaseDate { get; set; }
    public double? Rate { get; set; }
    
    public int RateNumbers { get; private set; }
    public void IncreaseRateNumbers() {++RateNumbers;}
}