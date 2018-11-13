using System;
using System.Collections.Generic;
using System.Text;

namespace ArkBot4.Entities.ArkServer
{
    public class ArkServer
    {
        // SERIALIZED ARK PROPERTIES
        public string rcon_ip { get; set; }
        public int rcon_port { get; set; }
        public string rcon_password { get; set; }

        public string server_name { get; set; }
    }
}
