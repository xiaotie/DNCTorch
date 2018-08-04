using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNCTorch.Test
{
    using DNCTorch.Native;

    [TestClass]
    public unsafe class THStorageTest
    {
        [TestMethod]
        public void TestCreate()
        {
            THFloatStorage* s = THFloatStorage.THFloatStorage_newWithSize(64);
            Assert.AreEqual(64, THFloatStorage.THFloatStorage_size(s));
        }
    }
}
