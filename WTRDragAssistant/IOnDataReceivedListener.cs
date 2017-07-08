using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTRDragAssistant
{
    public interface IOnDataReceivedListener
    {
        void OnDataReceived(string data);
    }
}
