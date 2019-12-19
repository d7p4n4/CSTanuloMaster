using CSAc4yAnnotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTanuloMaster
{
    [NeedToSerialize]
    class Nyelv
    {
        public string SectionName { get; set; }
        public string WrapPanelSorszam { get; set; }
        [Ac4yWidgetType("TextBox")]
        public string Nev { get; set; }
        [Ac4yWidgetType("TextBox")]
        public string Szint { get; set; }
    }
}
