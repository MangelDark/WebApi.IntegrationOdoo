using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Client.Models
{

    public class ResPartnerViewModel 
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }  

        // res.partner.title
        [JsonProperty("title")]
        public long? Title { get; set; }

        [JsonProperty("vat")]
        public string Vat { get; set; }


        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
   
        [JsonProperty("credit_limit")]
        public double? CreditLimit { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_formatted")]
        public string EmailFormatted { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }
    
    }



}