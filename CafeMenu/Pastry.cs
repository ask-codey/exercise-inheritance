namespace CafeMenu;

// A pastry can be warmed up, for 75 cents more.
// On the menu board, a warmed pastry ends with "(warmed)": "Croissant, $3.75 (warmed)".
public class Pastry : MenuItem
{
    public bool IsWarmed { get; }

    public Pastry(string name, decimal basePrice, bool isWarmed) : base("", 0)
    {
        // Pass the name and the base price on to MenuItem, and keep whether it's warmed.
    }
}
