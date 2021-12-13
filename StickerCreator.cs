using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPCath_Marking
{
    public partial class StickerCreator : Form
    {
        public StickerCreator()
        {
            InitializeComponent();
        }

        private void информационныйСтикерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 SC = new Form1();
            SC.Show();
        }

        private void открытьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPCath_DataBase CDB = new EPCath_DataBase();
            CDB.Show();
        }
    }
}
