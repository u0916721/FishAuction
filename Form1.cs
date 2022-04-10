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

    private void search_Click(object sender, EventArgs e)
    {
      controller.findFish(fishToFind.Text);
      var image = Image.FromFile(@"C:\\Users\\krais\\Downloads\\fishImage" + (controller.fishImageNumber-1) + ".jpg");
      fishPicture.Image = image;
    }

    private void fishToFind_TextChanged(object sender, EventArgs e)
    {
      
    }

    private void fishPicture_Click(object sender, EventArgs e)
    {
      //fishPicture.Image
    }
  }
}
