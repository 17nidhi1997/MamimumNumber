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
        [Test]
        public void MaxIntegerValue_SecondValue()
        {
            MaximumNumber md = new MaximumNumber();
            int actualMax = md.maximumIntegerNumber(10, 15, 14);
            Assert.AreEqual(15, actualMax);
        }
        [Test]
        public void MaxIntegerValue_ThirdValue()
        {
            MaximumNumber md = new MaximumNumber();
            int actualMax = md.maximumIntegerNumber(10, 15, 20);
            Assert.AreEqual(20, actualMax);
        }

        [Test]
        public void MaxDoubleValue_FirstValue()
        {
            MaximumNumber md = new MaximumNumber();
            double actualMax = md.MaximumDoubleArray(20.5, 15.2, 14.3);
            Assert.AreEqual(20.5, actualMax);
        }

        [Test]
        public void MaxDoubleValue_secondValue()
        {
            MaximumNumber md = new MaximumNumber();
            double actualMax = md.MaximumDoubleArray(10.5, 15.2, 14.3);
            Assert.AreEqual(15.2, actualMax);
        }
        [Test]
        public void MaxDoubleValue_ThirdValue()
        {
            MaximumNumber md = new MaximumNumber();
            double actualMax = md.MaximumDoubleArray(10.5, 15.2, 20.3);
            Assert.AreEqual(20.3, actualMax);
        }

        [Test]
        public void MaxStringValue_FirstValue()
        {
            MaximumNumber md = new MaximumNumber();
            string actualMax = md.MaximumStringArray("peach", "apple", "banana");
            Assert.AreEqual("peach", actualMax);
        }
        [Test]
        public void MaxStringValue_secondValue()
        {
            MaximumNumber md = new MaximumNumber();
            string actualMax = md.MaximumStringArray("apple", "peach", "banana");
            Assert.AreEqual("peach", actualMax);
        }
        [Test]
        public void MaxStringValue_ThirdValue()
        {
            MaximumNumber md = new MaximumNumber();
            string actualMax = md.MaximumStringArray("apple", "banana", "peach");
            Assert.AreEqual("peach", actualMax);
        }


    }
}