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
using Champs;
using Logging;
using System.Diagnostics;

namespace WinForms_TBG
{
    public partial class Form1 : Form
    {

        Logger logger = new Logger();
        logger.CreateLogFile();

        public Form1()
        {
            InitializeComponent();
            Logger.WriteToLog("                       App was Launched");
            Logger.WriteToLog(" ");
            Logger.WriteToLog("               Player in champion creation window");
        }

        static Random random = new Random();
        public Champions Mychampion = new Champions("My champion");
        public Champions Enemychampion = new Champions("Enymy champion");



        private void PlayerPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textProgressBar1_Click(object sender, EventArgs e)
        {

        }


        private void PlayerName_Click(object sender, EventArgs e)
        {

        }

        private void ActionLabel_Click(object sender, EventArgs e)
        {
            
        }

        public void Attackbtn_Click(object sender, EventArgs e)
        {
            if (Mychampion.HealthPoints > 0)
            {
                int attack = Mychampion.Attack(Enemychampion);
                textBoxCanvas.SelectionColor = Color.White;
                textBoxCanvas.AppendText(Mychampion.Name + " atacked " + Enemychampion.Name + " for " + attack + " damage");
                Logger.Writelog(Mychampion.Name + " atacked " + Enemychampion.Name + " for " + attack + " damage");
                textBoxCanvas.AppendText(Environment.NewLine);
                labelEnemychampionHealthPoints.Text = "Health Points: " + Enemychampion.HealthPoints;
                Logger.Writelog("Enemy has " + Enemychampion.HealthPoints + " Health Points");
            }


            int Surrender = random.Next(1, 100);
            if (Enemychampion.HealthPoints <= random.Next(1, 500) && Surrender <= 5)
            {
                Enemychampion.HealthPoints = 0;
                labelEnemychampionHealthPoints.Text = "Health Points: " + Enemychampion.HealthPoints;
                textBoxCanvas.SelectionColor = Color.White;
                textBoxCanvas.AppendText(Enemychampion.Name + " surrender");
                textBoxCanvas.AppendText(Environment.NewLine);
                textBoxCanvas.SelectionColor = Color.Blue;
                textBoxCanvas.AppendText(Mychampion.Name + " Won");
                textBoxCanvas.AppendText(Environment.NewLine);
                textBoxCanvas.SelectionColor = Color.Red;
                textBoxCanvas.AppendText("GAME OVER");
                Enemychampion.HealthPoints = 0;
                Logger.Writelog(Enemychampion.Name + " surrender");
                Logger.Writelog(Mychampion.Name + " champion left with " + Mychampion.HealthPoints + " Health Points");
                Logger.Writelog("GAME OVER");
                Logger.Writelog("-------------------------Player Won-------------------------");

                // TextBox scroll to bottom

                textBoxCanvas.SelectionStart = textBoxCanvas.Text.Length;
                textBoxCanvas.ScrollToCaret();

                Resetbtn.Visible = true;
                Attackbtn.Visible = false;
                Healbtn.Visible = false;
                Surrenderbtn.Visible = false;
            }

            int DecideThenUseHeal = random.Next(1, 100);
            if (Enemychampion.HealthPoints < DecideThenUseHeal)
            {
                int EnemyHeal = random.Next(1, 150);
                Enemychampion.HealthPoints += EnemyHeal;
                textBoxCanvas.SelectionColor = Color.White;
                textBoxCanvas.AppendText(Enemychampion.Name + " healed him self " + EnemyHeal + " Health");
                Logger.Writelog(Enemychampion.Name + " healed him self " + EnemyHeal + " Health");
                textBoxCanvas.AppendText(Environment.NewLine);
                labelEnemychampionHealthPoints.Text = "Health Points: " + Enemychampion.HealthPoints;
                Logger.Writelog("After Heal " + Enemychampion.Name + " has " + Enemychampion.HealthPoints + " Health Points");

            }
            else if (Enemychampion.HealthPoints > 0)
            {
                int attack = Enemychampion.Attack(Mychampion);
                textBoxCanvas.SelectionColor = Color.White;
                textBoxCanvas.AppendText(Enemychampion.Name + " atacked " + Mychampion.Name + " champion for " + attack + " damage");
                Logger.Writelog(Enemychampion.Name + " atacked " + Mychampion.Name + " champion for " + attack + " damage");
                textBoxCanvas.AppendText(Environment.NewLine);
                labelMyHealthPoints.Text = "Health Points: " + Mychampion.HealthPoints;
                Logger.Writelog(Mychampion.Name + " champion has " + Mychampion.HealthPoints + " Health Points");
            }

            // TextBox scroll to bottom

            textBoxCanvas.SelectionStart = textBoxCanvas.Text.Length;
            textBoxCanvas.ScrollToCaret();

            if (Mychampion.HealthPoints < 0 || Enemychampion.HealthPoints < 0)
            {
                textBoxCanvas.SelectionColor = Color.Red;
                textBoxCanvas.AppendText("GAME OVER");
                textBoxCanvas.AppendText(Environment.NewLine);
                if (Enemychampion.HealthPoints < 0)
                {
                    textBoxCanvas.SelectionColor = Color.Blue;
                    textBoxCanvas.AppendText("YOU WON");
                    Logger.Writelog("");
                    Logger.Writelog("Player left alive with " + Mychampion.HealthPoints + " Health Points after Enemy was defeated!");
                    Logger.Writelog("GAME OVER");
                    Logger.Writelog("-------------------------Player Won-------------------------");
                    Logger.Writelog(" ");

                }
                else if (Mychampion.HealthPoints < 0)
                {
                    textBoxCanvas.SelectionColor = Color.Red;
                    textBoxCanvas.AppendText("YOU LOST");
                    Logger.Writelog("");
                    Logger.Writelog("Enemy left alive with " + Enemychampion.HealthPoints + " Health Points after Player was defeated!");
                    Logger.Writelog("GAME OVER");
                    Logger.Writelog("-------------------------Player Lost-------------------------");
                    Logger.Writelog(" ");
                }
                Attackbtn.Visible = false;
                Healbtn.Visible = false;
                Surrenderbtn.Visible = false;
                Resetbtn.Visible = true;
            }
        }

