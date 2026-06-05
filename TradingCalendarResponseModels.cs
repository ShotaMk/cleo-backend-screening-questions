record CalendarResponse(
    Dictionary<string, CalendarMonthData> MonthsByKey,
    List<CalendarYearNavItem> NavYears,
    List<CalendarMonthNavItem> NavMonths,  
    string SelectedMonthKey,
    List<string> Weekdays,
    List<Option> ProfitModes,
    List<Option> WeekStartOptions
);

record CalendarYearNavItem(
    int Value,
    string Label,
    bool IsSelected,
    bool IsDisabled
);

record CalendarMonthNavItem(
    string Key,
    int Year,
    string Label,
    bool IsSelected,
    bool IsDisabled
);

record CalendarMonthData(
    int DaysInMonth,
    int FirstDayWeekdayIndex,
    List<TradingDay> Days
);

record TradingDay(
    int Day,
    int PositionsCount,
    decimal ProfitUsdt,
    decimal ProfitPercent
);

record Option(
    string Value,
    string Label,
    bool IsSelected
);

//Assumption

// - Month keys use YYYY-MM format, for example 2019-10.
// - SelectedMonthKey always points to an existing key in MonthsByKey.
// - Disabled months can be shown in navigation but are absent from MonthsByKey.
// - Days contains only days with positions; missing days are rendered as empty cells with "-".
// - FirstDayWeekdayIndex is based on the returned Weekdays order.
// - Popup open state is FE-only and not included.
// - FE builds the calendar grid from DaysInMonth, FirstDayWeekdayIndex and Weekdays; no external calendar library is required.






record CalendarResponse(
    List<CalendarYearNavItem> Years,
    List<CalendarMonth> Months,
    List<string> Weekdays,
    List<Option> ProfitModes,
    List<Option> WeekStartOptions
);

record CalendarYearNavItem(
    int Value,
    string Label,
    bool IsSelected,
    bool IsDisabled
);

record CalendarMonth(
    int Year,
    int Month,
    string Label,
    bool IsSelected,
    bool IsDisabled,
    int DaysInMonth,
    int FirstDayWeekdayIndex,
    List<TradingDay> Days
);

record TradingDay(
    int Day,
    int PositionsCount,
    decimal ProfitUsdt,
    decimal ProfitPercent
);

record Option(
    string Value,
    string Label,
    bool IsSelected
);
