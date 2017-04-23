using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextGame
{
    enum ActionType { MOVEMENT = 1, SPEECH, ATTACK, ROLEPLAY };

    public class InputManager
    {
        public InputManager()
        {
        }

        public void HandleInput(string input)
        {
            string temp = input.Trim();
            string[] parsedInput = ParseInput(temp);

            if (input != "exit")
            {
                int type = EvaluateInputType(parsedInput);

                switch (type)
                {
                    case (int)ActionType.SPEECH:
                        Console.WriteLine("The player is trying to speak.");
                        break;
                    case (int)ActionType.MOVEMENT:
                        Console.WriteLine("The player is trying to move.");
                        break;
                    default:
                        Console.WriteLine("Not sure what the player is doing.  It has not been captured");
                        break;
                }
            }
        }

        protected int EvaluateInputType(string[] parsedInput)
        {
            int type = 0;  

            if (parsedInput[0][0].Equals('\'') || parsedInput[0][0].Equals('"') || parsedInput[0] == "say")
                type = (int)ActionType.SPEECH;
            else if (parsedInput[0].Equals("go") || parsedInput[0].Equals("move"))
                type = (int)ActionType.MOVEMENT;
            else
                type = 0;

            return type;
        }

        protected string[] ParseInput(string input)
        {
            string temp = Regex.Replace(input, @"\s+", " ");
            string[] words = temp.Split(' ');
            return words;
        }
    }
}
