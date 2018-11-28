using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;

namespace ImageCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mult = trackBar.Value / 100f;
            templateList.MultiSelect = false;
            fileList.MultiSelect = false;
        }
	//Variables
        List<string> filePaths;
        List<string> templatePaths;
        Color replaceColor;
        string outputPath;
        float mult = 0;
        private void filesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog filesDialog = new OpenFileDialog();
            filesDialog.Title = "Select images to work with";
            filesDialog.Multiselect = true;
            filesDialog.Filter = "Image files|*.png;*.jpg";
            if (filesDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileImage.Image = System.Drawing.Image.FromFile(filesDialog.FileName);
                    fileList.Items.Clear();
                    filePaths = new List<string>(filesDialog.FileNames);
                    foreach (var item in filePaths)
                    {
                        //ListViewItem path = new ListViewItem(item.Split('\\')[item.Split('\\').Length-1]);
                        ListViewItem path = new ListViewItem(item);
                        fileList.Items.Add(path);
                    }
                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        Bitmap ConvertToFormat(System.Drawing.Image image, PixelFormat format)
        {
            Bitmap copy = new Bitmap(image.Width, image.Height, format);
            using (Graphics gr = Graphics.FromImage(copy))
            {
                gr.DrawImage(image, new Rectangle(0, 0, copy.Width, copy.Height));
            }
            return copy;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            if(CheckConditions())
            {
                progressBar.Value = 0;
                progressBar.Maximum = filePaths.Count;
                SolidBrush brush = new SolidBrush(replaceColor);
             
                foreach (var path in filePaths)
                {
                    Bitmap sourceImage = ConvertToFormat(System.Drawing.Image.FromFile(path), PixelFormat.Format24bppRgb);

                    foreach (string item in templatePaths)
                    {
                    
                    // create template matching algorithm's instance
                    // (set similarity threshold to 92.5%)

                    ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(mult);
                    // find all matchings with specified above similarity

                    TemplateMatch[] matchings = tm.ProcessImage(sourceImage, (Bitmap)System.Drawing.Image.FromFile(item));
                    // highlight found matchings

                    using (Graphics g = Graphics.FromImage(sourceImage))
                    {
                        foreach (TemplateMatch m in matchings)
                        {
                            //g.DrawRectangle(new Pen(replaceColor,1),m.Rectangle);
                            g.FillRectangle(brush,m.Rectangle);
                            //Drawing.Rectangle(data, m.Rectangle, Color.White);
                        }
                    }

                   // sourceImage.UnlockBits(data);

                    }
                    sourceImage.Save(outputPath + '\\' + path.Split('\\')[path.Split('\\').Length - 1]);
                    progressBar.Value++;
                }
                MessageBox.Show("Finished!!!");
                progressBar.Value = 0;
            }
        }
        private bool CheckConditions()
        {
            string errorText = "";
            errorText = "No files selected";
            if (filePaths != null && filePaths.Count != 0)
            {
                errorText = "No template selected";
                if (templateList.Items.Count != 0)
                {
                    errorText = "No color selected";
                    if (replaceColor.Name != "0")
                    {
                        errorText = "No path selected";
                        if (outputPath != null)
                        {
                            return true;
                        }
                    }
                }
            }
            MessageBox.Show(errorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            errorLabel.Text = errorText;
            return false;
        }
        private void pathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    outputPath = dialog.SelectedPath;
                    pathLabel.Text = outputPath;
                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void templateButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "Select template image";
            fileDialog.Filter = "Image files|*.png;*.jpg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    templateImage.Image = System.Drawing.Image.FromFile(fileDialog.FileName);
                    templateList.Items.Clear();
                    templatePaths = new List<string>(fileDialog.FileNames);
                    foreach (var item in templatePaths)
                    {
                        //ListViewItem path = new ListViewItem(item.Split('\\')[item.Split('\\').Length-1]);
                        ListViewItem path = new ListViewItem(item);
                        templateList.Items.Add(path);
                    }
                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    replaceColor = colorDialog.Color;
                    colorPanel.BackColor = replaceColor;
                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            mult = trackBar.Value / 100f;
            percentLabel.Text = trackBar.Value.ToString() + '%';
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(fileList.SelectedItems.Count > 0)
            fileImage.Image = System.Drawing.Image.FromFile(fileList.SelectedItems[0].Text);
        }

        private void templateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (templateList.SelectedItems.Count > 0)
            templateImage.Image = System.Drawing.Image.FromFile(templateList.SelectedItems[0].Text);
        }
    }
}
