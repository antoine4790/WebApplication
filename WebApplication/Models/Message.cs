using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Message
    {
        public Message()
        {
            Emetteur = "emetteur";
            Contenu = "contenu";
            Date = DateTime.Now;
        }
        public Message (string emetteur, string contenu, DateTime date)
        {
            Emetteur = emetteur;
            Contenu = contenu;
            Date = date;
        }
        public string Emetteur { get; set; }
        public string Contenu { get; set; }
        public DateTime Date
        { get; set; }
    }
}