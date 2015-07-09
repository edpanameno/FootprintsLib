using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FootprintsLib
{
    /// This class defines the values used to send out an email
    /// notification to the appropriate team/people that are 
    /// associated with the ticket.  The value of 1 enables the
    /// notification, while the value of 0 disables it. If no
    /// argument is passed, then Footprints will assume that mail
    /// will be sent for the receipient(s).
    /// </summary>    [SoapTypeAttribute("Mail", "MRWebServices")]
    public class Mail
    {
        /// <summary>
        /// Sent email to the assignees of the ticket
        /// </summary>
        public string assignees;

        /// <summary>
        /// Send an email to the contact of the ticket
        /// </summary>
        public string contact;

        /// <summary>
        /// Send an email to the permanent CCs of the ticket
        /// </summary>
        public string permanentCCs;    }
}
