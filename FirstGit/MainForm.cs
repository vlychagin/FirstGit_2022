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
            // ветвь master 
            InitializeComponent();

            listBox1 = new ListBox();
            listBox2 = new ListBox();

            // рекомендуемый вариант получения сегодняшней даты
            var today = DateTime.Today;
        }
    }
}
