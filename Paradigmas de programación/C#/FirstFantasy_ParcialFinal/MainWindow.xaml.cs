using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Player;
using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFantasy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            Character myCharacter;
            Weapon myWeapon;
            Armor myArmor;
            String character = CboxCharacter.Text;
            String weapon = CboxWeapon.Text;
            String armor = CboxArmor.Text;
            switch (character)
            {
                case "Cleric":
                    myCharacter = new Cleric(txtName.Text);
                    break;

                case "Fighter":
                    myCharacter = new Fighter(txtName.Text);
                    break;

                case "Rogue":
                    myCharacter = new Rogue(txtName.Text);
                    break;

                case "Wizard":
                    myCharacter = new Wizard(txtName.Text);
                    break;

                case "Assassin":
                    myCharacter = new Assassin(txtName.Text);
                    break;

                default:
                    myCharacter = null;
                    MessageBox.Show("You MUST select a character");
                    break;

            }
            switch (weapon)
            {
                case "Sword":
                    myWeapon = new Sword();
                    break;

                case "Axe":
                    myWeapon = new Axe();
                    break;

                case "Mallet":
                    myWeapon = new Mallet();
                    break;

                default:
                    myWeapon = null;
                    MessageBox.Show("You MUST select a weapon");
                    break;

            }
            switch (armor)
            {
                case "Diamond Armor":
                    myArmor = new Diamond();
                    break;

                case "Netherite Armor":
                    myArmor = new Netherite();
                    break;

                case "Gold Armor":
                    myArmor = new Gold();
                    break;

                default:
                    myArmor = null;
                    MessageBox.Show("You MUST select a armor");
                    break;

            }

            if (myCharacter != null && myWeapon != null && myArmor != null)
            {
                int i = 1;
                bool a = true;
                while (i < FileManager.ReadAllLines().Length)
                {
                    if (txtName.Text == FileManager.ReadAllLines()[i])
                    {
                        MessageBox.Show("Invalid Name");
                        txtName.Text = "";
                        a = false;
                        break;
                    }
                    else
                    {
                        if (txtName.Text == "")
                        {
                            txtName.Text = "";
                            a = false;
                            MessageBox.Show("Invalid Name");
                            break;
                        }
                        i += 4;
                    }
                }
                if (a == true)
                {
                    lbCharacter.Items.Add(myCharacter.Name);
                    FileManager.WriteFile(myCharacter.Name);
                    FileManager.WriteFile(myCharacter.ShowInformation());
                    FileManager.WriteFile(myWeapon.ShowInformation());
                    FileManager.WriteFile(myArmor.ShowInformation());
                    txtName.Text = "";
                }
                
            }
        }
        private void btnInformation_Click(object sender, RoutedEventArgs e)
        {
            btnChange.Visibility = Visibility.Visible;
            lbInventory.Items.Clear();
            int i = 0;
            while (i != FileManager.ReadAllLines().Length)
            {
                if (FileManager.ReadAllLines()[i] == lbCharacter.SelectedItem.ToString())
                {
                    lbInventory.Items.Add(FileManager.ReadAllLines()[i]);
                    lbInventory.Items.Add(FileManager.ReadAllLines()[i+1]);
                    lbInventory.Items.Add(FileManager.ReadAllLines()[i+2]);
                    lbInventory.Items.Add(FileManager.ReadAllLines()[i+3]);
                    break;
                }
                else
                {
                    i += 1;
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbCharacter.Items.Clear();
            int i = 0;
            
            while (i != FileManager.ReadAllLines().Length && i <= FileManager.ReadAllLines().Length)
            {
                lbCharacter.Items.Add(FileManager.ReadAllLines()[i]);
                i += 4;

            }
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            List<string> objectList = new List<string>();
            int i = 0;
            while (i != FileManager.ReadAllLines().Length && i <= FileManager.ReadAllLines().Length)
            {
                if (FileManager.ReadAllLines()[i] == lbCharacter.SelectedItem.ToString())
                {
                    if (CboxCharacter.Text == "Character" || CboxWeapon.Text == "Weapon" || CboxArmor.Text == "Armor")
                    {
                        MessageBox.Show("You must select the items to change");
                        objectList.Add(FileManager.ReadAllLines()[i]);
                        i += 1;
                    }
                    else
                    {
                        objectList.Add(FileManager.ReadAllLines()[i]);
                        objectList.Add(CboxCharacter.Text);
                        objectList.Add(CboxWeapon.Text);
                        objectList.Add(CboxArmor.Text);
                        i += 4;
                    }
                }
                else
                {
                    objectList.Add(FileManager.ReadAllLines()[i].ToString());
                    i += 1;
                }
            }
            string[] objectArray = objectList.ToArray();
            FileManager.OverrideFile(objectArray);
            lbInventory.Items.Clear();
            i = 0;
            while (i != FileManager.ReadAllLines().Length)
            {
                if (FileManager.ReadAllLines()[i] == lbCharacter.SelectedItem.ToString())
                {
                    lbInventory.Items.Add(FileManager.ReadAllLines()[i]);
                    lbInventory.Items.Add(FileManager.ReadAllLines()[i + 1]);
                    lbInventory.Items.Add(FileManager.ReadAllLines()[i + 2]);
                    lbInventory.Items.Add(FileManager.ReadAllLines()[i + 3]);
                    break;
                }
                else
                {
                    i += 1;
                }
            }
        }

        private void btnTaunt_Click(object sender, RoutedEventArgs e)
        {
            if (lbInventory.Items[1].ToString() == "Assassin")
            {
                Character tcharacter = new Assassin(lbInventory.Items[0].ToString());
                MessageBox.Show(tcharacter.Taunt());
            }
            if (lbInventory.Items[1].ToString() == "Rogue")
            {
                Character tcharacter = new Rogue(lbInventory.Items[0].ToString());
                MessageBox.Show(tcharacter.Taunt());
            }
            if (lbInventory.Items[1].ToString() == "Wizard")
            {
                Character tcharacter = new Wizard(lbInventory.Items[0].ToString());
                MessageBox.Show(tcharacter.Taunt());
            }
            if (lbInventory.Items[1].ToString() == "Cleric")
            {
                Character tcharacter = new Cleric(lbInventory.Items[0].ToString());
                MessageBox.Show(tcharacter.Taunt());
            }
            if (lbInventory.Items[1].ToString() == "Fighter")
            {
                Character tcharacter = new Fighter(lbInventory.Items[0].ToString());
                MessageBox.Show(tcharacter.Taunt());
            }
        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            if (lbInventory.Items[2].ToString() == "Axe")
            {
                Weapon aweapon = new Axe();
                MessageBox.Show(aweapon.Attack());
            }
            if (lbInventory.Items[2].ToString() == "Sword")
            {
                Weapon aweapon = new Sword();
                MessageBox.Show(aweapon.Attack());
            }
            if (lbInventory.Items[2].ToString() == "Mallet")
            {
                Weapon aweapon = new Mallet();
                MessageBox.Show(aweapon.Attack());
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            lbInventory.Items.Clear();
            List<string> objectList = new List<string>();
            int i = 0;
            while (i != FileManager.ReadAllLines().Length)
            {
                if (FileManager.ReadAllLines()[i] == lbCharacter.SelectedItem.ToString())
                {
                    i += 4;
                }
                else
                {
                    objectList.Add(FileManager.ReadAllLines()[i].ToString());
                    i += 1;
                }
            }
            string[] objectArray = objectList.ToArray();
            FileManager.OverrideFile(objectArray);

            lbCharacter.Items.Clear();
            i = 0;

            while (i != FileManager.ReadAllLines().Length && i <= FileManager.ReadAllLines().Length)
            {
                lbCharacter.Items.Add(FileManager.ReadAllLines()[i]);
                i += 4;

            }
            btnChange.Visibility = Visibility.Hidden;
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            Character myCharacter;
            Weapon myWeapon;
            Armor myArmor;

            if (lbInventory.SelectedItem == null)
            {
                MessageBox.Show("You must select an item to see details");
            }
            else
            {
                String character = lbInventory.SelectedItem.ToString();
                String weapon = lbInventory.SelectedItem.ToString();
                String armor = lbInventory.SelectedItem.ToString();
                switch (character)
                {
                    case "Cleric":
                        myCharacter = new Cleric(lbInventory.Items[0].ToString());
                        break;

                    case "Fighter":
                        myCharacter = new Fighter(lbInventory.Items[0].ToString());
                        break;

                    case "Rogue":
                        myCharacter = new Rogue(lbInventory.Items[0].ToString());
                        break;

                    case "Wizard":
                        myCharacter = new Wizard(lbInventory.Items[0].ToString());
                        break;

                    case "Assassin":
                        myCharacter = new Assassin(lbInventory.Items[0].ToString());
                        break;

                    default:
                        myCharacter = null;
                        break;

                }
                switch (weapon)
                {
                    case "Sword":
                        myWeapon = new Sword();
                        break;

                    case "Axe":
                        myWeapon = new Axe();
                        break;

                    case "Mallet":
                        myWeapon = new Mallet();
                        break;

                    default:
                        myWeapon = null;
                        break;

                }
                switch (armor)
                {
                    case "Diamond Armor":
                        myArmor = new Diamond();
                        break;

                    case "Netherite Armor":
                        myArmor = new Netherite();
                        break;

                    case "Gold Armor":
                        myArmor = new Gold();
                        break;

                    default:
                        myArmor = null;
                        break;
                }
                if (myCharacter != null)
                {
                    MessageBox.Show(myCharacter.ShowInformation());
                }
                else
                {
                    if (myWeapon != null)
                    {
                        MessageBox.Show(myWeapon.ShowInformation());
                    }
                    else
                    {
                        if (myArmor != null)
                        {
                            MessageBox.Show(myArmor.ShowInformation());
                        }
                        else
                        {
                            MessageBox.Show("This is the name of the character");
                        }
                    }
                }
            }
        }
    }
}
