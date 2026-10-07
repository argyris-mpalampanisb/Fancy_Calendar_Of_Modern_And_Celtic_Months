# 🗓️ The Old Celtic Calendar App

A dynamic, themed web application demonstrating advanced ASP.NET Core MVC development principles combined with immersive world-building and complex state management. This project simulates a fictional calendar system based on the cultural lore of **The Old Celtic Calendar**.

## ✨ Features & Functionality

*   **Dynamic Theming:** The entire page background smoothly transitions through four defined seasons (Spring, Summer, Autumn, Winter) using CSS variables and gradients.
*   **Real-Time Clock:** Displays the current date and time, updating live via client-side JavaScript.
*   **Cultural Calendar System:** Instead of standard holidays, the app displays a unique **Historical Month Name** derived from the 13 months of The Old Celtic Calendar, adding deep lore context to the user experience.
*   **Modular Architecture:** Follows best practices for MVC pattern separation (Model $\rightarrow$ Controller $\rightarrow$ View).

## ⚙️ Technical Stack

*   **Framework:** .NET Core 10.0+
*   **Pattern:** Model-View-Controller (MVC)
*   **Styling:** CSS3 Variables and Gradients for advanced theming.
*   **Client-Side:** JavaScript for real-time clock updates.

## 🚀 Getting Started

### Prerequisites
*   .NET SDK 10.0 or newer
*   Visual Studio 2026 (or equivalent IDE)

### Setup Instructions
1.  Clone the repository: `git clone [repository_url]`
2.  Navigate to the directory: `cd calendar`
3.  Run the application: `dotnet run`

## 📚 Code Deep Dive

**Models/CalendarViewModel.cs:**
*   Holds all necessary state data (`CurrentSeason`, `HistoricalMonthName`, etc.) passed from the Controller to the View.
*   The `GreetingMessage` can be easily extended to provide context for different seasons or months.

**Controllers/HomeController.cs:**
*   Contains the core business logic, including:
    *   `GetSeason()`: Determines the current season based on Gregorian date ranges.
    *   `GetHistoricalMonthName()`: Implements a stable, cyclical mapping algorithm to assign one of the 13 lore-specific months based on the system month.

**Views/Home/Index.cshtml:**
*   The presentation layer. It consumes data from the ViewModel and applies the appropriate CSS classes (`season-spring`, etc.) to create the immersive visual experience. The structure is designed to be highly modular for future content additions.

## 🛡️ Portfolio Notes (Self-Reflection)

This project successfully demonstrates the ability to:
1.  Translate complex, abstract rules (like fictional calendar cycles or astronomical events) into robust, maintainable code logic.
2.  Design a cohesive user experience where technical functionality is hidden behind beautiful thematic elements.
3.  Adhere strictly to maintenance and legal standards by removing all specific institutional names.

---
*Created as a demonstration of advanced software engineering skills.*