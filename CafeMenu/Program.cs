using CafeMenu;

MenuItem muffin = new MenuItem("Blueberry Muffin", 2.50m);
Drink latte = new Drink("Latte", 4.00m, "Large");
Pastry croissant = new Pastry("Croissant", 3.00m, true);

Console.WriteLine("Today's menu");
Console.WriteLine(muffin);
Console.WriteLine(latte);
Console.WriteLine(croissant);
