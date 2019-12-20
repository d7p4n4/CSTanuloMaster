using CSAc4yAnnotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTanuloMaster
{
    [NeedToSerialize]
    class Tanulo
    {
        [Ac4yWidgetType("TextBox")]
        [Ac4yMultiple(false)]
        public string Vezeteknev { get; set; }
        [Ac4yWidgetType("TextBox")]
        [Ac4yMultiple(false)]
        public string Cim { get; set; }
        [Ac4yWidgetType("TextBox")]
        [Ac4yMultiple(false)]
        public string Kor { get; set; }
        [Ac4yWidgetType("TextBox")]
        [Ac4yMultiple(false)]
        public string Keresztnev { get; set; }
        [Ac4yEmbedded]
        [Ac4yMultiple(true)]
        public List<Nyelv> NyelvList { get; set; }
        [Ac4yEmbedded]
        [Ac4yMultiple(true)]
        public List<Vegzettseg> VegzettsegList { get; set; }
    }
}
