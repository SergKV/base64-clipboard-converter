namespace decoder
{
    public partial class EditItemForm : Form
    {
        private ClipBoardItem editItem { get; set; }

        public Point mouseLocation;

        public EditItemForm(ClipBoardItem item)
        {
            InitializeComponent();
            editItem = item;
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

        private void MouseDouble_Click(object sender, MouseEventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal)
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal)
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }
    }
}
