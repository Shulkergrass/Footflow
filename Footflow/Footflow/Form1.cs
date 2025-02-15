using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Footflow
{
    public partial class Form1 : Form
    {
        //toggle for footfall map
        bool toggleMap = false;
        //file for storing feedback
        string feedbackFile = "feedback.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //as the form loads, checks if there is a file already there, if not, creates a file for storing feedback later
            if (File.Exists(feedbackFile) == false)
            {
                File.Create(feedbackFile);
                StreamReader sr = new StreamReader(feedbackFile);
                sr.Close();
            }
        }

        private void btnFootfall_Click(object sender, EventArgs e)
        {
            //changes the image of the map to display the footfall map
            if (toggleMap == false)
            {
                toggleMap = true;
                pbMap.Image = Image.FromFile("footfall_img.png");
            }
            //changes the image of the map to display the plain map
            else
            {
                toggleMap = false;
                pbMap.Image = Image.FromFile("basic_img.png");
            }
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            //sets the chosen location to "Lake"
            lblLocation.Text = "Lake";
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            //sets the chosen location to "Path"
            lblLocation.Text = "Path";
        }

        private void btnWoods_Click(object sender, EventArgs e)
        {
            //sets the chosen location to "Woods"
            lblLocation.Text = "Woods";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checks that both a location and a comment type have been selected before allowing a comment to be submitted
            if (lbCategory.SelectedItem == null || lbCategory.SelectedIndex == 0 || lblLocation.Text == "Select an Area")
            {
                MessageBox.Show("Please select a category for your comment and an area");
            }
            else
            {
                //organising the text to be written to the file
                string hide = "";
                //deciding whether the comment is public or private
                if (cbPublic.Checked == false)
                {
                    hide = "private";
                }
                else
                {
                    hide = "public";
                }
                //preparing variables to be easily written into the file
                string line1 = "--------------------------------------------";
                string line2 = hide + " Comment on " + lblLocation.Text;
                string line3 = "Comment type: "+ lbCategory.SelectedItem;
                string line4 = "\n" + rtbComment.Text;
                string line5 = "--------------------------------------------\n";

                //putting the comment into the file with data about it and formatted correctly
                StreamWriter sw = new StreamWriter(feedbackFile, true);
                sw.WriteLine(line1);
                sw.WriteLine(line2);
                sw.WriteLine(line3);
                sw.WriteLine(line4);
                sw.WriteLine(line5);
                sw.Close();

                //confirming to the user that the comment has been saved
                MessageBox.Show("Your comment on " + lblLocation.Text + " has been saved");
                //resetting page
                rtbComment.Text = "";
                cbPublic.Checked = false;
                lblLocation.Text = "Select an Area";
                lbCategory.SelectedIndex = 0;
                lbCategory.SelectedItem = null;
            }
        }
    }
}
