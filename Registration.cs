using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKPERFORMANCE_COMPROG3
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;

        public int GetCount()
        {
            return count;
        }

        public int RegistrationID(int count)
        {
            clubRegistrationQuery.c();
            return ++count;
        }

        public void comboboxes()
        {

            string[] ListOfProgram = new string[]
            {
            "BS Information Technology",
            "BS Computer Science",
            "BS Information Systems",
            "BS in Accountancy",
            "BS in Hospitality Management",
            "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                CBPROGRAM.Items.Add(ListOfProgram[i].ToString());
            }


            string[] genders = new string[]
          {
            "Female",
            "Male"

          };

            for (int i = 0; i < 2; i++)
            {
                CBGENDER.Items.Add(genders[i].ToString());
            }
        }
           private void TXTSTUDENTID_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBPROGRAM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTREGISTER_Click(object sender, EventArgs e)
        {
            if (TXTSTUDENTID.Text == "" || TXTFIRSTNAME.Text == "" || TXTMIDDLENAME.Text == "" || TXTLASTNAME.Text == "" || TXTAGE.Text == ""
                || string.IsNullOrEmpty(Convert.ToString(CBGENDER.Text)) || string.IsNullOrEmpty(Convert.ToString(CBPROGRAM.Text)))
            {
                MessageBox.Show("Filup the ff.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                RegistrationID(GetCount());

                StudentId = long.Parse(TXTSTUDENTID.Text);
                FirstName = TXTFIRSTNAME.Text;
                MiddleName = TXTMIDDLENAME.Text;
                LastName = TXTLASTNAME.Text;
                Age = int.Parse(TXTAGE.Text);
                Gender = CBGENDER.Text;
                Program = CBPROGRAM.Text;

                clubRegistrationQuery.RegisterStudent(ID: count, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
            }
        }
        private void BTUPDATE_Click(object sender, EventArgs e)
        {
            update fupdate = new update();
            fupdate.Show();
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void BTREFRESH_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
            this.clubMembersTableAdapter.Fill(this.clubDBDataSet.ClubMembers);
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();
            comboboxes();



            
        }

        private void TXTLASTNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void TXTFIRSTNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTMIDDLENAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTAGE_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBGENDER_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGCLUBMEMBER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            DGCLUBMEMBER.DataSource = clubRegistrationQuery.bindingSource;
            DGCLUBMEMBER.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

 


        }


    }
