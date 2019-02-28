namespace VoxPopuliClient
{
  partial class PopForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopForm));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.urlBar1 = new VoxPopuliClient.src.controls.URLBar();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.CompactModeButton = new System.Windows.Forms.Button();
      this.SettingsButton = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.browserControl1 = new VoxPopuliClient.src.controls.BrowserControl();
      this.chatList1 = new VoxPopuliClient.src.controls.ChatList();
      this.tableLayoutPanel1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1061, 628);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 596);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1061, 32);
      this.statusStrip1.TabIndex = 4;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // StatusLabel
      // 
      this.StatusLabel.Name = "StatusLabel";
      this.StatusLabel.Size = new System.Drawing.Size(125, 27);
      this.StatusLabel.Text = "Welcome to SugarPop";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.AutoSize = true;
      this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel2.Controls.Add(this.urlBar1, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(1055, 68);
      this.tableLayoutPanel2.TabIndex = 5;
      // 
      // urlBar1
      // 
      this.urlBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.urlBar1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.urlBar1.Location = new System.Drawing.Point(3, 3);
      this.urlBar1.Name = "urlBar1";
      this.urlBar1.Size = new System.Drawing.Size(1017, 62);
      this.urlBar1.TabIndex = 3;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Controls.Add(this.CompactModeButton, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.SettingsButton, 0, 1);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(1024, 1);
      this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(30, 66);
      this.tableLayoutPanel3.TabIndex = 6;
      // 
      // CompactModeButton
      // 
      this.CompactModeButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CompactModeButton.FlatAppearance.BorderSize = 0;
      this.CompactModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.CompactModeButton.Image = ((System.Drawing.Image)(resources.GetObject("CompactModeButton.Image")));
      this.CompactModeButton.Location = new System.Drawing.Point(1, 1);
      this.CompactModeButton.Margin = new System.Windows.Forms.Padding(1);
      this.CompactModeButton.Name = "CompactModeButton";
      this.CompactModeButton.Size = new System.Drawing.Size(28, 31);
      this.CompactModeButton.TabIndex = 5;
      this.CompactModeButton.UseVisualStyleBackColor = true;
      this.CompactModeButton.Click += new System.EventHandler(this.CompactModeButton_Click);
      // 
      // SettingsButton
      // 
      this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SettingsButton.FlatAppearance.BorderSize = 0;
      this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
      this.SettingsButton.Location = new System.Drawing.Point(1, 34);
      this.SettingsButton.Margin = new System.Windows.Forms.Padding(1);
      this.SettingsButton.Name = "SettingsButton";
      this.SettingsButton.Size = new System.Drawing.Size(28, 31);
      this.SettingsButton.TabIndex = 4;
      this.SettingsButton.UseVisualStyleBackColor = true;
      this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainer1.Location = new System.Drawing.Point(1, 75);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.browserControl1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
      this.splitContainer1.Panel2.Controls.Add(this.chatList1);
      this.splitContainer1.Size = new System.Drawing.Size(1059, 520);
      this.splitContainer1.SplitterDistance = 700;
      this.splitContainer1.TabIndex = 2;
      // 
      // browserControl1
      // 
      this.browserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.browserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.browserControl1.Location = new System.Drawing.Point(0, 0);
      this.browserControl1.Name = "browserControl1";
      this.browserControl1.Size = new System.Drawing.Size(700, 520);
      this.browserControl1.TabIndex = 1;
      // 
      // chatList1
      // 
      this.chatList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.chatList1.BackColor = System.Drawing.Color.Transparent;
      this.chatList1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.chatList1.Location = new System.Drawing.Point(0, 0);
      this.chatList1.Margin = new System.Windows.Forms.Padding(1);
      this.chatList1.Name = "chatList1";
      this.chatList1.Size = new System.Drawing.Size(355, 520);
      this.chatList1.TabIndex = 0;
      // 
      // PopForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1061, 628);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "PopForm";
      this.Text = "SugarPop - Social Browsing";
      this.Load += new System.EventHandler(this.PopForm_Load);
      this.Shown += new System.EventHandler(this.PopForm_Shown);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private src.controls.URLBar urlBar1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button SettingsButton;    
    private src.controls.BrowserControl browserControl1;
    private System.Windows.Forms.Button CompactModeButton;
    private src.controls.ChatList chatList1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
  }
}

