
namespace EPCath_Marking
{
    partial class StickerCreator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.информационныйСтикерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ярлыкНаТранспортнуюТаруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упаковочныйЛистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информационныйСтикерToolStripMenuItem,
            this.ярлыкНаТранспортнуюТаруToolStripMenuItem,
            this.упаковочныйЛистToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "Создать";
            // 
            // информационныйСтикерToolStripMenuItem
            // 
            this.информационныйСтикерToolStripMenuItem.Name = "информационныйСтикерToolStripMenuItem";
            this.информационныйСтикерToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.информационныйСтикерToolStripMenuItem.Text = "Информационный стикер";
            this.информационныйСтикерToolStripMenuItem.Click += new System.EventHandler(this.информационныйСтикерToolStripMenuItem_Click);
            // 
            // ярлыкНаТранспортнуюТаруToolStripMenuItem
            // 
            this.ярлыкНаТранспортнуюТаруToolStripMenuItem.Name = "ярлыкНаТранспортнуюТаруToolStripMenuItem";
            this.ярлыкНаТранспортнуюТаруToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.ярлыкНаТранспортнуюТаруToolStripMenuItem.Text = "Ярлык на транспортную тару";
            // 
            // упаковочныйЛистToolStripMenuItem
            // 
            this.упаковочныйЛистToolStripMenuItem.Name = "упаковочныйЛистToolStripMenuItem";
            this.упаковочныйЛистToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.упаковочныйЛистToolStripMenuItem.Text = "Упаковочный лист";
            // 
            // StickerCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StickerCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPCath Marking";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem информационныйСтикерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ярлыкНаТранспортнуюТаруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упаковочныйЛистToolStripMenuItem;
    }
}