string transmission = "###";
int interferenceCount = 0;

foreach(char c in transmission)
{
    if(c.Equals('#')) interferenceCount++;
}

Console.WriteLine($"Interference markers: {interferenceCount}");
