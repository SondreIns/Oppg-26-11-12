bool hasSuit = true;
int oxygenPercent = 30;
int pressure = 90;
bool alarmActive = false;


bool canOpenAirlock = hasSuit && oxygenPercent >= 30 && pressure >= 90 && pressure <= 110 && !alarmActive;

if (canOpenAirlock)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}
