using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExternalEmailWarning
{
    public partial class SecureEmailForm : Form
    {
        private int _optionSelected = 2;

        public SecureEmailForm(List<string> recips)
        {
            InitializeComponent();
            foreach (string item in recips)
            {
                lstEmailAddresses.Items.Add(item);
            }
        }

        public int OptionSelected()
        {
            return _optionSelected;
        }

        private void btnSendSecure_Click(object sender, EventArgs e)
        {
            //change value of sensitivity and then send
            _optionSelected = 0;
            this.Close();
        }

        private void btnSendNormal_Click(object sender, EventArgs e)
        {
            //send email as is
            _optionSelected = 1;
            this.Close();
        }

        private void btnDoNotSend_Click(object sender, EventArgs e)
        {
            //cancel send (essentially do nothing and close form)
            _optionSelected = 2;
            this.Close();
        }
    }
}
