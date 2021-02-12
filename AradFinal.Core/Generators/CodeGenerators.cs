using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AradFinal.Core.Generators
{
    public static class CodeGenerators
    {
        public static Guid GetGuid()
        {
            return Guid.NewGuid();
        }

        public static string GetActiveCode()
        {
            Random random = new Random();
            return random.Next(100000, 999000).ToString();
        }

        public static string GetFileCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        public static string GetOrderCode()
        {
            Random random = new Random();
            return random.Next(10000000, 99900000).ToString();
        }

        public static string GetShamsiDate()
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(DateTime.Now).ToString("0000") + "/" +
                pc.GetMonth(DateTime.Now).ToString("00") + "/" +
                pc.GetDayOfMonth(DateTime.Now).ToString("00");
        }

        public static string GetCurrentTime()
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetHour(DateTime.Now).ToString("00") + "/" +
                pc.GetMinute(DateTime.Now).ToString("00") + "/" +
                pc.GetSecond(DateTime.Now).ToString("00");
        }
    }
}