        private void Runbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        public void SetUpGame()
        {
            
        }

        private void labelMyHealthPoints_Click(object sender, EventArgs e)
        {

        }

        public void Stuff()
        {
            Mychampion.SetStats();
            int randomEnemychampionClass = random.Next(1, 3 + 1);
            switch (randomEnemychampionClass)
            {
                case 1:
                    Enemychampion = new Knight("Enemy champion");
                    this.championImage.BackgroundImage = global::WinForms_TBG.Properties.Resources.knightss;
                    Logger.Writelog("Enemy picked Knight as his champion class");
                    Logger.Writelog("Enemy champion starting with: " + Enemychampion.HealthPoints + " Health Points");
                    Logger.Writelog("");
                    break;
                case 2:
                    Enemychampion = new Assassin("Enemy champion");
                    this.championImage.BackgroundImage = global::WinForms_TBG.Properties.Resources.assas;
                    Logger.Writelog("Enemy picked Assassin as his champion class");
                    Logger.Writelog("Enemy champion starting with: " + Enemychampion.HealthPoints + " Health Points");
                    Logger.Writelog("");
                    break;
                case 3:
                    Enemychampion = new Mage("Enemy champion");
                    this.championImage.BackgroundImage = global::WinForms_TBG.Properties.Resources.mage;
                    Logger.Writelog("Enemy picked Mage as his champion class");
                    Logger.Writelog("Enemy champion starting with: " + Enemychampion.HealthPoints + " Health Points");
                    Logger.Writelog("");
                    break;
            }
            Enemychampion.SetStats();

            buttonClassInformation.Visible = false;
            ButtonStartGame.Visible = false;
            labelPlayerName.Visible = false;
            labelChampionClass.Visible = false;
            TextBoxPlayerName.Visible = false;
            ComboBoxChampionClass.Visible = false;
            Resetbtn.Visible = false;

            labelEnemychampionHealthPoints.Visible = true;
            labelEnemychampionClass.Visible = true;
            textBoxCanvas.Visible = true;
            PlayerPanel.Visible = true;
            MovePanel.Visible = true;
            Attackbtn.Visible = true;
            Surrenderbtn.Visible = true;
            Healbtn.Visible = true;
            championImage.Visible = true;

            labelMyHealthPoints.Text = "Health Points: " + Mychampion.HealthPoints;
            labelMychampionClass.Text = "Class: " + Mychampion.GetType().Name;
            labelEnemychampionHealthPoints.Text = "Health Points: " + Enemychampion.HealthPoints;
            labelEnemychampionClass.Text = "Class: " + Enemychampion.GetType().Name;
            textBoxCanvas.AppendText(Mychampion.Name + " You going first");
            textBoxCanvas.AppendText(Environment.NewLine);
        }

