using NUnit.Framework;
using PhoneBook;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PhoneBook.Test
{
    public class PhoneDirectoryTests
    {
        PhoneDirectory _target = new PhoneDirectory();

        [Test]
        public void PutNumber_Jorry28955674_ShouldContainJorry()
        {
            //Act
            _target.PutNumber("Jorry", "28955674");

            //Assert
            Assert.AreEqual("28955674", _target.GetNumber("Jorry"));
        }

        [Test]
        public void GetNumber_Jorry_ShouldBeNull()
        {
            //Act
            var number = _target.GetNumber("Jorry");

            //Assert
            Assert.AreEqual(null, number);
        }
    }
}