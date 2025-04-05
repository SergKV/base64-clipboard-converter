using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decoder
{
    public partial class ucEditListView : BaseUserControl
    {
        ClipBoardItem editItem;



        public ucEditListView()
        {
            this.Visible = false;
            InitializeComponent();
            //this.Load += ClipboardViewer_Load;
        }

        private void ClipboardViewer_Load(object? sender, EventArgs e)
        {
            
        }
    }
}
