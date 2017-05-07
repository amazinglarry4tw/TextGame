using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class ActionManager
    {
        Dictionary<string, string> Actions;

        public ActionManager()
        {
            Actions = new Dictionary<string, string>();

            AddMovementActions();
            AddSpeechActions();
            PrintActions();
        }

        protected void AddMovementActions()
        {
            string[] actions = { "north", "east", "south", "west", "go", "move", "enter", "climb", "sneak", "crawl" };
            AddActions(actions, "movement");
        }

        protected void AddSpeechActions()
        {
            string[] speech = { "'", "\"", "say", "shout", "yell" };
            AddActions(speech, "speech");
        }

        protected void AddActions(string[] actions, string type)
        {
            if (actions != null)
            {
                foreach (var item in actions)
                {
                    Actions.Add(item, type);
                }
            }
        }

        public bool MatchesAction(string input, string type)
        {
            bool matches = false;
            if (Actions.ContainsKey(input.ToString()))
            {
                if (Actions[input.ToString()] == type)
                    matches = true;
            }
            return matches;
        }

        public void PrintActions()
        {
            foreach (var item in Actions)
            {
                Console.WriteLine(string.Format("{0} is of type {1}", item.Key, item.Value));
            }
        }

        public List<string> GetActionTypes(string input)
        {
            List<string> type = new List<string>();

            return type;
        }
    }
}
