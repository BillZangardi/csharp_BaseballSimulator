using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseballSimulator
{
    public partial class ScoreBoard : Form
    {
        BaseballSimulator game = new BaseballSimulator();
        public ScoreBoard()
        {
            InitializeComponent();
            game.NewGame();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblHomeTotal.Text = "0";
            lblAwayTotal.Text = "0";
            lblInningPlays.Text = "Inning Plays";
            lblInning.Text = "Inning \n" + "1";
            lblHome1.Text = "0";
            lblHome2.Text = "0";
            lblHome3.Text = "0";
            lblHome4.Text = "0";
            lblHome5.Text = "0";
            lblHome6.Text = "0";
            lblHome7.Text = "0";
            lblHome8.Text = "0";
            lblHome9.Text = "0";
            lblAway1.Text = "0";
            lblAway2.Text = "0";
            lblAway3.Text = "0";
            lblAway4.Text = "0";
            lblAway5.Text = "0";
            lblAway6.Text = "0";
            lblAway7.Text = "0";
            lblAway8.Text = "0";
            lblAway9.Text = "0";
            btnFullGame.Enabled = true;
            btnHalfInning.Enabled = true;
            btnSingleInning.Enabled = true;
            game.NewGame();
        }

        private void btnHalfInning_Click(object sender, EventArgs e)
        {
            game.HalfInning();
            lblHomeTotal.Text = "" + game.getHomeScore();
            lblAwayTotal.Text = "" + game.getAwayScore();
            lblInningPlays.Text = game.getInningPlays();
            lblInning.Text = "Inning \n" + game.getCurrentInning();
            if (game.getGameStatus() == true)
            {
                btnFullGame.Enabled = false;
                btnHalfInning.Enabled = false;
                btnSingleInning.Enabled = false;
            }
            int []homeScore=game.HomeInningsScore();
            lblHome1.Text = "" + homeScore[0];
            lblHome2.Text = "" + homeScore[1];
            lblHome3.Text = "" + homeScore[2];
            lblHome4.Text = "" + homeScore[3];
            lblHome5.Text = "" + homeScore[4];
            lblHome6.Text = "" + homeScore[5];
            lblHome7.Text = "" + homeScore[6];
            lblHome8.Text = "" + homeScore[7];
            lblHome9.Text = "" + homeScore[8];
            int[] awayScore = game.AwayInningsScore();
            lblAway1.Text = "" + awayScore[0];
            lblAway2.Text = "" + awayScore[1];
            lblAway3.Text = "" + awayScore[2];
            lblAway4.Text = "" + awayScore[3];
            lblAway5.Text = "" + awayScore[4];
            lblAway6.Text = "" + awayScore[5];
            lblAway7.Text = "" + awayScore[6];
            lblAway8.Text = "" + awayScore[7];
            lblAway9.Text = "" + awayScore[8];
        }

        private void btnSingleInning_Click(object sender, EventArgs e)
        {
            game.SingleInning();
            lblHomeTotal.Text = "" + game.getHomeScore();
            lblAwayTotal.Text = "" + game.getAwayScore();
            lblInningPlays.Text = game.getInningPlays();
            lblInning.Text = "Inning \n" + game.getCurrentInning();
            if (game.getGameStatus() == true)
            {
                btnFullGame.Enabled = false;
                btnHalfInning.Enabled = false;
                btnSingleInning.Enabled = false;
            }
            int[] homeScore = game.HomeInningsScore();
            lblHome1.Text = "" + homeScore[0];
            lblHome2.Text = "" + homeScore[1];
            lblHome3.Text = "" + homeScore[2];
            lblHome4.Text = "" + homeScore[3];
            lblHome5.Text = "" + homeScore[4];
            lblHome6.Text = "" + homeScore[5];
            lblHome7.Text = "" + homeScore[6];
            lblHome8.Text = "" + homeScore[7];
            lblHome9.Text = "" + homeScore[8];
            int[] awayScore = game.AwayInningsScore();
            lblAway1.Text = "" + awayScore[0];
            lblAway2.Text = "" + awayScore[1];
            lblAway3.Text = "" + awayScore[2];
            lblAway4.Text = "" + awayScore[3];
            lblAway5.Text = "" + awayScore[4];
            lblAway6.Text = "" + awayScore[5];
            lblAway7.Text = "" + awayScore[6];
            lblAway8.Text = "" + awayScore[7];
            lblAway9.Text = "" + awayScore[8];
            
        }

        private void btnFullGame_Click(object sender, EventArgs e)
        {
            game.FullGame();
            lblHomeTotal.Text = "" + game.getHomeScore();
            lblAwayTotal.Text = "" + game.getAwayScore();
            lblInningPlays.Text = game.getInningPlays();
            lblInning.Text = "Inning \n" + game.getCurrentInning();
            if (game.getGameStatus() == true)
            {
                btnFullGame.Enabled = false;
                btnHalfInning.Enabled = false;
                btnSingleInning.Enabled = false;
            }
            int[] homeScore = game.HomeInningsScore();
            lblHome1.Text = "" + homeScore[0];
            lblHome2.Text = "" + homeScore[1];
            lblHome3.Text = "" + homeScore[2];
            lblHome4.Text = "" + homeScore[3];
            lblHome5.Text = "" + homeScore[4];
            lblHome6.Text = "" + homeScore[5];
            lblHome7.Text = "" + homeScore[6];
            lblHome8.Text = "" + homeScore[7];
            lblHome9.Text = "" + homeScore[8];
            int[] awayScore = game.AwayInningsScore();
            lblAway1.Text = "" + awayScore[0];
            lblAway2.Text = "" + awayScore[1];
            lblAway3.Text = "" + awayScore[2];
            lblAway4.Text = "" + awayScore[3];
            lblAway5.Text = "" + awayScore[4];
            lblAway6.Text = "" + awayScore[5];
            lblAway7.Text = "" + awayScore[6];
            lblAway8.Text = "" + awayScore[7];
            lblAway9.Text = "" + awayScore[8];
        }
    }
}
