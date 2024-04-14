using NUnitTestDemo;

namespace NunitTest
{
    [TestFixture]
    public class Tests
    {
        public MyMath m;
        [SetUp]
        public void Setup()
        {
            m = new MyMath();
        }
        [Test]
        [MaxTime(2000)]
        [Category("UnitTest")]
        [Description("This is the Sample Test Case")]
        public async Task Test1()
        {
            await Task.Delay(1000);
            Assert.AreEqual(20,m.add(10, 10));
        }
        [TestCase(10,5,2)]
        public void Test2(int a,int b,int c) 
        {
            Assert.AreEqual(c,m.divide(a,b));
        }
        [TestCaseSource(nameof(SourceProvider))]
        public void Test3(int a, int b,int c)
        {
            
            Assert.AreEqual(c,m.divide(a,b));
        }
        //determine the author of a test
        [Author("Dileep")]
        [Test]
        public void Test4()
        {
            var author = (string)TestContext.CurrentContext.Test.Properties.Get("Author");
            Assert.AreEqual(author,"Dileep");
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual("peeliD", m.ReverseString("Dileep"));
            int[] a = { 1, 2, 3, 4, };
            Assert.AreEqual(10, m.SumArray(a)) ;
            Assert.AreEqual(6, m.MaxList(new List<int> { 3, 6,4, 5 }));
            HashSet<int> expected = new HashSet<int> {1,2,3,5,6,9,7 };
            HashSet<int> expect = new HashSet<int> {2,3,5 };
            Assert.AreEqual(expected, m.UnionHashSet(new HashSet<int> { 1, 2, 3, 5, 6 }, new HashSet<int> { 9, 2, 3, 5, 7 }));
            Assert.AreEqual(expect, m.IntersectHashSet(new HashSet<int> { 1, 2, 3, 5, 6 }, new HashSet<int> { 9, 2, 3, 5, 7 }));
        }
        public static IEnumerable<int[]> SourceProvider()
        {
            yield return new int[] { 300, 100, 3 };
            yield return new int[] { 400, 200, 2 };
            yield return new int[] { 100, 50, 2 };
        }
    }
}