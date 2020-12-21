
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ITServiceModel
{
    public class Equipment
    {
        public Guid EQUIPMENT_RECORD { get; set; }
        public string EQUIPMENT_ID { get; set; }
        public string TYPE_EQUIPMENT { get; set; }
        public string EQUIPMENT_BRAND { get; set; }
        public string EQUIPMENT_MODEL { get; set; }
        public string EQUIPMENT_SN { get; set; }
        public string EQUIPMENT_EMEI1 { get; set; }
        public string EQUIPMENT_EMEI2 { get; set; }
        public string BUY_DATE { get; set; }
        public string WARRANTY_DATE { get; set; }
        public string EQUIPMENT_STATUS { get; set; }
        public string EQUIPMENT_OWNER { get; set; }
        public string EQUIPMENT_DEPT { get; set; }
        public string EQUIPMENT_LOCATION { get; set; }
        public string PCNB_CPU { get; set; }
        public string PCNB_RAM { get; set; }
        public string PCNB_HDD { get; set; }
        public string PCNB_VGA { get; set; }
        public string LICENSE_WINDOWS { get; set; }
        public string LICENSE_OFFICE { get; set; }
        public string LICENSE_ANTIVIRUS { get; set; }
        public string VLAN_COMNAME { get; set; }
        public string EQUIPMENT_BORROW { get; set; }
    }
}