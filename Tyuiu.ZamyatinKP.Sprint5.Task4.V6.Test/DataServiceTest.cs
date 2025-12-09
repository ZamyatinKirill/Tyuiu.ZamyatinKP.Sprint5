using Tyuiu.ZamyatinKP.Sprint5.Task4.V6.Lib;

namespace Tyuiu.ZamyatinKP.Sprint5.Task4.V6.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.Equal(2.876, result.LoadFromDataFile("C:\\DataSprint5\\InPutDataFileTask4V6.txt"));
        }
    }
}