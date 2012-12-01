using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciudad_conectada.Models
{
    public class Notification
    {
        public string UserName { get; set; }
        public string Text { get; set; }
        public Position Position { get; set; }
    }
}