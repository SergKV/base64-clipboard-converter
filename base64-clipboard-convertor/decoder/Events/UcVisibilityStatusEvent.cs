using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoder.Events
{
    internal class UcVisibilityStatusEvent : EventArgs
    {
        public static event EventHandler<UcVisibilityStatusEvent> ucVisibilityStatusEvent;
        private ClipBoardItem item;

        public UcVisibilityStatusEvent() { }

        public UcVisibilityStatusEvent(ClipBoardItem item)
        {
            this.item = item;
        }
        
        public ClipBoardItem Item 
        { 
            get 
            { 
                return item; 
            } 
        }

        protected virtual void OnChangeEvent(UcVisibilityStatusEvent e)
        {
            ucVisibilityStatusEvent?.Invoke(this, e);
        }

        public void SendEventInfo(ClipBoardItem item)
        {
            OnChangeEvent(new UcVisibilityStatusEvent(item));
        }
    }
}
