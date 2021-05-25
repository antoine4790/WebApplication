using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Message
    {
        public string Emetteur { get; set; }
        public string Contenu { get; set; }
        public DateTime Date
        { get; set; }
    }
}