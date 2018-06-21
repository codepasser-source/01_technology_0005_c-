using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFCore.db;
using WFCore.exception;
using System.Data.SQLite;

namespace WFView
{
    public partial class DBForm : Form
    {

        private SQLiteConnection sqliteConn;
        private Boolean allSelected = false;

        /// <summary>
        /// DBForm constructor
        /// </summary>
        public DBForm()
        {
            InitializeComponent();

        }




        /// <summary>
        /// PowerMode gridview checkBox list  on check or uncheck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (this.allSelected)
            {
                if (this.PowerModeGridView.RowCount > 0)
                {
                    for (int rowIndex = 0; rowIndex < this.PowerModeGridView.RowCount; rowIndex++)
                    {
                        DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)this.PowerModeGridView.Rows[rowIndex].Cells["select"];
                        checkBox.Value = false;
                        this.allSelected = false;
                    }
                }
            }
            else
            {
                if (this.PowerModeGridView.RowCount > 0)
                {
                    for (int rowIndex = 0; rowIndex < this.PowerModeGridView.RowCount; rowIndex++)
                    {
                        DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)this.PowerModeGridView.Rows[rowIndex].Cells["select"];
                        checkBox.Value = true;
                        this.allSelected = true;
                    }
                }
            }

        }

        /// <summary>
        /// query
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                DBCommand dbCommand = new DBCommand();
                DataTable dataTable = dbCommand.query();
                if (dataTable != null)
                {
                    this.PowerModeGridView.DataSource = dataTable;
                }
            }
            catch (CoreException ex)
            {
                MessageBox.Show(this, ex.getErrorMessage());
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {

                DBCommand dbCommand = new DBCommand();
                dbCommand.deleteBySeq("47");
                this.QueryButton_Click(sender, e);
            }
            catch (CoreException ex)
            {
                MessageBox.Show(this, ex.getErrorMessage());
            }
        }
    }
}
