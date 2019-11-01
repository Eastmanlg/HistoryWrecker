using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Googler
{
    public partial class Main : Form
    {
        Random rnd = new Random();
        string[] questions = { "Can you", "How could I", "Is it normal to", "Can I", "Is it legal to", "How to", "Would my mom hate me if I", "Should I confess that I", "Why does my son", "How to stop dog from wanting to", "I want to", "My dad is going to", "My uncle says he wants to", "My mom wants to", "My brother wants to", "Is it true that you can", "What should I do if my boss wants to", "Is there a reason to", "Should I pray to", "How likely is it to", "Would I be arrested if I tried to", "Would I go to Hell if I", "Would my Grandma care if I", "Is it moral to", "Would God hate me if I", "Do gay people", "Do Asians", "Is it true that Mormons", "What if I", "My subconcious keeps trying to", "How to stop my mind from trying to", "Can I train my dog to", "Can I train my son to", "Can I train my mom to"};

        string[] verbs = { "marry", "kiss", "inject", "hang", "swallow", "stroke", "fill", "talk to", "view", "see", "experience", "slam", "emancipate", "offer Satan", "summon", "cast spells on", "commune with", "Confide in", "traffic", "sell", "enslave", "Avenge", "stab", "'stab'", "cuddle with", "sing about", "pray to", "enjoy", "'enjoy'", "capture", "eat", "impregnate", "suckle", "cradle", "hug", "'hug'", "hex", "condemn", "preach about", "prosthelize about", "read about", "research", "demonize", "collect", "deport", "gather", "categorize", "marginalize"};
        string[] nouns = { "my cousin", "cows", "farm animals", "iguanas", "French people", "frogs", "fictional characters", "my 'friend'", "my sister", "pigs", "my priest", "my boss", "Satan", "The Dark Lord", "J.K. Rollins", "Jesus Christ", "God", "Kanye West", "Snoop Lion", "Snoop Dogg", "Billy Mays", "Trump", "Davey Jones", "Tim Burton", "Tom Cruise", "Scientology", "Mormonism", "Joseph Smith", "William Eyelash", "Willy Shakespear", "Michael Scott", "The Red Sox", "Muslims", "Christians", "Catholics", "the gays", "conservative lesbians", "Liberals", "Prince Henry" };
        string[] prepositions = { "for many hours", "always", "at Walmart", "in my own house", "when pregnant", "while drunk", "before bed", "behind the barn", "after sex", "before class", "in a bag", "in Rome", "on vacation", "in the United States", "at the White House", "while I sleep"};


        public Main()
        {
            InitializeComponent();
            Console.WriteLine(String.Format("({0},{1},{2})", questions.Length.ToString(), verbs.Length.ToString(), nouns.Length.ToString()));
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                string query = GetSearchString();

                if (cbxActuallySearch.Checked)
                {
                    System.Diagnostics.Process.Start(GetFirstResult(query).ToString());
                }
                else
                {
                    //MessageBox.Show(query);
                    Console.WriteLine(query);
                }
            }
        }
        
        public string GetSearchString()
        {
            int qIndex = rnd.Next(0, questions.Length);
            int vIndex = rnd.Next(0, verbs.Length);
            int nIndex = rnd.Next(0, nouns.Length);
            int pIndex = rnd.Next(0, prepositions.Length);

            //prints the ints to the console
            //Console.WriteLine(String.Format("({0},{1},{2},{3})", qIndex.ToString(), vIndex.ToString(), nIndex.ToString(), pIndex.ToString()));

            return String.Format("{0} {1} {2} {3}?", questions[qIndex], verbs[vIndex], nouns[nIndex], prepositions[pIndex]);
        }

        public Uri GetFirstResult(string term)
        {
            // Use the I'm Feeling Lucky URL
            var url = string.Format("https://www.google.com/search?num=100&site=&source=hp&q={0}&btnI=1", term);

            HttpWebRequest req = HttpWebRequest.CreateHttp(url);
            return req.GetResponse().ResponseUri;
        }
    }
}
