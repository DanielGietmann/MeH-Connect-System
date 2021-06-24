using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeHmMeHConnect.mail
{
    public class SendMailManager : MonoBehaviour
    {
        public string SMTP_USERNAME;
        public string SMTP_PASSWORD;
        public string HOST;
        public int PORT;


        public bool isDebug;

        private void Awake()
        {



        }
    }
}
