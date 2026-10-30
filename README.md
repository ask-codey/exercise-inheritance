# Exercise: Inheritance

Exercise code for the lesson **Exercise: Inheritance** in the C# Full-Stack Bootcamp on [ask-codey.com](https://www.ask-codey.com).

A café's menu has plain items, such as a muffin, and two special kinds: **drinks**, priced by size, and **pastries**, which can be warmed. You'll finish the two derived classes, `Drink` and `Pastry`, so they build on `MenuItem` instead of repeating it.

## What's here

- `CafeMenu/MenuItem.cs`: the base class, with a name, a base price, `Price`, `PriceFor(quantity)` and `ToString()`. Read it first.
- `CafeMenu/Drink.cs` and `CafeMenu/Pastry.cs`: the derived classes, for you to finish. The comment at the top of each says what it should do.
- `CafeMenu.Tests`: tests for both. You don't need to change these.

## What to do

1. **The constructors.** Each derived constructor passes `""` and `0` to `MenuItem` for now. Pass the real name and base price on with `base(...)`, and keep the derived class's own value (the size, or whether it's warmed).
2. **Price.** A drink's price depends on its size, and a warmed pastry costs more. `Price` in `MenuItem` has to allow that, and each derived class has to change it.
3. **ToString.** A drink's menu line starts with its size, and a warmed pastry's ends with `(warmed)`. Reuse `MenuItem`'s line instead of writing it again.

Run the program with **Ctrl+F5** to see the menu, and run the tests with **Test > Run All Tests** (or `dotnet test`). At first every test fails: each step turns more of them green.

## Tips

- Only a `virtual` member can be overridden. A property can be `virtual` and `override` just like a method.
- `base.ToString()` returns `MenuItem`'s line, already with the right price: it uses `Price`, and a drink's `Price` is the drink's own.
- `PriceFor` needs no changes at all. Once `Price` is overridden, it works for drinks and pastries too.

## Hand it in

When it works, push your solution to a public repo of your own on GitHub, then paste that repo's address into **Submit your exercise** on the lesson page at [ask-codey.com](https://www.ask-codey.com). That's what completes the lesson. The lesson page shows the Git commands, step by step.
