using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace MySQLDataBaseInterface
{

    public partial class Form1 : Form
    {
        private const string SERVER = "127.0.0.1";
        private string DATABASE = "emp";

        List<string> columnName = new List<string>();
        List<string> values = new List<string>();

        DB database;
        public Form1()
        {           

            InitializeComponent();
            commandButton.Enabled = false;
            commandTextBox.Enabled = false;
        }

        private void commandButton_Click(object sender, EventArgs e)
        {
            result_richText.Text += "\n-------------------------------------------------------------------";
            MySqlCommand cmd = database.giveCommand(commandTextBox.Text);
            MySqlDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch(Exception eq)
            {
                MessageBox.Show("Error : " + eq.StackTrace);
            }

            int fieldNum = reader.FieldCount;
            if (commandTextBox.Text.Contains("select"))
                printData(fieldNum, reader);
            else if (commandTextBox.Text.Contains("update"))
            {
                //TODO : Set up getting updated strings.                
                //string updated = result_richText.Text.Substring(result_richText.Text.IndexOf("set ", 4));
                result_richText.Text += "\n\tTable Updated";
            }
            reader.Close();
        }

        void printData(int fieldNum,MySqlDataReader reader)
        {
            
            //Add the column names
            result_richText.Text += "\n"; 
            for (int i = 0; i < fieldNum; i++)
            {
                columnName.Add(reader.GetName(i));
                result_richText.Text += "\t" + reader.GetName(i);
            }
            //Add all the values of all rows
            result_richText.Text += "\n";
            while (reader.Read())
            {
                result_richText.Text += "\n";
                for (int i = 0; i < fieldNum; i++)
                {
                    values.Add(reader[i].ToString());
                    result_richText.Text += "\t" + reader[i].ToString();
                }
            }
            
            int[] initOffset = new int[fieldNum];
            for (int i = 0; i < fieldNum; i++)
                initOffset[i] = i;
            //Gets all the values of a particular field each
            for (int j = 0; j < fieldNum; j++)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    if (initOffset[j] == i)
                    {                        
                        initOffset[j] += fieldNum;
                    }
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                database.closeConnection();
            }
            catch { }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Text != String.Empty && passwordTextBox.Text != String.Empty && textBoxDatabase.Text != String.Empty)
            {
                DATABASE = textBoxDatabase.Text;
                database = new DB(SERVER, DATABASE, userIdTextBox.Text, passwordTextBox.Text);
                database.connect();
                try
                {
                    database.openConnection();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Wrong Value for either User ID or Password");
                }
                commandButton.Enabled = true;
                commandTextBox.Enabled = true;
            }
            labelDatabaseName.Text = "Data Base Name : " + database.getBuilder().Database.ToString().ToUpper();
            labelTableName.Text = "Table Name : " + database.getTableNames();
            setDataGrid();
            

        }
        void setDataGrid()
        {
            MySqlDataAdapter adapter = database.getAdapter();
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlDataAdapter adapter = database.getAdapter();
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(adapter);
                adapter.UpdateCommand = mcb.GetUpdateCommand();
                adapter.Update(changes);
                ((DataTable)dataGridView1.DataSource).AcceptChanges();
            }
        }

        private void OnClick_RemoveText(object sender, EventArgs e)
        {
            if (sender.Equals(userIdTextBox))
                userIdTextBox.Text = "";
            if (sender.Equals(passwordTextBox))
                passwordTextBox.Text = "";
            if (sender.Equals(textBoxDatabase))
                textBoxDatabase.Text = "";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < columnName.Count; i++)
            {
                Console.WriteLine("Column " + columnName[i]);
            }
            int k = 1;
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine("Value " + values[i]);               
            }
            for (k = 1; k < values.Count; k+=3)
            {
                Console.WriteLine("Name : " + values[k] + " ,age = " + values[k+1]);
                chart.Series["value"].Points.AddXY(values[k], values[k + 1]);
            }
            
        }

        private void buttonGraphSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                chart.SaveImage(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
