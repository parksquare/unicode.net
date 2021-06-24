using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeoSmart.Unicode;

namespace UnicodeTests
{
    [TestClass]
    public class SingleEmojiTests
    {
        [TestMethod]
        public void TestSingleEmojiSame()
        {
            Assert.IsFalse(Emoji.AbButtonBloodType_E0_6 == null);
            Assert.IsFalse(null == Emoji.AbButtonBloodType_E0_6);
            Assert.IsFalse(Emoji.AbButtonBloodType_E0_6 == Emoji.Abacus_E11_0);
#pragma warning disable CS1718 // Comparison made to same variable
            Assert.IsTrue(Emoji.AbButtonBloodType_E0_6 == Emoji.AbButtonBloodType_E0_6);
#pragma warning restore CS1718 // Comparison made to same variable
        }

        [TestMethod]
        public void TestSingleEmojiNotSame()
        {
            Assert.IsTrue(Emoji.AbButtonBloodType_E0_6 != null);
            Assert.IsTrue(null != Emoji.AbButtonBloodType_E0_6);
            Assert.IsTrue(Emoji.AbButtonBloodType_E0_6 != Emoji.Abacus_E11_0);
#pragma warning disable CS1718 // Comparison made to same variable
            Assert.IsFalse(Emoji.AbButtonBloodType_E0_6 != Emoji.AbButtonBloodType_E0_6);
#pragma warning restore CS1718 // Comparison made to same variable
        }

        [TestMethod]
        public void TestSingleEmojiEquality()
        {
            Assert.IsFalse(Emoji.AbButtonBloodType_E0_6.Equals(null));
            Assert.IsTrue(Emoji.AbButtonBloodType_E0_6.Equals(Emoji.AbButtonBloodType_E0_6));

            Assert.IsFalse(Equals(Emoji.AbButtonBloodType_E0_6, null));
            Assert.IsTrue(Equals(Emoji.AbButtonBloodType_E0_6, Emoji.AbButtonBloodType_E0_6));

            Assert.IsTrue(Emoji.AbButtonBloodType_E0_6.Equals(Emoji.AbButtonBloodType_E0_6));
        }

        [TestMethod]
        public void TestSingleEmojiCompareTo()
        {
            Assert.IsFalse(Emoji.AbButtonBloodType_E0_6.CompareTo(Emoji.AbButtonBloodType_E0_6) != 0);
        }
    }
}
