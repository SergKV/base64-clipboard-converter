using System.Runtime.InteropServices;
using decoder.Events;

namespace Base64ClipboardDecoder
{
    public partial class ClipBoardViewer : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        int MaximizeAppKeyId = 1;
        int AppStateKeyId = 2;

        private AppStatusEvent AppStatusEvent;

        private const string disabled = "Disable";
        private const string enabled = "Enable";

        public Point mouseLocation;

        private bool isDisabled = false;

        public bool IsDisabled
        {
            get => isDisabled;

            set
            {
                if (isDisabled != value)
                {
                    isDisabled = value;
                    disableMenuItem.Text = isDisabled ? enabled : disabled;
                }
            }
        }

        public ToolStripMenuItem disableMenuItem
        {
            get { return DisableMenuStripMenuItem; }
        }

        public ClipBoardViewer()
        {
            InitializeComponent();

            var AltF1Registered = RegisterHotKey(
                this.Handle, MaximizeAppKeyId, 0x0001, (int)Keys.F1
            );

            var AltF2Registered = RegisterHotKey(
                this.Handle, AppStateKeyId, 0x0001, (int)Keys.F2
            );

            AppStatusEvent = new AppStatusEvent();
            AppStatusEvent.appStatusEvent -= AppStatusEvent_AppStatusChanged;
            AppStatusEvent.appStatusEvent += AppStatusEvent_AppStatusChanged;

            WindowState = FormWindowState.Minimized;
        }

        private void AppStatusEvent_AppStatusChanged(object? sender, AppStatusEvent e)
        {
            IsDisabled = e.appStatus;
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

            ucHistoryListView1.UpdateClipboardList();
        }


        private void ClipBoardViewer_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void DisableMenuStrip_Click(object sender, EventArgs e)
        {
            ToggleAppState();
        }

        private void ExitContextMenuStrip_Click(object sender, EventArgs e)
        {
            AppStatusEvent.appStatusEvent -= AppStatusEvent_AppStatusChanged;

            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void ClipBoardViewer_SizeChanged(object sender, EventArgs e)
        {
            ucHistoryListView1.UpdateClipboardList();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                if (id == 1)
                {
                    ToggleAppFormWindowState();
                }
                else
                {
                    ToggleAppState();
                }
            }

            base.WndProc(ref m);
        }

        private void ToggleAppFormWindowState()
        {
            this.Show();
            this.WindowState = (this.WindowState == FormWindowState.Normal)
                ? FormWindowState.Minimized
                : FormWindowState.Normal;
        }

        private void ToggleAppState()
        {
            AppStatusEvent.SendEventInfo(!isDisabled);
        }
    }
}
