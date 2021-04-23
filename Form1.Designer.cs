
namespace FirewallBlocker
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.duvidaAppHover = new System.Windows.Forms.Button();
            this.listaIPHover = new System.Windows.Forms.Button();
            this.Titulo2 = new System.Windows.Forms.Label();
            this.dicaLista = new System.Windows.Forms.Label();
            this.Titulo1 = new System.Windows.Forms.Label();
            this.dicaCaminho = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 191);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(242, 172);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(286, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.button2.Location = new System.Drawing.Point(286, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Criar Regra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Firewall Blocker";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // duvidaAppHover
            // 
            this.duvidaAppHover.BackColor = System.Drawing.Color.Transparent;
            this.duvidaAppHover.BackgroundImage = global::FirewallBlocker.Properties.Resources.question_solid;
            this.duvidaAppHover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.duvidaAppHover.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.duvidaAppHover.FlatAppearance.BorderSize = 0;
            this.duvidaAppHover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duvidaAppHover.ForeColor = System.Drawing.Color.Transparent;
            this.duvidaAppHover.Location = new System.Drawing.Point(75, 58);
            this.duvidaAppHover.Name = "duvidaAppHover";
            this.duvidaAppHover.Size = new System.Drawing.Size(28, 23);
            this.duvidaAppHover.TabIndex = 5;
            this.duvidaAppHover.UseVisualStyleBackColor = false;
            this.duvidaAppHover.MouseLeave += new System.EventHandler(this.duvidaAppHover_MouseLeave);
            this.duvidaAppHover.MouseHover += new System.EventHandler(this.duvidaAppHover_MouseHover);
            // 
            // listaIPHover
            // 
            this.listaIPHover.BackColor = System.Drawing.Color.Transparent;
            this.listaIPHover.BackgroundImage = global::FirewallBlocker.Properties.Resources.question_solid;
            this.listaIPHover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.listaIPHover.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.listaIPHover.FlatAppearance.BorderSize = 0;
            this.listaIPHover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaIPHover.ForeColor = System.Drawing.Color.Transparent;
            this.listaIPHover.Location = new System.Drawing.Point(75, 143);
            this.listaIPHover.Name = "listaIPHover";
            this.listaIPHover.Size = new System.Drawing.Size(28, 23);
            this.listaIPHover.TabIndex = 6;
            this.listaIPHover.UseVisualStyleBackColor = false;
            this.listaIPHover.MouseLeave += new System.EventHandler(this.listaIPHover_MouseLeave);
            this.listaIPHover.MouseHover += new System.EventHandler(this.listaIPHover_MouseHover);
            // 
            // Titulo2
            // 
            this.Titulo2.AutoSize = true;
            this.Titulo2.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.Titulo2.Location = new System.Drawing.Point(109, 141);
            this.Titulo2.Name = "Titulo2";
            this.Titulo2.Size = new System.Drawing.Size(88, 23);
            this.Titulo2.TabIndex = 7;
            this.Titulo2.Text = "Lista de Ip";
            // 
            // dicaLista
            // 
            this.dicaLista.AutoSize = true;
            this.dicaLista.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dicaLista.Location = new System.Drawing.Point(-1, 169);
            this.dicaLista.Name = "dicaLista";
            this.dicaLista.Size = new System.Drawing.Size(476, 19);
            this.dicaLista.TabIndex = 8;
            this.dicaLista.Text = "Adicione os ips que deseja bloquear, ou deixe em branco para bloquear tudo";
            this.dicaLista.Visible = false;
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.Titulo1.Location = new System.Drawing.Point(109, 58);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(84, 23);
            this.Titulo1.TabIndex = 9;
            this.Titulo1.Text = "Aplicativo";
            // 
            // dicaCaminho
            // 
            this.dicaCaminho.AutoSize = true;
            this.dicaCaminho.Font = new System.Drawing.Font("Segoe UI", 9.1F);
            this.dicaCaminho.Location = new System.Drawing.Point(12, 80);
            this.dicaCaminho.Name = "dicaCaminho";
            this.dicaCaminho.Size = new System.Drawing.Size(383, 17);
            this.dicaCaminho.TabIndex = 10;
            this.dicaCaminho.Text = "Cole o caminho manualmente ou clique selecionar para navegar";
            this.dicaCaminho.Visible = false;
            this.dicaCaminho.Click += new System.EventHandler(this.label5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(263, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Criar regra de entrada e saida";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(353, 350);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Disponível no GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 372);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dicaCaminho);
            this.Controls.Add(this.Titulo1);
            this.Controls.Add(this.dicaLista);
            this.Controls.Add(this.Titulo2);
            this.Controls.Add(this.listaIPHover);
            this.Controls.Add(this.duvidaAppHover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firewall Blocker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button duvidaAppHover;
        private System.Windows.Forms.Button listaIPHover;
        private System.Windows.Forms.Label Titulo2;
        private System.Windows.Forms.Label dicaLista;
        private System.Windows.Forms.Label Titulo1;
        private System.Windows.Forms.Label dicaCaminho;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

