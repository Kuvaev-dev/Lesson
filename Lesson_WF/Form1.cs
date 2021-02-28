using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Lesson_WF
{
    public partial class Form1 : Form
    {
        Lazy<OpenFileDialog> dialogOpen;
        Lazy<SaveFileDialog> dialogSave;
        Lazy<string> pathToFile;
        public Form1()
        {
            InitializeComponent();

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            dialogOpen = new Lazy<OpenFileDialog>();
            dialogOpen.Value.Filter = "Text|*.txt";
            if (dialogOpen.Value.ShowDialog() == DialogResult.OK)
            {
                pathToFile = new Lazy<string>(new Func<string>(() => dialogOpen.Value.FileName));
                textBox.Text = File.ReadAllText(pathToFile.Value);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dialogOpen.Value.Dispose();
            GC.Collect(GC.GetGeneration(dialogOpen));
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            dialogSave = new Lazy<SaveFileDialog>();
            dialogSave.Value.Filter = "Text|*.txt";
            if (dialogSave.Value.ShowDialog() == DialogResult.OK)
            {
                pathToFile = new Lazy<string>(new Func<string>(() => dialogSave.Value.FileName));
                File.WriteAllText(pathToFile.Value, textBox.Text);
            }
        }
    }
}
