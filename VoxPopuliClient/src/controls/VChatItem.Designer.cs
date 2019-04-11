namespace VoxPopuliClient.src.controls
{
  partial class VChatItem
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VChatItem));
      this.ChatTextBox = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.UsernameLabel = new System.Windows.Forms.Label();
      this.ChatImage = new System.Windows.Forms.PictureBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ChatImage)).BeginInit();
      this.SuspendLayout();
      // 
      // ChatTextBox
      // 
      this.ChatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ChatTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ChatTextBox.Location = new System.Drawing.Point(150, 0);
      this.ChatTextBox.Margin = new System.Windows.Forms.Padding(0);
      this.ChatTextBox.Multiline = true;
      this.ChatTextBox.Name = "ChatTextBox";
      this.ChatTextBox.Size = new System.Drawing.Size(302, 61);
      this.ChatTextBox.TabIndex = 0;
      this.ChatTextBox.Text = "text";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.ChatTextBox, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 61);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.UsernameLabel, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.ChatImage, 0, 1);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 55);
      this.tableLayoutPanel2.TabIndex = 3;
      // 
      // UsernameLabel
      // 
      this.UsernameLabel.AutoSize = true;
      this.UsernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.UsernameLabel.Image = ((System.Drawing.Image)(resources.GetObject("UsernameLabel.Image")));
      this.UsernameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.UsernameLabel.Location = new System.Drawing.Point(0, 0);
      this.UsernameLabel.Margin = new System.Windows.Forms.Padding(0);
      this.UsernameLabel.Name = "UsernameLabel";
      this.UsernameLabel.Size = new System.Drawing.Size(144, 14);
      this.UsernameLabel.TabIndex = 1;
      this.UsernameLabel.Text = "UserName";
      this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // ChatImage
      // 
      this.ChatImage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ChatImage.Location = new System.Drawing.Point(3, 17);
      this.ChatImage.Name = "ChatImage";
      this.ChatImage.Size = new System.Drawing.Size(138, 35);
      this.ChatImage.TabIndex = 2;
      this.ChatImage.TabStop = false;
      // 
      // VChatItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Controls.Add(this.tableLayoutPanel1);
      this.Margin = new System.Windows.Forms.Padding(1);
      this.Name = "VChatItem";
      this.Size = new System.Drawing.Size(452, 61);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ChatImage)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox ChatTextBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label UsernameLabel;
    private System.Windows.Forms.PictureBox ChatImage;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
  }
}
