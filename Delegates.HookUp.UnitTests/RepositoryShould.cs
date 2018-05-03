using System;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Delegates.HookUp.UnitTests
{
    [TestClass]
    public class RepositoryShould
    {
        [TestMethod]
        public void TestMethod1()
        {
            var type = typeof(Repository);

            Assert.IsNotNull(type);

            var expected = 3;
            var repository = new Repository(expected);

            var actual = (int)((TypeInfo)type).DeclaredFields.First().GetValue(repository);

            Assert.AreEqual(expected, actual);
        }
    }
}
