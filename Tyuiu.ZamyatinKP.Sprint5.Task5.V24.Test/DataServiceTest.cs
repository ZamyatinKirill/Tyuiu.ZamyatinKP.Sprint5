using Tyuiu.ZamyatinKP.Sprint5.Task5.V24.Lib;

namespace Tyuiu.ZamyatinKP.Sprint5.Task5.V24.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.Equal(2.876, result.LoadFromDataFile("C:\\DataSprint5\\InPutDataFileTask5V24.txt"));
        }
    }
}