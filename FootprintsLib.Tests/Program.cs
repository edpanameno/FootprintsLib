using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using FootprintsLib;

namespace FootprintsLib.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = ConfigurationManager.AppSettings["footprints_username"];
            string password =  ConfigurationManager.AppSettings["footprints_password"];
            string url =  ConfigurationManager.AppSettings["footprints_api_url"];

            CreateTicket(username, password, url);
            Console.ReadLine();
        }

        static void CreateTicket(string username, string password, string url)
        {
            CreateIssueArgs ticket = new CreateIssueArgs();
            ProjFields projectFields = new ProjFields();
            Mail mailProperties = new Mail();

            ticket.projectID = "34";
            ticket.title = "Test Ticket from FootprintsLib";
            ticket.priorityNumber = "5";
            ticket.status = "Open.";
            ticket.selectContact = "panameno"; // med domain username who will be the contact for this ticket

            projectFields.Submitted__bVia = "Email";
            projectFields.Category = "Software";
            projectFields.Type = "Microsoft Outlook/Exchange";
            projectFields.Item = "Add/Install/Configure";
            projectFields.Location = "UNH - University Hospital";
            projectFields.Floor__fRoom = "n/a";
            ticket.description = "This is a test ticket created using the FootprintsLib library\n" +
                                 "-------------------------------------------------------------\n" +
                                 "Created on: " + DateTime.Now.ToString() + "\n";

            ticket.assignees = new string[] { "Help__bDesk" };

            mailProperties.assignees = "1";
            mailProperties.contact = "0";
            mailProperties.permanentCCs = "0";

            ticket.projfields = projectFields;
            ticket.mail = mailProperties;

            Console.WriteLine("Creating Ticket ...");
            CreateIssue createTicket = new CreateIssue();
            createTicket.Url = url;
            string ticketNumber = createTicket.MRWebServices__createIssue(username, password, "", ticket);
            Console.WriteLine("Ticket #: " + ticketNumber);
        }
    }
}
