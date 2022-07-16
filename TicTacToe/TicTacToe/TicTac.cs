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

        public void clear_p1_choices()
        {
            player1_choices.Clear();
        }


        public void add_p2_choices(string c)
        {
            player1_choices.Add(c);
        }

        public void clear_p2_choices()
        {
            player2_choices.Clear();
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
            bool is_it_equal = false;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (p[j] == win_patterns[i, j])
                    {
                        is_it_equal = true;
                    }
                    else
                    {
                        is_it_equal = false;
                        break;
                    }

                }
                if (is_it_equal)
                {
                    is_it_equal = true;
                    break;
                }
            }
            return is_it_equal;
        }

    }
}
