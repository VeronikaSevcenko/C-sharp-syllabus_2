using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System.IO;
using WordCount;

namespace wordCount.Test
{
    public class WordCount
    {
        [Test]
        public void CountTheLines_LearTxt_Result6()
        {
            //Arrange
            string countLines = File.ReadAllText(@"C:\Users\37123\Desktop\C-sharp-syllabus_2\csharp-basics\exercises\Collections\WordCount\lear.txt");

            //Act
            var result = Lines.CountLines(countLines);

            //Assert
            Assert.AreEqual(6, result);
        }
    }
}