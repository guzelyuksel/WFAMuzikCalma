using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAMuzikCalma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            }

        private void MuzikCal()
        {
            Stream sasirmaStream = Properties.Resources.sasirma;
            SoundPlayer player = new SoundPlayer(sasirmaStream);
            player.Play();
        }

        private void btnSasir_Click(object sender, EventArgs e)
        {
            MuzikCal();
        }
    }
}
