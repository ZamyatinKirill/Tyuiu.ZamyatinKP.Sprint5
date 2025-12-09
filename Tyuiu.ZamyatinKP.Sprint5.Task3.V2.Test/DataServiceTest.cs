using Tyuiu.ZamyatinKP.Sprint5.Task3.V2.Lib;

namespace Tyuiu.ZamyatinKP.Sprint5.Task3.V2.Test
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