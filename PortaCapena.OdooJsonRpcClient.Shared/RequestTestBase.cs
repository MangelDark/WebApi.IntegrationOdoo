using PortaCapena.OdooJsonRpcClient.Models;

namespace PortaCapena.OdooJsonRpcClient.Shared
{
    public class RequestTestBase
    {
        protected static readonly OdooConfig TestConfig = new OdooConfig(
            apiUrl: "https://rr-trainer.odoo.com", // "https://db-name.dev.odoo.com"
            dbName: "rr-trainer",
            userName: "yacalos_@hotmail.com",
            password: "Sanchez192307@."
        );
    }
}