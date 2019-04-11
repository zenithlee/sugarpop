namespace VoxPopuliClient.src.controls
{
  partial class ChatList
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatList));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.ChatLayout = new System.Windows.Forms.FlowLayoutPanel();
      this.chatControl1 = new VoxPopuliClient.src.controls.ChatControl();
      this.IconList = new System.Windows.Forms.ImageList(this.components);
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.ChatLayout, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.chatControl1, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.16456F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.83544F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 694);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // ChatLayout
      // 
      this.ChatLayout.AutoSize = true;
      this.ChatLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ChatLayout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ChatLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.ChatLayout.Location = new System.Drawing.Point(1, 1);
      this.ChatLayout.Margin = new System.Windows.Forms.Padding(1);
      this.ChatLayout.Name = "ChatLayout";
      this.ChatLayout.Size = new System.Drawing.Size(429, 505);
      this.ChatLayout.TabIndex = 3;
      // 
      // chatControl1
      // 
      this.chatControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.chatControl1.Location = new System.Drawing.Point(1, 508);
      this.chatControl1.Margin = new System.Windows.Forms.Padding(1);
      this.chatControl1.Name = "chatControl1";
      this.chatControl1.Size = new System.Drawing.Size(429, 185);
      this.chatControl1.TabIndex = 2;
      // 
      // IconList
      // 
      this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
      this.IconList.TransparentColor = System.Drawing.Color.Transparent;
      this.IconList.Images.SetKeyName(0, "man24.png");
      // 
      // timer1
      // 
      this.timer1.Interval = 9000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // ChatList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.Controls.Add(this.tableLayoutPanel1);
      this.DoubleBuffered = true;
      this.Name = "ChatList";
      this.Size = new System.Drawing.Size(431, 694);
      this.Load += new System.EventHandler(this.ChatList_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private ChatControl CommentControl;
    private System.Windows.Forms.ImageList IconList;
    private System.Windows.Forms.Timer timer1;
    private ChatControl chatControl1;
    private System.Windows.Forms.FlowLayoutPanel ChatLayout;
  }
}