        public void ButtonStartGame_Click(object sender, EventArgs e)
        {
            if (TextBoxPlayerName.Text == "" && ComboBoxChampionClass.SelectedItem == null)
            {
                MessageBox.Show("Please choose a name and class!");
                Logger.Writelog("Start Button was Clicked but not choose name and class so game wasn't started");
            }
            else if (TextBoxPlayerName.Text == "")
            {
                MessageBox.Show("Please choose a name!");
                Logger.Writelog("Start Button was Clicked but not choose name so game wasn't started");
            }
            else
            {
                switch (ComboBoxChampionClass.Text)
                {
                    case "Knight":
                        Mychampion = new Knight(TextBoxPlayerName.Text);
                        MessageBox.Show("Hi " + Mychampion.Name + " you choose the Knight class for your champion!");

                        Logger.Writelog("-------------------------Game Starting-------------------------");
                        Logger.Writelog("");
                        Logger.Writelog("Player " + Mychampion.Name + " picked Knight class for his champion");
                        Logger.Writelog(Mychampion.Name + " champion starting with: " + Mychampion.HealthPoints + " Health Points");
                        Logger.Writelog(" ");
                        Stuff();
                        break;
                    case "Assassin":
                        Mychampion = new Assassin(TextBoxPlayerName.Text);
                        Logger.Writelog("-------------------------Game Starting-------------------------");
                        Logger.Writelog("");
                        MessageBox.Show("Hi " + Mychampion.Name + " you choose the Assassin class for your champion!");
                        Logger.Writelog("Player " + Mychampion.Name + " picked Assassin class for his champion");
                        Logger.Writelog(Mychampion.Name + " champion starting with: " + Mychampion.HealthPoints + " Health Points");
                        Logger.Writelog(" ");
                        Stuff();
                        break;
                    case "Mage":
                        Mychampion = new Mage(TextBoxPlayerName.Text);
                        MessageBox.Show("Hi " + Mychampion.Name + " you choose the Mage class for your champion!");
                        Logger.Writelog("-------------------------Game Starting-------------------------");
                        Logger.Writelog("");
                        Logger.Writelog("Player " + Mychampion.Name + " picked Mage as his champion class for your champion");
                        Logger.Writelog(Mychampion.Name + " champion starting with: " + Mychampion.HealthPoints + " Health Points");
                        Logger.Writelog(" ");
                        Stuff();
                        break;
                    default:
                        MessageBox.Show("Please go back and choose a class!");
                        Logger.Writelog("Start Button was Clicked but not choose class so game wasn't started");
                        break;
                }
            }
        }

        private void labelEnemychampionClass_Click(object sender, EventArgs e)
        {

        }

        private void labelEnemychampionHealthPoints_Click(object sender, EventArgs e)
        {

        }

        private void labelMychampionClass_Click(object sender, EventArgs e)
        {

        }

        private void buttonClassInformation_Click(object sender, EventArgs e)
        {
            Logger.Writelog("                Clicked Class Information Button");
            Logger.Writelog(" ");
            String output = string.Format("Knight: {0}" +
                                          "Defending: Chance to block and receive no damage and even gain some health.{0}" +
                                          "Attacking: Chance to do 200% damage.{0}{0}" +
                                          "Assassin: {0}" +
                                          "Attacking: Chance to do 300% damage.{0}{0}" +
                                          "Mage: {0}" +
                                          "Attacking: Chance to do 200% damage.{0}" +
                                          "Defending: Chance to put on a spell and take 50% damage."
                                          , Environment.NewLine);
            Logger.Writelog(output);
            Logger.Writelog("Class Information was closed");
            MessageBox.Show(output);
        }

