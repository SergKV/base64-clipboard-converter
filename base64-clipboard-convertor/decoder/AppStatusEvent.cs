using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoder
{
    internal class AppStatusEvent : EventArgs
    {
        public bool appStatus;
        public static event EventHandler<AppStatusEvent> appStatusEvent;
        public AppStatusEvent() { }
        public AppStatusEvent(bool status)
        {
            appStatus = status;
        }

        protected virtual void OnChangeEvent(AppStatusEvent e)
        {
            appStatusEvent?.Invoke(this, e);
        }

        public void SendEventInfo(bool appStatusInfo)
        {
            OnChangeEvent(new AppStatusEvent(appStatusInfo));
        }
    }
}
