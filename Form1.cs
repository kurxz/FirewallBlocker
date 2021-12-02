using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FirewallBlocker
{
    public partial class Form1 : Form
    {
        //Fields for border
        private int borderRadius = 20;

        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(57, 62, 70);

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.mainPanel.BackColor = borderColor;
            this.BackColor = borderColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void selectAppButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames;
                AppPathTextBox.Text = sFileName;
            }
        }

        public static bool isValidIP(string strIP)
        {
            IPAddress result = null;
            return
                !String.IsNullOrEmpty(strIP) &&
                IPAddress.TryParse(strIP, out result);
        }

        private void createRuleButton_Click(object sender, EventArgs e)
        {
            String Program = AppPathTextBox.Text;
            String IPs = ipListRichText.Text;
            bool InOutRule = false;
            bool shouldCreate = false;

            if (inoutCheckbox.Checked)
            {
                InOutRule = true;
            }

            if (string.IsNullOrEmpty(Program) || Program.Substring(Program.Length - 4) != ".exe")
            {
                MessageBox.Show("Você não selecionou um aplicativo. Inclua o executável terminando em .exe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(ipListRichText.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Você deixou a lista de IPs em branco. O app irá block TODOS os IPs para o processo selecionado. Deseja prosseguir?", "Aviso!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        shouldCreate = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        shouldCreate = false;
                    }
                }

                if (shouldCreate == true)
                {
                    createRule(Program, IPs, InOutRule);
                }
            }
        }

        private void createRule(String App, String IPs, bool InOutRule)
        {
            var date = DateTime.Now.ToString("dd/MM/yyyy - H:m:ss");
            var name = "Firewall Blocker - " + date;

            var lines = this.ipListRichText.Text.Split('\n');
            String block = "";
            String program = App;
            bool ipIsOk = true;

            switch (InOutRule)
            {
                case false:

                    if (!string.IsNullOrEmpty(IPs))
                    {
                        foreach (var line in lines)
                        {
                            if (isValidIP(line) == true)
                            {
                                block += $"{line},";
                                ipIsOk = true;
                            }
                            else
                            {
                                MessageBox.Show($"Um dos IPs é inválido: {line}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ipIsOk = false;
                                break;
                            }
                        }

                        if (ipIsOk == true)
                        {
                            block = block.Remove(block.Length - 1);
                            var cmdCommand = "netsh advfirewall firewall add rule name=\"" + name + "\" ^ dir =in interface=any action = block remoteip=\"" + block + "\"" + " program=\"" + program + "\"";
                            System.Diagnostics.Process.Start("CMD.exe", "/c" + cmdCommand);
                            MessageBox.Show("Regra criada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (ipIsOk == true)
                        {
                            var cmdCommand = "netsh advfirewall firewall add rule name=\"" + name + "\" ^ dir =in interface=any action = block program=\"" + program + "\"";
                            System.Diagnostics.Process.Start("CMD.exe", "/c" + cmdCommand);
                            MessageBox.Show("Regra criada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    break;

                case true:

                    if (!string.IsNullOrEmpty(IPs))
                    {
                        foreach (var line in lines)
                        {
                            if (isValidIP(line) == true)
                            {
                                block += $"{line},";
                                ipIsOk = true;
                            }
                            else
                            {
                                MessageBox.Show($"Um dos IPs é inválido: {line}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ipIsOk = false;
                                break;
                            }
                        }

                        if (ipIsOk == true)
                        {
                            block = block.Remove(block.Length - 1);
                            var blockOut = "netsh advfirewall firewall add rule name=\"" + name + "\" ^ dir =out interface=any action = block remoteip=\"" + block + "\"" + " program=\"" + program + "\"";
                            var blockIn = "netsh advfirewall firewall add rule name=\"" + name + "\" ^ dir =in interface=any action = block remoteip=\"" + block + "\"" + " program=\"" + program + "\"";
                            System.Diagnostics.Process.Start("CMD.exe", "/c" + blockOut);
                            System.Diagnostics.Process.Start("CMD.exe", "/c" + blockIn);
                            MessageBox.Show("Regra criada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (ipIsOk == true)
                        {
                            var blockOut = "netsh advfirewall firewall add rule name=\"" + name + "\" ^ dir =out interface=any action = block program=\"" + program + "\"";
                            var blockIn = "netsh advfirewall firewall add rule name=\"" + name + "\" ^ dir =in interface=any action = block program=\"" + program + "\"";
                            System.Diagnostics.Process.Start("CMD.exe", "/c" + blockOut);
                            System.Diagnostics.Process.Start("CMD.exe", "/c" + blockIn);
                            MessageBox.Show("Regra criada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    break;

                default:

                    break;
            }
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void appHelpButton_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ao continuar irá abrir uma aba no navegador com a página de ajuda. Deseja prosseguir?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("https://github.com/kurxz/FirewallBlocker/wiki/Help-Page");
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragArround();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(mainPanel, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void titleBackgroundPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragArround();
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            dragArround();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/kurxz/firewallblocker");
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }

        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);

                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);

                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);

                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);

                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();

            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);

            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);

            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);

            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void dragArround()
        {
            //This function is used to drag the app arround the screen
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}