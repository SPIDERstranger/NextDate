using NUnit.Framework;
using System.Collections;

namespace NextDate
{
    [TestFixture]
    public class TestNextDate
    {
        #region isleap
        class NDate : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new NextDate(2000, 1, 1), true };
                yield return new object[] { new NextDate(1800, 1, 1), false };
                yield return new object[] { new NextDate(2008, 1, 1), true };
                yield return new object[] { new NextDate(1999, 1, 1), false };
            }
        }

        [Test]
        [TestCaseSource(typeof(NDate))]
        public void TestIsleap(NextDate nd, bool ex)
        {
            Assert.AreEqual(nd.isleap(), ex);
        }
        #endregion

        #region isdate

        static object[][] testcaseIsDate =
        {
            new object[]{ new NextDate(-1999,12,30),false},
            new object[]{ new NextDate(3000,1,1),false},
            new object[]{ new NextDate(1999 ,-6,30),false},
            new object[]{ new NextDate(1980,15,2),false},
            new object[]{ new NextDate(0,0,0),false},
            new object[]{ new NextDate(2013,1,1),true},
            new object[]{ new NextDate(2008,8,31),true},
            new object[]{ new NextDate(2008,8,32),false},
            new object[]{ new NextDate(1999,12,-15),false},
            new object[]{ new NextDate(1999,12,31),true},
            new object[]{ new NextDate(1999,12,32),false},
            new object[]{ new NextDate(2008,4,-31),false},
            new object[]{ new NextDate(2008,4,27),true},
            new object[]{ new NextDate(2008,4,30),true},
            new object[]{ new NextDate(2008,4,31),false},
            new object[]{ new NextDate(1800,2,28),true},
            new object[]{ new NextDate(1800,2,29),false},
            new object[]{ new NextDate(1800,2,30),false},
            new object[]{ new NextDate(1800,2,31),false},
            new object[]{ new NextDate(1800,2,0),false},
            new object[]{ new NextDate(2000,2,1),true},
            new object[]{ new NextDate(2000,2,29),true},
            new object[]{ new NextDate(2000,2,30),false},
            new object[]{ new NextDate(2000,2,31),false},
            new object[]{ new NextDate(2000,2,-28),false}   
        };

        [Test]
        [TestCaseSource(nameof(testcaseIsDate))]
        public void TestIsDate(NextDate nd, bool ex)
        {
            Assert.AreEqual(ex, nd.isDate(nd));
        }


        #endregion
    }
}
