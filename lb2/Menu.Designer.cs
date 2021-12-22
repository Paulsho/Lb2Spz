
namespace lb2
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUniversities = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lFac = new System.Windows.Forms.Label();
            this.lLabs = new System.Windows.Forms.Label();
            this.lLec = new System.Windows.Forms.Label();
            this.lStud = new System.Windows.Forms.Label();
            this.lTeach = new System.Windows.Forms.Label();
            this.lEngin = new System.Windows.Forms.Label();
            this.btAddUniversity = new System.Windows.Forms.Button();
            this.btDeleteUniversity = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCompare = new System.Windows.Forms.Button();
            this.btMerge = new System.Windows.Forms.Button();
            this.lF = new System.Windows.Forms.Label();
            this.lL = new System.Windows.Forms.Label();
            this.lLc = new System.Windows.Forms.Label();
            this.lS = new System.Windows.Forms.Label();
            this.lT = new System.Windows.Forms.Label();
            this.lE = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUniversities
            // 
            this.lbUniversities.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUniversities.FormattingEnabled = true;
            this.lbUniversities.ItemHeight = 21;
            this.lbUniversities.Location = new System.Drawing.Point(253, 95);
            this.lbUniversities.Name = "lbUniversities";
            this.lbUniversities.Size = new System.Drawing.Size(296, 256);
            this.lbUniversities.TabIndex = 0;
            this.lbUniversities.SelectedIndexChanged += new System.EventHandler(this.lbUniversities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(279, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "УНІВЕРСИТЕТ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Інформація";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(612, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Операції";
            // 
            // lFac
            // 
            this.lFac.AutoSize = true;
            this.lFac.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFac.Location = new System.Drawing.Point(45, 161);
            this.lFac.Name = "lFac";
            this.lFac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lFac.Size = new System.Drawing.Size(125, 24);
            this.lFac.TabIndex = 4;
            this.lFac.Text = "Факультети:";
            // 
            // lLabs
            // 
            this.lLabs.AutoSize = true;
            this.lLabs.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLabs.Location = new System.Drawing.Point(37, 194);
            this.lLabs.Name = "lLabs";
            this.lLabs.Size = new System.Drawing.Size(133, 24);
            this.lLabs.TabIndex = 5;
            this.lLabs.Text = "Лабораторні:";
            // 
            // lLec
            // 
            this.lLec.AutoSize = true;
            this.lLec.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLec.Location = new System.Drawing.Point(70, 229);
            this.lLec.Name = "lLec";
            this.lLec.Size = new System.Drawing.Size(100, 24);
            this.lLec.TabIndex = 6;
            this.lLec.Text = "Лекційні:";
            // 
            // lStud
            // 
            this.lStud.AutoSize = true;
            this.lStud.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStud.Location = new System.Drawing.Point(65, 284);
            this.lStud.Name = "lStud";
            this.lStud.Size = new System.Drawing.Size(102, 24);
            this.lStud.TabIndex = 7;
            this.lStud.Text = "Студенти:";
            // 
            // lTeach
            // 
            this.lTeach.AutoSize = true;
            this.lTeach.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTeach.Location = new System.Drawing.Point(55, 318);
            this.lTeach.Name = "lTeach";
            this.lTeach.Size = new System.Drawing.Size(112, 24);
            this.lTeach.TabIndex = 8;
            this.lTeach.Text = "Викладачі:";
            // 
            // lEngin
            // 
            this.lEngin.AutoSize = true;
            this.lEngin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEngin.Location = new System.Drawing.Point(60, 353);
            this.lEngin.Name = "lEngin";
            this.lEngin.Size = new System.Drawing.Size(107, 24);
            this.lEngin.TabIndex = 9;
            this.lEngin.Text = "Інженери:";
            // 
            // btAddUniversity
            // 
            this.btAddUniversity.Location = new System.Drawing.Point(253, 364);
            this.btAddUniversity.Name = "btAddUniversity";
            this.btAddUniversity.Size = new System.Drawing.Size(129, 58);
            this.btAddUniversity.TabIndex = 10;
            this.btAddUniversity.Text = "Додати університет";
            this.btAddUniversity.UseVisualStyleBackColor = true;
            this.btAddUniversity.Click += new System.EventHandler(this.btAddUniversity_Click);
            // 
            // btDeleteUniversity
            // 
            this.btDeleteUniversity.Location = new System.Drawing.Point(426, 364);
            this.btDeleteUniversity.Name = "btDeleteUniversity";
            this.btDeleteUniversity.Size = new System.Drawing.Size(123, 58);
            this.btDeleteUniversity.TabIndex = 11;
            this.btDeleteUniversity.Text = "Видалити університет";
            this.btDeleteUniversity.UseVisualStyleBackColor = true;
            this.btDeleteUniversity.Click += new System.EventHandler(this.btDeleteUniversity_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(609, 107);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(110, 57);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Додати";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(609, 170);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(110, 57);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "Видалити";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCompare
            // 
            this.btCompare.Location = new System.Drawing.Point(609, 233);
            this.btCompare.Name = "btCompare";
            this.btCompare.Size = new System.Drawing.Size(110, 57);
            this.btCompare.TabIndex = 14;
            this.btCompare.Text = "Порівняти";
            this.btCompare.UseVisualStyleBackColor = true;
            this.btCompare.Click += new System.EventHandler(this.btCompare_Click);
            // 
            // btMerge
            // 
            this.btMerge.Location = new System.Drawing.Point(609, 296);
            this.btMerge.Name = "btMerge";
            this.btMerge.Size = new System.Drawing.Size(110, 57);
            this.btMerge.TabIndex = 15;
            this.btMerge.Text = "Об\'єднати";
            this.btMerge.UseVisualStyleBackColor = true;
            this.btMerge.Click += new System.EventHandler(this.btMerge_Click);
            // 
            // lF
            // 
            this.lF.AutoSize = true;
            this.lF.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lF.Location = new System.Drawing.Point(187, 159);
            this.lF.Name = "lF";
            this.lF.Size = new System.Drawing.Size(0, 24);
            this.lF.TabIndex = 16;
            // 
            // lL
            // 
            this.lL.AutoSize = true;
            this.lL.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lL.Location = new System.Drawing.Point(187, 192);
            this.lL.Name = "lL";
            this.lL.Size = new System.Drawing.Size(0, 24);
            this.lL.TabIndex = 17;
            // 
            // lLc
            // 
            this.lLc.AutoSize = true;
            this.lLc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLc.Location = new System.Drawing.Point(187, 227);
            this.lLc.Name = "lLc";
            this.lLc.Size = new System.Drawing.Size(0, 24);
            this.lLc.TabIndex = 18;
            // 
            // lS
            // 
            this.lS.AutoSize = true;
            this.lS.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lS.Location = new System.Drawing.Point(187, 282);
            this.lS.Name = "lS";
            this.lS.Size = new System.Drawing.Size(0, 24);
            this.lS.TabIndex = 19;
            // 
            // lT
            // 
            this.lT.AutoSize = true;
            this.lT.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lT.Location = new System.Drawing.Point(187, 316);
            this.lT.Name = "lT";
            this.lT.Size = new System.Drawing.Size(0, 24);
            this.lT.TabIndex = 20;
            // 
            // lE
            // 
            this.lE.AutoSize = true;
            this.lE.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lE.Location = new System.Drawing.Point(187, 351);
            this.lE.Name = "lE";
            this.lE.Size = new System.Drawing.Size(0, 24);
            this.lE.TabIndex = 21;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(55, 121);
            this.lName.Name = "lName";
            this.lName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lName.Size = new System.Drawing.Size(71, 24);
            this.lName.TabIndex = 22;
            this.lName.Text = "Назва:";
            // 
            // lN
            // 
            this.lN.AutoSize = true;
            this.lN.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lN.Location = new System.Drawing.Point(132, 121);
            this.lN.Name = "lN";
            this.lN.Size = new System.Drawing.Size(0, 24);
            this.lN.TabIndex = 23;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lN);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lE);
            this.Controls.Add(this.lT);
            this.Controls.Add(this.lS);
            this.Controls.Add(this.lLc);
            this.Controls.Add(this.lL);
            this.Controls.Add(this.lF);
            this.Controls.Add(this.btMerge);
            this.Controls.Add(this.btCompare);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDeleteUniversity);
            this.Controls.Add(this.btAddUniversity);
            this.Controls.Add(this.lEngin);
            this.Controls.Add(this.lTeach);
            this.Controls.Add(this.lStud);
            this.Controls.Add(this.lLec);
            this.Controls.Add(this.lLabs);
            this.Controls.Add(this.lFac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUniversities);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lFac;
        private System.Windows.Forms.Label lLabs;
        private System.Windows.Forms.Label lLec;
        private System.Windows.Forms.Label lStud;
        private System.Windows.Forms.Label lTeach;
        private System.Windows.Forms.Label lEngin;
        private System.Windows.Forms.Button btAddUniversity;
        private System.Windows.Forms.Button btDeleteUniversity;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btCompare;
        private System.Windows.Forms.Button btMerge;
        private System.Windows.Forms.Label lF;
        private System.Windows.Forms.Label lL;
        private System.Windows.Forms.Label lLc;
        private System.Windows.Forms.Label lS;
        private System.Windows.Forms.Label lT;
        private System.Windows.Forms.Label lE;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lN;
        private System.Windows.Forms.ListBox lbUniversities;
    }
}

