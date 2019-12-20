using CSAc4yClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTanuloMaster
{
    class Program
    {
        public static void Main(String[] args)
        {
            new Serializer().Serialize("c:\\Server\\", typeof(Program));
        }
    }
}
