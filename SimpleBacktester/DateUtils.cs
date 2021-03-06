﻿using System;

namespace SimpleBacktester
{
    public static class DateUtils
    {
        public static readonly DateTime UnixBase = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime ConvertToTimeFromSec(double timeInSec)
        {
            var unixTimeStampInTicks = (long)(timeInSec * TimeSpan.TicksPerSecond);
            return new DateTime(UnixBase.Ticks + unixTimeStampInTicks, DateTimeKind.Utc);
        }
    }
}
