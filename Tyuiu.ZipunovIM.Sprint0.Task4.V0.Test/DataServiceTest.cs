namespace Tyuiu.ZipunovIM.Sprint0.Task4.V0.Test
{
    using Tyuiu.ZipunovIM.Sprint0.Task4.V0.Lib;
    public class Tests
    {
        [Test]
        public void Setup()
        {
        }

        [Test]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [Test]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        [Test]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [Test]
        public void ChekedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}