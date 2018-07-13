using System;

namespace _0630
{
    public class Birthday
    {
        public string IsTodayJoeyBirthday()
        {
            return GetToday().Month == 9 && GetToday().Day == 1 ? "Happy Birthday" : "No";
        }

        protected virtual DateTime GetToday()
        {
            return DateTime.Now;
        }
    }
}