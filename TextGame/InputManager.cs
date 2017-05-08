using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextGame
{
    public class InputManager
    {
        enum ActionType { MOVEMENT = 1, SPEECH, ATTACK, ROLEPLAY };

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
                        HandleMovement(parsedInput);
                        break;
                    default:
                        Console.WriteLine("Not sure what the player is doing.  It has not been captured");
                        break;
                }
            }
        }

        public void HandleMovement(string[] parsedInput)
        {
            
            switch (parsedInput.Length)
            {
                case 1:
                    Console.WriteLine("This is a single direction.  e.g. East, North, Out");
                    break;
                default:
                    Console.WriteLine("Likely has too many arguments.  Don't want to assume.");
                    break;
            }
        }

        protected int EvaluateInputType(string[] parsedInput)
        {
            int type = 0;

            if (Program.am.MatchesAction(parsedInput[0], "speech") || Program.am.MatchesAction(parsedInput[0][0].ToString(), "speech"))
                type = (int)ActionType.SPEECH;
            else if (Program.am.MatchesAction(parsedInput[0], "movement"))
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
