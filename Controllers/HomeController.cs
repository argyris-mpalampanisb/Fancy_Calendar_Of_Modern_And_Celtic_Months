using calendar.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;

namespace calendar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Instantiate and populate the ViewModel with current system data
            var viewModel = new CalendarViewModel
            {
                CurrentDateTime = DateTime.Now,
                // Season detection is handled by GetSeason helper method
                CurrentSeason = GetSeason(DateTime.Now),
                HistoricalMonthName = GetHistoricalMonthName(DateTime.Now) // <-- UPDATED CALL
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // --- Calendar Logic Helpers ---

        /// <summary>Determines the current season based on the date.</summary>
        private string GetSeason(DateTime date)
        {
            int month = date.Month;
            if ((month >= 12 && month <= 2) || (month == 3)) return "Winter";
            if (month >= 3 && month <= 5) return "Spring";
            if (month >= 6 && month <= 8) return "Summer";
            return "Autumn";
        }

        /// <summary>
        /// Determines the historical month name based on a simulated cycle from the Isles Calendar.
        /// </summary>
        private string GetHistoricalMonthName(DateTime date)
        {
            // The 13 months in order: Earth, Harvest, Nets, Rain, Wind, Darkness, High Cold, Ice, Hearths, Seeds, Timber, Clans, Songs
            string[] historicalMonths = new string[] {
                "The Month of Earth", "The Month of Harvest", "The Month of Nets", 
                "The Month of Rain", "The Month of Wind", "The Month of Darkness", 
                "The Month of High Cold", "The Month of Ice", "The Month of Hearths", 
                "The Month of Seeds", "The Month of Timber", "The Month of Clans", 
                "The Month of Songs"
            };

            // We use (date.Month - 1) % 13 to cycle through the 13 months array index.
            // This provides a stable, cyclical mapping for demonstration purposes based on the Gregorian month number.
            int monthIndex = (date.Month - 1) % historicalMonths.Length;
            return historicalMonths[monthIndex];
        }

        // Keeping these methods as placeholders, but they are no longer called by Index()
        private bool CalculateOrthodoxChristmas(DateTime date)
        {
            // Placeholder for complex math. Removed from main flow.
            return false; 
        }

        private bool CalculateOrthodoxEaster(DateTime date)
        {
            // Placeholder for complex math. Removed from main flow.
            return false; 
        }
    }
}