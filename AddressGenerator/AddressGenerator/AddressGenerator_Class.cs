using AddressGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

class AddressGenerator_Class : IAddress
{
    private uint address;

    public AddressGenerator_Class(uint address)
    {
        this.address = address;
    }

    public string generateIPv4()
    {
        return new IPAddress(address).ToString();
    }

    public string generateSubnet(int cidr)
    {
        uint subnetMask = (uint)(0xffffffff << (32 - cidr));
        byte[] bytes = BitConverter.GetBytes(subnetMask);
        Array.Reverse(bytes);
        return new IPAddress(bytes).ToString();
    }
}
