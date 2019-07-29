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
        
        string[] questions = { "Can you", "How will I", "Is it normal to", "Can I", "Is it legal to", "How to", "Would my mom hate me if I", "Should I confess that I", "Why does my son", "How to stop dog from" };
        string[] verbs = { "marry", "kiss", "inject", "fuck", "hang", "swallow", "stroke", "fill", "talk to", "view", "see", "experience", "slam", "emancipate" };
        string[] nouns = { "my cousin", "cows", "farm animals", "iguanas", "French people", "frogs", "fictional characters", "my 'friend'", "my sister", "pigs", "my priest", "my boss" };

        public Main()
        {
            InitializeComponent();
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            var rnd = new Random(DateTime.Now.Millisecond);

            string question = questions[rnd.Next(0, questions.Length)];
            string verb = verbs[rnd.Next(0, verbs.Length)];
            string noun = nouns[rnd.Next(0, nouns.Length)];

            string query = String.Format("{0} {1} {2}?", question, verb, noun);

            if (cbxActuallySearch.Checked)
            {
                System.Diagnostics.Process.Start(GetFirstResult(query).ToString());
            }
            else
            {
                MessageBox.Show(query);
            }
            
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
