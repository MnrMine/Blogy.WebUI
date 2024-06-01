using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.EntityLayer.Concrete
{
    public class Message
    {
        public int MessageID { get; set; }
        public string? SenderNameSurname { get; set; }
        public string? SenderMail { get; set; }
        public string? ReceiverNameSurname { get; set; }
        public string? ReceiverMail { get; set; }
        public string? Subject { get; set; }
        public string? Content { get; set; }
        public DateTime Date { get; set; }
    }
}
