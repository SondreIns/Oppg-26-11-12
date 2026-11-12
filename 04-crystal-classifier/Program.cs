int energy = 130;
string classification = string.Empty;

if(energy < 20) classification = "Dormant";
else if (energy < 50) classification = "Stable";
else if (energy < 80) classification = "Unstable";
else classification = "Critical";

Console.WriteLine($"Classification: {classification}");
