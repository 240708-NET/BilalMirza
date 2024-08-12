// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// adds +1 to counter and writes to log every second
var counter = 0;
var max = args.Length is not 0 ? Convert.ToInt32(args[0]) : -1;
while (max is -1 || counter < max)
{
    Console.WriteLine($"Counter: {++counter}");
    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
}