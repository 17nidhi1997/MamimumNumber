using NUnit.Framework;

namespace MamimumNumber
{
    public class Tests
    {
        [Test]
        public void MaxIntegerValue_FirstValue()
        {
            MaximumNumber md = new MaximumNumber();
            int actualMax = md.maximumIntegerNumber(20, 15, 14);
            Assert.AreEqual(20, actualMax);
        }
    }
}