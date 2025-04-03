using System.Runtime.InteropServices;
using System.Text;
using decoder;

namespace Base64ClipboardDecoder
{
    public partial class ClipBoardViewer : BaseForm
    {
        private const string convertToTxt = "Convert to txt";
        private const string convertToBase64 = "Convert to base64";
        private const string disabled = "Disable";
        private const string enabled = "Enable";

        public Point mouseLocation;

        private ucHistoryListView historyListView;

        public ToolStripMenuItem deactivateMenuItem
        {
            get { return deactivateToolStripMenuItem; }
        }

        public ToolStripMenuItem disableMenuItem
        {
            get { return DisableMenuStripMenuItem; }
        }

        public ClipBoardViewer()
        {
            InitializeComponent();

            historyListView = new ucHistoryListView();

            WindowState = FormWindowState.Minimized;
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            NotifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void ClipBoardViewer_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                NotifyIcon.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                NotifyIcon.Visible = false;
            }
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal)
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }


        private void ClipBoardViewer_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void DisableMenuStrip_Click(object sender, EventArgs e)
        {
            historyListView.IsDisabled = !historyListView.IsDisabled;
        }

        private void ExitContextMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucHistoryListView1_Load(object sender, EventArgs e)
        {

        }
    }
}
