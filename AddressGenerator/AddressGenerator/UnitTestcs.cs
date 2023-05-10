using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressGenerator
{
    [TestClass]
    public class AddressGeneratorTests
    {
        [TestMethod]
        public void TestGenerateIPv4()
        {
            uint address = 0xc0a80101; // 192.168.1.1
            AddressGenerator_Class addressGenerator = new AddressGenerator_Class(address);
            string ipv4 = addressGenerator.generateIPv4();
            Assert.AreEqual("192.168.1.1", ipv4);
        }

        [TestMethod]
        public void TestGenerateSubnet()
        {
            uint address = 0xc0a80101;
            AddressGenerator_Class addressGenerator = new AddressGenerator_Class(address);
            string subnet = addressGenerator.generateSubnet(24);
            Assert.AreEqual("255.255.255.0", subnet);
        }
    }

}