namespace FormCommunicationApplication {
    partial class formLayout {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.conversationTextBox = new System.Windows.Forms.RichTextBox();
            this.formLowerSectionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sendMessageButton = new MetroFramework.Controls.MetroButton();
            this.messageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.messageLabel = new MetroFramework.Controls.MetroLabel();
            this.formTableLayoutPanel.SuspendLayout();
            this.formLowerSectionTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTableLayoutPanel
            // 
            this.formTableLayoutPanel.ColumnCount = 1;
            this.formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.0991F));
            this.formTableLayoutPanel.Controls.Add(this.conversationTextBox, 0, 0);
            this.formTableLayoutPanel.Controls.Add(this.formLowerSectionTableLayoutPanel, 0, 1);
            this.formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.formTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.formTableLayoutPanel.Name = "formTableLayoutPanel";
            this.formTableLayoutPanel.RowCount = 2;
            this.formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.89723F));
            this.formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.102767F));
            this.formTableLayoutPanel.Size = new System.Drawing.Size(576, 576);
            this.formTableLayoutPanel.TabIndex = 0;
            // 
            // conversationTextBox
            // 
            this.conversationTextBox.BackColor = System.Drawing.Color.White;
            this.conversationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conversationTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversationTextBox.Location = new System.Drawing.Point(3, 3);
            this.conversationTextBox.Name = "conversationTextBox";
            this.conversationTextBox.ReadOnly = true;
            this.conversationTextBox.Size = new System.Drawing.Size(570, 523);
            this.conversationTextBox.TabIndex = 0;
            this.conversationTextBox.Text = "";
            // 
            // formLowerSectionTableLayoutPanel
            // 
            this.formLowerSectionTableLayoutPanel.ColumnCount = 3;
            this.formLowerSectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.94203F));
            this.formLowerSectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.05797F));
            this.formLowerSectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.formLowerSectionTableLayoutPanel.Controls.Add(this.sendMessageButton, 2, 0);
            this.formLowerSectionTableLayoutPanel.Controls.Add(this.messageTextBox, 1, 0);
            this.formLowerSectionTableLayoutPanel.Controls.Add(this.messageLabel, 0, 0);
            this.formLowerSectionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLowerSectionTableLayoutPanel.Location = new System.Drawing.Point(0, 529);
            this.formLowerSectionTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.formLowerSectionTableLayoutPanel.Name = "formLowerSectionTableLayoutPanel";
            this.formLowerSectionTableLayoutPanel.RowCount = 1;
            this.formLowerSectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formLowerSectionTableLayoutPanel.Size = new System.Drawing.Size(576, 47);
            this.formLowerSectionTableLayoutPanel.TabIndex = 1;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendMessageButton.Location = new System.Drawing.Point(485, 8);
            this.sendMessageButton.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(88, 31);
            this.sendMessageButton.TabIndex = 0;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseSelectable = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // messageTextBox
            // 
            // 
            // 
            // 
            this.messageTextBox.CustomButton.Image = null;
            this.messageTextBox.CustomButton.Location = new System.Drawing.Point(369, 1);
            this.messageTextBox.CustomButton.Name = "";
            this.messageTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.messageTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.messageTextBox.CustomButton.TabIndex = 1;
            this.messageTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.messageTextBox.CustomButton.UseSelectable = true;
            this.messageTextBox.CustomButton.Visible = false;
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.messageTextBox.Lines = new string[0];
            this.messageTextBox.Location = new System.Drawing.Point(80, 8);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.messageTextBox.MaxLength = 32767;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.PasswordChar = '\0';
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.messageTextBox.SelectedText = "";
            this.messageTextBox.SelectionLength = 0;
            this.messageTextBox.SelectionStart = 0;
            this.messageTextBox.ShortcutsEnabled = true;
            this.messageTextBox.Size = new System.Drawing.Size(399, 31);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.UseSelectable = true;
            this.messageTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.messageTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.messageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTextBox_KeyDown);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel.Location = new System.Drawing.Point(5, 9);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(5, 9, 0, 9);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(72, 29);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Message :";
            // 
            // formLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.formTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "formLayout";
            this.Size = new System.Drawing.Size(576, 576);
            this.formTableLayoutPanel.ResumeLayout(false);
            this.formLowerSectionTableLayoutPanel.ResumeLayout(false);
            this.formLowerSectionTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formTableLayoutPanel;
        private System.Windows.Forms.RichTextBox conversationTextBox;
        private System.Windows.Forms.TableLayoutPanel formLowerSectionTableLayoutPanel;
        private MetroFramework.Controls.MetroButton sendMessageButton;
        private MetroFramework.Controls.MetroTextBox messageTextBox;
        private MetroFramework.Controls.MetroLabel messageLabel;
    }
}
