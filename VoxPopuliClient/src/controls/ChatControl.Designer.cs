namespace VoxPopuliClient.src.controls
{
  partial class ChatControl
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.CommentBox = new System.Windows.Forms.RichTextBox();
      this.CommentButton = new System.Windows.Forms.Button();
      this.SmileButton = new System.Windows.Forms.Button();
      this.UserNameBox = new System.Windows.Forms.TextBox();
      this.TextCounter = new System.Windows.Forms.Label();
      this.GetTrendsButton = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
      this.tableLayoutPanel1.ColumnCount = 6;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
      this.tableLayoutPanel1.Controls.Add(this.CommentBox, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.CommentButton, 5, 1);
      this.tableLayoutPanel1.Controls.Add(this.SmileButton, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.UserNameBox, 4, 1);
      this.tableLayoutPanel1.Controls.Add(this.TextCounter, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.GetTrendsButton, 2, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 219);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // CommentBox
      // 
      this.CommentBox.BackColor = System.Drawing.Color.White;
      this.CommentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tableLayoutPanel1.SetColumnSpan(this.CommentBox, 6);
      this.CommentBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CommentBox.Location = new System.Drawing.Point(3, 3);
      this.CommentBox.MaxLength = 512;
      this.CommentBox.Name = "CommentBox";
      this.CommentBox.Size = new System.Drawing.Size(658, 181);
      this.CommentBox.TabIndex = 0;
      this.CommentBox.Text = "";
      this.CommentBox.TextChanged += new System.EventHandler(this.CommentBox_TextChanged);
      this.CommentBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CommentBox_KeyUp);
      // 
      // CommentButton
      // 
      this.CommentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
      this.CommentButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CommentButton.FlatAppearance.BorderSize = 0;
      this.CommentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.CommentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CommentButton.Location = new System.Drawing.Point(580, 188);
      this.CommentButton.Margin = new System.Windows.Forms.Padding(1);
      this.CommentButton.Name = "CommentButton";
      this.CommentButton.Size = new System.Drawing.Size(83, 30);
      this.CommentButton.TabIndex = 1;
      this.CommentButton.Text = "Comment";
      this.CommentButton.UseVisualStyleBackColor = false;
      this.CommentButton.Click += new System.EventHandler(this.CommentButton_Click);
      // 
      // SmileButton
      // 
      this.SmileButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SmileButton.FlatAppearance.BorderSize = 0;
      this.SmileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.SmileButton.Location = new System.Drawing.Point(416, 188);
      this.SmileButton.Margin = new System.Windows.Forms.Padding(1);
      this.SmileButton.Name = "SmileButton";
      this.SmileButton.Size = new System.Drawing.Size(63, 30);
      this.SmileButton.TabIndex = 2;
      this.SmileButton.Text = "+Lick";
      this.SmileButton.UseVisualStyleBackColor = true;
      this.SmileButton.Click += new System.EventHandler(this.SmileButton_Click);
      // 
      // UserNameBox
      // 
      this.UserNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.UserNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.UserNameBox.Location = new System.Drawing.Point(483, 190);
      this.UserNameBox.MaxLength = 32;
      this.UserNameBox.Name = "UserNameBox";
      this.UserNameBox.Size = new System.Drawing.Size(93, 17);
      this.UserNameBox.TabIndex = 3;
      this.UserNameBox.Text = "Anon";
      // 
      // TextCounter
      // 
      this.TextCounter.AutoSize = true;
      this.TextCounter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TextCounter.Location = new System.Drawing.Point(3, 187);
      this.TextCounter.Name = "TextCounter";
      this.TextCounter.Size = new System.Drawing.Size(34, 32);
      this.TextCounter.TabIndex = 4;
      this.TextCounter.Text = "512";
      this.TextCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // GetTrendsButton
      // 
      this.GetTrendsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
      this.GetTrendsButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.GetTrendsButton.FlatAppearance.BorderSize = 0;
      this.GetTrendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.GetTrendsButton.Location = new System.Drawing.Point(351, 188);
      this.GetTrendsButton.Margin = new System.Windows.Forms.Padding(1);
      this.GetTrendsButton.Name = "GetTrendsButton";
      this.GetTrendsButton.Size = new System.Drawing.Size(63, 30);
      this.GetTrendsButton.TabIndex = 5;
      this.GetTrendsButton.Text = "Trends";
      this.GetTrendsButton.UseVisualStyleBackColor = false;
      this.GetTrendsButton.Click += new System.EventHandler(this.GetTrendsButton_Click);
      // 
      // ChatControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ChatControl";
      this.Size = new System.Drawing.Size(664, 219);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.RichTextBox CommentBox;
    private System.Windows.Forms.Button CommentButton;
    private System.Windows.Forms.Button SmileButton;
    private System.Windows.Forms.TextBox UserNameBox;
    private System.Windows.Forms.Label TextCounter;
    private System.Windows.Forms.Button GetTrendsButton;
  }
}
