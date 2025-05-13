using System.ComponentModel.DataAnnotations; // dla atrybutu [DataType]
namespace ProjektZadanie2.Data.Models;

public class Movie
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Title is required!")]
    public string? Title { get; set; } // "?" oznacza że może być null
    public string? Description { get; set; }
    public int? ReleaseYear { get; set; } // int? oznacza, że może być null

    [DataType(DataType.Date)]
    public DateTime? ReleaseDate { get; set; }
    public double? Rate { get; set; }
    public int RateNumbers { get; private set; }
    [DataType(DataType.ImageUrl)]
    public string? ImageUrl {get; set;}

    public void IncreaseRateNumbers() {++RateNumbers;}
    public void AddRating(int newRating) {
        // Walidacja przedzdziału od 1 do 10 jest w Details.razor
        double currentTotal = (Rate ?? 0) * RateNumbers;
        double newTotal = currentTotal + newRating;
        ++RateNumbers;
        if(RateNumbers > 0) Rate = newTotal / RateNumbers;
        else Rate = null; // Nie dzielimy przez 0
    }
}