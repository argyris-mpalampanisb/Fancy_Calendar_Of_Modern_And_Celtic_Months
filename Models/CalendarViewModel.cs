using System;
using System.ComponentModel.DataAnnotations; // <-- Added this using directive!

namespace calendar.Models
{
    /// <summary>
    /// ViewModel for displaying all calendar-related information, including dynamic styling data.
    /// </summary>
    public class CalendarViewModel
    {
        [Required]
        public DateTime CurrentDateTime { get; set; }

        // Season tracking (e.g., "Winter", "Spring", etc.)
        public string CurrentSeason { get; set; } = "Unknown";

        // Holiday status flags for special theming
        public string HistoricalMonthName { get; set; } = "Unknown";

        // A general message or greeting based on the current date/holiday.
        public string GreetingMessage { get; set; } = "Welcome to your The Old Celtic Calendar!";
    }
}