namespace Tyuiu.ZipunovIM.Sprint0.Task2.V0.Test;
using Tyuiu.ZipunovIM.Sprint0.Task2.V0.lib;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckGetMessageVaLid ()

        {
            var name = "Игорь";
        var res = DataService.GetMessage(name);
        Assert.That(res, Is.EqualTo("Привет, Игорь")); 
    }
}
