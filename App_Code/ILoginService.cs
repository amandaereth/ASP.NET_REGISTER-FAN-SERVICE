using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface ILoginService
    {
    [OperationContract]
    int VenueLogin (string username, string password);

    [OperationContract]
    int VenueRegistration(VenueLite v);
    }

	[DataContract]
public class VenueLite
    {
        [DataMember]
        public string Name {set; get;}
        [DataMember]
        public string Address{ set; get; }
        [DataMember]
        public string City { set; get; }
        [DataMember]
        public string State {set; get;}
        [DataMember]
        public string ZipCode {set; get;}
        [DataMember]
         public string Phone {set; get;}
        [DataMember]
         public string Email {set; get;}
        [DataMember]
        public string WebPage { set; get; }
        [DataMember]
        public int AgeRestriction { set; get; }
        [DataMember]
        public string UserName { set; get; }
        [DataMember]
        public string Password { set; get; }

    }

