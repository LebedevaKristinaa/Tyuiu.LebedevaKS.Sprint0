using Tyuiu.LebedevaKS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.LebedevaKS.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetMessageValid()
        {
            var name = "Кристина";
            var res = DataService.GetMessage(name);
            Assert.Equal("Привет, Кристина", res);
        }
    }
}