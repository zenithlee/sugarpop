namespace VoxPopuliClient.src.controls
{
  partial class VoteControl
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoteControl));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.DownVote = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.UpVote = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.DownVote, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.UpVote, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(113, 33);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // DownVote
      // 
      this.DownVote.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DownVote.FlatAppearance.BorderSize = 0;
      this.DownVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.DownVote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.DownVote.ImageIndex = 1;
      this.DownVote.ImageList = this.imageList1;
      this.DownVote.Location = new System.Drawing.Point(57, 1);
      this.DownVote.Margin = new System.Windows.Forms.Padding(1);
      this.DownVote.Name = "DownVote";
      this.DownVote.Size = new System.Drawing.Size(55, 31);
      this.DownVote.TabIndex = 8;
      this.DownVote.Text = "0";
      this.DownVote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.DownVote.UseVisualStyleBackColor = true;
      this.DownVote.Click += new System.EventHandler(this.DownVote_Click);
      this.DownVote.MouseEnter += new System.EventHandler(this.DownVote_MouseEnter);
      this.DownVote.MouseLeave += new System.EventHandler(this.DownVote_MouseLeave);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "votedown.png");
      this.imageList1.Images.SetKeyName(1, "votedown_grey.png");
      this.imageList1.Images.SetKeyName(2, "voteup.png");
      this.imageList1.Images.SetKeyName(3, "voteup_grey.png");
      // 
      // UpVote
      // 
      this.UpVote.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UpVote.FlatAppearance.BorderSize = 0;
      this.UpVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.UpVote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.UpVote.ImageIndex = 3;
      this.UpVote.ImageList = this.imageList1;
      this.UpVote.Location = new System.Drawing.Point(1, 1);
      this.UpVote.Margin = new System.Windows.Forms.Padding(1);
      this.UpVote.Name = "UpVote";
      this.UpVote.Size = new System.Drawing.Size(54, 31);
      this.UpVote.TabIndex = 7;
      this.UpVote.Text = "0";
      this.UpVote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.UpVote.UseVisualStyleBackColor = true;
      this.UpVote.Click += new System.EventHandler(this.UpVote_Click);
      this.UpVote.MouseEnter += new System.EventHandler(this.UpVote_MouseEnter);
      this.UpVote.MouseLeave += new System.EventHandler(this.UpVote_MouseLeave);
      // 
      // VoteControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "VoteControl";
      this.Size = new System.Drawing.Size(113, 33);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button UpVote;
    private System.Windows.Forms.Button DownVote;
    private System.Windows.Forms.ImageList imageList1;
  }
}
