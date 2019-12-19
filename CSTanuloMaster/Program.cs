using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTanuloMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            CSSerializerLib.Serialize _serialize = new CSSerializerLib.Serialize();

            _serialize.SerializeMethod("c:\\Server\\", typeof(Program));
        }
    }
}
