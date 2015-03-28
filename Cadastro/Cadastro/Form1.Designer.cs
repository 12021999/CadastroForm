namespace Cadastro
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
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.genderM = new System.Windows.Forms.RadioButton();
            this.genderF = new System.Windows.Forms.RadioButton();
            this.genderOutro = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.profBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.salBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusC = new System.Windows.Forms.RadioButton();
            this.statusS = new System.Windows.Forms.RadioButton();
            this.statusA = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.NF0 = new System.Windows.Forms.RadioButton();
            this.NF1 = new System.Windows.Forms.RadioButton();
            this.NF3 = new System.Windows.Forms.RadioButton();
            this.NF2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.bloodBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.diaBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mesBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.anoBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addSave = new System.Windows.Forms.Label();
            this.salSave = new System.Windows.Forms.Label();
            this.profSave = new System.Windows.Forms.Label();
            this.nomeSave = new System.Windows.Forms.Label();
            this.dataSave = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bloodSave = new System.Windows.Forms.Label();
            this.nameList = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(85, 32);
            this.nomeBox.MaxLength = 100;
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(547, 20);
            this.nomeBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // genderM
            // 
            this.genderM.AutoSize = true;
            this.genderM.Checked = true;
            this.genderM.Location = new System.Drawing.Point(6, 8);
            this.genderM.Name = "genderM";
            this.genderM.Size = new System.Drawing.Size(34, 17);
            this.genderM.TabIndex = 4;
            this.genderM.TabStop = true;
            this.genderM.Text = "M";
            this.genderM.UseVisualStyleBackColor = true;
            // 
            // genderF
            // 
            this.genderF.AutoSize = true;
            this.genderF.Location = new System.Drawing.Point(46, 8);
            this.genderF.Name = "genderF";
            this.genderF.Size = new System.Drawing.Size(31, 17);
            this.genderF.TabIndex = 5;
            this.genderF.TabStop = true;
            this.genderF.Text = "F";
            this.genderF.UseVisualStyleBackColor = true;
            // 
            // genderOutro
            // 
            this.genderOutro.AutoSize = true;
            this.genderOutro.Location = new System.Drawing.Point(83, 8);
            this.genderOutro.Name = "genderOutro";
            this.genderOutro.Size = new System.Drawing.Size(51, 17);
            this.genderOutro.TabIndex = 6;
            this.genderOutro.TabStop = true;
            this.genderOutro.Text = "Outro";
            this.genderOutro.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Profissão";
            // 
            // profBox
            // 
            this.profBox.Location = new System.Drawing.Point(85, 134);
            this.profBox.MaxLength = 100;
            this.profBox.Name = "profBox";
            this.profBox.Size = new System.Drawing.Size(547, 20);
            this.profBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Salário - R$";
            // 
            // salBox
            // 
            this.salBox.Location = new System.Drawing.Point(85, 171);
            this.salBox.MaxLength = 50;
            this.salBox.Name = "salBox";
            this.salBox.Size = new System.Drawing.Size(165, 20);
            this.salBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // statusC
            // 
            this.statusC.AutoSize = true;
            this.statusC.Location = new System.Drawing.Point(72, 7);
            this.statusC.Name = "statusC";
            this.statusC.Size = new System.Drawing.Size(61, 17);
            this.statusC.TabIndex = 10;
            this.statusC.Text = "Casado";
            this.statusC.UseVisualStyleBackColor = true;
            // 
            // statusS
            // 
            this.statusS.AutoSize = true;
            this.statusS.Checked = true;
            this.statusS.Location = new System.Drawing.Point(6, 7);
            this.statusS.Name = "statusS";
            this.statusS.Size = new System.Drawing.Size(60, 17);
            this.statusS.TabIndex = 9;
            this.statusS.TabStop = true;
            this.statusS.Text = "Solteiro";
            this.statusS.UseVisualStyleBackColor = true;
            // 
            // statusA
            // 
            this.statusA.AutoSize = true;
            this.statusA.Location = new System.Drawing.Point(139, 7);
            this.statusA.Name = "statusA";
            this.statusA.Size = new System.Drawing.Size(77, 17);
            this.statusA.TabIndex = 11;
            this.statusA.Text = "Assexuado";
            this.statusA.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nº de Filhos";
            // 
            // NF0
            // 
            this.NF0.AutoSize = true;
            this.NF0.Checked = true;
            this.NF0.Location = new System.Drawing.Point(4, 7);
            this.NF0.Name = "NF0";
            this.NF0.Size = new System.Drawing.Size(31, 17);
            this.NF0.TabIndex = 12;
            this.NF0.TabStop = true;
            this.NF0.Text = "0";
            this.NF0.UseVisualStyleBackColor = true;
            // 
            // NF1
            // 
            this.NF1.AutoSize = true;
            this.NF1.Location = new System.Drawing.Point(41, 7);
            this.NF1.Name = "NF1";
            this.NF1.Size = new System.Drawing.Size(31, 17);
            this.NF1.TabIndex = 13;
            this.NF1.Text = "1";
            this.NF1.UseVisualStyleBackColor = true;
            // 
            // NF3
            // 
            this.NF3.AutoSize = true;
            this.NF3.Location = new System.Drawing.Point(115, 7);
            this.NF3.Name = "NF3";
            this.NF3.Size = new System.Drawing.Size(37, 17);
            this.NF3.TabIndex = 15;
            this.NF3.Text = "3+";
            this.NF3.UseVisualStyleBackColor = true;
            // 
            // NF2
            // 
            this.NF2.AutoSize = true;
            this.NF2.Location = new System.Drawing.Point(78, 7);
            this.NF2.Name = "NF2";
            this.NF2.Size = new System.Drawing.Size(31, 17);
            this.NF2.TabIndex = 14;
            this.NF2.Text = "2";
            this.NF2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Blood Type";
            // 
            // bloodBox
            // 
            this.bloodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodBox.FormattingEnabled = true;
            this.bloodBox.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-",
            "C#"});
            this.bloodBox.Location = new System.Drawing.Point(85, 288);
            this.bloodBox.MaxLength = 2;
            this.bloodBox.Name = "bloodBox";
            this.bloodBox.Size = new System.Drawing.Size(47, 21);
            this.bloodBox.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Address";
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(85, 332);
            this.addBox.MaxLength = 50;
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(450, 20);
            this.addBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nascimento";
            // 
            // diaBox
            // 
            this.diaBox.Location = new System.Drawing.Point(85, 64);
            this.diaBox.MaxLength = 2;
            this.diaBox.Name = "diaBox";
            this.diaBox.Size = new System.Drawing.Size(23, 20);
            this.diaBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "/";
            // 
            // mesBox
            // 
            this.mesBox.Location = new System.Drawing.Point(120, 64);
            this.mesBox.MaxLength = 2;
            this.mesBox.Name = "mesBox";
            this.mesBox.Size = new System.Drawing.Size(23, 20);
            this.mesBox.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "/";
            // 
            // anoBox
            // 
            this.anoBox.Location = new System.Drawing.Point(157, 65);
            this.anoBox.MaxLength = 4;
            this.anoBox.Name = "anoBox";
            this.anoBox.Size = new System.Drawing.Size(47, 20);
            this.anoBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // addSave
            // 
            this.addSave.AutoSize = true;
            this.addSave.ForeColor = System.Drawing.Color.Red;
            this.addSave.Location = new System.Drawing.Point(541, 335);
            this.addSave.Name = "addSave";
            this.addSave.Size = new System.Drawing.Size(19, 13);
            this.addSave.TabIndex = 38;
            this.addSave.Text = "    ";
            // 
            // salSave
            // 
            this.salSave.AutoSize = true;
            this.salSave.ForeColor = System.Drawing.Color.Red;
            this.salSave.Location = new System.Drawing.Point(257, 174);
            this.salSave.Name = "salSave";
            this.salSave.Size = new System.Drawing.Size(19, 13);
            this.salSave.TabIndex = 39;
            this.salSave.Text = "    ";
            // 
            // profSave
            // 
            this.profSave.AutoSize = true;
            this.profSave.ForeColor = System.Drawing.Color.Red;
            this.profSave.Location = new System.Drawing.Point(638, 140);
            this.profSave.Name = "profSave";
            this.profSave.Size = new System.Drawing.Size(19, 13);
            this.profSave.TabIndex = 40;
            this.profSave.Text = "    ";
            // 
            // nomeSave
            // 
            this.nomeSave.AutoSize = true;
            this.nomeSave.ForeColor = System.Drawing.Color.Red;
            this.nomeSave.Location = new System.Drawing.Point(638, 35);
            this.nomeSave.Name = "nomeSave";
            this.nomeSave.Size = new System.Drawing.Size(19, 13);
            this.nomeSave.TabIndex = 41;
            this.nomeSave.Text = "    ";
            // 
            // dataSave
            // 
            this.dataSave.AutoSize = true;
            this.dataSave.ForeColor = System.Drawing.Color.Red;
            this.dataSave.Location = new System.Drawing.Point(210, 68);
            this.dataSave.Name = "dataSave";
            this.dataSave.Size = new System.Drawing.Size(19, 13);
            this.dataSave.TabIndex = 43;
            this.dataSave.Text = "    ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.genderM);
            this.groupBox1.Controls.Add(this.genderF);
            this.groupBox1.Controls.Add(this.genderOutro);
            this.groupBox1.Location = new System.Drawing.Point(85, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 26);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusA);
            this.groupBox2.Controls.Add(this.statusS);
            this.groupBox2.Controls.Add(this.statusC);
            this.groupBox2.Location = new System.Drawing.Point(85, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 25);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NF3);
            this.groupBox3.Controls.Add(this.NF0);
            this.groupBox3.Controls.Add(this.NF1);
            this.groupBox3.Controls.Add(this.NF2);
            this.groupBox3.Location = new System.Drawing.Point(85, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 25);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // bloodSave
            // 
            this.bloodSave.AutoSize = true;
            this.bloodSave.ForeColor = System.Drawing.Color.Red;
            this.bloodSave.Location = new System.Drawing.Point(138, 294);
            this.bloodSave.Name = "bloodSave";
            this.bloodSave.Size = new System.Drawing.Size(19, 13);
            this.bloodSave.TabIndex = 47;
            this.bloodSave.Text = "    ";
            // 
            // nameList
            // 
            this.nameList.FormattingEnabled = true;
            this.nameList.Location = new System.Drawing.Point(675, 32);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(222, 329);
            this.nameList.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 51;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.removerClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(567, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(98, 82);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 52;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.editarClick);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salvarToolStripMenuItem.Text = "&Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 366);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.nameList);
            this.Controls.Add(this.bloodSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataSave);
            this.Controls.Add(this.nomeSave);
            this.Controls.Add(this.profSave);
            this.Controls.Add(this.salSave);
            this.Controls.Add(this.addSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.anoBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mesBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.diaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bloodBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.profBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gerenciamento de Funcionários";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton genderM;
        private System.Windows.Forms.RadioButton genderF;
        private System.Windows.Forms.RadioButton genderOutro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox profBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton statusC;
        private System.Windows.Forms.RadioButton statusS;
        private System.Windows.Forms.RadioButton statusA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton NF0;
        private System.Windows.Forms.RadioButton NF1;
        private System.Windows.Forms.RadioButton NF3;
        private System.Windows.Forms.RadioButton NF2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox bloodBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox diaBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mesBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox anoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label addSave;
        private System.Windows.Forms.Label salSave;
        private System.Windows.Forms.Label profSave;
        private System.Windows.Forms.Label nomeSave;
        private System.Windows.Forms.Label dataSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label bloodSave;
        private System.Windows.Forms.ListBox nameList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
    }
}

