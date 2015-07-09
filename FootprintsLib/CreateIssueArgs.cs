using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace FootprintsLib
{
    /// <summary>
    /// This class is used to create a ticket in Footprints
    /// </summary>
    public class CreateIssueArgs
    {
        /// <summary>
        /// The Unique Project ID
        /// </summary>
        public string projectID;

        /// <summary>
        /// Title of the ticket
        /// </summary>
        public string title;

        /// <summary>
        /// The team(s) that this ticket will be assigned to this ticket
        /// </summary>
        public string[] assignees;

        /// <summary>
        /// The Priority Number (as an integer) of the ticket
        /// </summary>
        public string priorityNumber;

        /// <summary>
        /// The name of the priority
        /// </summary>
        public string priorityWords;

        /// <summary>
        /// The status of the ticket
        /// </summary>
        public string status;

        /// <summary>
        /// Description of the ticket. Note: no html can be added
        /// to this field only text format is allowed.
        /// </summary>
        public string description;

        /// <summary>
        /// This is the UserID field that is used to populate the contact
        /// field for the ticket
        /// </summary>
        public string selectContact;

        public ProjFields projfields;
        public Mail mail;    }
}
