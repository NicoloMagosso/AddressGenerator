using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressGenerator
{
    class AddressGenerator : IAddress
    {
        private uint bits;

        public AddressGenerator(uint bits)
        {
            this.bits = bits;
        }

        public string generateIPv4()
        {
            if (bits > 0xffffffff)
            {
                throw new ArgumentException("Bits must be 32-bit unsigned integer.");
            }

            byte[] bytes = BitConverter.GetBytes(bits);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return string.Join(".", bytes);
        }

        public string generateSubnet()
        {
            int prefixLength = 0;
            for (int i = 31; i >= 0; i--)
            {
                if ((bits & (1u << i)) != 0)
                {
                    prefixLength = i + 1;
                    break;
                }
            }

            return $"{generateIPv4()}/{prefixLength}";
        }
    }
}