        private void championImage_Click(object sender, EventArgs e)
        {
            
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            buttonClassInformation.Visible = true;
            ButtonStartGame.Visible = true;
            labelPlayerName.Visible = true;
            labelChampionClass.Visible = true;
            TextBoxPlayerName.Visible = true;
            ComboBoxChampionClass.Visible = true;

            labelEnemychampionHealthPoints.Visible = false;
            labelEnemychampionClass.Visible = false;
            textBoxCanvas.Visible = false;
            PlayerPanel.Visible = false;
            MovePanel.Visible = false;
            championImage.Visible = false;

            Attackbtn.Enabled = true;
            textBoxCanvas.Clear();
            ComboBoxChampionClass.ResetText();
            TextBoxPlayerName.Clear();
            Logger.Writelog("Clicked Reset button and moved to creation window");
        }

        private void Healbtn_Click(object sender, EventArgs e)
        {
            if (Mychampion.HealthPoints > 0)
            {
                int PlayerHeal = random.Next(1, 150);
                Mychampion.HealthPoints += PlayerHeal;
                textBoxCanvas.SelectionColor = Color.White;
                textBoxCanvas.AppendText(Mychampion.Name + " healed him self " + PlayerHeal + " Health");
                Logger.Writelog(Mychampion.Name + " healed him self " + PlayerHeal + " Health");
                textBoxCanvas.AppendText(Environment.NewLine);
                labelMyHealthPoints.Text = "Health Points: " + Mychampion.HealthPoints;
                Logger.Writelog("After Heal " + Mychampion.Name + " has " + Mychampion.HealthPoints + " Health Points");
            }

            if (Enemychampion.HealthPoints > 0)
            {
                int Surrender = random.Next(1, 100);
                int DecideThenUseHeal = random.Next(50, 400);
                if (Enemychampion.HealthPoints <= random.Next(1, 500) && Surrender <= 5)
                {
                    Enemychampion.HealthPoints = 0;
                    labelEnemychampionHealthPoints.Text = "Health Points: " + Enemychampion.HealthPoints;
                    textBoxCanvas.SelectionColor = Color.White;
                    textBoxCanvas.AppendText(Enemychampion.Name + " surrender");
                    textBoxCanvas.AppendText(Environment.NewLine);
                    textBoxCanvas.SelectionColor = Color.Blue;
                    textBoxCanvas.AppendText(Mychampion.Name + " Won");
                    textBoxCanvas.AppendText(Environment.NewLine);
                    textBoxCanvas.SelectionColor = Color.Red;
                    textBoxCanvas.AppendText("GAME OVER");
                    Enemychampion.HealthPoints = 0;
                    Logger.Writelog(Enemychampion.Name + " surrender");
                    Logger.Writelog(Mychampion.Name + " champion left with " + Mychampion.HealthPoints + " Health Points");
                    Logger.Writelog("GAME OVER");
                    Logger.Writelog("-------------------------Player Won-------------------------");

                    // TextBox scroll to bottom

                    textBoxCanvas.SelectionStart = textBoxCanvas.Text.Length;
                    textBoxCanvas.ScrollToCaret();

                    Resetbtn.Visible = true;
                    Attackbtn.Visible = false;
                    Healbtn.Visible = false;
                    Surrenderbtn.Visible = false;
                }
                if(Enemychampion.HealthPoints < DecideThenUseHeal)
                {
                    int EnemyHeal = random.Next(1, 150);
                    Enemychampion.HealthPoints += EnemyHeal;
                    textBoxCanvas.SelectionColor = Color.White;
                    textBoxCanvas.AppendText(Enemychampion.Name + " healed him self " + EnemyHeal + " Health");
                    Logger.Writelog(Enemychampion.Name + " healed him self " + EnemyHeal + " Health");
                    textBoxCanvas.AppendText(Environment.NewLine);
                    labelEnemychampionHealthPoints.Text = "Health Points: " + Enemychampion.HealthPoints;
                    Logger.Writelog("After Heal " + Enemychampion.Name + " has " + Enemychampion.HealthPoints + " Health Points");

                }
                else
                {
                    int attack = Enemychampion.Attack(Mychampion);
                    textBoxCanvas.SelectionColor = Color.White;
                    textBoxCanvas.AppendText(Enemychampion.Name + " atacked " + Mychampion.Name + " champion for " + attack + " damage");
                    Logger.Writelog(Enemychampion.Name + " atacked " + Mychampion.Name + " champion for " + attack + " damage");
                    textBoxCanvas.AppendText(Environment.NewLine);
                    labelMyHealthPoints.Text = "Health Points: " + Mychampion.HealthPoints;
                    Logger.Writelog(Mychampion.Name + " champion has " + Mychampion.HealthPoints + " Health Points");
                }
            }

            // TextBox scroll to bottom

            textBoxCanvas.SelectionStart = textBoxCanvas.Text.Length;
            textBoxCanvas.ScrollToCaret();

            if (Mychampion.HealthPoints < 0 || Enemychampion.HealthPoints < 0)
            {
                textBoxCanvas.SelectionColor = Color.Red;
                textBoxCanvas.AppendText("GAME OVER");
                textBoxCanvas.AppendText(Environment.NewLine);
                if (Enemychampion.HealthPoints < 0)
                {
                    textBoxCanvas.SelectionColor = Color.Blue;
                    textBoxCanvas.AppendText("YOU WON");
                    Logger.Writelog("");
                    Logger.Writelog("Player left alive with " + Mychampion.HealthPoints + " Health Points after Enemy was defeated!");
                    Logger.Writelog("GAME OVER");
                    Logger.Writelog("-------------------------Player Won-------------------------");
                    Logger.Writelog(" ");

                }
                else if (Mychampion.HealthPoints < 0)
                {
                    textBoxCanvas.SelectionColor = Color.Red;
                    textBoxCanvas.AppendText("YOU LOST");
                    Logger.Writelog("");
                    Logger.Writelog("Enemy left alive with " + Enemychampion.HealthPoints + " Health Points after Player was defeated!");
                    Logger.Writelog("GAME OVER");
                    Logger.Writelog("-------------------------Player Lost-------------------------");
                    Logger.Writelog(" ");
                }
                Attackbtn.Visible = false;
                Healbtn.Visible = false;
                Surrenderbtn.Visible = false;
                Resetbtn.Visible = true;
            }
        }

