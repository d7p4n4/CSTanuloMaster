using CSAc4yAnnotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTanuloMaster
{
    [NeedToSerialize]
    class TanuloKontener
    {
        [Ac4yEmbedded]
        public List<Tanulo> TanuloLista { get; set; }
    }
}
