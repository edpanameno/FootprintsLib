using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootprintsLib
{
    /// <summary>
    /// This class represents a Footprints Ticket and can be used
    /// to set properties of the ticket when it's created and  
    /// assigned to the appropriate workspace in footprints. The 
    /// workspace id along with the ticket information can be manually
    /// entered by the users.
    /// </summary>
    public class FPTicket
    {
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public CreateIssueArgs TicketInfo { get; set; }
        public ProjFields ProjectInfo { get; set; }
        public Mail MailInfo { get; set; }

        /// <summary>
        /// Create a Footprints Ticket
        /// </summary>
        /// <param name="url">URL to the Footprints Web API</param>
        /// <param name="username">Footprints username of user with System Admin rights</param>
        /// <param name="password">Footprints User Password</param>
        public FPTicket(string url, string username, string password)
        {
            Url = url;
            Username = username;
            Password = password;

            TicketInfo = new CreateIssueArgs();
            ProjectInfo = new ProjFields();
            MailInfo = new Mail();
        }

        public string CreateTicket()
        {
            TicketInfo.projfields = ProjectInfo;
            TicketInfo.mail = MailInfo;

            CreateIssue createIssue = new CreateIssue();
            createIssue.Url = Url;

            string ticketNumber = createIssue.MRWebServices__createIssue(Username, Password, "", TicketInfo);
            return ticketNumber;
        }
    }
}
