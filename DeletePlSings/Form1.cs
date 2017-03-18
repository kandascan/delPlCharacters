using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeletePlSings
{
    public partial class Form1 : Form
    {
        private string path;
        private string pathSave;
        private string[] lines;
        List<string> linie = new List<string>();
        private string line;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseTheFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Wybierz plik z napisami";
            ofd.Filter = "SubRip File|*.srt|Tekst File|*.txt";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblFilePath.Text = ofd.SafeFileName;
                path = ofd.FileName;
                StreamReader sr = new StreamReader(File.OpenRead(path), Encoding.GetEncoding("Windows-1250"));
       
                while ((line = sr.ReadLine()) != null)
                {
                   linie.Add(line);
                }

                lines = linie.ToArray();

                sr.Dispose();
                btnDelPlSings.Enabled = true;
            }

        }

        private void btnDelPlSings_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lines.Count(); i++)
            {
                lines[i] = lines[i].Replace("ą", "a")
                .Replace("Ą", "A")
                .Replace("ę", "e")
                .Replace("Ę", "E")
                .Replace("ś", "s")
                .Replace("Ś", "S")
                .Replace("ż", "z")
                .Replace("Ż", "Z")
                .Replace("ć", "c")
                .Replace("Ć", "C")
                .Replace("ź", "z")
                .Replace("Ź", "Z")
                .Replace("ń", "n")
                .Replace("Ń", "N")
                .Replace("ó", "o")
                .Replace("Ó", "O")
                .Replace("ł", "l")
                .Replace("Ł", "L");
            }

            btnSave.Enabled = true;
            lblQuantityLines.Text = "Plik zawiera " + lines.Count().ToString() + " lini tekstu";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //pathSave = path.Insert((path.Count() - 4), "[BEZ_PL]");
            //StreamWriter sw = new StreamWriter(File.Create(pathSave));
     
            //foreach (var line in lines)
            //{
            //    sw.WriteLine(line);
            //}
            //sw.Dispose();
            //lblNameFileSave.Text = lblFilePath.Text.Insert(lblFilePath.Text.Count() - 4, "[BEZ PL]");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SubRip File|*.srt|Tekst File|*.txt";
            sfd.FileName = lblFilePath.Text;
            sfd.Title = "Gdzie chcesz zapisać plik";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string savePath = sfd.FileName;
                StreamWriter sw = new StreamWriter(File.Create(savePath));
                foreach (var line in lines)
                {
                    sw.WriteLine(line);
                }
                sw.Dispose();
                lblNameFileSave.Text = savePath;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
