using Tyuiu.ZamyatinKP.Sprint5.Task6.V25.Lib;

namespace Tyuiu.ZamyatinKP.Sprint5.Task6.V25.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.Equal(2.876, result.LoadFromDataFile("C:\\DataSprint5\\InPutDataFileTask6V25.txt"));
        }
    }
}