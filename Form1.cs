using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FirewallBlocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames;     
                textBox1.Text = sFileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Você não selecionou um aplicativo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else {
                String Programa = textBox1.Text;
                String IPs = richTextBox1.Text;
                bool InOut = false;

                if (checkBox1.Checked){
                    InOut = true;
                }

                CriarRegra(Programa, IPs, InOut);
            }
        }

        void CriarRegra(String App, String IPs, bool InOut)
        {
            var data = DateTime.Now.ToString("dd/MM/yyyy - H:m:ss");
            var nome = "Firewall Blocker - " + data;

            var lines = this.richTextBox1.Text.Split('\n');
            String bloquear = "";
            String programa = textBox1.Text.ToString();

            switch (InOut)
            {
                case false:
     
                    if (!string.IsNullOrEmpty(IPs))
                    {
                        foreach (var line in lines)
                        {
                            bloquear += $"{line},";

                        }
                        bloquear = bloquear.Remove(bloquear.Length - 1);
                        var comando = "netsh advfirewall firewall add rule name=\"" + nome + "\" ^ dir =in interface=any action = block remoteip=\"" + bloquear + "\"" + " program=\"" + programa + "\"";
                        System.Diagnostics.Process.Start("CMD.exe", "/c" + comando);
                        MessageBox.Show("Regra criada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var comando = "netsh advfirewall firewall add rule name=\"" + nome + "\" ^ dir =in interface=any action = block program=\"" + programa + "\"";
                        System.Diagnostics.Process.Start("CMD.exe", "/c" + comando);
                        MessageBox.Show("Regra criada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;

                case true:
             
                    if (!string.IsNullOrEmpty(IPs))
                    {
                        foreach (var line in lines)
                        {
                            bloquear += $"{line},";

                        }

                        bloquear = bloquear.Remove(bloquear.Length - 1);
                        var bloqOut = "netsh advfirewall firewall add rule name=\"" + nome + "\" ^ dir =out interface=any action = block remoteip=\"" + bloquear + "\"" + " program=\"" + programa + "\"";
                        var bloqIn = "netsh advfirewall firewall add rule name=\"" + nome + "\" ^ dir =in interface=any action = block remoteip=\"" + bloquear + "\"" + " program=\"" + programa + "\"";
                        System.Diagnostics.Process.Start("CMD.exe", "/c" + bloqOut);
                        System.Diagnostics.Process.Start("CMD.exe", "/c" + bloqIn);
                        MessageBox.Show("Regra criada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var bloqOut = "netsh advfirewall firewall add rule name=\"" + nome + "\" ^ dir =out interface=any action = block program=\"" + programa + "\"";
                        var bloqIn = "netsh advfirewall firewall add rule name=\"" + nome + "\" ^ dir =in interface=any action = block program=\"" + programa + "\"";
                        System.Diagnostics.Process.Start("CMD.exe", "/c" + bloqOut);
                        System.Diagnostics.Process.Start("CMD.exe", "/c" + bloqIn);
                        MessageBox.Show("Regra criada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    break;

                default:

                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void duvidaAppHover_MouseHover(object sender, EventArgs e)
        {
            dicaCaminho.Show();
        }

        private void duvidaAppHover_MouseLeave(object sender, EventArgs e)
        {
            dicaCaminho.Hide();
        }

        private void listaIPHover_MouseHover(object sender, EventArgs e)
        {
            dicaLista.Show();
        }

        private void listaIPHover_MouseLeave(object sender, EventArgs e)
        {
            dicaLista.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kurxz/firewallblocker");
        }
    }
}
