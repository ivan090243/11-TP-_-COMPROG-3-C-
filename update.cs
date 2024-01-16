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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
            stud();
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
                CBPROGRAMS.Items.Add(ListOfProgram[i].ToString());
            }

            string[] genders = new string[]
          {
            "Female",
            "Male"

          };

            for (int i = 0; i < 2; i++)
            {
               CBGENDERS.Items.Add(genders[i].ToString());
            }


        }
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();

        public void textboxes()
        {

            clubRegistrationQuery.DisplayText();


            TXTFIRST.Text = clubRegistrationQuery.FirstName;
            TXTMIDDLE.Text = clubRegistrationQuery.MiddleName;
            TXTLAST.Text = clubRegistrationQuery.LastName;
            TXTAGE.Text = Convert.ToString(clubRegistrationQuery.Age);
            CBGENDERS.Text = clubRegistrationQuery.Gender;
            CBPROGRAMS.Text = clubRegistrationQuery.Program;



        }

        private void stud()
        {

            clubRegistrationQuery.DisplayList();
            BTNSTUDENTID.DataSource = clubRegistrationQuery.bindingSource;
            BTNSTUDENTID.DisplayMember = "StudentId";
            clubRegistrationQuery.sId = BTNSTUDENTID.Text;


        }

        private int ID, Age;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void txtLastName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textboxes();
        }

        private void cbStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubRegistrationQuery.sId = BTNSTUDENTID.Text;  

        }


        private void update_Load(object sender, EventArgs e)
        {
            comboboxes();
            stud();

        }
        private void BTNSTUDENTID_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubRegistrationQuery.sId = BTNSTUDENTID.Text;
        }

        private void TXTLAST_TextChanged(object sender, EventArgs e)
        {

        }
        private long StudentId;
        private void button1_Click(object sender, EventArgs e)
        {
            if (BTNSTUDENTID.Text == "" || TXTFIRST.Text == "" || TXTMIDDLE.Text == "" || TXTLAST.Text == "" || TXTAGE.Text == ""
                || string.IsNullOrEmpty(Convert.ToString(CBGENDERS.Text)) || string.IsNullOrEmpty(Convert.ToString(CBPROGRAMS.Text)))
            {
                MessageBox.Show("Filup the ff.", "Error", MessageBoxButtons.OK);
            }
            else
            {

                StudentId = long.Parse(BTNSTUDENTID.Text);
                FirstName = TXTFIRST.Text;
                MiddleName = TXTMIDDLE.Text;
                LastName = TXTLAST.Text;
                Age = int.Parse(TXTAGE.Text);
                Gender = CBGENDERS.Text;
                Program = CBPROGRAMS.Text;

                clubRegistrationQuery.UpdateStudent(StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
            }
        }
        private void TXTFIRST_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTMIDDLE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTAGE_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBGENDERS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBPROGRAMS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
