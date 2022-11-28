using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace laba4
{
    [TestFixture]
    class Test
    {
        [Test]
        //тест первого метода привводе даты рождения
        public void TestGetSingOfZodiakByNumberAndNumber()
        {
            Assert.AreEqual("Овен", Znak.Zodiak(22,3));
            Assert.AreEqual("Телец", Znak.Zodiak(22, 4));
            Assert.AreEqual("Близнецы", Znak.Zodiak(22, 5));
            Assert.AreEqual("Рак", Znak.Zodiak(23, 6));
            Assert.AreEqual("Лев", Znak.Zodiak(24, 7));
            Assert.AreEqual("Дева", Znak.Zodiak(25, 8));
            Assert.AreEqual("Весы", Znak.Zodiak(25, 9));
            Assert.AreEqual("Скорпион", Znak.Zodiak(25, 10));
            Assert.AreEqual("Стрелец", Znak.Zodiak(24, 11));
            Assert.AreEqual("Козерог", Znak.Zodiak(23, 12));
            Assert.AreEqual("Водолей", Znak.Zodiak(22, 1));
            Assert.AreEqual("Рыбы", Znak.Zodiak(20, 2));
        }
        [Test]
        public void TestGetSingOfZodiakByNumberAndString()
        {
            Assert.AreEqual("Овен", Znak.Zodiak(22, "Март"));
            Assert.AreEqual("Телец", Znak.Zodiak(22, "Апрель"));
            Assert.AreEqual("Близнецы", Znak.Zodiak(22, "Май"));
            Assert.AreEqual("Рак", Znak.Zodiak(23, "Июнь"));
            Assert.AreEqual("Лев", Znak.Zodiak(24, "Июль"));
            Assert.AreEqual("Дева", Znak.Zodiak(25, "Август"));
            Assert.AreEqual("Весы", Znak.Zodiak(25, "Сентябрь"));
            Assert.AreEqual("Скорпион", Znak.Zodiak(25, "Октябрь"));
            Assert.AreEqual("Стрелец", Znak.Zodiak(24, "Ноябрь"));
            Assert.AreEqual("Козерог", Znak.Zodiak(23, "Декабрь"));
            Assert.AreEqual("Водолей", Znak.Zodiak(22, "Январь"));
            Assert.AreEqual("Рыбы", Znak.Zodiak(20, "Февраль"));
        }
        [Test]
        public void TestGetSingOfZodiakByNumberAndNumerErrorInput()
        {
            Assert.AreEqual("Проверьте правильность заполнения формы и повторите попытку", Znak.Zodiak(70, 3));
        }
        [Test]
        public void TestGetSingOfZodiakByNumberAndStringErrorInput()
        {
            Assert.AreEqual("Проверьте правильность заполнения формы и повторите попытку", Znak.Zodiak(15, "август"));
        }
        [Test]
        public void TestGetDateBySingOfZodiak()
        {
            Assert.AreEqual("21 Марта - 20 Апреля", Znak.Zodiak("Овен"));
            Assert.AreEqual("21 Апреля - 20 Мая", Znak.Zodiak("Телец"));
            Assert.AreEqual("21 Мая - 21 Июня", Znak.Zodiak("Близнецы"));
            Assert.AreEqual("22 Июня - 22 Июля", Znak.Zodiak("Рак"));
            Assert.AreEqual("23 Июля - 23 Августа", Znak.Zodiak("Лев"));
            Assert.AreEqual("24 Августа - 23 Сентября", Znak.Zodiak("Дева"));
            Assert.AreEqual("24 Сентября - 23 Октября", Znak.Zodiak("Весы"));
            Assert.AreEqual("24 Октября - 22 Ноября", Znak.Zodiak("Скорпион"));
            Assert.AreEqual("23 Ноября - 21 Декабря", Znak.Zodiak("Стрелец"));
            Assert.AreEqual("22 Декабря - 20 Января", Znak.Zodiak("Козерог"));
            Assert.AreEqual("21 Января - 18 Февраля", Znak.Zodiak("Водолей"));
            Assert.AreEqual("19 Февраля - 20 Марта", Znak.Zodiak("Рыбы"));
        }
        [Test]
        public void TestGetDateBySingOfZodiakErrorInput()
        {
            Assert.AreEqual("Проверьте правильность заполнения формы и повторите попытку", Znak.Zodiak("Овн"));
        }
    }
}
