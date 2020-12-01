using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingClients.Model
{
   public  class Note
    {
        public Note()
        {
            Ticket = new Ticket();
        }
        public int Id { get; set; }
        public string Comments { get; set; }
        public int TicketId { get; set; }//foregin key=>Ticket
        public virtual Ticket Ticket { get; set; }//multi navigation prop
    }
}
