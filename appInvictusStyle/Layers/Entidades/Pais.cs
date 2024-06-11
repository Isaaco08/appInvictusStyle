using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.InvictusStyle.Layers.Entidades
{
    [DataContract]
    public class Pais
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public List<string> topLevelDomain { get; set; }

        [DataMember]
        public string alpha2Code { get; set; }
        [DataMember]
        public string alpha3Code { get; set; }

        [DataMember]
        public List<string> callingCodes { get; set; }
        [DataMember]
        public string capital { get; set; }

        [DataMember]
        public List<string> altSpellings { get; set; }
        [DataMember]
        public string region { get; set; }
        [DataMember]
        public string subregion { get; set; }
        [DataMember]
        public int population { get; set; }
        [DataMember]
        public List<string> latlng { get; set; }
        [DataMember]
        public string demonym { get; set; }
        [DataMember]
        public string area { get; set; }
        [DataMember]
        public string gini { get; set; }
        [DataMember]
        public List<string> timezones { get; set; }
        [DataMember]
        public List<string> borders { get; set; }
        [DataMember]
        public string nativeName { get; set; }
        [DataMember]
        public string numericCode { get; set; }


        public override string ToString()
        {
            return name;
        }


    }
}
