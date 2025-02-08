using System.Globalization;

namespace CultureGR_MVC_ModelFirst.Models
{
    public class HomeViewModel
    {
        public string CurrentDay { get; set; } = string.Empty;

        public void OnGet()
        {
            TimeZoneInfo greeceTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Europe/Athens");
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, greeceTimeZone);
            CurrentDay = localTime.ToString("F", CultureInfo.CreateSpecificCulture("el-GR"));
        }
    }
}
