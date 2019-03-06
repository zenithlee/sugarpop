namespace VoxPopuliClient.src.controls
{
  partial class URLBar
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URLBar));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.GoButton = new System.Windows.Forms.Button();
      this.URLBox = new System.Windows.Forms.TextBox();
      this.FavoriteButton = new System.Windows.Forms.Button();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.BackButton = new System.Windows.Forms.Button();
      this.FwdButton = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.voteControl1 = new VoxPopuliClient.src.controls.VoteControl();
      this.tableLayoutPanel1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
      this.tableLayoutPanel1.ColumnCount = 6;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
      this.tableLayoutPanel1.Controls.Add(this.GoButton, 5, 0);
      this.tableLayoutPanel1.Controls.Add(this.URLBox, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.FavoriteButton, 4, 0);
      this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.BackButton, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.FwdButton, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.voteControl1, 3, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 64);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // GoButton
      // 
      this.GoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.GoButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.GoButton.FlatAppearance.BorderSize = 0;
      this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.GoButton.Location = new System.Drawing.Point(546, 1);
      this.GoButton.Margin = new System.Windows.Forms.Padding(1);
      this.GoButton.Name = "GoButton";
      this.GoButton.Size = new System.Drawing.Size(53, 32);
      this.GoButton.TabIndex = 0;
      this.GoButton.Text = "Go";
      this.GoButton.UseVisualStyleBackColor = false;
      this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
      // 
      // URLBox
      // 
      this.URLBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.URLBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.URLBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.URLBox.Location = new System.Drawing.Point(67, 3);
      this.URLBox.Name = "URLBox";
      this.URLBox.Size = new System.Drawing.Size(320, 20);
      this.URLBox.TabIndex = 1;
      this.URLBox.Text = "http://bigfun.co.za/pop/";
      this.URLBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.URLBox_KeyUp);
      // 
      // FavoriteButton
      // 
      this.FavoriteButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FavoriteButton.FlatAppearance.BorderSize = 0;
      this.FavoriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.FavoriteButton.Image = ((System.Drawing.Image)(resources.GetObject("FavoriteButton.Image")));
      this.FavoriteButton.Location = new System.Drawing.Point(513, 3);
      this.FavoriteButton.Name = "FavoriteButton";
      this.FavoriteButton.Size = new System.Drawing.Size(29, 28);
      this.FavoriteButton.TabIndex = 2;
      this.toolTip1.SetToolTip(this.FavoriteButton, "Add to Favotites");
      this.FavoriteButton.UseVisualStyleBackColor = true;
      this.FavoriteButton.Click += new System.EventHandler(this.FavoriteButton_Click);
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.AutoSize = true;
      this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
      this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 6);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 35);
      this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(598, 28);
      this.flowLayoutPanel1.TabIndex = 3;
      // 
      // BackButton
      // 
      this.BackButton.BackColor = System.Drawing.Color.Transparent;
      this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BackButton.FlatAppearance.BorderSize = 0;
      this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
      this.BackButton.Location = new System.Drawing.Point(1, 1);
      this.BackButton.Margin = new System.Windows.Forms.Padding(1);
      this.BackButton.Name = "BackButton";
      this.BackButton.Size = new System.Drawing.Size(30, 32);
      this.BackButton.TabIndex = 4;
      this.BackButton.UseVisualStyleBackColor = false;
      this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
      // 
      // FwdButton
      // 
      this.FwdButton.BackColor = System.Drawing.Color.Transparent;
      this.FwdButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FwdButton.FlatAppearance.BorderSize = 0;
      this.FwdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.FwdButton.Image = ((System.Drawing.Image)(resources.GetObject("FwdButton.Image")));
      this.FwdButton.Location = new System.Drawing.Point(33, 1);
      this.FwdButton.Margin = new System.Windows.Forms.Padding(1);
      this.FwdButton.Name = "FwdButton";
      this.FwdButton.Size = new System.Drawing.Size(30, 32);
      this.FwdButton.TabIndex = 5;
      this.FwdButton.UseVisualStyleBackColor = false;
      this.FwdButton.Click += new System.EventHandler(this.FwdButton_Click);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "fave_24.png");
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
      this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
      // 
      // renameToolStripMenuItem
      // 
      this.renameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
      this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
      this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.renameToolStripMenuItem.Text = "Rename";
      // 
      // toolStripTextBox1
      // 
      this.toolStripTextBox1.Name = "toolStripTextBox1";
      this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
      this.toolStripTextBox1.Text = "xx";
      this.toolStripTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyUp);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.deleteToolStripMenuItem.Text = "Delete";
      this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
      // 
      // voteControl1
      // 
      this.voteControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.voteControl1.Location = new System.Drawing.Point(393, 3);
      this.voteControl1.Name = "voteControl1";
      this.voteControl1.Size = new System.Drawing.Size(114, 28);
      this.voteControl1.TabIndex = 6;
      // 
      // URLBar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "URLBar";
      this.Size = new System.Drawing.Size(600, 64);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button GoButton;
    private System.Windows.Forms.TextBox URLBox;
    private System.Windows.Forms.Button FavoriteButton;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.Button BackButton;
    private System.Windows.Forms.Button FwdButton;
    private VoteControl voteControl1;
  }
}
