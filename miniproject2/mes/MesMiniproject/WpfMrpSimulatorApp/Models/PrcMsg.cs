using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMrpSimulatorApp.Models
{
    // json전송용 객체. 딴데 안씀
    public class PrcMsg
    {
        public string ClientId { get; set; }
        public string PlantCode { get; set; }
        public string FacilityId { get; set; }
        public string Flag { get; set; }
    }
}
