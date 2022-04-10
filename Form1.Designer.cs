
namespace FishAuction
{
  partial class Form1
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
      this.search = new System.Windows.Forms.Button();
      this.fishToFind = new System.Windows.Forms.TextBox();
      this.fishPicture = new System.Windows.Forms.PictureBox();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.fishPicture)).BeginInit();
      this.SuspendLayout();
      // 
      // search
      // 
      this.search.Location = new System.Drawing.Point(141, 12);
      this.search.Name = "search";
      this.search.Size = new System.Drawing.Size(75, 23);
      this.search.TabIndex = 0;
      this.search.Text = "Find Fish";
      this.search.UseVisualStyleBackColor = true;
      this.search.Click += new System.EventHandler(this.search_Click);
      // 
      // fishToFind
      // 
      this.fishToFind.Location = new System.Drawing.Point(12, 12);
      this.fishToFind.Name = "fishToFind";
      this.fishToFind.Size = new System.Drawing.Size(100, 20);
      this.fishToFind.TabIndex = 1;
      this.fishToFind.TextChanged += new System.EventHandler(this.fishToFind_TextChanged);
      this.fishToFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fishToFind_KeyDown);
      // 
      // fishPicture
      // 
      this.fishPicture.Location = new System.Drawing.Point(877, 12);
      this.fishPicture.Name = "fishPicture";
      this.fishPicture.Size = new System.Drawing.Size(877, 790);
      this.fishPicture.TabIndex = 2;
      this.fishPicture.TabStop = false;
      this.fishPicture.Click += new System.EventHandler(this.fishPicture_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.richTextBox1.Location = new System.Drawing.Point(12, 56);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(813, 762);
      this.richTextBox1.TabIndex = 3;
      this.richTextBox1.Text = "";
      this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1782, 830);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.fishPicture);
      this.Controls.Add(this.fishToFind);
      this.Controls.Add(this.search);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.fishPicture)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button search;
    private System.Windows.Forms.TextBox fishToFind;
    private System.Windows.Forms.PictureBox fishPicture;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}

