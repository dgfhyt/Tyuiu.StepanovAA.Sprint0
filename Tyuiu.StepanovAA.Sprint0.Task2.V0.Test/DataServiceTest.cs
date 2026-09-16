using Tyuiu.StepanovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.StepanovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Artem";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hello, Artem", res);

        }
    }
}
