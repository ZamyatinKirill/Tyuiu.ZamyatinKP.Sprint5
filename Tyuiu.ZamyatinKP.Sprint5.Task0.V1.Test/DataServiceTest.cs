using Tyuiu.ZamyatinKP.Sprint5.Task0.V1.Lib;

namespace Tyuiu.ZamyatinKP.Sprint5.Task0.V1.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.True(new FileInfo($@"{Path.GetTempPath()}\OutPutFileTask0.txt").Exists);
        }
    }
}