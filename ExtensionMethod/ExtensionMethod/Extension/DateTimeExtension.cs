using System.Globalization;

namespace System
{
    static class DateTimeExtension
    {
        public static string ElapsedTime(this DateTime thisobject)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisobject);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
            }
            else
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
        }
    }
}
