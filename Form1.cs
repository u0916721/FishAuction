using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishAuction
{
  public partial class Form1 : Form
  {

    private Controller controller;
    BackgroundWorker bgworker;
    public Form1()
    {
      InitializeComponent();
      controller = new Controller();
    }
    private void findFish()
    {

      controller.findFish(fishToFind.Text);
      var image = Image.FromFile(@"C:\\Users\\krais\\Downloads\\fishImage" + (controller.fishImageNumber - 1) + ".jpg");
      fishPicture.Image = image;
      richTextBox1.Text = controller.info;
      loadingLable.Visible = false;
      loadingBox.Visible = false;

    }
    private void search_Click(object sender, EventArgs e)
    {

      if (!bgworker.IsBusy)
      {
        displayLoad();
        bgworker.RunWorkerAsync();
        // btn_Start.Enabled = false;
      }
      //  findFish();
    }

    private void fishToFind_TextChanged(object sender, EventArgs e)
    {
      
    }

    private void fishPicture_Click(object sender, EventArgs e)
    {
      //fishPicture.Image
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      bgworker = new BackgroundWorker();

      bgworker.DoWork += backgroundWorker_DoWork; ;

      bgworker.RunWorkerCompleted += backgroundWorker_Completed;

      bgworker.ProgressChanged += Bgworker_ProgressChanged;

      bgworker.WorkerReportsProgress = true;

      bgworker.WorkerSupportsCancellation = true;

    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {

    }
    private void displayLoad()
    {
      Random rand = new Random();
      int number = rand.Next(0, 6);
      var image = Image.FromFile(@"C:\\Users\\krais\\Desktop\\WaitingScreens\\screen" + rand.Next(0,6) + ".gif");
      loadingBox.Image = image;
      loadingLable.Visible = true;
      loadingBox.Visible = true;
    }
    private void fishToFind_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        if (!bgworker.IsBusy)
        {
          displayLoad();
          bgworker.RunWorkerAsync();
          // btn_Start.Enabled = false;
        }
      }
    }


    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void Bgworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      
    }

    private void backgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Cancelled)
        label1.Text = @"The user cancelled the operation";
      else
        label1.Text = @"operation done";

      richTextBox1.Text = controller.info;
      loadingLable.Visible = false;
      loadingBox.Visible = false;

    }

    private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      //TODO : Upload video code 

      findFish();
    }

    private void btn_Start_Click(object sender, EventArgs e)
    {
      if (!bgworker.IsBusy)
      {
        bgworker.RunWorkerAsync();
       // btn_Start.Enabled = false;
      }
    }

    private void Stop_Click(object sender, EventArgs e)
    {
      bgworker.CancelAsync();
    }

    private void progressBar1_Click(object sender, EventArgs e)
    {

    }

    private void loadingLable_Click(object sender, EventArgs e)
    {

    }

    private void loadingBox_Click(object sender, EventArgs e)
    {

    }
  }
}
