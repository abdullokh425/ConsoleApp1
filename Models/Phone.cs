using ConsoleApp1.Services;

namespace ConsoleApp1.Models;

public class Phone
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }
    public string Color { get; set; }
}