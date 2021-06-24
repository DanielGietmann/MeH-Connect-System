using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Mail;
using System.Net;
using System;

namespace MeHConnect.mail
{
    public class SendMail : MonoBehaviour
    {

        void sendEmail(string frommail, string fromname,string toemail, string smtpusername, string smtphost, int smtpserverport ,string smptpassword)
        {
            string FROM = frommail;
            string FROMNAME = fromname;


            string TO = toemail;
            string SMTP_USERNAME = smtpusername;
            string SMTP_PASSWORD = smptpassword;
            string HOST = smtphost;
            int PORT = smtpserverport;

            string SUBJECT = "ToD Questions";

            string BODY =
                "<p>Hello,</p>" +
                "<p>Thank you for submitting your question.<br />If this should be taken over into the game, we will contact you again!</p>" +
                "<p>If you have any questions, please feel free to send us an email.</p>" +
                "<p>Best regards,<br />Meh-Development</p>";

            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            message.From = new MailAddress(FROM, FROMNAME);
            message.To.Add(new MailAddress(TO));
            message.Subject = SUBJECT;
            message.Body = BODY;

            using (var client = new System.Net.Mail.SmtpClient(HOST, PORT))
            {
                // Pass SMTP credentials
                client.Credentials =
                    new NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);

                // Enable SSL encryption
                client.EnableSsl = true;

                // Try to send the message. Show status in console.
                try
                {
                    Debug.Log("Attempting to send email...");
                    client.Send(message);
                    Debug.Log("Email sent!");
                }
                catch (Exception ex)
                {
                    Debug.Log("The email was not sent.");
                    Debug.Log("Error message: " + ex.Message);
                }
            }

        }
    }
}
