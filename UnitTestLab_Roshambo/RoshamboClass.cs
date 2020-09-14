using System;
using System.Collections.Generic;
using System.Text;

namespace RoshamboLab
{
    public class RoshamboClass
    {
        public string Winner(string firstPlayer, string secondPlayer)
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