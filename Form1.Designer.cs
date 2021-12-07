
namespace EPCath_Marking
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cath_StickerGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cath_LOT = new System.Windows.Forms.TextBox();
            this.Cath_REF = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cath_Date1 = new System.Windows.Forms.DateTimePicker();
            this.Cath_QTY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cath_FirstSN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cath_StickerGenerate
            // 
            this.Cath_StickerGenerate.Location = new System.Drawing.Point(178, 259);
            this.Cath_StickerGenerate.Name = "Cath_StickerGenerate";
            this.Cath_StickerGenerate.Size = new System.Drawing.Size(158, 63);
            this.Cath_StickerGenerate.TabIndex = 0;
            this.Cath_StickerGenerate.Text = "СОЗДАТЬ СТИКЕР";
            this.Cath_StickerGenerate.UseVisualStyleBackColor = true;
            this.Cath_StickerGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "QR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(15, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 95);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Код партии (LOT) :";
            // 
            // Cath_LOT
            // 
            this.Cath_LOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cath_LOT.Location = new System.Drawing.Point(15, 115);
            this.Cath_LOT.MaxLength = 3;
            this.Cath_LOT.Name = "Cath_LOT";
            this.Cath_LOT.Size = new System.Drawing.Size(116, 22);
            this.Cath_LOT.TabIndex = 6;
            this.Cath_LOT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cath_LOT_KeyPress);
            this.Cath_LOT.MouseEnter += new System.EventHandler(this.Cath_LOT_MouseEnter);
            // 
            // Cath_REF
            // 
            this.Cath_REF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cath_REF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cath_REF.FormattingEnabled = true;
            this.Cath_REF.Items.AddRange(new object[] {
            "DIA CS6D252N",
            "DIA.CO6Q005N",
            "DIA.JO6Q005N",
            "ABL.SS6Q252N4",
            "ABL.SM6Q252N4",
            "ABL.SL6Q252N4",
            "ABL.SM75Q252N4",
            "ABL.SL75Q252N4",
            "ABL.SM75Q252J35",
            "IRR 001"});
            this.Cath_REF.Location = new System.Drawing.Point(15, 47);
            this.Cath_REF.Name = "Cath_REF";
            this.Cath_REF.Size = new System.Drawing.Size(206, 24);
            this.Cath_REF.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вариант исполнения катетера:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(198, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата изготовления:";
            // 
            // Cath_Date1
            // 
            this.Cath_Date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Cath_Date1.Location = new System.Drawing.Point(227, 117);
            this.Cath_Date1.Name = "Cath_Date1";
            this.Cath_Date1.Size = new System.Drawing.Size(109, 20);
            this.Cath_Date1.TabIndex = 11;
            this.Cath_Date1.Enter += new System.EventHandler(this.Date_of_prod_ValueChanged);
            // 
            // Cath_QTY
            // 
            this.Cath_QTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cath_QTY.Location = new System.Drawing.Point(276, 49);
            this.Cath_QTY.Name = "Cath_QTY";
            this.Cath_QTY.Size = new System.Drawing.Size(60, 22);
            this.Cath_QTY.TabIndex = 12;
            this.Cath_QTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cath_QTY_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(140, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Начальный серийный номер:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(247, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Количество:";
            // 
            // Cath_FirstSN
            // 
            this.Cath_FirstSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cath_FirstSN.Location = new System.Drawing.Point(285, 173);
            this.Cath_FirstSN.Name = "Cath_FirstSN";
            this.Cath_FirstSN.Size = new System.Drawing.Size(51, 22);
            this.Cath_FirstSN.TabIndex = 15;
            this.Cath_FirstSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cath_FirstSN_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 369);
            this.Controls.Add(this.Cath_FirstSN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cath_QTY);
            this.Controls.Add(this.Cath_Date1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cath_REF);
            this.Controls.Add(this.Cath_LOT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cath_StickerGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EPCath Sticker Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cath_StickerGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cath_LOT;
        private System.Windows.Forms.ComboBox Cath_REF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Cath_Date1;
        private System.Windows.Forms.TextBox Cath_QTY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Cath_FirstSN;
    }
}

