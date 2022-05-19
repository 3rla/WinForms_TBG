namespace WinForms_TBG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.championImage = new System.Windows.Forms.PictureBox();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.labelMyHealthPoints = new System.Windows.Forms.Label();
            this.labelMychampionClass = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.ButtonStartGame = new System.Windows.Forms.Button();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.Surrenderbtn = new System.Windows.Forms.Button();
            this.Healbtn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Attackbtn = new System.Windows.Forms.Button();
            this.buttonClassInformation = new System.Windows.Forms.Button();
            this.labelEnemychampionHealthPoints = new System.Windows.Forms.Label();
            this.textBoxCanvas = new System.Windows.Forms.RichTextBox();
            this.labelEnemychampionClass = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.TextBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelChampionClass = new System.Windows.Forms.Label();
            this.ComboBoxChampionClass = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.championImage)).BeginInit();
            this.PlayerPanel.SuspendLayout();
            this.MovePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // championImage
            // 
            this.championImage.BackColor = System.Drawing.Color.Transparent;
            this.championImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.championImage.Location = new System.Drawing.Point(279, 99);
            this.championImage.Name = "championImage";
            this.championImage.Size = new System.Drawing.Size(234, 191);
            this.championImage.TabIndex = 1;
            this.championImage.TabStop = false;
            this.championImage.Click += new System.EventHandler(this.championImage_Click);
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlayerPanel.Controls.Add(this.labelMyHealthPoints);
            this.PlayerPanel.Controls.Add(this.labelMychampionClass);
            this.PlayerPanel.Controls.Add(this.PlayerName);
            this.PlayerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayerPanel.Location = new System.Drawing.Point(0, 398);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(800, 52);
            this.PlayerPanel.TabIndex = 6;
            this.PlayerPanel.Visible = false;
            this.PlayerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayerPanel_Paint);
            // 
            // labelMyHealthPoints
            // 
            this.labelMyHealthPoints.AutoSize = true;
            this.labelMyHealthPoints.BackColor = System.Drawing.Color.Transparent;
            this.labelMyHealthPoints.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMyHealthPoints.ForeColor = System.Drawing.Color.LightCoral;
            this.labelMyHealthPoints.Location = new System.Drawing.Point(297, 12);
            this.labelMyHealthPoints.Name = "labelMyHealthPoints";
            this.labelMyHealthPoints.Size = new System.Drawing.Size(173, 32);
            this.labelMyHealthPoints.TabIndex = 2;
            this.labelMyHealthPoints.Text = "Health Points:";
            this.labelMyHealthPoints.Click += new System.EventHandler(this.labelMyHealthPoints_Click);
            // 
            // labelMychampionClass
            // 
            this.labelMychampionClass.AutoSize = true;
            this.labelMychampionClass.BackColor = System.Drawing.Color.Transparent;
            this.labelMychampionClass.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMychampionClass.ForeColor = System.Drawing.Color.White;
            this.labelMychampionClass.Location = new System.Drawing.Point(591, 11);
            this.labelMychampionClass.Name = "labelMychampionClass";
            this.labelMychampionClass.Size = new System.Drawing.Size(78, 32);
            this.labelMychampionClass.TabIndex = 1;
            this.labelMychampionClass.Text = "Class:";
            this.labelMychampionClass.Click += new System.EventHandler(this.labelMychampionClass_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.BackColor = System.Drawing.Color.Transparent;
            this.PlayerName.Font = new System.Drawing.Font("NESCyrillic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PlayerName.Location = new System.Drawing.Point(77, 6);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(181, 38);
            this.PlayerName.TabIndex = 0;
            this.PlayerName.Text = "Player";
            this.PlayerName.Click += new System.EventHandler(this.PlayerName_Click);
            // 
            // ButtonStartGame
            // 
            this.ButtonStartGame.BackColor = System.Drawing.Color.Black;
            this.ButtonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStartGame.Font = new System.Drawing.Font("NESCyrillic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonStartGame.ForeColor = System.Drawing.Color.White;
            this.ButtonStartGame.Location = new System.Drawing.Point(279, 350);
            this.ButtonStartGame.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonStartGame.Name = "ButtonStartGame";
            this.ButtonStartGame.Size = new System.Drawing.Size(183, 42);
            this.ButtonStartGame.TabIndex = 14;
            this.ButtonStartGame.Text = "Start Game";
            this.ButtonStartGame.UseVisualStyleBackColor = false;
            this.ButtonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MovePanel.Controls.Add(this.Surrenderbtn);
            this.MovePanel.Controls.Add(this.Healbtn);
            this.MovePanel.Controls.Add(this.Resetbtn);
            this.MovePanel.Controls.Add(this.Attackbtn);
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(800, 54);
            this.MovePanel.TabIndex = 7;
            this.MovePanel.Visible = false;
            // 
            // Surrenderbtn
            // 
            this.Surrenderbtn.BackColor = System.Drawing.Color.Black;
            this.Surrenderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Surrenderbtn.Font = new System.Drawing.Font("NESCyrillic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Surrenderbtn.ForeColor = System.Drawing.Color.White;
            this.Surrenderbtn.Location = new System.Drawing.Point(502, 6);
            this.Surrenderbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Surrenderbtn.Name = "Surrenderbtn";
            this.Surrenderbtn.Size = new System.Drawing.Size(159, 42);
            this.Surrenderbtn.TabIndex = 21;
            this.Surrenderbtn.Text = "Surrender";
            this.Surrenderbtn.UseVisualStyleBackColor = false;
            this.Surrenderbtn.Click += new System.EventHandler(this.Surrenderbtn_Click);
            // 
            // Healbtn
            // 
            this.Healbtn.BackColor = System.Drawing.Color.Black;
            this.Healbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Healbtn.Font = new System.Drawing.Font("NESCyrillic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Healbtn.ForeColor = System.Drawing.Color.White;
            this.Healbtn.Location = new System.Drawing.Point(331, 6);
            this.Healbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Healbtn.Name = "Healbtn";
            this.Healbtn.Size = new System.Drawing.Size(159, 42);
            this.Healbtn.TabIndex = 20;
            this.Healbtn.Text = "Heal";
            this.Healbtn.UseVisualStyleBackColor = false;
            this.Healbtn.Click += new System.EventHandler(this.Healbtn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.Black;
            this.Resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resetbtn.Font = new System.Drawing.Font("NESCyrillic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Resetbtn.ForeColor = System.Drawing.Color.White;
            this.Resetbtn.Location = new System.Drawing.Point(331, 6);
            this.Resetbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(159, 42);
            this.Resetbtn.TabIndex = 19;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Attackbtn
            // 
            this.Attackbtn.BackColor = System.Drawing.Color.Black;
            this.Attackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attackbtn.Font = new System.Drawing.Font("NESCyrillic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Attackbtn.ForeColor = System.Drawing.Color.White;
            this.Attackbtn.Location = new System.Drawing.Point(160, 6);
            this.Attackbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Attackbtn.Name = "Attackbtn";
            this.Attackbtn.Size = new System.Drawing.Size(159, 42);
            this.Attackbtn.TabIndex = 3;
            this.Attackbtn.Text = "ATTACK";
            this.Attackbtn.UseVisualStyleBackColor = false;
            this.Attackbtn.Click += new System.EventHandler(this.Attackbtn_Click);
            // 
            // buttonClassInformation
            // 
            this.buttonClassInformation.BackColor = System.Drawing.Color.Black;
            this.buttonClassInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClassInformation.Font = new System.Drawing.Font("NESCyrillic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClassInformation.ForeColor = System.Drawing.Color.White;
            this.buttonClassInformation.Location = new System.Drawing.Point(297, 296);
            this.buttonClassInformation.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClassInformation.Name = "buttonClassInformation";
            this.buttonClassInformation.Size = new System.Drawing.Size(140, 42);
            this.buttonClassInformation.TabIndex = 2;
            this.buttonClassInformation.Text = "Classes";
            this.buttonClassInformation.UseVisualStyleBackColor = false;
            this.buttonClassInformation.Click += new System.EventHandler(this.buttonClassInformation_Click);
            // 
            // labelEnemychampionHealthPoints
            // 
            this.labelEnemychampionHealthPoints.AutoSize = true;
            this.labelEnemychampionHealthPoints.BackColor = System.Drawing.Color.Transparent;
            this.labelEnemychampionHealthPoints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnemychampionHealthPoints.ForeColor = System.Drawing.Color.LightCoral;
            this.labelEnemychampionHealthPoints.Location = new System.Drawing.Point(279, 75);
            this.labelEnemychampionHealthPoints.Name = "labelEnemychampionHealthPoints";
            this.labelEnemychampionHealthPoints.Size = new System.Drawing.Size(117, 21);
            this.labelEnemychampionHealthPoints.TabIndex = 11;
            this.labelEnemychampionHealthPoints.Text = "Health Points:";
            this.labelEnemychampionHealthPoints.Visible = false;
            this.labelEnemychampionHealthPoints.Click += new System.EventHandler(this.labelEnemychampionHealthPoints_Click);
            // 
            // textBoxCanvas
            // 
            this.textBoxCanvas.BackColor = System.Drawing.Color.Black;
            this.textBoxCanvas.Font = new System.Drawing.Font("NESCyrillic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCanvas.ForeColor = System.Drawing.Color.White;
            this.textBoxCanvas.Location = new System.Drawing.Point(29, 296);
            this.textBoxCanvas.Name = "textBoxCanvas";
            this.textBoxCanvas.Size = new System.Drawing.Size(738, 96);
            this.textBoxCanvas.TabIndex = 12;
            this.textBoxCanvas.Text = "";
            this.textBoxCanvas.Visible = false;
            // 
            // labelEnemychampionClass
            // 
            this.labelEnemychampionClass.AutoSize = true;
            this.labelEnemychampionClass.BackColor = System.Drawing.Color.Transparent;
            this.labelEnemychampionClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnemychampionClass.ForeColor = System.Drawing.Color.White;
            this.labelEnemychampionClass.Location = new System.Drawing.Point(461, 75);
            this.labelEnemychampionClass.Name = "labelEnemychampionClass";
            this.labelEnemychampionClass.Size = new System.Drawing.Size(52, 21);
            this.labelEnemychampionClass.TabIndex = 13;
            this.labelEnemychampionClass.Text = "Class:";
            this.labelEnemychampionClass.Visible = false;
            this.labelEnemychampionClass.Click += new System.EventHandler(this.labelEnemychampionClass_Click);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerName.Font = new System.Drawing.Font("NESCyrillic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerName.ForeColor = System.Drawing.Color.White;
            this.labelPlayerName.Location = new System.Drawing.Point(177, 99);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(96, 23);
            this.labelPlayerName.TabIndex = 15;
            this.labelPlayerName.Text = "Name: ";
            // 
            // TextBoxPlayerName
            // 
            this.TextBoxPlayerName.Font = new System.Drawing.Font("NESCyrillic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPlayerName.Location = new System.Drawing.Point(271, 99);
            this.TextBoxPlayerName.Name = "TextBoxPlayerName";
            this.TextBoxPlayerName.Size = new System.Drawing.Size(242, 34);
            this.TextBoxPlayerName.TabIndex = 16;
            // 
            // labelChampionClass
            // 
            this.labelChampionClass.AutoSize = true;
            this.labelChampionClass.BackColor = System.Drawing.Color.Transparent;
            this.labelChampionClass.Font = new System.Drawing.Font("NESCyrillic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChampionClass.ForeColor = System.Drawing.Color.White;
            this.labelChampionClass.Location = new System.Drawing.Point(160, 148);
            this.labelChampionClass.Name = "labelChampionClass";
            this.labelChampionClass.Size = new System.Drawing.Size(113, 23);
            this.labelChampionClass.TabIndex = 17;
            this.labelChampionClass.Text = "Class: ";
            // 
            // ComboBoxChampionClass
            // 
            this.ComboBoxChampionClass.Font = new System.Drawing.Font("NESCyrillic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxChampionClass.FormattingEnabled = true;
            this.ComboBoxChampionClass.Items.AddRange(new object[] {
            "Knight",
            "Assassin",
            "Mage"});
            this.ComboBoxChampionClass.Location = new System.Drawing.Point(271, 148);
            this.ComboBoxChampionClass.Name = "ComboBoxChampionClass";
            this.ComboBoxChampionClass.Size = new System.Drawing.Size(242, 31);
            this.ComboBoxChampionClass.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForms_TBG.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBoxChampionClass);
            this.Controls.Add(this.buttonClassInformation);
            this.Controls.Add(this.labelChampionClass);
            this.Controls.Add(this.TextBoxPlayerName);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.ButtonStartGame);
            this.Controls.Add(this.labelEnemychampionClass);
            this.Controls.Add(this.textBoxCanvas);
            this.Controls.Add(this.labelEnemychampionHealthPoints);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.PlayerPanel);
            this.Controls.Add(this.championImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.championImage)).EndInit();
            this.PlayerPanel.ResumeLayout(false);
            this.PlayerPanel.PerformLayout();
            this.MovePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox championImage;
        private Panel PlayerPanel;
        private Label PlayerName;
        private Panel MovePanel;
        private Button buttonClassInformation;
        private Button Attackbtn;
        private Label labelEnemychampionHealthPoints;
        private RichTextBox textBoxCanvas;
        private Label labelMyHealthPoints;
        private Label labelMychampionClass;
        private Label labelEnemychampionClass;
        private Button ButtonStartGame;
        private Label labelPlayerName;
        private TextBox TextBoxPlayerName;
        private Label labelChampionClass;
        private ComboBox ComboBoxChampionClass;
        private Button Resetbtn;
        private Button Healbtn;
        private Button Surrenderbtn;
    }
}