using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcola_Click(object sender, EventArgs e)
        {
            if (txtLettura.Text != "" && txtCIDR.Text != "")
            {
                // Ottieni i valori di input dalla GUI
                string inputAddress = txtLettura.Text;
                int cidr = int.Parse(txtCIDR.Text);

                // Converte l'indirizzo IPv4 in un uint
                uint address = BitConverter.ToUInt32(IPAddress.Parse(inputAddress).GetAddressBytes(), 0);

                // Crea l'istanza della classe AddressGenerator e genera l'IPv4 e la subnet
                AddressGenerator_Class addressGenerator = new AddressGenerator_Class(address);
                string ipv4 = addressGenerator.generateIPv4();
                string subnet = addressGenerator.generateSubnet(cidr);
                txtSM.Text = subnet;
            }
            else
                MessageBox.Show("L'indirizzo IP non è valido.", "Invalido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtLettura_KeyPress(object sender, KeyPressEventArgs e)
        {
            int charCode = (int)e.KeyChar;

            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || charCode == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCIDR_KeyPress(object sender, KeyPressEventArgs e)
        {
            int charCode = (int)e.KeyChar;

            if (char.IsDigit(e.KeyChar) || charCode == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
