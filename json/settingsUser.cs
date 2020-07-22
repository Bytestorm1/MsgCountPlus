using MsgCountPlusNET.json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgCountPlusNETF.json
{
    public class settingsUser
    {
        public string name;
        public ulong Id;
        public int step;
        public bool waitForResponse;
        public ulong guild;
        public jSettings priorSettings;
    }
}
