namespace Pizza_winForm
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
            this.button_betoltes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_faljbetoltes = new System.Windows.Forms.TextBox();
            this.listBox_pizza_menu = new System.Windows.Forms.ListBox();
            this.button_atlagar = new System.Windows.Forms.Button();
            this.groupBox_fizetes = new System.Windows.Forms.GroupBox();
            this.radioButton_kezpenz = new System.Windows.Forms.RadioButton();
            this.radioButton_bankkartya = new System.Windows.Forms.RadioButton();
            this.checkBox_szamla = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_hozzaadas = new System.Windows.Forms.Button();
            this.textBox_db = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_fizetesmegerosites = new System.Windows.Forms.Button();
            this.listBox_kosar = new System.Windows.Forms.ListBox();
            this.button_rendeles = new System.Windows.Forms.Button();
            this.textBox_vegosszeg = new System.Windows.Forms.TextBox();
            this.button_vegosszeg = new System.Windows.Forms.Button();
            this.groupBox_fizetes.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_betoltes
            // 
            this.button_betoltes.Location = new System.Drawing.Point(32, 108);
            this.button_betoltes.Margin = new System.Windows.Forms.Padding(6);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(150, 44);
            this.button_betoltes.TabIndex = 0;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = true;
            this.button_betoltes.Click += new System.EventHandler(this.button_betoltes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizzák betöltése";
            // 
            // textBox_faljbetoltes
            // 
            this.textBox_faljbetoltes.Location = new System.Drawing.Point(32, 58);
            this.textBox_faljbetoltes.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_faljbetoltes.Name = "textBox_faljbetoltes";
            this.textBox_faljbetoltes.Size = new System.Drawing.Size(196, 31);
            this.textBox_faljbetoltes.TabIndex = 2;
            // 
            // listBox_pizza_menu
            // 
            this.listBox_pizza_menu.FormattingEnabled = true;
            this.listBox_pizza_menu.ItemHeight = 25;
            this.listBox_pizza_menu.Location = new System.Drawing.Point(32, 165);
            this.listBox_pizza_menu.Margin = new System.Windows.Forms.Padding(6);
            this.listBox_pizza_menu.Name = "listBox_pizza_menu";
            this.listBox_pizza_menu.Size = new System.Drawing.Size(408, 504);
            this.listBox_pizza_menu.TabIndex = 3;
            this.listBox_pizza_menu.SelectedIndexChanged += new System.EventHandler(this.listBox_pizza_menu_SelectedIndexChanged);
            // 
            // button_atlagar
            // 
            this.button_atlagar.Location = new System.Drawing.Point(194, 798);
            this.button_atlagar.Margin = new System.Windows.Forms.Padding(6);
            this.button_atlagar.Name = "button_atlagar";
            this.button_atlagar.Size = new System.Drawing.Size(150, 44);
            this.button_atlagar.TabIndex = 4;
            this.button_atlagar.Text = "Átlagár";
            this.button_atlagar.UseVisualStyleBackColor = true;
            this.button_atlagar.Click += new System.EventHandler(this.button_atalagar);
            // 
            // groupBox_fizetes
            // 
            this.groupBox_fizetes.Controls.Add(this.radioButton_kezpenz);
            this.groupBox_fizetes.Controls.Add(this.radioButton_bankkartya);
            this.groupBox_fizetes.Location = new System.Drawing.Point(480, 58);
            this.groupBox_fizetes.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_fizetes.Name = "groupBox_fizetes";
            this.groupBox_fizetes.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_fizetes.Size = new System.Drawing.Size(400, 192);
            this.groupBox_fizetes.TabIndex = 5;
            this.groupBox_fizetes.TabStop = false;
            this.groupBox_fizetes.Text = "Mivel szeretne fizetni?";
            // 
            // radioButton_kezpenz
            // 
            this.radioButton_kezpenz.AutoSize = true;
            this.radioButton_kezpenz.Location = new System.Drawing.Point(14, 108);
            this.radioButton_kezpenz.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_kezpenz.Name = "radioButton_kezpenz";
            this.radioButton_kezpenz.Size = new System.Drawing.Size(127, 29);
            this.radioButton_kezpenz.TabIndex = 1;
            this.radioButton_kezpenz.TabStop = true;
            this.radioButton_kezpenz.Text = "Kézpénz";
            this.radioButton_kezpenz.UseVisualStyleBackColor = true;
            this.radioButton_kezpenz.CheckedChanged += new System.EventHandler(this.radioButton_kezpenz_CheckedChanged);
            // 
            // radioButton_bankkartya
            // 
            this.radioButton_bankkartya.AutoSize = true;
            this.radioButton_bankkartya.Location = new System.Drawing.Point(14, 50);
            this.radioButton_bankkartya.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_bankkartya.Name = "radioButton_bankkartya";
            this.radioButton_bankkartya.Size = new System.Drawing.Size(151, 29);
            this.radioButton_bankkartya.TabIndex = 0;
            this.radioButton_bankkartya.TabStop = true;
            this.radioButton_bankkartya.Text = "Bankkártya";
            this.radioButton_bankkartya.UseVisualStyleBackColor = true;
            this.radioButton_bankkartya.CheckedChanged += new System.EventHandler(this.radioButton_bankkartya_CheckedChanged);
            // 
            // checkBox_szamla
            // 
            this.checkBox_szamla.AutoSize = true;
            this.checkBox_szamla.Location = new System.Drawing.Point(480, 287);
            this.checkBox_szamla.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox_szamla.Name = "checkBox_szamla";
            this.checkBox_szamla.Size = new System.Drawing.Size(85, 29);
            this.checkBox_szamla.TabIndex = 6;
            this.checkBox_szamla.Text = "Igen";
            this.checkBox_szamla.UseVisualStyleBackColor = true;
            this.checkBox_szamla.CheckedChanged += new System.EventHandler(this.checkBox_szamla_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Szeretne számlát kérni, ha igen jelölje a négyzeten.";
            // 
            // button_hozzaadas
            // 
            this.button_hozzaadas.Location = new System.Drawing.Point(32, 798);
            this.button_hozzaadas.Margin = new System.Windows.Forms.Padding(6);
            this.button_hozzaadas.Name = "button_hozzaadas";
            this.button_hozzaadas.Size = new System.Drawing.Size(150, 44);
            this.button_hozzaadas.TabIndex = 9;
            this.button_hozzaadas.Text = "Hozzáadás";
            this.button_hozzaadas.UseVisualStyleBackColor = true;
            this.button_hozzaadas.Click += new System.EventHandler(this.button_hozzaadas_Click);
            // 
            // textBox_db
            // 
            this.textBox_db.Location = new System.Drawing.Point(32, 748);
            this.textBox_db.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_db.Name = "textBox_db";
            this.textBox_db.Size = new System.Drawing.Size(146, 31);
            this.textBox_db.TabIndex = 10;
            this.textBox_db.TextChanged += new System.EventHandler(this.textBox_db_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 712);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adja meg a darabszámot:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(964, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kosár";
            // 
            // button_fizetesmegerosites
            // 
            this.button_fizetesmegerosites.Location = new System.Drawing.Point(480, 331);
            this.button_fizetesmegerosites.Margin = new System.Windows.Forms.Padding(6);
            this.button_fizetesmegerosites.Name = "button_fizetesmegerosites";
            this.button_fizetesmegerosites.Size = new System.Drawing.Size(150, 44);
            this.button_fizetesmegerosites.TabIndex = 13;
            this.button_fizetesmegerosites.Text = "Megerősítés";
            this.button_fizetesmegerosites.UseVisualStyleBackColor = true;
            this.button_fizetesmegerosites.Click += new System.EventHandler(this.button_fizetesmegerosites_Click);
            // 
            // listBox_kosar
            // 
            this.listBox_kosar.FormattingEnabled = true;
            this.listBox_kosar.ItemHeight = 25;
            this.listBox_kosar.Location = new System.Drawing.Point(1046, 71);
            this.listBox_kosar.Margin = new System.Windows.Forms.Padding(6);
            this.listBox_kosar.Name = "listBox_kosar";
            this.listBox_kosar.Size = new System.Drawing.Size(526, 254);
            this.listBox_kosar.TabIndex = 14;
            this.listBox_kosar.SelectedIndexChanged += new System.EventHandler(this.listBox_kosar_SelectedIndexChanged);
            // 
            // button_rendeles
            // 
            this.button_rendeles.Location = new System.Drawing.Point(1046, 476);
            this.button_rendeles.Name = "button_rendeles";
            this.button_rendeles.Size = new System.Drawing.Size(204, 48);
            this.button_rendeles.TabIndex = 15;
            this.button_rendeles.Text = "Rendelés";
            this.button_rendeles.UseVisualStyleBackColor = true;
            this.button_rendeles.Click += new System.EventHandler(this.button_rendeles_Click);
            // 
            // textBox_vegosszeg
            // 
            this.textBox_vegosszeg.Location = new System.Drawing.Point(1098, 367);
            this.textBox_vegosszeg.Name = "textBox_vegosszeg";
            this.textBox_vegosszeg.Size = new System.Drawing.Size(152, 31);
            this.textBox_vegosszeg.TabIndex = 16;
            this.textBox_vegosszeg.TextChanged += new System.EventHandler(this.textBox_vegosszeg_TextChanged);
            // 
            // button_vegosszeg
            // 
            this.button_vegosszeg.Location = new System.Drawing.Point(1272, 360);
            this.button_vegosszeg.Name = "button_vegosszeg";
            this.button_vegosszeg.Size = new System.Drawing.Size(163, 45);
            this.button_vegosszeg.TabIndex = 17;
            this.button_vegosszeg.Text = "Végösszeg";
            this.button_vegosszeg.UseVisualStyleBackColor = true;
            this.button_vegosszeg.Click += new System.EventHandler(this.button_vegosszeg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.button_vegosszeg);
            this.Controls.Add(this.textBox_vegosszeg);
            this.Controls.Add(this.button_rendeles);
            this.Controls.Add(this.listBox_kosar);
            this.Controls.Add(this.button_fizetesmegerosites);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_db);
            this.Controls.Add(this.button_hozzaadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_szamla);
            this.Controls.Add(this.groupBox_fizetes);
            this.Controls.Add(this.button_atlagar);
            this.Controls.Add(this.listBox_pizza_menu);
            this.Controls.Add(this.textBox_faljbetoltes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_betoltes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Pizza rendelés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_fizetes.ResumeLayout(false);
            this.groupBox_fizetes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_betoltes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_faljbetoltes;
        private System.Windows.Forms.ListBox listBox_pizza_menu;
        private System.Windows.Forms.Button button_atlagar;
        private System.Windows.Forms.GroupBox groupBox_fizetes;
        private System.Windows.Forms.RadioButton radioButton_kezpenz;
        private System.Windows.Forms.RadioButton radioButton_bankkartya;
        private System.Windows.Forms.CheckBox checkBox_szamla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_hozzaadas;
        private System.Windows.Forms.TextBox textBox_db;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_fizetesmegerosites;
        private System.Windows.Forms.ListBox listBox_kosar;
        private System.Windows.Forms.Button button_rendeles;
        private System.Windows.Forms.TextBox textBox_vegosszeg;
        private System.Windows.Forms.Button button_vegosszeg;
    }
}

