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
        [Ac4yMultiple(false)]
        public string SectionName { get; set; }
        [Ac4yMultiple(false)]
        public string WrapPanelSorszam { get; set; }
        [Ac4yWidgetType("TextBox")]
        [Ac4yMultiple(false)]
        public string Nev { get; set; }
        [Ac4yWidgetType("TextBox")]
        [Ac4yMultiple(false)]
        public string Szint { get; set; }
    }
}
