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
        public string Vezeteknev { get; set; }
        [Ac4yWidgetType("TextBox")]
        public string Cim { get; set; }
        [Ac4yWidgetType("TextBox")]
        public string Kor { get; set; }
        [Ac4yWidgetType("TextBox")]
        public string Keresztnev { get; set; }
        [Ac4yEmbedded]
        public List<Nyelv> NyelvList { get; set; }
        [Ac4yEmbedded]
        public List<Vegzettseg> VegzettsegList { get; set; }
    }
}
