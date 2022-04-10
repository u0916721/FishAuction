using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishAuction
{
  public partial class Form1 : Form
  {

    private Controller controller;
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

    }
    private void search_Click(object sender, EventArgs e)
    {
      findFish();
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


    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        MessageBox.Show("Enter key pressed");
        findFish();
      }
    }

    private void fishToFind_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        findFish();
      }
    }


    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
