using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;

namespace FootprintsLib
{
    [WebServiceBinding(Name = "CreateIssueWebService", Namespace = "MRWebServices")]    public class CreateIssue : SoapHttpClientProtocol
    {
        public CreateIssue()
        {
        }

        [SoapDocumentMethodAttribute(
         "MRWebServices#MRWebServices__createIssue",
         RequestNamespace = "MRWebServices",
         ResponseNamespace = "MRWebServices",
         Use = System.Web.Services.Description.SoapBindingUse.Encoded,
         ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string MRWebServices__createIssue(string userName, string password, string extraInfo, CreateIssueArgs args)
        {
            object[] results = this.Invoke("MRWebServices__createIssue",
                                            new object[] { userName, password, extraInfo, args });
            return ((string)(results[0]));
        }    }
}
