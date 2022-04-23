
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.distBox = new System.Windows.Forms.RichTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.habitatBox = new System.Windows.Forms.RichTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.maxLengthBox = new System.Windows.Forms.RichTextBox();
      this.la = new System.Windows.Forms.Label();
      this.maintBox = new System.Windows.Forms.RichTextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.tempBox = new System.Windows.Forms.RichTextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.dietBox = new System.Windows.Forms.RichTextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.behaveBox = new System.Windows.Forms.RichTextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.sexBox = new System.Windows.Forms.RichTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.repoBox = new System.Windows.Forms.RichTextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.factBox = new System.Windows.Forms.RichTextBox();
      this.loadingBox = new System.Windows.Forms.PictureBox();
      this.loadingLable = new System.Windows.Forms.Label();
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(236, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "label1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(8, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(114, 24);
      this.label2.TabIndex = 8;
      this.label2.Text = "Distribution\r\n";
      // 
      // distBox
      // 
      this.distBox.BackColor = System.Drawing.SystemColors.MenuText;
      this.distBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.distBox.ForeColor = System.Drawing.SystemColors.Menu;
      this.distBox.Location = new System.Drawing.Point(12, 62);
      this.distBox.Name = "distBox";
      this.distBox.Size = new System.Drawing.Size(953, 47);
      this.distBox.TabIndex = 9;
      this.distBox.Text = "test";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(8, 112);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(74, 24);
      this.label4.TabIndex = 11;
      this.label4.Text = "Habitat";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // habitatBox
      // 
      this.habitatBox.BackColor = System.Drawing.SystemColors.MenuText;
      this.habitatBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.habitatBox.ForeColor = System.Drawing.SystemColors.Menu;
      this.habitatBox.Location = new System.Drawing.Point(12, 139);
      this.habitatBox.Name = "habitatBox";
      this.habitatBox.Size = new System.Drawing.Size(953, 76);
      this.habitatBox.TabIndex = 12;
      this.habitatBox.Text = "I jump so high";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(8, 218);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(259, 24);
      this.label3.TabIndex = 13;
      this.label3.Text = "Maximum Standard Length";
      // 
      // maxLengthBox
      // 
      this.maxLengthBox.BackColor = System.Drawing.SystemColors.MenuText;
      this.maxLengthBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.maxLengthBox.ForeColor = System.Drawing.SystemColors.Menu;
      this.maxLengthBox.Location = new System.Drawing.Point(12, 245);
      this.maxLengthBox.Name = "maxLengthBox";
      this.maxLengthBox.Size = new System.Drawing.Size(953, 33);
      this.maxLengthBox.TabIndex = 14;
      this.maxLengthBox.Text = "test";
      // 
      // la
      // 
      this.la.AutoSize = true;
      this.la.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.la.Location = new System.Drawing.Point(8, 281);
      this.la.Name = "la";
      this.la.Size = new System.Drawing.Size(130, 24);
      this.la.TabIndex = 17;
      this.la.Text = "Maintenance";
      // 
      // maintBox
      // 
      this.maintBox.BackColor = System.Drawing.SystemColors.MenuText;
      this.maintBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.maintBox.ForeColor = System.Drawing.SystemColors.Menu;
      this.maintBox.Location = new System.Drawing.Point(12, 308);
      this.maintBox.Name = "maintBox";
      this.maintBox.Size = new System.Drawing.Size(953, 73);
      this.maintBox.TabIndex = 18;
      this.maintBox.Text = "test";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(8, 384);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(130, 24);
      this.label6.TabIndex = 19;
      this.label6.Text = "Temperature";
      // 
      // tempBox
      // 
      this.tempBox.BackColor = System.Drawing.SystemColors.MenuText;
      this.tempBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tempBox.ForeColor = System.Drawing.SystemColors.Menu;
      this.tempBox.Location = new System.Drawing.Point(12, 411);
      this.tempBox.Name = "tempBox";
      this.tempBox.Size = new System.Drawing.Size(953, 30);
      this.tempBox.TabIndex = 20;
      this.tempBox.Text = "test";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(8, 444);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(46, 24);
      this.label7.TabIndex = 21;
      this.label7.Text = "Diet";
      // 
      // dietBox
      // 
      this.dietBox.BackColor = System.Drawing.SystemColors.MenuText;
      this.dietBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dietBox.ForeColor = System.Drawing.SystemColors.Menu;
      this.dietBox.Location = new System.Drawing.Point(12, 471);
      this.dietBox.Name = "dietBox";
      this.dietBox.Size = new System.Drawing.Size(953, 60);
      this.dietBox.TabIndex = 22;
      this.dietBox.Text = "test";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(12, 534);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(269, 24);
      this.label8.TabIndex = 23;
      this.label8.Text = "Behaviour and Compatibility";
      // 
      // behaveBox
      // 
      this.behaveBox.BackColor = System.Drawing.SystemColors.MenuText;
      this.behaveBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.behaveBox.ForeColor = System.Drawing.SystemColors.Menu;
      this.behaveBox.Location = new System.Drawing.Point(12, 561);
      this.behaveBox.Name = "behaveBox";
      this.behaveBox.Size = new System.Drawing.Size(953, 114);
      this.behaveBox.TabIndex = 24;
      this.behaveBox.Text = "test";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(8, 678);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(191, 24);
      this.label9.TabIndex = 25;
      this.label9.Text = "Sexual Dimorphism";
      // 
      // sexBox
      // 
      this.sexBox.BackColor = System.Drawing.SystemColors.MenuText;
      this.sexBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sexBox.ForeColor = System.Drawing.SystemColors.Menu;
      this.sexBox.Location = new System.Drawing.Point(12, 705);
      this.sexBox.Name = "sexBox";
      this.sexBox.Size = new System.Drawing.Size(953, 69);
      this.sexBox.TabIndex = 26;
      this.sexBox.Text = "test";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(8, 777);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(136, 24);
      this.label5.TabIndex = 27;
      this.label5.Text = "Reproduction";
      // 
      // repoBox
      // 
      this.repoBox.BackColor = System.Drawing.SystemColors.MenuText;
      this.repoBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.repoBox.ForeColor = System.Drawing.SystemColors.Menu;
      this.repoBox.Location = new System.Drawing.Point(12, 804);
      this.repoBox.Name = "repoBox";
      this.repoBox.Size = new System.Drawing.Size(953, 69);
      this.repoBox.TabIndex = 28;
      this.repoBox.Text = "test";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(8, 876);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(103, 24);
      this.label10.TabIndex = 29;
      this.label10.Text = "Fun Facts";
      this.label10.Click += new System.EventHandler(this.label10_Click);
      // 
      // factBox
      // 
      this.factBox.BackColor = System.Drawing.SystemColors.MenuText;
      this.factBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.factBox.ForeColor = System.Drawing.SystemColors.Menu;
      this.factBox.Location = new System.Drawing.Point(12, 903);
      this.factBox.Name = "factBox";
      this.factBox.Size = new System.Drawing.Size(963, 75);
      this.factBox.TabIndex = 30;
      this.factBox.Text = "test";
      // 
      // loadingBox
      // 
      this.loadingBox.Location = new System.Drawing.Point(12, 112);
      this.loadingBox.Name = "loadingBox";
      this.loadingBox.Size = new System.Drawing.Size(749, 433);
      this.loadingBox.TabIndex = 31;
      this.loadingBox.TabStop = false;
      this.loadingBox.Visible = false;
      // 
      // loadingLable
      // 
      this.loadingLable.AutoSize = true;
      this.loadingLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.loadingLable.Location = new System.Drawing.Point(12, 62);
      this.loadingLable.Name = "loadingLable";
      this.loadingLable.Size = new System.Drawing.Size(300, 37);
      this.loadingLable.TabIndex = 32;
      this.loadingLable.Text = "Loading Fish Info....";
      this.loadingLable.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlLight;
      this.BackgroundImage = global::FishAuction.Properties.Resources.amazon_river_tilt_shift_wallpaper_2400x1350;
      this.ClientSize = new System.Drawing.Size(1782, 1040);
      this.Controls.Add(this.loadingLable);
      this.Controls.Add(this.loadingBox);
      this.Controls.Add(this.factBox);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.repoBox);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.sexBox);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.behaveBox);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.dietBox);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.tempBox);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.maintBox);
      this.Controls.Add(this.la);
      this.Controls.Add(this.maxLengthBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.habitatBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.distBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.fishToFind);
      this.Controls.Add(this.search);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "GSLAS Auction Betta Version";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button search;
    private System.Windows.Forms.TextBox fishToFind;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RichTextBox distBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RichTextBox habitatBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RichTextBox maxLengthBox;
    private System.Windows.Forms.Label la;
    private System.Windows.Forms.RichTextBox maintBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.RichTextBox tempBox;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.RichTextBox dietBox;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.RichTextBox behaveBox;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.RichTextBox sexBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.RichTextBox repoBox;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.RichTextBox factBox;
    private System.Windows.Forms.PictureBox loadingBox;
    private System.Windows.Forms.Label loadingLable;
  }
}

