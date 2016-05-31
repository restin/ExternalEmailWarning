using System.Collections.Generic;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ExternalEmailWarning
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.ItemSend += new Microsoft.Office.Interop.Outlook.ApplicationEvents_11_ItemSendEventHandler(Application_ItemSend);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see http://go.microsoft.com/fwlink/?LinkId=506785
        }

        private void Application_ItemSend(object Item, ref bool Cancel)
        {
            MessageBox.Show("Test Version");
            Outlook.MailItem mail = Item as Outlook.MailItem;
            List<string> recipients = new List<string>();

            int count = 0;
            const string PR_SMTP_ADDRESS = "http://schemas.microsoft.com/mapi/proptag/0x39FE001E";

            // Stop the email from sending so the addresses can be checked first
            Cancel = true;

            /// <summary>
            /// Get list of recipients and check for any external addresses. This process also 
            /// checks the members in distribution groups. Many groups may slow down processing.
            /// </summary>
            foreach (Outlook.Recipient rec in mail.Recipients)
            {
                Outlook.PropertyAccessor pa = rec.PropertyAccessor;
                string smtpAddress = pa.GetProperty(PR_SMTP_ADDRESS).ToString();
                smtpAddress = smtpAddress.ToLower();

                if (rec.AddressEntry.DisplayType == Outlook.OlDisplayType.olDistList)
                {
                    Outlook.PropertyAccessor pa2;
                    string smtpAddress2;

                    foreach (Outlook.AddressEntry myAE in rec.AddressEntry.Members)
                    {
                        pa2 = myAE.PropertyAccessor;
                        smtpAddress2 = pa2.GetProperty(PR_SMTP_ADDRESS).ToString();
                        smtpAddress2 = smtpAddress2.ToLower();

                        if (smtpAddress2.IndexOf("@primewest.org") <= 0
                            && smtpAddress2.IndexOf("@co.itasca.mn.us") <= 0
                            && smtpAddress2.IndexOf("@cirdanhealth.com") <= 0
                            && smtpAddress2.IndexOf("primetherapeutics.com") <= 0
                            && smtpAddress2.IndexOf("medimpact.com") <= 0)
                        {
                            recipients.Add(smtpAddress2);
                            count++;
                        }
                    }
                }

                //add the addresses that are external to the list box for display
                if (smtpAddress.IndexOf("@primewest.org") <= 0
                    && smtpAddress.IndexOf("@co.itasca.mn.us") <= 0
                    && smtpAddress.IndexOf("@cirdanhealth.com") <= 0
                    && smtpAddress.IndexOf("primetherapeutics.com") <= 0
                    && smtpAddress.IndexOf("medimpact.com") <= 0)
                {
                    recipients.Add(smtpAddress);
                    count++;
                }

            }

            //If any of the recipients are external then create the SecureEmailForm and populate the list with those members
            if (count > 0)
            {
                SecureEmailForm frmWarningForm = new SecureEmailForm(recipients);
                frmWarningForm.StartPosition = FormStartPosition.CenterParent;
                frmWarningForm.ShowDialog();

                //If any external recipients, run the switch statement, if not the set Cancel to false
                switch (frmWarningForm.OptionSelected())
                {
                    case 0://change value of sensitivity and then send
                        mail.Sensitivity = Outlook.OlSensitivity.olConfidential;
                        Cancel = false;
                        break;
                    case 1: //send email as is
                        Cancel = false;
                        break;
                    case 2: //cancel send 
                        break;
                }
            }
            else
            {
                Cancel = false;
            }
        }
        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
