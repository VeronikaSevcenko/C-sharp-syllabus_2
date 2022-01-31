using Exercise_8;
using NUnit.Framework;

namespace Exercise8.Test
{
    public class Tests
    {
        [TestCase(4, 8, "Error")]
        [TestCase(9, 50, "The salary is 495$")]
        [TestCase(8, 45, "The salary is 380$")]
        [Parallelizable]

        public void IfWorkMore60HoursAndMinWageLess7_BasePayHoursWorked_ResultSalarryOrGetError(double basePay, int hoursWorked, string expected)
        {
            Assert.AreEqual(expected, GetSalary_new_.GetSalary(basePay, hoursWorked));
        }
    }
}