        private void Surrenderbtn_Click(object sender, EventArgs e)
        {
            Mychampion.HealthPoints = 0;
            labelMyHealthPoints.Text = "Health Points: " + Mychampion.HealthPoints;
            textBoxCanvas.SelectionColor = Color.White;
            textBoxCanvas.AppendText(Mychampion.Name + " surrender");
            textBoxCanvas.AppendText(Environment.NewLine);
            textBoxCanvas.SelectionColor = Color.Red;
            textBoxCanvas.AppendText(Mychampion.Name +" Lost");
            textBoxCanvas.AppendText(Environment.NewLine);
            textBoxCanvas.SelectionColor = Color.Red;
            textBoxCanvas.AppendText("GAME OVER");
            Mychampion.HealthPoints = 0;
            Logger.Writelog(Mychampion.Name + " surrender");
            Logger.Writelog("Enemy left with " + Enemychampion.HealthPoints + " Health Points");
            Logger.Writelog("GAME OVER");
            Logger.Writelog("-------------------------Player Lost-------------------------");

            // TextBox scroll to bottom

            textBoxCanvas.SelectionStart = textBoxCanvas.Text.Length;
            textBoxCanvas.ScrollToCaret();

            Resetbtn.Visible = true;
            Attackbtn.Visible = false;
            Healbtn.Visible = false;
            Surrenderbtn.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
                Logger.Writelog("                       App was Closed");
            else
                Logger.Writelog("                       App was Closed");
        }
    }
}