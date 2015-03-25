using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mixter.Domain;
using NFluent;

namespace Mixter.Tests.Domain
{
    [TestClass]
    public class MessageIdTest
    {
        [TestMethod]
        public void WhenGenerate2IdThenIsNotEquals()
        {
            var id1 = MessageId.Generate();
            var id2 = MessageId.Generate();

            Check.That(id1).IsNotEqualTo(id2);
        }

        [TestMethod]
        public void WhenToStringIdThenId()
        {
            var id = MessageId.Generate();

            Check.That(id.ToString()).IsEqualTo(id.Id);
        }
    }
}