/*
    Example for Falgs enumerator
*/

namespace DayEnumerator
    {
        [Flags]
        enum Day
        {
            Sat = 0b_0000_0001,
            Sun = 0b_0000_0010,
            Mon = 0b_0000_0100,
            Tue = 0b_0000_1000,
            Wed = 0b_0001_0000,
            Thu = 0b_0010_0000,
            Fri = 0b_0100_0000,
            WeekEnds = Sat | Sun,
            WeekDays = ~ WeekEnds
        }
}