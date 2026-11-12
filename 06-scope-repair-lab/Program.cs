int signalStrength = 68;

string status = string.Empty;
if(signalStrength >= 70) status = "STRONG";
else status = "WEAK";

Console.WriteLine($"Signal status: {status}");
