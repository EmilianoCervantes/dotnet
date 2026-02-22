void Divider(string title = "New Section:")
{
  Console.WriteLine("\n----- ----- ----- ----- -----");
  Console.WriteLine("----- ----- ----- ----- -----\n");

  Console.WriteLine(title);
}

Divider("Now and Today:\n");

var now = DateTime.Now;
var utcNow = DateTime.UtcNow;

Console.WriteLine($"Right now: {now}"); // My local time.
Console.WriteLine($"UTC Right now: {utcNow}");

var today = DateTime.Today;
Console.WriteLine($"Today: {today}");

Divider("DateOnly and TimeOnly:\n");
var dtOnly = DateOnly.FromDateTime(DateTime.Now);
var tmOnly = TimeOnly.FromDateTime(DateTime.Now);
var tmOnlyUTC = TimeOnly.FromDateTime(DateTime.UtcNow);
Console.WriteLine($"DateOnly Now: {dtOnly}");
Console.WriteLine($"TimeOnly Now: {tmOnly}");
Console.WriteLine($"TimeOnly UTC Now: {tmOnlyUTC}");

Divider("Date Properties!\n");
Console.WriteLine($"DayOfWeek: {now.DayOfWeek}");
Console.WriteLine($"DayOfYear: {now.DayOfYear}");

var daysAdded = 5;
var hrsAdded = 2;
var monthsAdded = 1;
var minsAdded = 17;

var futureNow = now.AddDays(daysAdded);
futureNow = futureNow.AddHours(hrsAdded);
futureNow = futureNow.AddMonths(monthsAdded);
futureNow = futureNow.AddMinutes(minsAdded);
Console.WriteLine($"{monthsAdded} months, {daysAdded} days, {hrsAdded} hours, and {minsAdded} mins into the future: {futureNow}!");

Divider("Time Spans!\n");
var AprilFools = new DateTime(now.Year, 4, 1);
var xMass = new DateTime(now.Year, 12, 24);
TimeSpan interval = xMass - AprilFools;
TimeSpan interval2 = AprilFools - xMass;

Console.WriteLine($"Is Fools day before XMass? {AprilFools < xMass}.");
Console.WriteLine($"There is a time span of {interval} between April Fools and XMass.");
Console.WriteLine($"Can we do it the other way around? interval2 = {interval2}.");

Divider("Formatting dates (all these depending on LOCALE):\n");
Console.WriteLine($"utcNow:d (dd/mm/yyy) or (mm/dd/yyy): {utcNow:d}.");
Console.WriteLine($"utcNow:D (Weekday, dd mm yyyy): {utcNow:D}.");
Console.WriteLine($"utcNow:f (Weekday, dd mm yyyy hh:mm): {utcNow:f}.");
Console.WriteLine($"utcNow:g (dd/mm/yyyy hh:mm): {utcNow:g}.");
Console.WriteLine($"utcNow:G (dd/mm/yyyy hh:mm:ss): {utcNow:G}.\n");
Console.WriteLine($"utcNow:Custom made => {utcNow:dddd, MMMM, d - yyyy}.");
Console.WriteLine($"utcNow:Another custom => {utcNow:ddd, MM, d - yy}.");

Divider("Parsing different formats into dates:\n");
string[] sampleDateTimes = {
    "January 1, 2025 9:30 AM",
    "1/1/2025",
    "Jan 1, 2025 7:30PM",
    "Jan 1, 25",
    "1/2025",
    "1/1 7PM",
    "Jan 1 '15",
};

foreach (string dtStr in sampleDateTimes)
{
  DateTime result;
  // Use the static class function TryParse to try parsing the dates
  if (DateTime.TryParse(dtStr, out result))
  {
    Console.WriteLine($"{dtStr,-30} gets parsed as: {result}");
  }
  else
  {
    Console.WriteLine($"Could not parse '{dtStr}'");
  }
}
