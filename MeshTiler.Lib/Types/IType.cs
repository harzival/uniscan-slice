using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshTiler.Lib.Types
{
    interface IType
    {
        void LoadFromStringArray(string[] data);
    }
}
