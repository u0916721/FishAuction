﻿
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.search = new System.Windows.Forms.Button();
      this.fishToFind = new System.Windows.Forms.TextBox();
      this.fishPicture = new System.Windows.Forms.PictureBox();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.loadingBox = new System.Windows.Forms.PictureBox();
      this.loadingLable = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.fishPicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).BeginInit();
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(236, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "label1";
      // 
      // loadingBox
      // 
      this.loadingBox.Image = ((System.Drawing.Image)(resources.GetObject("loadingBox.Image")));
      this.loadingBox.Location = new System.Drawing.Point(907, 99);
      this.loadingBox.Name = "loadingBox";
      this.loadingBox.Size = new System.Drawing.Size(576, 404);
      this.loadingBox.TabIndex = 6;
      this.loadingBox.TabStop = false;
      this.loadingBox.Visible = false;
      this.loadingBox.Click += new System.EventHandler(this.loadingBox_Click);
      // 
      // loadingLable
      // 
      this.loadingLable.AutoSize = true;
      this.loadingLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.loadingLable.Location = new System.Drawing.Point(901, 61);
      this.loadingLable.Name = "loadingLable";
      this.loadingLable.Size = new System.Drawing.Size(198, 35);
      this.loadingLable.TabIndex = 7;
      this.loadingLable.Text = "LOADING.....";
      this.loadingLable.Visible = false;
      this.loadingLable.Click += new System.EventHandler(this.loadingLable_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1782, 830);
      this.Controls.Add(this.loadingLable);
      this.Controls.Add(this.loadingBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.fishPicture);
      this.Controls.Add(this.fishToFind);
      this.Controls.Add(this.search);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.fishPicture)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button search;
    private System.Windows.Forms.TextBox fishToFind;
    private System.Windows.Forms.PictureBox fishPicture;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox loadingBox;
    private System.Windows.Forms.Label loadingLable;
  }
}

