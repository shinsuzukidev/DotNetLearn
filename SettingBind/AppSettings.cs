using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingBind
{
    public class AppSettings
    {
        public string Title { get; set; } = "";
        public int Revision { get; set; }
        public bool LoggingEnabled { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; } = new ConnectionStrings();
        public HttpStatus[] HttpStatuses { get; set; } = new HttpStatus[] { };
    }
}
