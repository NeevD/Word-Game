namespace Word_Game
{
    public partial class Form1 : Form
    {
        Label[] labels = new Label[11];
        List<string> wordList = new List<string>();
        int i;
        int m = 100;
        int score;
        String[] prompts = { "Food", "Jobs", "Adjectives", "Fruit", "Furniture" };
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            labels[4] = label5;
            labels[5] = label6;
            labels[6] = label11;
            labels[7] = label12;
            labels[8] = label13;
            labels[9] = label14;

            label8.Text = "Prompt : " + prompts[rand.Next(0, 4)];
            timer1.Enabled = true;

            StreamReader file = new StreamReader("../../../resources/ukenglish.txt");
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    if (ln.Length > 1 && ln.Length < 16)
                    { wordList.Add(ln); }
                }
                file.Close();
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int j = 0; j < wordList.Count; j++)
                {
                    if (textBox1.Text == wordList[j])
                    {
                        labels[i].Text = textBox1.Text;
                        i++;
                        score++;
                        textBox1.Clear();
                    }
                }
                label7.Text = "Score = " + score;
                if (score == 10)
                {
                    timer1.Enabled = false;
                    label10.Text = "- You Win -";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < wordList.Count; j++)
            {
                if (textBox1.Text == wordList[j])
                {
                    labels[i].Text = textBox1.Text;
                    i++;
                    score++;
                    textBox1.Clear();
                }
            }
            label7.Text = "Score = " + score;
            if (score == 10)
            {
                timer1.Enabled = false;
                label10.Text = "- You Win -";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            m--;
            label9.Text = "Timer = " + m;
            if (m == 0)
            {
                timer1.Enabled = false;
                label10.Text = "- You Lose -";
            }
        }
    }
}