using CSAc4yAnnotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTanuloMaster
{
    [NeedToSerialize]
    class Vegzettseg
    {
        [Ac4yWidgetType("TextBox")]
        [Ac4yMultiple(false)]
        public string IskolaNeve { get; set; }
        [Ac4yWidgetType("TextBox")]
        [Ac4yMultiple(false)]
        public string Szint { get; set; }
        [Ac4yWidgetType("TextBox")]
        [Ac4yMultiple(false)]
        public string Szak { get; set; }
    }
}
