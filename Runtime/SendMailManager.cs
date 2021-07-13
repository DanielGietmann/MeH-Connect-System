using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MeHConnect.Mail;

namespace MeHConnect.Mail
{
    public class SendMailManager : MonoBehaviour
    {
        public string SMTP_USERNAME;
        public string SMTP_PASSWORD;
        public string HOST;
        public int PORT;

        public string senderEmail;



        public bool isDebug;

        private void Awake()
        {
            SendMail.HanldleMailMangager(SMTP_USERNAME,SMTP_PASSWORD, HOST, PORT);
        }
    }
}
