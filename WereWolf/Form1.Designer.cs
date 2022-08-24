
namespace WereWolf
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRace = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.pcbWolf = new System.Windows.Forms.PictureBox();
            this.lblCreatureHealth = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblAccountRace = new System.Windows.Forms.Label();
            this.lblAccountUserName = new System.Windows.Forms.Label();
            this.lblAccountBranch = new System.Windows.Forms.Label();
            this.lblAccountWeapon = new System.Windows.Forms.Label();
            this.lblFight = new System.Windows.Forms.Label();
            this.lblVs = new System.Windows.Forms.Label();
            this.cmbWeapon = new System.Windows.Forms.ComboBox();
            this.lblAccountHealth = new System.Windows.Forms.Label();
            this.lblAccountMobility = new System.Windows.Forms.Label();
            this.lblAccountDamage = new System.Windows.Forms.Label();
            this.btnCreatureAttack = new System.Windows.Forms.Button();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblCreatureName = new System.Windows.Forms.Label();
            this.lblCreatureAttack = new System.Windows.Forms.Label();
            this.lblCreatureMobility = new System.Windows.Forms.Label();
            this.lblCreatureTextHealth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWolf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRace.Location = new System.Drawing.Point(91, 70);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(29, 24);
            this.lblRace.TabIndex = 0;
            this.lblRace.Text = "Irk";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(91, 44);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 24);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Kullanıcı Adı";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBranch.Location = new System.Drawing.Point(91, 94);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(58, 24);
            this.lblBranch.TabIndex = 0;
            this.lblBranch.Text = "Branş";
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeapon.Location = new System.Drawing.Point(91, 120);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(51, 24);
            this.lblWeapon.TabIndex = 0;
            this.lblWeapon.Text = "Silah";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(210, 46);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(199, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Cüce",
            "Ork",
            "Lizard",
            "Undeath"});
            this.cmbRace.Location = new System.Drawing.Point(210, 70);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(199, 21);
            this.cmbRace.TabIndex = 2;
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Items.AddRange(new object[] {
            "Warior",
            "Mage",
            "Archer",
            "Rogue",
            "Brusier"});
            this.cmbBrans.Location = new System.Drawing.Point(210, 100);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(199, 21);
            this.cmbBrans.TabIndex = 2;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(432, 44);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(311, 100);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "seç";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // pcbWolf
            // 
            this.pcbWolf.Image = ((System.Drawing.Image)(resources.GetObject("pcbWolf.Image")));
            this.pcbWolf.Location = new System.Drawing.Point(743, 176);
            this.pcbWolf.Name = "pcbWolf";
            this.pcbWolf.Size = new System.Drawing.Size(300, 161);
            this.pcbWolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWolf.TabIndex = 4;
            this.pcbWolf.TabStop = false;
            this.pcbWolf.Visible = false;
            // 
            // lblCreatureHealth
            // 
            this.lblCreatureHealth.BackColor = System.Drawing.Color.DarkRed;
            this.lblCreatureHealth.Location = new System.Drawing.Point(743, 355);
            this.lblCreatureHealth.Name = "lblCreatureHealth";
            this.lblCreatureHealth.Size = new System.Drawing.Size(300, 32);
            this.lblCreatureHealth.TabIndex = 5;
            this.lblCreatureHealth.Visible = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAttack.Location = new System.Drawing.Point(99, 400);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(167, 63);
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "Saldır";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblAccountRace
            // 
            this.lblAccountRace.AutoSize = true;
            this.lblAccountRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccountRace.Location = new System.Drawing.Point(91, 100);
            this.lblAccountRace.Name = "lblAccountRace";
            this.lblAccountRace.Size = new System.Drawing.Size(29, 24);
            this.lblAccountRace.TabIndex = 0;
            this.lblAccountRace.Text = "Irk";
            this.lblAccountRace.Visible = false;
            // 
            // lblAccountUserName
            // 
            this.lblAccountUserName.AutoSize = true;
            this.lblAccountUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccountUserName.Location = new System.Drawing.Point(91, 76);
            this.lblAccountUserName.Name = "lblAccountUserName";
            this.lblAccountUserName.Size = new System.Drawing.Size(113, 24);
            this.lblAccountUserName.TabIndex = 0;
            this.lblAccountUserName.Text = "Kullanıcı Adı";
            this.lblAccountUserName.Visible = false;
            // 
            // lblAccountBranch
            // 
            this.lblAccountBranch.AutoSize = true;
            this.lblAccountBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccountBranch.Location = new System.Drawing.Point(91, 124);
            this.lblAccountBranch.Name = "lblAccountBranch";
            this.lblAccountBranch.Size = new System.Drawing.Size(58, 24);
            this.lblAccountBranch.TabIndex = 0;
            this.lblAccountBranch.Text = "Branş";
            this.lblAccountBranch.Visible = false;
            // 
            // lblAccountWeapon
            // 
            this.lblAccountWeapon.AutoSize = true;
            this.lblAccountWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccountWeapon.Location = new System.Drawing.Point(91, 148);
            this.lblAccountWeapon.Name = "lblAccountWeapon";
            this.lblAccountWeapon.Size = new System.Drawing.Size(51, 24);
            this.lblAccountWeapon.TabIndex = 0;
            this.lblAccountWeapon.Text = "Silah";
            this.lblAccountWeapon.Visible = false;
            // 
            // lblFight
            // 
            this.lblFight.AutoSize = true;
            this.lblFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFight.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFight.Location = new System.Drawing.Point(549, 9);
            this.lblFight.Margin = new System.Windows.Forms.Padding(0);
            this.lblFight.Name = "lblFight";
            this.lblFight.Size = new System.Drawing.Size(143, 46);
            this.lblFight.TabIndex = 7;
            this.lblFight.Text = "FIGHT";
            this.lblFight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFight.Visible = false;
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVs.Location = new System.Drawing.Point(578, 176);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(63, 39);
            this.lblVs.TabIndex = 8;
            this.lblVs.Text = "VS";
            this.lblVs.Visible = false;
            // 
            // cmbWeapon
            // 
            this.cmbWeapon.FormattingEnabled = true;
            this.cmbWeapon.Items.AddRange(new object[] {
            "Short Sword",
            "Long Sword",
            "Mace",
            "Staff",
            "Bow",
            "Dagger",
            "Balyoz",
            "Mace",
            "Throwable Knife",
            "Wand"});
            this.cmbWeapon.Location = new System.Drawing.Point(210, 129);
            this.cmbWeapon.Name = "cmbWeapon";
            this.cmbWeapon.Size = new System.Drawing.Size(199, 21);
            this.cmbWeapon.TabIndex = 9;
            // 
            // lblAccountHealth
            // 
            this.lblAccountHealth.AutoSize = true;
            this.lblAccountHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccountHealth.Location = new System.Drawing.Point(95, 176);
            this.lblAccountHealth.Name = "lblAccountHealth";
            this.lblAccountHealth.Size = new System.Drawing.Size(60, 24);
            this.lblAccountHealth.TabIndex = 10;
            this.lblAccountHealth.Text = "label1";
            this.lblAccountHealth.Visible = false;
            // 
            // lblAccountMobility
            // 
            this.lblAccountMobility.AutoSize = true;
            this.lblAccountMobility.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccountMobility.Location = new System.Drawing.Point(95, 204);
            this.lblAccountMobility.Name = "lblAccountMobility";
            this.lblAccountMobility.Size = new System.Drawing.Size(60, 24);
            this.lblAccountMobility.TabIndex = 11;
            this.lblAccountMobility.Text = "label1";
            this.lblAccountMobility.Visible = false;
            // 
            // lblAccountDamage
            // 
            this.lblAccountDamage.AutoSize = true;
            this.lblAccountDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccountDamage.Location = new System.Drawing.Point(95, 232);
            this.lblAccountDamage.Name = "lblAccountDamage";
            this.lblAccountDamage.Size = new System.Drawing.Size(60, 24);
            this.lblAccountDamage.TabIndex = 12;
            this.lblAccountDamage.Text = "label1";
            this.lblAccountDamage.Visible = false;
            // 
            // btnCreatureAttack
            // 
            this.btnCreatureAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreatureAttack.Location = new System.Drawing.Point(746, 400);
            this.btnCreatureAttack.Name = "btnCreatureAttack";
            this.btnCreatureAttack.Size = new System.Drawing.Size(167, 63);
            this.btnCreatureAttack.TabIndex = 13;
            this.btnCreatureAttack.Text = "Attack";
            this.btnCreatureAttack.UseVisualStyleBackColor = true;
            this.btnCreatureAttack.Visible = false;
            this.btnCreatureAttack.Click += new System.EventHandler(this.btnCreatureAttack_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.Green;
            this.lblHealth.Location = new System.Drawing.Point(96, 355);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(300, 32);
            this.lblHealth.TabIndex = 5;
            this.lblHealth.Visible = false;
            // 
            // lblCreatureName
            // 
            this.lblCreatureName.AutoSize = true;
            this.lblCreatureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreatureName.Location = new System.Drawing.Point(742, 46);
            this.lblCreatureName.Name = "lblCreatureName";
            this.lblCreatureName.Size = new System.Drawing.Size(122, 24);
            this.lblCreatureName.TabIndex = 14;
            this.lblCreatureName.Text = "WEREWOLF";
            this.lblCreatureName.Visible = false;
            // 
            // lblCreatureAttack
            // 
            this.lblCreatureAttack.AutoSize = true;
            this.lblCreatureAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreatureAttack.Location = new System.Drawing.Point(742, 76);
            this.lblCreatureAttack.Name = "lblCreatureAttack";
            this.lblCreatureAttack.Size = new System.Drawing.Size(60, 24);
            this.lblCreatureAttack.TabIndex = 15;
            this.lblCreatureAttack.Text = "label1";
            this.lblCreatureAttack.Visible = false;
            // 
            // lblCreatureMobility
            // 
            this.lblCreatureMobility.AutoSize = true;
            this.lblCreatureMobility.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreatureMobility.Location = new System.Drawing.Point(742, 100);
            this.lblCreatureMobility.Name = "lblCreatureMobility";
            this.lblCreatureMobility.Size = new System.Drawing.Size(60, 24);
            this.lblCreatureMobility.TabIndex = 16;
            this.lblCreatureMobility.Text = "label1";
            this.lblCreatureMobility.Visible = false;
            // 
            // lblCreatureTextHealth
            // 
            this.lblCreatureTextHealth.AutoSize = true;
            this.lblCreatureTextHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreatureTextHealth.Location = new System.Drawing.Point(742, 129);
            this.lblCreatureTextHealth.Name = "lblCreatureTextHealth";
            this.lblCreatureTextHealth.Size = new System.Drawing.Size(60, 24);
            this.lblCreatureTextHealth.TabIndex = 17;
            this.lblCreatureTextHealth.Text = "label1";
            this.lblCreatureTextHealth.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 556);
            this.Controls.Add(this.lblCreatureTextHealth);
            this.Controls.Add(this.lblCreatureMobility);
            this.Controls.Add(this.lblCreatureAttack);
            this.Controls.Add(this.lblCreatureName);
            this.Controls.Add(this.btnCreatureAttack);
            this.Controls.Add(this.lblAccountDamage);
            this.Controls.Add(this.lblAccountMobility);
            this.Controls.Add(this.lblAccountHealth);
            this.Controls.Add(this.cmbWeapon);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.lblFight);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblCreatureHealth);
            this.Controls.Add(this.pcbWolf);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblAccountWeapon);
            this.Controls.Add(this.lblWeapon);
            this.Controls.Add(this.lblAccountBranch);
            this.Controls.Add(this.lblAccountUserName);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblAccountRace);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblRace);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbWolf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.PictureBox pcbWolf;
        private System.Windows.Forms.Label lblCreatureHealth;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblAccountRace;
        private System.Windows.Forms.Label lblAccountUserName;
        private System.Windows.Forms.Label lblAccountBranch;
        private System.Windows.Forms.Label lblAccountWeapon;
        private System.Windows.Forms.Label lblFight;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.ComboBox cmbWeapon;
        private System.Windows.Forms.Label lblAccountHealth;
        private System.Windows.Forms.Label lblAccountMobility;
        private System.Windows.Forms.Label lblAccountDamage;
        private System.Windows.Forms.Button btnCreatureAttack;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblCreatureName;
        private System.Windows.Forms.Label lblCreatureAttack;
        private System.Windows.Forms.Label lblCreatureMobility;
        private System.Windows.Forms.Label lblCreatureTextHealth;
    }
}

