﻿using System;
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
        List<Weapon> weapons= new List<Weapon>();
        bool removeWeapons = false;
        Color backgroundColor = Color.Empty;
        public mainWindow()
        {
            InitializeComponent();
        }

        private void LoadCreature(string fileName)
        {
            weapons.Clear();
            weaponList.Nodes.Clear();
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

            WeaponCreator weaponCreator = new WeaponCreator();
           
            //Get Weapons
            foreach (XmlNode weapon in node.SelectSingleNode("Weapons").ChildNodes)
            {
                Weapon wep = weaponCreator.LoadWeaponFromFilePath(weapon.FirstChild.InnerText);
                AddWeapon(wep);
            }

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
            

            //Start saving Weapons
            xmlTextWriter.WriteStartElement("Weapons");
            
            //Save each weapon in the Weapons list
            foreach (var weapon in weapons)
            {
                xmlTextWriter.WriteElementString("FilePath", weapon.FilePath);
            }

            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Flush();
            xmlTextWriter.Close();
        }

        private void openCreatureFile_Click(object sender, EventArgs e)
        {
            if (openCreatureDialog.ShowDialog() == DialogResult.OK)
            {
                //Read the creature file
                LoadCreature(openCreatureDialog.FileName);
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(creatureSaveDialog.ShowDialog() == DialogResult.OK)
            {
                SaveCreature(creatureSaveDialog.FileName);
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

        private void addWeapon_Click(object sender, EventArgs e)
        {
            if (openWeaponDialog.ShowDialog() == DialogResult.OK)
            {
                //Read the creature file
                AddWeapon(openWeaponDialog.FileName);
            }
        }

        private void AddWeapon(string fileName)
        {
            XmlDocument weaponFile = new XmlDocument();
            weaponFile.Load(fileName);
            XmlNode node = weaponFile.DocumentElement;
            Weapon weapon= new Weapon();

            //Get Name of Weapon
            weapon.Name = node.SelectSingleNode("Name").InnerText;

            //Get Stats of Weapon
            weapon.DamageDie = int.Parse(node.SelectSingleNode("DamageDice").InnerText);
            weapon.DamageDieAmount = int.Parse(node.SelectSingleNode("DamageDiceAmount").InnerText);
            weapon.Modifier = int.Parse(node.SelectSingleNode("ExtraModifier").InnerText);
            weapon.FilePath = node.SelectSingleNode("FilePath").InnerText;
            //Add the Weapon
            AddWeapon(weapon);

        }

        private void AddWeapon(Weapon weapon)
        {
            //Add Weapon
            if (weapon != null)
                weapons.Add(weapon);
            else
                return;

            //Display Weapon
            weaponList.Nodes.Add(weapon.Name);
        }

        private void RemoveWeapon(Weapon weapon)
        {
            if (weapon != null)
            {
                weaponList.Nodes.RemoveByKey(weapon.Name);
                weapons.Remove(weapon);
            }
            else
                return;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //Check color
            if(backgroundColor == Color.Empty)
                backgroundColor = ActiveForm.BackColor;

            //Do something with seperate window
            removeWeapons = !removeWeapons;
            if (removeWeapons)
            {
                removeButton.Text = "Click to Remove";
                ActiveForm.BackColor = Color.Red;
            }
            else
            {
                ActiveForm.BackColor = backgroundColor;
                removeButton.Text = "Remove Weapon";
            }
                
        }

        private void weaponList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(removeWeapons)
                weaponList.Nodes.Remove(weaponList.SelectedNode);
        }
    }
}
