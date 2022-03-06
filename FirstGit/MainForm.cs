using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGit
{
    // комментарий
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // ветвь branch1 
            InitializeComponent();

            listBox1 = new ListBox();
            listBox2 = new ListBox();

            // мое видение пробелмы получения сегодняшней даты
            DateTime today = DateTime.Now;
        }
    }
}
