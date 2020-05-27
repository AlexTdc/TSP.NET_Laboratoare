using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API;
using System.IO;

namespace GUI
{

    public partial class Form2 : Form
    {
        MplementInterfaceClient api = new MplementInterfaceClient();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //apiControlForm2 edit  = new apiControlForm2();
            //edit.UpdateImage2(textBoxPlace2.Text);
            api.UpdateImage1(textBoxName2.Text, textBoxPath2.Text, textBoxAbout2.Text, textBoxPlace2.Text,  textBoxPeople2.Text);
            labelSaved.Text = "Saved !!!";

        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            //apiControlForm2 test = new apiControlForm2();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.mp4;)|*.jpg; *.jpeg; *.png; *.mp4;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBoxPath2.Text = open.FileName;
                textBoxName2.Text = open.SafeFileName;
                pictureBox1.Image = new Bitmap(open.FileName);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelSaved_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //apiControlForm2 delete = new apiControlForm2();
            api.deleteImage(textBoxPath2.Text);
            label6.Text = "Photo Deleted !";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
