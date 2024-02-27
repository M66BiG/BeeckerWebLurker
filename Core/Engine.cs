using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeckerWebLurker.Core
{
    internal class Engine
    {
        public static void StartEngine()
        {
            UserModel user = WebLogic.StartSession();
        }
    }
}
