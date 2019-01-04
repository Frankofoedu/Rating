using Newtonsoft.Json;
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

namespace rating
{
    public partial class Form1 : Form
    {
        List<Word> _Words = new List<Word>();
        List<VaderClassification> Done = new List<VaderClassification>();
        string dataFolder = Path.Combine(Application.StartupPath, "Data");
        string resultFilePath = Path.Combine(Application.StartupPath, "Data", "result.txt");
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            Cursor = Cursors.AppStarting;
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _Words = JsonConvert.DeserializeObject<List<Word>>(File.ReadAllText(Path.Combine(dataFolder, "JsonWords.txt")));

            if (File.Exists(resultFilePath))
            {
                Done = JsonConvert.DeserializeObject<List<VaderClassification>>(File.ReadAllText(resultFilePath));
            }
            else
            {
                foreach (var item in _Words)
                {
                    Done.Add(new VaderClassification() { Word = item.dWord, Value = null });
                }
            }

            count = Properties.Settings.Default.position;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Display(count);

            Cursor = Cursors.Arrow;
        }

        private void Display(int index)
        {
            var curWord = _Words[index];
            var curClass = Done[index];

            txtExample.Text = curWord.Examples;
            txtMeaning.Text = curWord.Definitions;
            txtWord.Text = curWord.dWord;

            selectRad(curClass.Value);
        }

        private int? getRadValue()
        {
            int? rtn = null;
            if (rad0.Checked) rtn = 0;
            else if (rad1.Checked) rtn = 1;
            else if (rad2.Checked) rtn = 2;
            else if (rad3.Checked) rtn = 3;
            else if (rad4.Checked) rtn = 4;
            else if (rad1Neg.Checked) rtn = -1;
            else if (rad2Neg.Checked) rtn = -2;
            else if (rad3Neg.Checked) rtn = -3;
            else if (rad4Neg.Checked) rtn = -4;
            else rtn = null;

            return rtn;
        }
        private void selectRad(int? value)
        {
            switch (value)
            {
                case -4: rad4Neg.Checked = true;
                    break;
                case -3:
                    rad3Neg.Checked = true;
                    break;
                case -2:
                    rad2Neg.Checked = true;
                    break;
                case -1:
                    rad1Neg.Checked = true;
                    break;
                case 0:
                    rad0.Checked = true;
                    break;
                case 1:
                    rad1.Checked = true;
                    break;
                case 2:
                    rad2.Checked = true;
                    break;
                case 3:
                    rad3.Checked = true;
                    break;
                case 4:
                    rad4.Checked = true;
                    break;
                default:
                    rad4.Checked = false;
                    rad3.Checked = false;
                    rad2.Checked = false;
                    rad1.Checked = false;
                    rad0.Checked = false;
                    rad1Neg.Checked = false;
                    rad2Neg.Checked = false;
                    rad3Neg.Checked = false;
                    rad4Neg.Checked = false;

                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var str = JsonConvert.SerializeObject(Done);
            File.WriteAllText(resultFilePath, str);

            Properties.Settings.Default.position = count;
            Properties.Settings.Default.Save();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Done[count].Value = getRadValue();

            if (count<_Words.Count)
            {
                count++;
                Display(count);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            Done[count].Value = getRadValue();

            if (count > 0)
            {
                count--;
                Display(count);
            }
        }
    }
}
