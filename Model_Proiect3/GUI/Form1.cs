using System;
using System.Drawing;
using System.Windows.Forms;
using API;

namespace GUI
{
    public partial class Form1 : Form
    {
        MplementInterfaceClient api = new MplementInterfaceClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //apiControlForm1 api = new apiControlForm1();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
           // MplementInterfaceClient api = new MplementInterfaceClient();
            //apiControlForm1 api = new apiControlForm1();
            //api.uploadImage(textBoxPath);

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.mp4;)|*.jpg; *.jpeg; *.png; *.mp4;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = open.FileName;
                textBoxName.Text = open.SafeFileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //apiControlForm1 save = new apiControlForm1();
            api.saveImage(textBoxName.Text, textBoxPath.Text, textBoxAbout.Text, textBoxPlace.Text, textBoxPeople.Text);
            labelSaveMsg.Text = "Saved !!!";
        }

        private void btnOpenEdit_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            this.Hide();
            //this.Close(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
