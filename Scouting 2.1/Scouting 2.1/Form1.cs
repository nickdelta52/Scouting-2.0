using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scouting_2._1
{
    public partial class Form1 : Form
    {
        public Team[] teams;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teams = new Team[6000];
            newTeam(811,  "111111111");
            newTeam(1519, "000000000");
            newTeam(292,  "100101101");
            newTeam(1234, "001010101");
            newTeam(445,  "111001000");
        }
        //Pit
        private void chkPitClimb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPitHPS_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Match
        public Team selected;
        private void btnMatchTeam_Click(object sender, EventArgs e)
        {
            Team input = searchNumber(teams, int.Parse(tbMatchTeam.Text));
            if (input != null)
            {
                selected = input;
                lblMatchTeam.Text = "Team: " + selected.number;
            }
            else
            {
                lblMatchTeam.Text = "Team: ";
            }
        }

        //View

        //Other
        public void newTeam(int number, string binary)
        {
            Team team = new Team(number, binary);
            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i] == null)
                {
                    teams[i] = team;
                    break;
                }
            }
        }

        public Team searchNumber(Team[] teams, int number)
        {
            foreach (Team team in teams)
            {
                if (team != null)
                {
                    if (team.number == number)
                    {
                        return team;
                    }
                }
            }
            return null;
        }
    }
}
