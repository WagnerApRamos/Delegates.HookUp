using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Delegates.HookUp.UnitTests
{
    [TestClass]
    public class ReflactionExtesionsShould
    {
        [TestMethod]
        public void Return_A_Value_By_DeclaredFieldName()
        {
            var expected = 5;
            var repository = new Repository(expected);

            var actual = repository.GetValue<int>("_serverCount");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Return_A_Value_By_DeclaredFieldType()
        {
            var expected = 5;
            var repository = new Repository(expected);

            var actual = repository.GetValue<int>();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Throw_An_Exception_When_Does_Not_Find_By_DeclaredFieldName()
        {
            var expected = 5;
            var repository = new Repository(expected);

            var actual = repository.GetValue<int>("MyTest");
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Throw_An_Exception_When_Does_Not_Find_By_DeclaredFieldType()
        {
            var expected = 5;
            var repository = new Repository(expected);

            var actual = repository.GetValue<string>();
        }
    }
}
