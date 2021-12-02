
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
            this.AppPathTextBox = new System.Windows.Forms.TextBox();
            this.ipListRichText = new System.Windows.Forms.RichTextBox();
            this.selectAppButton = new System.Windows.Forms.Button();
            this.createRuleButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.appHelpButton = new System.Windows.Forms.Button();
            this.ipListLabel = new System.Windows.Forms.Label();
            this.pathTitleLabel = new System.Windows.Forms.Label();
            this.inoutCheckbox = new System.Windows.Forms.CheckBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.titleBackgroundPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.titleBackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppPathTextBox
            // 
            this.AppPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.AppPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.AppPathTextBox.Location = new System.Drawing.Point(12, 85);
            this.AppPathTextBox.Name = "AppPathTextBox";
            this.AppPathTextBox.Size = new System.Drawing.Size(282, 21);
            this.AppPathTextBox.TabIndex = 0;
            // 
            // ipListRichText
            // 
            this.ipListRichText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ipListRichText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ipListRichText.Location = new System.Drawing.Point(12, 147);
            this.ipListRichText.Name = "ipListRichText";
            this.ipListRichText.Size = new System.Drawing.Size(282, 172);
            this.ipListRichText.TabIndex = 1;
            this.ipListRichText.Text = "";
            // 
            // selectAppButton
            // 
            this.selectAppButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.selectAppButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.selectAppButton.Location = new System.Drawing.Point(376, 78);
            this.selectAppButton.Name = "selectAppButton";
            this.selectAppButton.Size = new System.Drawing.Size(100, 35);
            this.selectAppButton.TabIndex = 2;
            this.selectAppButton.Text = "Selecionar";
            this.selectAppButton.UseVisualStyleBackColor = true;
            this.selectAppButton.Click += new System.EventHandler(this.selectAppButton_Click);
            // 
            // createRuleButton
            // 
            this.createRuleButton.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.createRuleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.createRuleButton.Location = new System.Drawing.Point(376, 195);
            this.createRuleButton.Name = "createRuleButton";
            this.createRuleButton.Size = new System.Drawing.Size(100, 35);
            this.createRuleButton.TabIndex = 3;
            this.createRuleButton.Text = "Criar Regra";
            this.createRuleButton.UseVisualStyleBackColor = true;
            this.createRuleButton.Click += new System.EventHandler(this.createRuleButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.titleLabel.Location = new System.Drawing.Point(150, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(228, 32);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Firewall Blocker";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // appHelpButton
            // 
            this.appHelpButton.BackColor = System.Drawing.Color.Transparent;
            this.appHelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appHelpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.appHelpButton.FlatAppearance.BorderSize = 0;
            this.appHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.appHelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.appHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appHelpButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.appHelpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.appHelpButton.Location = new System.Drawing.Point(463, 303);
            this.appHelpButton.Name = "appHelpButton";
            this.appHelpButton.Size = new System.Drawing.Size(82, 23);
            this.appHelpButton.TabIndex = 5;
            this.appHelpButton.Text = "Ajuda?";
            this.appHelpButton.UseVisualStyleBackColor = false;
            this.appHelpButton.Click += new System.EventHandler(this.appHelpButton_Click_1);
            // 
            // ipListLabel
            // 
            this.ipListLabel.AutoSize = true;
            this.ipListLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ipListLabel.Location = new System.Drawing.Point(91, 124);
            this.ipListLabel.Name = "ipListLabel";
            this.ipListLabel.Size = new System.Drawing.Size(100, 20);
            this.ipListLabel.TabIndex = 7;
            this.ipListLabel.Text = "Lista de IP";
            // 
            // pathTitleLabel
            // 
            this.pathTitleLabel.AutoSize = true;
            this.pathTitleLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pathTitleLabel.Location = new System.Drawing.Point(99, 62);
            this.pathTitleLabel.Name = "pathTitleLabel";
            this.pathTitleLabel.Size = new System.Drawing.Size(93, 20);
            this.pathTitleLabel.TabIndex = 9;
            this.pathTitleLabel.Text = "Aplicativo";
            // 
            // inoutCheckbox
            // 
            this.inoutCheckbox.AutoSize = true;
            this.inoutCheckbox.Font = new System.Drawing.Font("Verdana", 8F);
            this.inoutCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.inoutCheckbox.Location = new System.Drawing.Point(310, 172);
            this.inoutCheckbox.Name = "inoutCheckbox";
            this.inoutCheckbox.Size = new System.Drawing.Size(211, 17);
            this.inoutCheckbox.TabIndex = 11;
            this.inoutCheckbox.Text = "Criar regra de entrada e saída ?";
            this.inoutCheckbox.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.titleBackgroundPanel);
            this.mainPanel.Controls.Add(this.selectAppButton);
            this.mainPanel.Controls.Add(this.appHelpButton);
            this.mainPanel.Controls.Add(this.pathTitleLabel);
            this.mainPanel.Controls.Add(this.createRuleButton);
            this.mainPanel.Controls.Add(this.ipListRichText);
            this.mainPanel.Controls.Add(this.inoutCheckbox);
            this.mainPanel.Controls.Add(this.AppPathTextBox);
            this.mainPanel.Controls.Add(this.ipListLabel);
            this.mainPanel.Location = new System.Drawing.Point(2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(561, 332);
            this.mainPanel.TabIndex = 13;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button1.Location = new System.Drawing.Point(301, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Código no Github";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleBackgroundPanel
            // 
            this.titleBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.titleBackgroundPanel.Controls.Add(this.minimizeButton);
            this.titleBackgroundPanel.Controls.Add(this.closeButton);
            this.titleBackgroundPanel.Controls.Add(this.titleLabel);
            this.titleBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBackgroundPanel.Name = "titleBackgroundPanel";
            this.titleBackgroundPanel.Size = new System.Drawing.Size(570, 36);
            this.titleBackgroundPanel.TabIndex = 13;
            this.titleBackgroundPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBackgroundPanel_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Verdana", 15F);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(435, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(54, 36);
            this.minimizeButton.TabIndex = 7;
            this.minimizeButton.Text = "-";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(494, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(54, 37);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 332);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firewall Blocker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.titleBackgroundPanel.ResumeLayout(false);
            this.titleBackgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox AppPathTextBox;
        private System.Windows.Forms.RichTextBox ipListRichText;
        private System.Windows.Forms.Button selectAppButton;
        private System.Windows.Forms.Button createRuleButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button appHelpButton;
        private System.Windows.Forms.Label ipListLabel;
        private System.Windows.Forms.Label pathTitleLabel;
        private System.Windows.Forms.CheckBox inoutCheckbox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel titleBackgroundPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button1;
    }
}

