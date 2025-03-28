using Lab8;
using NUnit.Framework.Interfaces;
namespace MyLinkedListTests
{
    [TestFixture]
    public class Tests
    {
        private MyLinkedList<string> test;
        [SetUp]
        public void Setup()
        {
            test = new MyLinkedList<string>();
        }

        [Test]
        public void Test_AddFirst()
        {
            string expected = "Joe Schmoe";
            test.AddFirst(expected);

            Assert.AreEqual(expected, test.Head.Data);

            test.AddFirst("Joe Blow");
            Assert.AreEqual("Joe Blow", test.Head.Data);
        }

        [Test]
        public void Test_AddLast()
        {
            string expected = "Sam Sammerson";
            test.AddLast(expected);

            Assert.AreEqual(expected, test.Tail.Data);

            test.AddLast("Dave Daverson");
            Assert.AreEqual("Dave Daverson", test.Tail.Data);

        }

        [Test]
        public void Test_RemoveFirst()
        {
            string expected = "List is already empty";
            test.RemoveFirst();
            Assert.AreEqual(expected, test.output);

            test.AddFirst("Joe Schmoe");
            test.AddFirst("Joe Blow");

            expected = "Joe Schmoe";
            test.RemoveFirst();

            Assert.AreEqual (expected, test.Head.Data);

            test.AddLast("John Smith");
            test.RemoveFirst();
            Assert.AreEqual("John Smith", test.Head.Data);
        }

        [Test]
        public void Test_RemoveLast()
        {
            string expected = "The list is already empty";
            test.RemoveLast();
            Assert.AreEqual(expected, test.output);

            test.AddFirst("Joe Schmoe");
            test.AddFirst("Joe Blow");

            expected = "Joe Blow";
            test.RemoveLast();

            Assert.AreEqual(expected, test.Tail.Data);

            test.AddFirst("John Smith");
            test.RemoveLast();
            Assert.AreEqual("John Smith", test.Tail.Data);
        }

        [Test]
        public void Test_GetValue()
        {
            string expected = "List is empty";
           string actual = test.GetValue(6);
            Assert.AreEqual(expected, actual);

            test.AddFirst("Joe Schmoe");
            test.AddFirst("Joe Blow");
            test.AddLast("John Smith");
            test.AddLast("Jane Doe");

             expected = "John Smith";
             actual = test.GetValue(3);
            Assert.AreEqual(expected, actual);

            expected = "Index is greater than the length of the list";
            actual = test.GetValue(6);
            Assert.AreEqual(expected, actual);

            
        }
    }
}