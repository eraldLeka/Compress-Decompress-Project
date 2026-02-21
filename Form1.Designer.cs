namespace Erald_Leka_Lab6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelAccentLine;
        private System.Windows.Forms.Panel panelSeparator;

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblThreadLabel;
        private System.Windows.Forms.Label lblTopBarTitle;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Label lblStatusDot;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmptyIcon;
        private System.Windows.Forms.Label lblEmptyHint;
        private System.Windows.Forms.Label lblFooterInfo;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton singleThread;
        private System.Windows.Forms.RadioButton multiThread;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.Button decompressButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            panelAccentLine = new Panel();
            lblAppName = new Label();
            lblVersion = new Label();
            lblThreadLabel = new Label();
            singleThread = new RadioButton();
            multiThread = new RadioButton();
            lblStatusDot = new Label();
            lblStatus = new Label();
            panelMain = new Panel();
            panelTopBar = new Panel();
            lblTopBarTitle = new Label();
            lblFileCount = new Label();
            lblEmptyIcon = new Label();
            lblEmptyHint = new Label();
            listBox1 = new ListBox();
            panelBottom = new Panel();
            panelSeparator = new Panel();
            compressButton = new Button();
            decompressButton = new Button();
            browse = new Button();
            lblFooterInfo = new Label();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            panelTopBar.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(13, 13, 22);
            panelSidebar.Controls.Add(panelAccentLine);
            panelSidebar.Controls.Add(lblAppName);
            panelSidebar.Controls.Add(lblVersion);
            panelSidebar.Controls.Add(lblThreadLabel);
            panelSidebar.Controls.Add(singleThread);
            panelSidebar.Controls.Add(multiThread);
            panelSidebar.Controls.Add(lblStatusDot);
            panelSidebar.Controls.Add(lblStatus);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(215, 640);
            panelSidebar.TabIndex = 0;
            // 
            // panelAccentLine
            // 
            panelAccentLine.BackColor = Color.FromArgb(0, 200, 130);
            panelAccentLine.Location = new Point(0, 0);
            panelAccentLine.Name = "panelAccentLine";
            panelAccentLine.Size = new Size(3, 640);
            panelAccentLine.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(22, 38);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(180, 74);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "COMPRESS\r\nSTUDIO";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 8F);
            lblVersion.ForeColor = Color.FromArgb(80, 80, 110);
            lblVersion.Location = new Point(22, 114);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(79, 21);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "erald-leka";
            // 
            // lblThreadLabel
            // 
            lblThreadLabel.AutoSize = true;
            lblThreadLabel.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblThreadLabel.ForeColor = Color.FromArgb(75, 75, 105);
            lblThreadLabel.Location = new Point(22, 185);
            lblThreadLabel.Name = "lblThreadLabel";
            lblThreadLabel.Size = new Size(145, 20);
            lblThreadLabel.TabIndex = 3;
            lblThreadLabel.Text = "THREADING MODE";
            // 
            // singleThread
            // 
            singleThread.Appearance = Appearance.Button;
            singleThread.BackColor = Color.Transparent;
            singleThread.Checked = true;
            singleThread.FlatAppearance.BorderColor = Color.FromArgb(35, 35, 55);
            singleThread.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 50, 35);
            singleThread.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 22, 38);
            singleThread.FlatStyle = FlatStyle.Flat;
            singleThread.Font = new Font("Segoe UI", 9.5F);
            singleThread.ForeColor = Color.FromArgb(190, 190, 215);
            singleThread.Location = new Point(18, 212);
            singleThread.Name = "singleThread";
            singleThread.Size = new Size(176, 40);
            singleThread.TabIndex = 0;
            singleThread.TabStop = true;
            singleThread.Text = "   Single Thread";
            singleThread.UseVisualStyleBackColor = false;
            singleThread.CheckedChanged += singleThread_CheckedChanged;
            // 
            // multiThread
            // 
            multiThread.Appearance = Appearance.Button;
            multiThread.BackColor = Color.Transparent;
            multiThread.FlatAppearance.BorderColor = Color.FromArgb(35, 35, 55);
            multiThread.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 30, 70);
            multiThread.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 22, 38);
            multiThread.FlatStyle = FlatStyle.Flat;
            multiThread.Font = new Font("Segoe UI", 9.5F);
            multiThread.ForeColor = Color.FromArgb(190, 190, 215);
            multiThread.Location = new Point(18, 260);
            multiThread.Name = "multiThread";
            multiThread.Size = new Size(176, 40);
            multiThread.TabIndex = 1;
            multiThread.TabStop = true;
            multiThread.Text = "   Multi Thread";
            multiThread.UseVisualStyleBackColor = false;
            multiThread.CheckedChanged += multiThread_CheckedChanged;
            // 
            // lblStatusDot
            // 
            lblStatusDot.AutoSize = true;
            lblStatusDot.Font = new Font("Segoe UI", 8F);
            lblStatusDot.ForeColor = Color.FromArgb(0, 200, 130);
            lblStatusDot.Location = new Point(22, 606);
            lblStatusDot.Name = "lblStatusDot";
            lblStatusDot.Size = new Size(20, 21);
            lblStatusDot.TabIndex = 4;
            lblStatusDot.Text = "●";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 8F);
            lblStatus.ForeColor = Color.FromArgb(0, 200, 130);
            lblStatus.Location = new Point(38, 606);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 21);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Ready";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(10, 10, 18);
            panelMain.Controls.Add(panelTopBar);
            panelMain.Controls.Add(lblEmptyIcon);
            panelMain.Controls.Add(lblEmptyHint);
            panelMain.Controls.Add(listBox1);
            panelMain.Controls.Add(panelBottom);
            panelMain.Location = new Point(215, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(765, 640);
            panelMain.TabIndex = 1;
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(15, 15, 26);
            panelTopBar.Controls.Add(lblTopBarTitle);
            panelTopBar.Controls.Add(lblFileCount);
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(765, 50);
            panelTopBar.TabIndex = 0;
            // 
            // lblTopBarTitle
            // 
            lblTopBarTitle.AutoSize = true;
            lblTopBarTitle.Font = new Font("Segoe UI Semibold", 11F);
            lblTopBarTitle.ForeColor = Color.White;
            lblTopBarTitle.Location = new Point(20, 14);
            lblTopBarTitle.Name = "lblTopBarTitle";
            lblTopBarTitle.Size = new Size(142, 30);
            lblTopBarTitle.TabIndex = 0;
            lblTopBarTitle.Text = "File Manager";
            // 
            // lblFileCount
            // 
            lblFileCount.AutoSize = true;
            lblFileCount.Font = new Font("Segoe UI", 8F);
            lblFileCount.ForeColor = Color.FromArgb(75, 75, 105);
            lblFileCount.Location = new Point(660, 18);
            lblFileCount.Name = "lblFileCount";
            lblFileCount.Size = new Size(51, 21);
            lblFileCount.TabIndex = 1;
            lblFileCount.Text = "0 files";
            // 
            // lblEmptyIcon
            // 
            lblEmptyIcon.AutoSize = true;
            lblEmptyIcon.Font = new Font("Segoe UI", 30F);
            lblEmptyIcon.ForeColor = Color.FromArgb(35, 35, 58);
            lblEmptyIcon.Location = new Point(316, 114);
            lblEmptyIcon.Name = "lblEmptyIcon";
            lblEmptyIcon.Size = new Size(117, 81);
            lblEmptyIcon.TabIndex = 1;
            lblEmptyIcon.Text = "📂";
            // 
            // lblEmptyHint
            // 
            lblEmptyHint.AutoSize = true;
            lblEmptyHint.Font = new Font("Segoe UI", 9.5F);
            lblEmptyHint.ForeColor = Color.FromArgb(50, 50, 78);
            lblEmptyHint.Location = new Point(272, 218);
            lblEmptyHint.Name = "lblEmptyHint";
            lblEmptyHint.Size = new Size(229, 25);
            lblEmptyHint.TabIndex = 2;
            lblEmptyHint.Text = "Browse files to get started";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(14, 14, 24);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.Font = new Font("Consolas", 9.5F);
            listBox1.ForeColor = Color.FromArgb(210, 210, 235);
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(0, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(765, 392);
            listBox1.TabIndex = 2;
            listBox1.DrawItem += listBox1_DrawItem;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(13, 13, 22);
            panelBottom.Controls.Add(panelSeparator);
            panelBottom.Controls.Add(compressButton);
            panelBottom.Controls.Add(decompressButton);
            panelBottom.Controls.Add(browse);
            panelBottom.Controls.Add(lblFooterInfo);
            panelBottom.Location = new Point(0, 458);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(765, 182);
            panelBottom.TabIndex = 3;
            // 
            // panelSeparator
            // 
            panelSeparator.BackColor = Color.FromArgb(26, 26, 44);
            panelSeparator.Location = new Point(0, 0);
            panelSeparator.Name = "panelSeparator";
            panelSeparator.Size = new Size(765, 1);
            panelSeparator.TabIndex = 0;
            // 
            // compressButton
            // 
            compressButton.BackColor = Color.FromArgb(0, 200, 130);
            compressButton.Cursor = Cursors.Hand;
            compressButton.FlatAppearance.BorderSize = 0;
            compressButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 170, 110);
            compressButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 225, 150);
            compressButton.FlatStyle = FlatStyle.Flat;
            compressButton.Font = new Font("Segoe UI Semibold", 10F);
            compressButton.ForeColor = Color.FromArgb(8, 8, 16);
            compressButton.Location = new Point(24, 30);
            compressButton.Name = "compressButton";
            compressButton.Size = new Size(188, 48);
            compressButton.TabIndex = 4;
            compressButton.Text = "⬇   Compress";
            compressButton.UseVisualStyleBackColor = false;
            compressButton.Click += compressButton_Click;
            // 
            // decompressButton
            // 
            decompressButton.BackColor = Color.FromArgb(41, 121, 255);
            decompressButton.Cursor = Cursors.Hand;
            decompressButton.FlatAppearance.BorderSize = 0;
            decompressButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 95, 210);
            decompressButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 145, 255);
            decompressButton.FlatStyle = FlatStyle.Flat;
            decompressButton.Font = new Font("Segoe UI Semibold", 10F);
            decompressButton.ForeColor = Color.White;
            decompressButton.Location = new Point(228, 30);
            decompressButton.Name = "decompressButton";
            decompressButton.Size = new Size(188, 48);
            decompressButton.TabIndex = 5;
            decompressButton.Text = "⬆   Decompress";
            decompressButton.UseVisualStyleBackColor = false;
            decompressButton.Click += decompressButton_Click;
            // 
            // browse
            // 
            browse.BackColor = Color.FromArgb(18, 18, 32);
            browse.Cursor = Cursors.Hand;
            browse.FlatAppearance.BorderColor = Color.FromArgb(0, 80, 55);
            browse.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 20, 14);
            browse.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 30, 22);
            browse.FlatStyle = FlatStyle.Flat;
            browse.Font = new Font("Segoe UI Semibold", 10F);
            browse.ForeColor = Color.FromArgb(0, 200, 130);
            browse.Location = new Point(492, 30);
            browse.Name = "browse";
            browse.Size = new Size(236, 48);
            browse.TabIndex = 0;
            browse.Text = "＋   Browse Files";
            browse.UseVisualStyleBackColor = false;
            browse.Click += browse_Click;
            // 
            // lblFooterInfo
            // 
            lblFooterInfo.AutoSize = true;
            lblFooterInfo.Font = new Font("Segoe UI", 7.5F);
            lblFooterInfo.ForeColor = Color.FromArgb(55, 55, 82);
            lblFooterInfo.Location = new Point(24, 98);
            lblFooterInfo.Name = "lblFooterInfo";
            lblFooterInfo.Size = new Size(378, 20);
            lblFooterInfo.TabIndex = 6;
            lblFooterInfo.Text = "Supported format: .gz   ·   Select threading from sidebar";
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(10, 10, 18);
            ClientSize = new Size(980, 640);
            Controls.Add(panelSidebar);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1002, 696);
            MinimumSize = new Size(1002, 696);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compress Studio";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        // Rounded corners helper for button Region
        private System.Drawing.Drawing2D.GraphicsPath RoundedRect(
            System.Drawing.Rectangle rc, int r)
        {
            var p = new System.Drawing.Drawing2D.GraphicsPath();
            p.AddArc(rc.X, rc.Y, r * 2, r * 2, 180, 90);
            p.AddArc(rc.Right - r * 2, rc.Y, r * 2, r * 2, 270, 90);
            p.AddArc(rc.Right - r * 2, rc.Bottom - r * 2, r * 2, r * 2, 0, 90);
            p.AddArc(rc.X, rc.Bottom - r * 2, r * 2, r * 2, 90, 90);
            p.CloseFigure();
            return p;
        }

        // Owner-draw ListBox: alternating dark rows + accent dot
        private void listBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            var lb = (System.Windows.Forms.ListBox)sender;
            string text = lb.Items[e.Index].ToString();
            bool sel = (e.State & System.Windows.Forms.DrawItemState.Selected) != 0;

            var bgColor = sel
                ? System.Drawing.Color.FromArgb(0, 55, 38)
                : (e.Index % 2 == 0
                    ? System.Drawing.Color.FromArgb(14, 14, 24)
                    : System.Drawing.Color.FromArgb(17, 17, 29));

            using (var b = new System.Drawing.SolidBrush(bgColor))
                e.Graphics.FillRectangle(b, e.Bounds);

            var dotColor = sel
                ? System.Drawing.Color.FromArgb(0, 200, 130)
                : System.Drawing.Color.FromArgb(38, 38, 62);
            using (var b = new System.Drawing.SolidBrush(dotColor))
                e.Graphics.FillEllipse(b,
                    e.Bounds.X + 10, e.Bounds.Y + 10, 8, 8);

            var fg = sel
                ? System.Drawing.Color.White
                : System.Drawing.Color.FromArgb(185, 185, 215);
            using (var b = new System.Drawing.SolidBrush(fg))
                e.Graphics.DrawString(text, e.Font, b,
                    new System.Drawing.RectangleF(
                        e.Bounds.X + 26, e.Bounds.Y + 5,
                        e.Bounds.Width - 30, e.Bounds.Height));
        }
    }
}