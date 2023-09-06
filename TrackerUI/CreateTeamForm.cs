using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> avaliableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
        }


        private void CreateSampleData()
        {
            avaliableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            avaliableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Gando" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Roberto", LastName = "Corey" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Jones", LastName = "Gando" });
        }

        private void WireUpLists()
        {

            //TODO - check a better way to do the refresh of the data binding
            selectTeamMemberDropdown.DataSource = null;

            selectTeamMemberDropdown.DataSource = avaliableTeamMembers;
            selectTeamMemberDropdown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        //private void teamNameLabel_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //}

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAdress = emailValue.Text;
                p.CellphoneNumber = cellPhoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                avaliableTeamMembers.Add(p);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellPhoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropdown.SelectedItem;


            if (p != null)
            {
                avaliableTeamMembers.Remove(p);

                selectedTeamMembers.Add(p);

                WireUpLists();
            }

        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                avaliableTeamMembers.Add(p);

                selectedTeamMembers.Remove(p);

                WireUpLists();
            }

        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

            //TODO - if the form wont close after creation, implements the form reset
        }
    }
}
