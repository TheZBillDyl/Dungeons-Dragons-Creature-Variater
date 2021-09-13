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
using System.Xml;
namespace DungeonsAndDragonsCreatureVariator
{
    public partial class mainWindow : Form
    {

        public mainWindow()
        {
            InitializeComponent();
        }

        private void LoadCreature(string fileName)
        {
            XmlDocument creatureFile = new XmlDocument();
            creatureFile.Load(fileName);

            //Get Name of creature
            XmlNode xmlNode = creatureFile.SelectSingleNode("Name");
            creatureName.Text = xmlNode.InnerText;
        }

        private void SaveCreature(string fileName)
        {
            //Check to see if the file type is XML. If not, make it!
            if (!fileName.EndsWith(".xml"))
            {
                fileName += ".xml";
            }

            XmlTextWriter xmlTextWriter = new XmlTextWriter(fileName, System.Text.Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument();

            xmlTextWriter.WriteStartElement("Name");
            xmlTextWriter.WriteElementString("Name", creatureName.Text);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Flush();
            xmlTextWriter.Close();
        }

        private void openCreatureFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Read the creature file
                LoadCreature(openFileDialog1.FileName);
            }

        }

        private void nextCreatureButton_Click(object sender, EventArgs e)
        {
            
        }

        private void previousCreatureButton_Click(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveCreature(saveFileDialog1.FileName);
            }
        }
    }
}
