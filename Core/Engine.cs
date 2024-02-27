using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeeckerWebLurker.Logic.HttpLogic;

namespace BeeckerWebLurker.Core
{
    internal class Engine
    {
        public static void StartEngine()
        {
            WebLogic user = WebLogic.StartSession();

        }
    }
}
