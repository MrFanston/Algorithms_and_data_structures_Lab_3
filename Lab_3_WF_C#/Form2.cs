using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_WF_C_
{
    public partial class FormRes : Form
    {
            public FormRes()
        {
            InitializeComponent();
        }

        public void Add(string name, string time, string time_otn, string c_n, string m_n)
        {
            dataGridView1.Rows.Add(name , time, time_otn, c_n, m_n);
        }
    }
}
