using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FootprintsLib
{
    /// <summary>
    /// This class defines the footprints workspace project fields
    /// </summary>
    [SoapTypeAttribute("ProjFields", "MRWebServices")]
    public class ProjFields
    {
        /// <summary>
        /// Pending Reason
        /// </summary>
        public string Pending__bReason;
        
        /// <summary>
        /// Specifies how a ticket was submited. Values include:
        /// Phone
        /// Email
        /// Walk-in
        /// </summary>
        public string Submitted__bVia;

        public string Category;
        public string Type;
        public string Item;
        public string Location;

        /// <summary>
        /// Floor/Room 
        /// </summary>
        public string Floor__fRoom;    }
}
