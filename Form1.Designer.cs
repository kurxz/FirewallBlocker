
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
            this.translationIcon = new System.Windows.Forms.PictureBox();
            this.langSelectBox = new System.Windows.Forms.ComboBox();
            this.githubButton = new System.Windows.Forms.Button();
            this.titleBackgroundPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translationIcon)).BeginInit();
            this.titleBackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppPathTextBox
            // 
            this.AppPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.AppPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            resources.ApplyResources(this.AppPathTextBox, "AppPathTextBox");
            this.AppPathTextBox.Name = "AppPathTextBox";
            // 
            // ipListRichText
            // 
            this.ipListRichText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ipListRichText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            resources.ApplyResources(this.ipListRichText, "ipListRichText");
            this.ipListRichText.Name = "ipListRichText";
            // 
            // selectAppButton
            // 
            resources.ApplyResources(this.selectAppButton, "selectAppButton");
            this.selectAppButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.selectAppButton.Name = "selectAppButton";
            this.selectAppButton.UseVisualStyleBackColor = true;
            this.selectAppButton.Click += new System.EventHandler(this.selectAppButton_Click);
            // 
            // createRuleButton
            // 
            resources.ApplyResources(this.createRuleButton, "createRuleButton");
            this.createRuleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.createRuleButton.Name = "createRuleButton";
            this.createRuleButton.UseVisualStyleBackColor = true;
            this.createRuleButton.Click += new System.EventHandler(this.createRuleButton_Click);
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // appHelpButton
            // 
            this.appHelpButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.appHelpButton, "appHelpButton");
            this.appHelpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.appHelpButton.FlatAppearance.BorderSize = 0;
            this.appHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.appHelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.appHelpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.appHelpButton.Name = "appHelpButton";
            this.appHelpButton.UseVisualStyleBackColor = false;
            this.appHelpButton.Click += new System.EventHandler(this.appHelpButton_Click_1);
            // 
            // ipListLabel
            // 
            resources.ApplyResources(this.ipListLabel, "ipListLabel");
            this.ipListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ipListLabel.Name = "ipListLabel";
            // 
            // pathTitleLabel
            // 
            resources.ApplyResources(this.pathTitleLabel, "pathTitleLabel");
            this.pathTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pathTitleLabel.Name = "pathTitleLabel";
            // 
            // inoutCheckbox
            // 
            resources.ApplyResources(this.inoutCheckbox, "inoutCheckbox");
            this.inoutCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.inoutCheckbox.Name = "inoutCheckbox";
            this.inoutCheckbox.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.mainPanel.Controls.Add(this.translationIcon);
            this.mainPanel.Controls.Add(this.langSelectBox);
            this.mainPanel.Controls.Add(this.githubButton);
            this.mainPanel.Controls.Add(this.titleBackgroundPanel);
            this.mainPanel.Controls.Add(this.selectAppButton);
            this.mainPanel.Controls.Add(this.appHelpButton);
            this.mainPanel.Controls.Add(this.pathTitleLabel);
            this.mainPanel.Controls.Add(this.createRuleButton);
            this.mainPanel.Controls.Add(this.ipListRichText);
            this.mainPanel.Controls.Add(this.inoutCheckbox);
            this.mainPanel.Controls.Add(this.AppPathTextBox);
            this.mainPanel.Controls.Add(this.ipListLabel);
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // translationIcon
            // 
            resources.ApplyResources(this.translationIcon, "translationIcon");
            this.translationIcon.Name = "translationIcon";
            this.translationIcon.TabStop = false;
            // 
            // langSelectBox
            // 
            this.langSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langSelectBox.FormattingEnabled = true;
            this.langSelectBox.Items.AddRange(new object[] {
            resources.GetString("langSelectBox.Items"),
            resources.GetString("langSelectBox.Items1"),
            resources.GetString("langSelectBox.Items2")});
            resources.ApplyResources(this.langSelectBox, "langSelectBox");
            this.langSelectBox.Name = "langSelectBox";
            this.langSelectBox.TabStop = false;
            this.langSelectBox.SelectedIndexChanged += new System.EventHandler(this.langSelectBox_SelectedIndexChanged);
            // 
            // githubButton
            // 
            this.githubButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.githubButton, "githubButton");
            this.githubButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.githubButton.FlatAppearance.BorderSize = 0;
            this.githubButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.githubButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.githubButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.githubButton.Name = "githubButton";
            this.githubButton.UseVisualStyleBackColor = false;
            this.githubButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleBackgroundPanel
            // 
            this.titleBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.titleBackgroundPanel.Controls.Add(this.minimizeButton);
            this.titleBackgroundPanel.Controls.Add(this.closeButton);
            this.titleBackgroundPanel.Controls.Add(this.titleLabel);
            resources.ApplyResources(this.titleBackgroundPanel, "titleBackgroundPanel");
            this.titleBackgroundPanel.Name = "titleBackgroundPanel";
            this.titleBackgroundPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBackgroundPanel_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.minimizeButton, "minimizeButton");
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translationIcon)).EndInit();
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
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.ComboBox langSelectBox;
        private System.Windows.Forms.PictureBox translationIcon;
    }
}

