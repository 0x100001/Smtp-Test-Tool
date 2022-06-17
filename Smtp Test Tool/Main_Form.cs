using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Smtp_Test_Tool
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void smtp_send_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SmtpClient smtp_client = new SmtpClient())
                {
                    MailAddress smtpaccount = new MailAddress(smtp_username_textbox.Text);
                    var Credentials = new NetworkCredential(smtp_username_textbox.Text, smtp_password_textbox.Text);

                    using (MailMessage message = new MailMessage())
                    {

                        if (secure_checkbox.Checked == true)
                            smtp_client.EnableSsl = true;

                        smtp_client.Host = smtp_server_textbox.Text;
                        smtp_client.UseDefaultCredentials = false;
                        smtp_client.Credentials = Credentials;
                        message.From = smtpaccount;
                        message.Subject = "Test E-Mail";
                        message.IsBodyHtml = true;
                        message.Body = "This is a test mail.";
                        message.To.Add(smtp_empfänger_textbox.Text);

                        try
                        {
                            smtp_client.Send(message);
                            MessageBox.Show("Successfully send.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
