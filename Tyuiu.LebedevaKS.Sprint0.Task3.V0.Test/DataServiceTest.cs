using Tyuiu.LebedevaKS.Sprint0.Task3.V0.Lib;
namespace Tyuiu.LebedevaKS.Sprint0.Task3.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void TCheckedValid()
        {
            Assert.Equal(10, DataService.Sum(5, 5));
        }
    }
}