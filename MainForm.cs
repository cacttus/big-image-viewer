using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Vec2f = OpenTK.Vector2;
using Vec3f = OpenTK.Vector3;
namespace Oc
{

    public partial class MainForm : Form, IMessageFilter
    {
        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(Point p);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, Int32 Msg, IntPtr wParam, IntPtr lParam);

        EngineManager _objEngineManager;
        NodeManager GetNodeManager() { return _objEngineManager.GetNodeManager(); }

        public List<string> _objValidImageExtensions = new List<string>
            {
                ".jpg", ".bmp", ".png", ".gif"
            };
        public List<string> _objValidSaveExtensions = new List<string>
            {
                ".jpg", ".bmp", ".png"
            };

        public EngineManager GetEngineManager() { return _objEngineManager; }
        public MainForm()
        {
            InitializeComponent();
            Text = "Omicron Enhanced Viewer";
        }

        #region Private: GUI Callbacks
        private void MainForm_Load(object sender, EventArgs e)
        {
            _objEngineManager = new EngineManager(this);

            GLControl glControl = _objEngineManager.GetGLControl();

            glControl.Dock = DockStyle.Fill;

            _objEngineManager.Initialize(true);

            Application.AddMessageFilter(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = GetValidUserFile();
            LoadImage(path);
        }
        private void _mnu50pct_Click(object sender, EventArgs e)
        {
            if (GetNodeManager().SelectedNode == null)
                return;

            GetNodeManager().SelectedNode.SetPos(new Vec3f(0, 0, 0));
            GetNodeManager().SelectedNode.SetScale(new Vec3f(0.5f, 0.5f, 0.5f));
            //  _objRenderManager.Invalidate();
        }
        private void _mnu100pct_Click(object sender, EventArgs e)
        {
            if (GetNodeManager().SelectedNode == null)
                return;

            GetNodeManager().SelectedNode.SetPos(new Vec3f(0, 0, 0));
            GetNodeManager().SelectedNode.SetScale(new Vec3f(1.0f, 1.0f, 1.0f));
            // _objRenderManager.Invalidate();
        }
        private void _mnu200pct_Click(object sender, EventArgs e)
        {
            if (GetNodeManager().SelectedNode == null)
                return;

            GetNodeManager().SelectedNode.SetPos(new Vec3f(0, 0, 0));
            GetNodeManager().SelectedNode.SetScale(new Vec3f(2.0f, 2.0f, 2.0f));
            // _objRenderManager.Invalidate();
        }
        private void _mnuDelete_Click(object sender, EventArgs e)
        {
            _objEngineManager.GetNodeManager().DeleteSelectedNode();
        }
        private void showAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetEngineManager().GetRenderManager().ShowAxis == false)
            {
                GetEngineManager().GetRenderManager().ShowAxis = true;
                showAxisToolStripMenuItem.Text = "Hide Axis";
            }
            else
            {
                GetEngineManager().GetRenderManager().ShowAxis = false;
                showAxisToolStripMenuItem.Text = "Show Axis";
            }
        }
        private void _mnuBackgroundColor_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog cd = new System.Windows.Forms.ColorDialog();
            DialogResult res = cd.ShowDialog();
            if (res == DialogResult.OK)
            {
                GetEngineManager().GetRenderManager().SetBackgroundColor(new Vector4(
                    (float)cd.Color.R / 255.0f,
                    (float)cd.Color.G / 255.0f,
                    (float)cd.Color.B / 255.0f,
                    (float)cd.Color.A / 255.0f
                    ));
            }
        }
        #endregion

        #region Private:Methods
        private TextureLoadResult LoadImage(string path)
        {  

            if (path == string.Empty)
                return TextureLoadResult.InvalidPath;

            string ext = System.IO.Path.GetExtension(path).ToLower();

            if (!_objValidImageExtensions.Contains(ext))
            {
                System.Windows.Forms.MessageBox.Show("The file type " + ext + " is not supported.");
                return TextureLoadResult.InvalidExtension;
            }

            BaseImage img = new BaseImage(GetEngineManager().GetRenderManager(), GetEngineManager().GetNodeManager());

            TextureLoadResult res = img.Load(path);
            if (res == TextureLoadResult.TooLarge)
            {
                int tx = Gpu.GetMaxTextureSize();
                ShowInfoMessage("This image is too large.  The maximum allowed image width/height is " + tx.ToString() + " pixels.");
                _objEngineManager.GetNodeManager().DeleteNode(img);
            }
            else
            {
                GetNodeManager().DeleteSelectedNode();
                GetNodeManager().SelectedNode = img;
            }
            
            return res;
            //_objImageList.Add(img);
        }
        private string GetValidUserFile()
        {
            System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
            System.Windows.Forms.DialogResult res = dlg.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.Cancel)
                return string.Empty;

            if (!System.IO.File.Exists(dlg.FileName))
                return string.Empty;

            return dlg.FileName;
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //foreach (BaseImage img in _objImageList)
            //{
            //    img.Free();
            //}
        }
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x0100)//key down
            {
                int key = (int)m.WParam;
                if (key == (int)System.Windows.Forms.Keys.F12)
                {
                    SwapFullscreen();
                }
                if (key == (int)System.Windows.Forms.Keys.Escape)
                {
                    if (_blnFullscreen)
                        ExitFullscreen();
                }
            }
            else if (m.Msg == 0x0200)//mouse move
            {
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                IntPtr hWnd = WindowFromPoint(pos);
                if (hWnd != IntPtr.Zero && hWnd != m.HWnd && Control.FromHandle(hWnd) != null)
                {
                    SendMessage(hWnd, m.Msg, m.WParam, m.LParam);
                    return true;
                }
            }
            //else if (m.Msg == 0x0201) //mouse lbutton
            else if (m.Msg == 0x020a)//mouse whele
            {
                // WM_MOUSEWHEEL, find the control at screen position m.LParam
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                IntPtr hWnd = WindowFromPoint(pos);
                if (hWnd != IntPtr.Zero && hWnd != m.HWnd && Control.FromHandle(hWnd) != null)
                {
                    SendMessage(hWnd, m.Msg, m.WParam, m.LParam);
                    return true;
                }
            }
            return false;
        }

        //System.Windows.Threading.DispatcherTimer _objInfoMessageHideTimer;
        #region Info Messages

        private const int EM_GETLINECOUNT = 0xba;
        [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

        private void ShowInfoMessage(string msg)
        {
            _txtInfoMessage.Text = msg;
            var numberOfLines = SendMessage(_txtInfoMessage.Handle.ToInt32(), EM_GETLINECOUNT, 0, 0);
            _txtInfoMessage.Height = (_txtInfoMessage.Font.Height + 2) * numberOfLines;
            _txtInfoMessage.Show();
            //_objUpdateTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);//ASAP
            //_objUpdateTimer.Tick += new EventHandler(EngineTick);
            //_objUpdateTimer.Start();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_objEngineManager.GetNodeManager().SelectedNode == null)
            {
                ShowInfoMessage("Please select an image to save.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = ".jpg";

            //Create Filter.
            string filter;
            filter = "Image Files (";
            string app = "";
            foreach (string ext in _objValidSaveExtensions)
            {
                filter += app + "*" + ext;
                app = ",";
            }
            filter += ")|";
            app="";
            foreach (string ext in _objValidSaveExtensions)
            {
                filter += app + "*" + ext;
                app = ";";
            }
            sfd.Filter = filter;
            DialogResult dr = sfd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string fileName = sfd.FileName;

                BaseImage img = (BaseImage)_objEngineManager.GetNodeManager().SelectedNode;
                if (!_objValidImageExtensions.Contains(System.IO.Path.GetExtension(fileName)))
                    ShowInfoMessage("The image cannot be saved as the specified type.  Please specify a valid path.");
                else if (img == null)
                    ShowInfoMessage("Invalid object was selected.");
                else if(img.GetTexture()==null)
                    ShowInfoMessage("Error object had no texture.");
                else if(img.GetTexture().GetGlId()==0)
                    ShowInfoMessage("Error object's texture was never sent to the GPU.");
                else if(!GL.IsTexture(img.GetTexture().GetGlId()))
                    ShowInfoMessage("Error object was not a recognized OpenGL texture.");
                else
                {
                    try
                    {
                        img.SaveToDisk(fileName);
                    }
                    catch (Exception ex)
                    {
                        ShowInfoMessage("An error has Occurred: \r\n" + ex.ToString());
                    }
                }

            }
        }


        private void _txtInfoMessage_MouseClick(object sender, MouseEventArgs e)
        {
            _txtInfoMessage.Hide();
        }
        #endregion

        AboutForm af = new AboutForm();
        private void _mnuAbout_Click(object sender, EventArgs e)
        {
            af.Show();
        }

        bool _blnFullscreen = false;
        private void SwapFullscreen()
        {
            if (_blnFullscreen)
                ExitFullscreen();
            else
                EnterFullscreen();
        }
        private void EnterFullscreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            _mnuMainMenu.Visible = false;
            _blnFullscreen = true;
        }
        private void ExitFullscreen()
        {
            _mnuMainMenu.Visible = true;
            WindowState = FormWindowState.Normal;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            _blnFullscreen = false;
        }
        private void _mnuFullscreen_Click(object sender, EventArgs e)
        {
            EnterFullscreen();
        }
    }
}
