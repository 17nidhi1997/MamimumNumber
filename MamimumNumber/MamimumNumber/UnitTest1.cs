using NUnit.Framework;

namespace MamimumNumber
{
    [TestFixture]
    public class Tests
    {
        
        [Test]
         public void MaxIntegerValue_FirstValue()
         {
             MaximumNumber md = new MaximumNumber();
             int actualMax = md.maxValueArray(20, 15, 14);
             Assert.AreEqual(20, actualMax);
         }
         [Test]
         public void MaxIntegerValue_SecondValue()
         {
             MaximumNumber md = new MaximumNumber();
             int actualMax = md.maxValueArray(10, 15, 14);
             Assert.AreEqual(15, actualMax);
         }
         [Test]
         public void MaxIntegerValue_ThirdValue()
         {
             MaximumNumber md = new MaximumNumber();
             int actualMax = md.maxValueArray(10, 15, 20);
             Assert.AreEqual(20, actualMax);
         }
         [Test]
         public void MaxDoubleValue_FirstValue()
         {
             MaximumNumber md = new MaximumNumber();
             double actualMax = md.maxValueArray(20.5, 15.2, 14.3);
             Assert.AreEqual(20.5, actualMax);
         }
         [Test]
         public void MaxDoubleValue_secondValue()
         {
             MaximumNumber md = new MaximumNumber();
             double actualMax = md.maxValueArray(10.5, 15.2, 14.3);
             Assert.AreEqual(15.2, actualMax);
         }
         [Test]
         public void MaxDoubleValue_ThirdValue()
         {
             MaximumNumber md = new MaximumNumber();
             double actualMax = md.maxValueArray(10.5, 15.2, 20.3);
             Assert.AreEqual(20.3, actualMax);
         }
         [Test]
         public void MaxStringValue_FirstValue()
         {
             MaximumNumber md = new MaximumNumber();
             string actualMax = md.maxValueArray("peach", "apple", "banana");
             Assert.AreEqual("peach", actualMax);
         }
         [Test]
         public void MaxStringValue_secondValue()
         {
             MaximumNumber md = new MaximumNumber();
             string actualMax = md.maxValueArray("apple", "peach", "banana");
             Assert.AreEqual("peach", actualMax);
         }
         [Test]
         public void MaxStringValue_ThirdValue()
         {
             MaximumNumber md = new MaximumNumber();
             string actualMax = md.maxValueArray("apple", "banana", "peach");
             Assert.AreEqual("peach", actualMax);
         }
    }
}