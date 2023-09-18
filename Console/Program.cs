
// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine($"Rolled {roll}.");

Random dice = new Random();
int roll1 = dice.Next();
// The first version of the Next() method doesn't set an upper and lower boundary, 
// so the method will return values ranging from 0 to 2,147,483,647, which is the maximum value 
// an int can store.
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

