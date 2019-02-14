using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_HW1
{
    public partial class Form1 : Form
    {
        string connectionString;
        List<string> groups;
        DataSet ds;
        SqlDataAdapter adapter;
        readonly SqlConnection connection;
        bool fsetHeader = false;
        public Form1()
        {
            InitializeComponent();
            groups = new List<string>();
            string dir = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName;
            string attachDBFilename = dir + @"\App_Data\University.mdf";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = @"(localdb)\mssqllocaldb",
                InitialCatalog = "University",
                AttachDBFilename = attachDBFilename,
                IntegratedSecurity = true
            };
            connectionString = builder.ConnectionString;
            StringBuilder queryString = new StringBuilder();
            queryString.Append("select Surname, MarkByOOP, MarkByWinForms, MarkByADOdotNET from Students;");
            queryString.Append("select GroupName, CuratorSurname from Groups;");
            queryString.Append("select s.Surname, g.GroupName, Round(CONVERT(FLOAT,(s.MarkByOOP+s.MarkByWinForms+s.MarkByADOdotNET),1)/3, 2) AverageMark from Students s left join Groups g on s.IdGroup=g.Id");
            connection = new SqlConnection(connectionString);
            connection.Open();
            adapter = new SqlDataAdapter(queryString.ToString(), connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds);

            ShowDataInTables();
            SetComboBoxSelectGroups();
        }
        private void ShowDataInTables()
        {
            dataGridViewStudents.Rows.Clear();
            dataGridViewGroups.Rows.Clear();
            dataGridViewSessionResults.Rows.Clear();
            try
            {
                dataGridViewStudents.DataSource = ds.Tables[0];
                dataGridViewGroups.DataSource = ds.Tables[1];
                dataGridViewSessionResults.DataSource = ds.Tables[2];
                if (!fsetHeader)
                {
                    SetViewDataGridViewStudents();
                    SetViewDataGridViewGroups();
                    SetViewDataGridSessionResults();
                    fsetHeader = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetComboBoxSelectGroups()
        {
            groups.Clear();
            comboBoxSelectGroups.Items.Clear();
            if (ds != null)
            {
                for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                {
                    groups.Add((ds.Tables[1].Rows[i]["GroupName"]).ToString());
                }
            }
            comboBoxSelectGroups.Items.AddRange(groups.Distinct().ToArray());
            comboBoxSelectGroups.SelectedIndex = 0;
        }
        private void SetViewDataGridViewStudents()
        {
            dataGridViewStudents.Columns[0].HeaderText = "Surname";
            dataGridViewStudents.Columns[1].HeaderText = "Mark by OOP";
            dataGridViewStudents.Columns[2].HeaderText = "Mark by WinForms";
            dataGridViewStudents.Columns[3].HeaderText = "Mark by ADO.NET";
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void SetViewDataGridViewGroups()
        {
            dataGridViewGroups.Columns[0].HeaderText = "Group name";
            dataGridViewGroups.Columns[1].HeaderText = "Curator surname";
            dataGridViewGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void SetViewDataGridSessionResults()
        {
            dataGridViewSessionResults.Columns[0].HeaderText = "Student surname";
            dataGridViewSessionResults.Columns[1].HeaderText = "Group name";
            dataGridViewSessionResults.Columns[2].HeaderText = "Average mark";
            dataGridViewSessionResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void comboBoxSelectGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            int excels = 0;
            int losers = 0;
            double aver = 0;
            for (int i = 0; i < ds.Tables[2].Rows.Count; i++)
            {
                if ((ds.Tables[2].Rows[i]["GroupName"]).ToString() == comboBoxSelectGroups.SelectedItem.ToString())
                {
                    aver = (double)ds.Tables[2].Rows[i]["AverageMark"];
                    if (aver < 4)
                        losers++;
                    else if (aver >= 9)
                        excels++;
                }
                labelCountLosers.Text = "= " + losers.ToString();
                labelCountExcellent.Text = "= " + excels.ToString();
            }
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxGroupName.Text == "")
                    throw new Exception("Please check your group name!");
                if (textBoxCuratorSurname.Text == "")
                    throw new Exception("Please check your curator name!");
                // set the command to insert
                adapter.InsertCommand = new SqlCommand("sp_CreateGroup", connection);
                // stored procedure
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                // add parameter for GroupName
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@GroupName", SqlDbType.NVarChar, 50, "GroupName"));
                // add parameter for CuratorSurname
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@CuratorSurname", SqlDbType.NVarChar, 50, "CuratorSurname"));
                // add output parameter for id
                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;
                DataTable dt = ds.Tables[1];
                // add a new line
                DataRow newRow = dt.NewRow();
                newRow["GroupName"] = textBoxGroupName.Text;
                newRow["CuratorSurname"] = textBoxCuratorSurname.Text;
                dt.Rows.Add(newRow);
                adapter.Update(dt);
                ds.AcceptChanges();
                // re-receive the data from the database clear completely DataSet
                ds.Clear();
                // reload data
                adapter.Fill(ds);
                SetComboBoxSelectGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
