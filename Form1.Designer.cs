
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cath_StickerGenerate = new System.Windows.Forms.Button();
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
            this.errorProviderLOT = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLOT)).BeginInit();
            this.SuspendLayout();
            // 
            // Cath_StickerGenerate
            // 
            this.Cath_StickerGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Cath_StickerGenerate.Location = new System.Drawing.Point(64, 329);
            this.Cath_StickerGenerate.Name = "Cath_StickerGenerate";
            this.Cath_StickerGenerate.Size = new System.Drawing.Size(135, 62);
            this.Cath_StickerGenerate.TabIndex = 0;
            this.Cath_StickerGenerate.Text = "СОЗДАТЬ СТИКЕР";
            this.Cath_StickerGenerate.UseVisualStyleBackColor = false;
            this.Cath_StickerGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Код партии (LOT) :";
            // 
            // Cath_LOT
            // 
            this.Cath_LOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cath_LOT.Location = new System.Drawing.Point(6, 96);
            this.Cath_LOT.MaxLength = 3;
            this.Cath_LOT.Name = "Cath_LOT";
            this.Cath_LOT.Size = new System.Drawing.Size(116, 22);
            this.Cath_LOT.TabIndex = 6;
        
            this.Cath_LOT.MouseEnter += new System.EventHandler(this.Cath_LOT_MouseEnter);
            // 
            // Cath_REF
            // 
            this.Cath_REF.BackColor = System.Drawing.Color.White;
            this.Cath_REF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cath_REF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cath_REF.ForeColor = System.Drawing.Color.Black;
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
            this.Cath_REF.Location = new System.Drawing.Point(6, 38);
            this.Cath_REF.Name = "Cath_REF";
            this.Cath_REF.Size = new System.Drawing.Size(209, 24);
            this.Cath_REF.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вариант исполнения катетера:";
          
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата изготовления:";
            // 
            // Cath_Date1
            // 
            this.Cath_Date1.CustomFormat = "MM.yyyy";
            this.Cath_Date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Cath_Date1.Location = new System.Drawing.Point(6, 156);
            this.Cath_Date1.Name = "Cath_Date1";
            this.Cath_Date1.Size = new System.Drawing.Size(109, 20);
            this.Cath_Date1.TabIndex = 11;
       
           
            // 
            // Cath_QTY
            // 
            this.Cath_QTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cath_QTY.Location = new System.Drawing.Point(6, 286);
            this.Cath_QTY.Name = "Cath_QTY";
            this.Cath_QTY.Size = new System.Drawing.Size(60, 22);
            this.Cath_QTY.TabIndex = 12;
         
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Начальный серийный номер:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Количество:";
            // 
            // Cath_FirstSN
            // 
            this.Cath_FirstSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cath_FirstSN.Location = new System.Drawing.Point(6, 217);
            this.Cath_FirstSN.Name = "Cath_FirstSN";
            this.Cath_FirstSN.Size = new System.Drawing.Size(51, 22);
            this.Cath_FirstSN.TabIndex = 15;
         
            // 
            // errorProviderLOT
            // 
            this.errorProviderLOT.BlinkRate = 700;
            this.errorProviderLOT.ContainerControl = this;
            this.errorProviderLOT.Tag = "Faild!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(272, 448);
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
            this.Controls.Add(this.Cath_StickerGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPCath Sticker Generator";
         
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLOT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cath_StickerGenerate;
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
        private System.Windows.Forms.ErrorProvider errorProviderLOT;
    }
}

