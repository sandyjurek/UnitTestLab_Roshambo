using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestLab_Roshambo
{
    public class RoshamboClass
    {
        public string Play(string firstPlayer, string secondPlayer)
        {
            string result;

            if ((firstPlayer == "Rock" && secondPlayer == "Scissors") || secondPlayer == "Rock" && firstPlayer == "Scissors")
            {
                result = "Rock beat Scissors";
            }
            else if ((firstPlayer == "Paper" && secondPlayer == "Rock") || secondPlayer == "Rock" && firstPlayer == "Paper")
            {
                result = "Paper beat Rock";
            }
            else if ((firstPlayer == "Scissors" && secondPlayer == "Paper") || secondPlayer == "Paper" && firstPlayer == "Scissors")
            {
                result = "Scissors beat Paper";
            }

            else
            {
                result = "Tie!";
            }

            return result;
        }
    }
}