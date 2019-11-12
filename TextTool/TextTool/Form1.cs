using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextTool
{
    public partial class Form1 : Form
    {
        private List<Tool> m_tools = new List<Tool>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tool UniqeWordsBeginningWith = new Tool();
            UniqeWordsBeginningWith.DisplayName = "Find all unique words beginning with";
            UniqeWordsBeginningWith.RegEx = @"(?<!\w)searchword\w+";
            UniqeWordsBeginningWith.ToolName = Tool.ToolNames.UniqeWordsBeginningWith;
            m_tools.Add(UniqeWordsBeginningWith);

            Tool UniqueWordsContaining = new Tool();
            UniqueWordsContaining.DisplayName = "Find all unique words containing ";
            UniqueWordsContaining.RegEx = @"\Bsearchword\w+";
            UniqueWordsContaining.ToolName = Tool.ToolNames.UniqueWordsContaining;
            m_tools.Add(UniqueWordsContaining);

            comboBoxTools.DisplayMember = "DisplayName";
            comboBoxTools.DataSource = m_tools;
        }

        private void comboBoxTools_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Tool t = comboBoxTools.SelectedValue as Tool;
                textBoxRegex.Text = t?.RegEx;
            }
            catch (Exception ex)
            {
                textBoxResult.Text = ex.ToString();
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult.Text = "";

                Tool t = comboBoxTools.SelectedValue as Tool;
                Regex r = new Regex(textBoxRegex.Text);
                List<string> uniqueTotal = new List<string>();

                if (radioButtonSearchInput.Checked)
                {
                    IEnumerable<string> uniques = Find(r, textBoxInput.Text);
                    uniqueTotal.AddRange(uniques);
                }
                else
                {
                    var files = Directory.GetFiles(textBoxDirName.Text, textBoxFileExt.Text, SearchOption.AllDirectories);
                    foreach (var file in files)
                    {
                        string text = File.ReadAllText(file);
                        IEnumerable<string> uniques = Find(r, text);
                        uniqueTotal.AddRange(uniques);

                        textBoxResult.Text = string.Join("\r\n", uniqueTotal.Distinct().OrderBy(w => w));
                        Application.DoEvents();
                    }
                }

                
            }
            catch (Exception ex)
            {
                textBoxResult.Text = ex.ToString();
            }
        }

        private IEnumerable<string> Find(Regex r, string text)
        {
            var matches = r.Matches(text);
            var uniques = matches.OfType<Match>().Select(m => m.Value).Distinct();
            return uniques;
        }

        private void buttonSelectDir_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                    textBoxDirName.Text = folderBrowserDialog1.SelectedPath;
            }
            catch (Exception ex)
            {
                textBoxResult.Text = ex.ToString();
            }
        }
    }

    public class Tool
    {
        public enum ToolNames { UniqeWordsBeginningWith, UniqueWordsContaining }

        public ToolNames ToolName { get; set; }
        public string DisplayName { get; set; }
        public string RegEx { get; set; }
    }
}
