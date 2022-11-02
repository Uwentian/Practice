﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система_Фитнес_клуба_Fitness_house
{
    public partial class AddForm5 : Form
    {
        public AddForm5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                DataRow nRow = main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[10].NewRow();
                int rc = main.dataGridView1.RowCount + 2;
                nRow[0] = rc;
                nRow[1] = tbFam.Text;
                nRow[2] = tbName.Text;
                nRow[3] = tbOtch.Text;
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[10].Rows.Add(nRow);
                main.сотрудникTableAdapter.Update(main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Сотрудник);
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[10].AcceptChanges();
                main.dataGridView1.Refresh();
                tbFam.Text = "";
                tbName.Text = "";
                tbOtch.Text = "";
            }
        }
    }
}
