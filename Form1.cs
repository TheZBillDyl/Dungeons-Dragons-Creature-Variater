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
using System.Windows;

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
            XmlNode node = creatureFile.DocumentElement;

           
            //Get Name of creature
            creatureName.Text = node.SelectSingleNode("Name").InnerText;
            
            //Get Stats of Creature
            strengthStat.Text = node.SelectSingleNode("Strength").InnerText;
            dexterityStat.Text = node.SelectSingleNode("Dexterity").InnerText;
            constitutionStat.Text = node.SelectSingleNode("Constitution").InnerText;
            intelligenceStat.Text = node.SelectSingleNode("Intelligence").InnerText;
            wisdomStat.Text = node.SelectSingleNode("Wisdom").InnerText;
            charismaStat.Text = node.SelectSingleNode("Charisma").InnerText;

            //Have Modifiers get updated
            ChangeStatBox(strengthStat, strMod);
            ChangeStatBox(dexterityStat, dexMod);
            ChangeStatBox(constitutionStat, conMod);
            ChangeStatBox(intelligenceStat, intMod);
            ChangeStatBox(wisdomStat, wisMod);
            ChangeStatBox(charismaStat, charMod);
        }

        private void SaveCreature(string fileName)
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter(fileName, Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument();

            //Save Creature Name
            xmlTextWriter.WriteStartElement("Creature");
            xmlTextWriter.WriteElementString("Name", creatureName.Text);

            //Start Saving Stats
            xmlTextWriter.WriteElementString("Strength", strengthStat.Text);
            xmlTextWriter.WriteElementString("Dexterity", dexterityStat.Text);
            xmlTextWriter.WriteElementString("Constitution", constitutionStat.Text);
            xmlTextWriter.WriteElementString("Intelligence", intelligenceStat.Text);
            xmlTextWriter.WriteElementString("Wisdom", wisdomStat.Text);
            xmlTextWriter.WriteElementString("Charisma", charismaStat.Text);
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

        private void strengthStat_TextChanged(object sender, EventArgs e)
        {
            ChangeStatBox(strengthStat, strMod);
        }

        private void dexterityStat_TextChanged(object sender, EventArgs e)
        {
            ChangeStatBox(dexterityStat, dexMod);
            acValue.Text = (10 + int.Parse(dexMod.Text)).ToString();
        }

        private void constitutionStat_TextChanged(object sender, EventArgs e)
        {
            ChangeStatBox(constitutionStat, conMod);
        }

        private void intelligenceStat_TextChanged(object sender, EventArgs e)
        {
            ChangeStatBox(intelligenceStat, intMod);
        }

        private void wisdomStat_TextChanged(object sender, EventArgs e)
        {
            ChangeStatBox(wisdomStat, wisMod);
        }

        private void charismaStat_TextChanged(object sender, EventArgs e)
        {
            ChangeStatBox(charismaStat, charMod);
        }

        private void ChangeStatBox(TextBox box, Label label)
        {
            if (int.TryParse(box.Text, out int value))
            {
                //Value was accepted
                box.Text = value.ToString();
                ChangeMod(label, value);
            }
            else
            {
                //Value was not accepted
                box.Text = "";
            }
        }

        private void ChangeMod(Label label, int val)
        {
            float num = ((val - 10f) / 2f);
            num = (int)Math.Floor(num);
            label.Text = num.ToString();
        }

        private void createWeapon_Click(object sender, EventArgs e)
        {
            WeaponCreator weaponCreator = new WeaponCreator();
            weaponCreator.Show();
        }
    }
}
