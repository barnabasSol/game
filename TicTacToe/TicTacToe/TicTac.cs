using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTac
    {
        string[,] win_patterns = new string[,] { {"b1", "b2", "b3"}, {"b4", "b5", "b6"},
                                                 {"b7", "b8", "b9"}, {"b1", "b4", "b7"},
                                                 {"b2", "b5", "b8"}, {"b3", "b6", "b9"},
                                                 {"b1", "b5", "b9"}, {"b3", "b5", "b7"}};                                       
        public string winner { get; set; }
        public string loser { get; set; }

        static private List<string> player1_choices = new List<string>(); 
        static private List<string> player2_choices = new List<string>();


        public void add_p1_choices(string c)
        {
            player1_choices.Add(c);
        }

        public void add_p2_choices(string c)
        {
            player1_choices.Add(c);
        }

        public List<string> get_p1_choices()
        {
            return player1_choices;
        }

        public List<string> get_p2_choices()
        {
            return player2_choices;
        }

        public bool check_if_won(List<string> p)
        {


        }

    }
}
