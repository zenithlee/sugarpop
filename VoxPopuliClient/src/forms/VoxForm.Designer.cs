namespace VoxPopuliClient.forms
{
  partial class MacMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacMain));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.CompactButton = new System.Windows.Forms.Button();
      this.SettingsButton = new System.Windows.Forms.Button();
      this.StatusLabel = new System.Windows.Forms.Label();
      this.trendsControl1 = new VoxPopuliClient.src.controls.TrendsControl();
      this.chatList1 = new VoxPopuliClient.src.controls.ChatList();
      this.urlBar1 = new VoxPopuliClient.src.controls.URLBar();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.StatusLabel, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 706);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.trendsControl1, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.chatList1, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 108);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(387, 563);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
      this.tableLayoutPanel3.Controls.Add(this.urlBar1, 0, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(387, 99);
      this.tableLayoutPanel3.TabIndex = 1;
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 1;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Controls.Add(this.CompactButton, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.SettingsButton, 0, 1);
      this.tableLayoutPanel4.Location = new System.Drawing.Point(358, 3);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 2;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(26, 73);
      this.tableLayoutPanel4.TabIndex = 1;
      // 
      // CompactButton
      // 
      this.CompactButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CompactButton.FlatAppearance.BorderSize = 0;
      this.CompactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.CompactButton.Image = ((System.Drawing.Image)(resources.GetObject("CompactButton.Image")));
      this.CompactButton.Location = new System.Drawing.Point(0, 0);
      this.CompactButton.Margin = new System.Windows.Forms.Padding(0);
      this.CompactButton.Name = "CompactButton";
      this.CompactButton.Size = new System.Drawing.Size(26, 36);
      this.CompactButton.TabIndex = 0;
      this.CompactButton.UseVisualStyleBackColor = true;
      this.CompactButton.Click += new System.EventHandler(this.CompactButton_Click);
      // 
      // SettingsButton
      // 
      this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SettingsButton.FlatAppearance.BorderSize = 0;
      this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
      this.SettingsButton.Location = new System.Drawing.Point(0, 36);
      this.SettingsButton.Margin = new System.Windows.Forms.Padding(0);
      this.SettingsButton.Name = "SettingsButton";
      this.SettingsButton.Size = new System.Drawing.Size(26, 37);
      this.SettingsButton.TabIndex = 1;
      this.SettingsButton.UseVisualStyleBackColor = true;
      this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
      // 
      // StatusLabel
      // 
      this.StatusLabel.AutoSize = true;
      this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.StatusLabel.Location = new System.Drawing.Point(0, 674);
      this.StatusLabel.Margin = new System.Windows.Forms.Padding(0);
      this.StatusLabel.Name = "StatusLabel";
      this.StatusLabel.Size = new System.Drawing.Size(393, 32);
      this.StatusLabel.TabIndex = 2;
      this.StatusLabel.Text = "Welcome to Vox";
      this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // trendsControl1
      // 
      this.trendsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trendsControl1.Location = new System.Drawing.Point(403, 3);
      this.trendsControl1.Name = "trendsControl1";
      this.trendsControl1.Size = new System.Drawing.Size(1, 557);
      this.trendsControl1.TabIndex = 0;
      // 
      // chatList1
      // 
      this.chatList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.chatList1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.chatList1.Location = new System.Drawing.Point(3, 3);
      this.chatList1.Name = "chatList1";
      this.chatList1.Size = new System.Drawing.Size(394, 557);
      this.chatList1.TabIndex = 1;
      // 
      // urlBar1
      // 
      this.urlBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.urlBar1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.urlBar1.Location = new System.Drawing.Point(3, 3);
      this.urlBar1.Name = "urlBar1";
      this.urlBar1.Size = new System.Drawing.Size(349, 93);
      this.urlBar1.TabIndex = 2;
      // 
      // MacMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(393, 706);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MacMain";
      this.Text = "Vox - bigfun.co.za";
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.MacMain_Shown);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private src.controls.ChatList chatList1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private src.controls.URLBar urlBar1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Button CompactButton;
    private System.Windows.Forms.Button SettingsButton;
    private System.Windows.Forms.Label StatusLabel;
    private src.controls.TrendsControl trendsControl1;    
    
  }
}