using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortaCapena.OdooJsonRpcClient.Shared.Models
{
    [OdooTableName("customers.customers")]
    [JsonConverter(typeof(OdooModelConverter))]

    public class CustomersCustomerOdooModel : IOdooModel
    {
        [JsonProperty("customer_id")]
        public long? CustomerId { get; set; }
        [JsonProperty("name")]
        public string  Name { get; set; }
        [JsonProperty("vat")]
        public string Vat { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("id")]

        public long Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
