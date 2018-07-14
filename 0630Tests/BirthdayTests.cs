using _0630;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _0630Tests
{
    [TestClass()]
    public class BirthdayTests
    {
        private FakeBirthday _fakeBirthday = new FakeBirthday();

        [TestMethod()]
        public void today_is_joey_birthday()
        {
            GivenDate(new DateTime(2018, 9, 1));

            TheResultShouldBe("Happy Birthday");
        }

        private void GivenDate(DateTime dateTime)
        {
            _fakeBirthday.SetDate(dateTime);
        }

        private void TheResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _fakeBirthday.IsTodayJoeyBirthday());
        }

        [TestMethod()]
        public void today_is_not_joey_birthday()
        {
            GivenDate(new DateTime(2018, 1, 1));

            TheResultShouldBe("No");
        }
    }

    internal class FakeBirthday : Birthday
    {
        private DateTime _day;

        protected override DateTime GetToday()
        {
            return _day;
        }

        public void SetDate(DateTime dateTime)
        {
            _day = dateTime;
        }
    }
}