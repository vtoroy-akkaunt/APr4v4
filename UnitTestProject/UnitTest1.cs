using APr4v4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // В задании не написано удалять этот метод
            int res = 2 + 2;
            Assert.AreEqual   (res,  4);
            Assert.AreNotEqual(res,  5);
            Assert.IsFalse    (res > 5);
            Assert.IsTrue     (res < 5);
        }
        [TestMethod]
        public void Formula1_Valid()
        {
            Assert.AreEqual(Formulas.calc_1(0, 0, 0), 0.0);
            Assert.AreEqual(Formulas.calc_1(5, 5, 0), 0.0);
            Assert.AreEqual(Formulas.calc_1(5, 0, 0), 0.71634, 0.001);
        }
        [TestMethod]
        public void Formula2_Valid()
        {
            Assert.AreEqual(Formulas.calc_2(0, 0, Formulas.Function2.sh_x),  0.5   , 0.001);
            Assert.AreEqual(Formulas.calc_2(0, 0, Formulas.Function2.x2  ),  0.5   , 0.001);
            Assert.AreEqual(Formulas.calc_2(0, 0, Formulas.Function2.ex  ),  1.5   , 0.001);
            Assert.AreEqual(Formulas.calc_2(1, 0, Formulas.Function2.sh_x),  2.4888, 0.001);
            Assert.AreEqual(Formulas.calc_2(1, 0, Formulas.Function2.x2  ),  1.7854, 0.001);
            Assert.AreEqual(Formulas.calc_2(1, 0, Formulas.Function2.ex  ), 21.3038, 0.001);
            Assert.AreEqual(Formulas.calc_2(1, 1, Formulas.Function2.sh_x), 10.7920, 0.001);
            Assert.AreEqual(Formulas.calc_2(1, 1, Formulas.Function2.x2  ), 8.5    , 0.001);
            Assert.AreEqual(Formulas.calc_2(1, 1, Formulas.Function2.ex  ), 51.9076, 0.001);
        }
        [TestMethod]
        public void Formula3_Valid()
        {
            // Отображение в приложении проводится с двумя знаками после запятой, но тут
            // честно подсчитано вручную, а не скопировано из приложения ^_^
            Assert.AreEqual(Formulas.calc_3(1, 1,  1),  2.0   , 0.001);
            Assert.AreEqual(Formulas.calc_3(1, 1,  2),  8.5684, 0.001);
            Assert.AreEqual(Formulas.calc_3(1, 1,  3), 27.4185, 0.001);
            Assert.AreEqual(Formulas.calc_3(0, 0,  0),  0.0   , 0.001);
            Assert.AreEqual(Formulas.calc_3(0, 0, -3),  0.0853, 0.001);
        }
        [TestMethod]
        public void Formulas_Invalid()
        // На самом деле в задании написано написать
        // "ещё три теста" (помимо TestMethod1), а это уже четвёртый,
        // но при желании можно и удалить
        {
            // В формулах нет ни одного места, где могло бы возникнуть деление на ноль
            // или выход за границы ОДЗ функций, так что ради разнообразия можно тестировать
            // на распространение нечисел.
            Assert.AreEqual(Formulas.calc_1(double.NaN, 0, 0                    ), double.NaN);
            Assert.AreEqual(Formulas.calc_2(0, double.NaN, Formulas.Function2.x2), double.NaN);
            Assert.AreEqual(Formulas.calc_3(0, 0, double.NaN                    ), double.NaN);
        }
    }
}
