using NUnit.Framework;

namespace MamimumNumber
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void MaxIntegerValue_FirstValue()
        {

            int actualMax = MaximumNumber<int>.maxValueArray(20, 15, 14);
            Assert.AreEqual(20, actualMax);
        }
        [Test]
        public void MaxIntegerValue_SecondValue()
        {

            int actualMax = MaximumNumber<int>.maxValueArray(10, 15, 14);
            Assert.AreEqual(15, actualMax);
        }
        [Test]
        public void MaxIntegerValue_ThirdValue()
        {

            int actualMax = MaximumNumber<int>.maxValueArray(10, 15, 20);
            Assert.AreEqual(20, actualMax);
        }
        [Test]
        public void MaxDoubleValue_FirstValue()
        {

            double actualMax = MaximumNumber<double>.maxValueArray(20.5, 15.2, 14.3);
            Assert.AreEqual(20.5, actualMax);
        }
        [Test]
        public void MaxDoubleValue_secondValue()
        {

            double actualMax = MaximumNumber<double>.maxValueArray(10.5, 15.2, 14.3);
            Assert.AreEqual(15.2, actualMax);
        }
        [Test]
        public void MaxDoubleValue_ThirdValue()
        {

            double actualMax = MaximumNumber<double>.maxValueArray(10.5, 15.2, 20.3);
            Assert.AreEqual(20.3, actualMax);
        }
        [Test]
        public void MaxStringValue_FirstValue()
        {

            string actualMax = MaximumNumber<string>.maxValueArray("peach", "apple", "banana");
            Assert.AreEqual("peach", actualMax);
        }
        [Test]
        public void MaxStringValue_secondValue()
        {

            string actualMax = MaximumNumber<string>.maxValueArray("apple", "peach", "banana");
            Assert.AreEqual("peach", actualMax);
        }
        [Test]
        public void MaxStringValue_ThirdValue()
        {

            string actualMax = MaximumNumber<string>.maxValueArray("apple", "banana", "peach");
            Assert.AreEqual("peach", actualMax);
        }
    }
}