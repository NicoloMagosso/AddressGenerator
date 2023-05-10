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
            // Recupera l'indirizzo IP dalla casella di testo txtLettura
            string indirizzoIP = txtLettura.Text;

            // Converti l'indirizzo IP in un valore a 32 bit
            uint bits = ConvertTo32Bit(indirizzoIP);

            // Crea un oggetto AddressGenerator usando i 32 bit dell'indirizzo IP
            AddressGenerator addressGenerator = new AddressGenerator(bits);

            txtSM.Text = addressGenerator.generateSubnet();
        }

        private uint ConvertTo32Bit(string indirizzoIP)
        {
            string[] indirizzoIPArray = indirizzoIP.Split('.');
            if (indirizzoIPArray.Length != 4)
            {
                throw new ArgumentException("L'indirizzo IP deve essere nella forma A.B.C.D");
            }

            uint bits = 0;
            for (int i = 0; i < 4; i++)
            {
                byte b = byte.Parse(indirizzoIPArray[i]);
                bits = bits << 8;
                bits = bits | b;
            }

            return bits;
        }
    }
}
