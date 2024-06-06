using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Projektas
{

    public partial class FormPOTD : Form
    {

        SavedData savedData = new SavedData();
        NasaApi nasaapi = new NasaApi();
        PotdData PotdJson = new PotdData();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        public FormPOTD()
        {
            InitializeComponent();
            FillTitleList();
        }

        private void FillTitleList()
        {

            int select = lbSaved.SelectedIndex;
            int select2 = lbSaved.Items.Count;
            lbSaved.Items.Clear();
            
            string[] AllTitles = savedData.GetAllTitles();
            lbSaved.Items.AddRange(AllTitles);
            // MessageBox.Show(lbSaved.Items.Count.ToString());
            if (select <= 0)
            {
                select = 0;
                btnInfoSaved.Enabled = false;
                btnDownload.Enabled = false;
            }
            else if (select > lbSaved.Items.Count - 1) select -= 1;
            else lbSaved.SelectedIndex = select;

            if (lbSaved.Items.Count <= 0)
            {
                btnRemoveSaved.Enabled = false;
                btnInfoSaved.Enabled = false;
                btnDownload.Enabled = false;
                rtbNotes.Enabled = false;
                btnNotes.Enabled = false;
            }
            else btnRemoveSaved.Enabled = true;
            //MessageBox.Show(select.ToString());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            INFO info = new INFO();
            info.Date = Calendar1.SelectionStart;
            info.Show();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //DateTime date = Calendar1.SelectionStart;
            string CurrentDate = Calendar1.SelectionStart.ToString("yyyy-MM-dd");
            Console.WriteLine(CurrentDate);
            string[] AllSavedDates = savedData.GetAllDates();
           // Console.WriteLine(AllSavedDates[0]);
            if (AllSavedDates.Contains(CurrentDate))
            {
                MessageBox.Show("This day is already added to favorites");
                return;
            }
            PotdJson = await nasaapi.GetPOTD(Calendar1.SelectionStart);
            savedData.SaveToFile(PotdJson);
            FillTitleList();
        }
        private void lbSaved_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInfoSaved.Enabled = true;
            btnDownload.Enabled = true;
            rtbNotes.Enabled = true;
            btnNotes.Enabled = true;
            string[] AllTitles = savedData.GetAllTitles();
            
            
            string title = AllTitles[lbSaved.SelectedIndex];
            PotdData SelectJson = savedData.GetDataFromTitle(title);
            String imageURL = SelectJson.Url;
            String type = SelectJson.Media_type;
            rtbNotes.Text = SelectJson.Notes;


            if (type == "video")
            {
                pbSaved.Visible = false;
                wbSaved.Visible = true;
                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "<iframe id='video' src= " + imageURL + " width='927' height='520' frameborder='0' allowfullscreen></iframe> ";
                html += "</head></html>";
                this.wbSaved.DocumentText = string.Format(html, imageURL);
            }
            else if (type == "image")
            {
                pbSaved.Visible = true;
                wbSaved.Visible = false;
                pbSaved.Load(imageURL);
            }
        }

        private void btnRemoveSaved_Click(object sender, EventArgs e)
        {
            string[] AllTitles = savedData.GetAllTitles();
            string title = AllTitles[lbSaved.SelectedIndex];

            savedData.DeleteDataFromTitle(title);
            
            FillTitleList();
        }

        private void btnInfoSaved_Click(object sender, EventArgs e)
        {
            string[] AllTitles = savedData.GetAllTitles();
            string title = AllTitles[lbSaved.SelectedIndex];
            PotdData SelectJson = savedData.GetDataFromTitle(title);

            DateTime formDate = DateTime.Parse(SelectJson.Date);

            //MessageBox.Show(formDate.ToString());

            INFO info = new INFO();
            info.Date = formDate;
            info.Show();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Image Files (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save Image";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    pbSaved.Image.Save(filePath);
                }
                catch
                {
                    MessageBox.Show("Error saving image");
                }
            }
        }

        private  void btnNotes_Click(object sender, EventArgs e)
        {
            string[] AllTitles = savedData.GetAllTitles();
            string title = AllTitles[lbSaved.SelectedIndex];
            PotdData SelectJson = savedData.GetDataFromTitle(title);

            DateTime formDate = DateTime.Parse(SelectJson.Date);
            string notes = rtbNotes.Text;

            //PotdJson = await nasaapi.GetPOTD(formDate);
            savedData.SaveNotesToFile(notes, formDate);
        }

        private async void Calendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime currenttime = DateTime.Now;
            if (Calendar1.SelectionStart > currenttime)
            {
                MessageBox.Show("There is no Nasa Picture of the day for " + Calendar1.SelectionStart.ToString("yyyy-MM-dd") + " yet");
                return;
            }
            btnInfo.Enabled = true;
            btnSave.Enabled = true;
            //MessageBox.Show(formattedDate);

            PotdJson = await nasaapi.GetPOTD(Calendar1.SelectionStart);
            if (PotdJson == null)
            {
                MessageBox.Show("Couldn't get data from API");
                return;
            }
            
            //MessageBox.Show(PotdJson, "test");
            String imageURL = PotdJson.Url;
            String type = PotdJson.Media_type;


            if (type == "video")
            {
                pbPOTD.Visible = false;
                wbVOTD.Visible = true;
                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "<iframe id='video' src= " + imageURL + " width='927' height='520' frameborder='0' allowfullscreen></iframe> ";
                html += "</head></html>";
                this.wbVOTD.DocumentText = string.Format(html, imageURL);
            }
            else if (type == "image")
            {
                pbPOTD.Visible = true;
                wbVOTD.Visible = false;
                pbPOTD.Load(imageURL);
            }
            lblTitle.Text = PotdJson.Title;
        }
    }
}
