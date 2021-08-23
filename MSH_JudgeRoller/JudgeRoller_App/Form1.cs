using JudgeRoller_DLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JudgeRoller_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private UniversalTable UT = new UniversalTable();
        private string ROLLING = "ROLLING";
        private int RollResult = new int();

        private void RollingAlert(int time)
        {
            lblResult.Text = ROLLING;
            pnlResult.BackColor = Color.Black;
            System.Threading.Thread.Sleep(time);
        }

        private void UpdateKarmaCosts()
        {
            if (UT.CostToGreen < 0) lblGreenCost.Text = "NA";
            else lblGreenCost.Text = UT.CostToGreen.ToString();
            if (UT.CostToYellow < 0) lblYellowCost.Text = "NA";
            else lblYellowCost.Text = UT.CostToYellow.ToString();
            if (UT.CostToRed < 0) lblRedCost.Text = "NA";
            else lblRedCost.Text = UT.CostToRed.ToString();
        }

        private void UpdateResult(string color)
        {
            pnlResult.BackColor = Color.Blue;
            lblResult.Text = "";
            System.Threading.Thread.Sleep(250);
            switch (color)
            {
                case "WHITE":
                    {
                        pnlResult.BackColor = Color.White;
                        UpdateKarmaCosts();
                        break;
                    }
                case "GREEN":
                    {
                        pnlResult.BackColor = Color.Green;
                        UpdateKarmaCosts();
                        break;
                    }
                case "YELLOW":
                    {
                        pnlResult.BackColor = Color.Yellow;
                        UpdateKarmaCosts();
                        break;
                    }
                case "RED":
                    {
                        pnlResult.BackColor = Color.Red;
                        UpdateKarmaCosts();
                        break;
                    }
                default:
                    {
                        pnlResult.BackColor = Color.Gray;
                        UpdateKarmaCosts();
                        break;
                    }
            }
            string RollType = cboRollType.SelectedItem.ToString();

            switch (RollType)
            {
                case "FEAT":
                    {
                        lblResult.Text = color;
                        break;
                    }
                case "Blunt Attack":
                    {
                        if (color == "WHITE") lblResult.Text = "MISS";
                        else if (color == "GREEN") lblResult.Text = "HIT";
                        else if (color == "YELLOW") lblResult.Text = "SLAM";
                        else if (color == "RED") lblResult.Text = "STUN";
                        break;
                    }
                case "Edged Attack":
                    {
                        if (color == "WHITE") lblResult.Text = "MISS";
                        else if (color == "GREEN") lblResult.Text = "HIT";
                        else if (color == "YELLOW") lblResult.Text = "STUN";
                        else if (color == "RED") lblResult.Text = "KILL";
                        break;
                    }
                case "Shooting Attack":
                    {
                        if (color == "WHITE") lblResult.Text = "MISS";
                        else if (color == "GREEN") lblResult.Text = "HIT";
                        else if (color == "YELLOW") lblResult.Text = "BULLSEYE";
                        else if (color == "RED") lblResult.Text = "KILL";
                        break;
                    }
                case "Throwing Edged":
                    {
                        if (color == "WHITE") lblResult.Text = "MISS";
                        else if (color == "GREEN") lblResult.Text = "HIT";
                        else if (color == "YELLOW") lblResult.Text = "STUN";
                        else if (color == "RED") lblResult.Text = "KILL";
                        break;
                    }
                case "Throwing Blunt":
                    {
                        if (color == "WHITE") lblResult.Text = "MISS";
                        else if (color == "GREEN") lblResult.Text = "HIT";
                        else if (color == "YELLOW") lblResult.Text = "HIT";
                        else if (color == "RED") lblResult.Text = "STUN";
                        break;
                    }
                case "Energy":
                    {
                        if (color == "WHITE") lblResult.Text = "MISS";
                        else if (color == "GREEN") lblResult.Text = "HIT";
                        else if (color == "YELLOW") lblResult.Text = "BULLSEYE";
                        else if (color == "RED") lblResult.Text = "KILL";
                        break;
                    }
                case "Force":
                    {
                        if (color == "WHITE") lblResult.Text = "MISS";
                        else if (color == "GREEN") lblResult.Text = "HIT";
                        else if (color == "YELLOW") lblResult.Text = "BULLSEYE";
                        else if (color == "RED") lblResult.Text = "STUN";
                        break;
                    }
                case "Grappling":
                    {
                        if (color == "WHITE") lblResult.Text = "MISS";
                        else if (color == "GREEN") lblResult.Text = "MISS";
                        else if (color == "YELLOW") lblResult.Text = "PARTIAL";
                        else if (color == "RED") lblResult.Text = "HOLD";
                        break;
                    }
                case "Grabbing":
                    {
                        if (color == "WHITE") lblResult.Text = "MISS";
                        else if (color == "GREEN") lblResult.Text = "TAKE";
                        else if (color == "YELLOW") lblResult.Text = "GRAB";
                        else if (color == "RED") lblResult.Text = "BREAK";
                        break;
                    }
                case "Escaping":
                    {
                        if (color == "WHITE") lblResult.Text = "MISS";
                        else if (color == "GREEN") lblResult.Text = "MISS";
                        else if (color == "YELLOW") lblResult.Text = "ESCAPE";
                        else if (color == "RED") lblResult.Text = "REVERSE";
                        break;
                    }
                case "Charging":
                    {
                        if (color == "WHITE") lblResult.Text = "MISS";
                        else if (color == "GREEN") lblResult.Text = "HIT";
                        else if (color == "YELLOW") lblResult.Text = "SLAM";
                        else if (color == "RED") lblResult.Text = "STUN";
                        break;
                    }
                case "Dodging":
                    {
                        if (color == "WHITE") lblResult.Text = "NONE";
                        else if (color == "GREEN") lblResult.Text = "-2CS";
                        else if (color == "YELLOW") lblResult.Text = "-4CS";
                        else if (color == "RED") lblResult.Text = "-6CS";
                        break;
                    }
                case "Evading":
                    {
                        if (color == "WHITE") lblResult.Text = "AUTOHIT";
                        else if (color == "GREEN") lblResult.Text = "EVASION";
                        else if (color == "YELLOW") lblResult.Text = "EVASION +1CS COUNTER";
                        else if (color == "RED") lblResult.Text = "EVASION +2CS COUNTER";
                        break;
                    }
                case "Blocking":
                    {
                        if (color == "WHITE") lblResult.Text = "STRENGTH -6CS ARMOR";
                        else if (color == "GREEN") lblResult.Text = "STRENTH -4CS ARMOR";
                        else if (color == "YELLOW") lblResult.Text = "STRENGTH -2CS ARMOR";
                        else if (color == "RED") lblResult.Text = "STRENGTH +1CS ARMOR";
                        break;
                    }
                case "Catching":
                    {
                        if (color == "WHITE") lblResult.Text = "AUTOHIT";
                        else if (color == "GREEN") lblResult.Text = "MISS";
                        else if (color == "YELLOW") lblResult.Text = "DAMAGE";
                        else if (color == "RED") lblResult.Text = "CATCH";
                        break;
                    }
                case "Stun":
                    {
                        if (color == "WHITE") lblResult.Text = String.Format("Stunned: {0} Rounds", UT.D10().ToString());
                        else if (color == "GREEN") lblResult.Text = "Stunned: 1 Round";
                        else if (color == "YELLOW") lblResult.Text = "NOT STUNNED";
                        else if (color == "RED") lblResult.Text = "NOT STUNNED";
                        break;
                    }
                case "Slam":
                    {
                        if (color == "WHITE") lblResult.Text = "GRAND SLAM!";
                        else if (color == "GREEN") lblResult.Text = "1 AREA";
                        else if (color == "YELLOW") lblResult.Text = "STAGGER";
                        else if (color == "RED") lblResult.Text = "NONE";
                        break;
                    }
                case "Kill":
                    {
                        if (color == "WHITE") lblResult.Text = "ENDURANCE LOSS";
                        else if (color == "GREEN") lblResult.Text = "EDGED/SHOOTING ENDURANCE LOSS";
                        else if (color == "YELLOW") lblResult.Text = "NONE";
                        else if (color == "RED") lblResult.Text = "NONE";
                        break;
                    }
            }
        }

        private void UpdateKarmaCosts(string color)
        {
            
        }

        private void btnShift0_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Shift-0", out RollResult));
        }

        private void btnFeeble_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Feeble", out RollResult));
        }

        private void btnPoor_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Poor", out RollResult));
        }

        private void btnTypical_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Typical", out RollResult));
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Good", out RollResult));
        }

        private void btnExcellent_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Excellent", out RollResult));
        }

        private void btnRemarkable_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Remarkable", out RollResult));
        }

        private void btnIncredible_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Incredible", out RollResult));
        }

        private void btnAmazing_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Amazing", out RollResult));
        }

        private void btnMonstrous_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Monstrous", out RollResult));
        }

        private void btnUnearthly_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Unearthly", out RollResult));
        }

        private void btnShiftX_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Shift-X", out RollResult));
        }

        private void btnShiftY_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Shift-Y", out RollResult));
        }

        private void btnShiftZ_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Shift-Z", out RollResult));
        }

        private void btnClass1000_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Class-1000", out RollResult));
        }

        private void btnClass3000_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Class-3000", out RollResult));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Class-5000", out RollResult));
        }

        private void btnBeyond_Click(object sender, EventArgs e)
        {
            UpdateResult(UT.RollFEAT("Beyond", out RollResult));
        }
    }
}
