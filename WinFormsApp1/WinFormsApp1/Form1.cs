namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int hod, counter = 0;
        int[,] x = new int[3, 3];

        public Form1()
        {
            InitializeComponent();

            button1.Click += new System.EventHandler(this.button_Click);
            button2.Click += new System.EventHandler(this.button_Click);
            button3.Click += new System.EventHandler(this.button_Click);
            button4.Click += new System.EventHandler(this.button_Click);
            button5.Click += new System.EventHandler(this.button_Click);
            button6.Click += new System.EventHandler(this.button_Click);
            button7.Click += new System.EventHandler(this.button_Click);
            button8.Click += new System.EventHandler(this.button_Click);
            button9.Click += new System.EventHandler(this.button_Click);

            button1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            button2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            button2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            button3.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            button3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            button4.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            button4.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            button5.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            button5.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            button6.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            button6.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            button7.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            button7.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            button8.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            button8.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            button9.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            button9.MouseLeave += new System.EventHandler(this.button_MouseLeave);
        }

        // Победа Крестика
        void WinnerX()
        {
            winnerText.Visible = true;
            winnerText.Text = "Выиграл Крестик";
            winnerText.ForeColor = Color.RoyalBlue;
        }

        // Победа нолика
        void WinnerO()
        {
            winnerText.Visible = true;
            winnerText.Text = "Выиграл Нолик";
            winnerText.ForeColor = Color.IndianRed;
        }

        // Ничья
        void Draw()
        {
            drawText.Visible = true;
        }

        // Проверка результата матча
        void WinnerCheck()
        {
            // Случаи с ничьёй
            if (counter == 9) Draw();

            // Случаи с победой
            else
            {
                // Случаи победы нолика
                // Строки
                if (button1.Text + button2.Text + button3.Text == "ooo")
                {
                    WinnerO();
                }
                else if (button4.Text + button5.Text + button6.Text == "ooo")
                {
                    WinnerO();
                }
                else if (button7.Text + button8.Text + button9.Text == "ooo")
                {
                    WinnerO();
                }
                //Столбцы
                else if (button1.Text + button4.Text + button7.Text == "ooo")
                {
                    WinnerO();
                }
                else if (button2.Text + button5.Text + button8.Text == "ooo")
                {
                    WinnerO();
                }
                else if (button3.Text + button6.Text + button9.Text == "ooo")
                {
                    WinnerO();
                }
                // Диагонали
                else if (button1.Text + button5.Text + button9.Text == "ooo")
                {
                    WinnerO();
                }
                else if (button3.Text + button5.Text + button7.Text == "ooo")
                {
                    WinnerO();
                }

                // Случаи победы крестика
                // Строки
                else if (button1.Text + button2.Text + button3.Text == "xxx")
                {
                    WinnerX();
                }
                else if (button4.Text + button5.Text + button6.Text == "xxx")
                {
                    WinnerX();
                }
                else if (button7.Text + button8.Text + button9.Text == "xxx")
                {
                    WinnerX();
                }
                //Столбцы
                else if (button1.Text + button4.Text + button7.Text == "xxx")
                {
                    WinnerX();
                }
                else if (button2.Text + button5.Text + button8.Text == "xxx")
                {
                    WinnerX();
                }
                else if (button3.Text + button6.Text + button9.Text == "xxx")
                {
                    WinnerX();
                }
                // Диагонали
                else if (button1.Text + button5.Text + button9.Text == "xxx")
                {
                    WinnerX();
                }
                else if (button3.Text + button5.Text + button7.Text == "xxx")
                {
                    WinnerX();
                }
            }
        }

        // Очистка кнопок
        void ClearButtons()
        {
            button1.Text = "";
            button1.ForeColor = Color.White;
            button2.Text = "";
            button2.ForeColor = Color.White;
            button3.Text = "";
            button3.ForeColor = Color.White;
            button4.Text = "";
            button4.ForeColor = Color.White;
            button5.Text = "";
            button5.ForeColor = Color.White;
            button6.Text = "";
            button6.ForeColor = Color.White;
            button7.Text = "";
            button7.ForeColor = Color.White;
            button8.Text = "";
            button8.ForeColor = Color.White;
            button9.Text = "";
            button9.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hod = rnd.Next(0, 2);

            winnerText.Visible = false;
            drawText.Visible = false;

            if (hod == 0) // Нолик
            {
                Krestik.Visible = false;
                Nolik.Visible = true;
            }
            else // Крестик
            {
                Krestik.Visible = true;
                Nolik.Visible = false;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button ThisButton = sender as Button;
            ThisButton.BackColor = Color.Gainsboro;

            if (ThisButton.Text == "")
            {
                if (hod == 0)
                {
                    ThisButton.Text = "o";
                    ThisButton.ForeColor = Color.IndianRed;

                    Nolik.Visible = false;
                    Krestik.Visible = true;
                    hod = 1;
                }
                else
                {
                    ThisButton.Text = "x";
                    ThisButton.ForeColor = Color.RoyalBlue;

                    Krestik.Visible = false;
                    Nolik.Visible = true;
                    hod = 0;
                }
                counter++;
                WinnerCheck();
            }
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button ThisButton = sender as Button;
            if (ThisButton.Text == "")
            {
                ThisButton.BackColor = Color.FromArgb(189, 251, 161);
            }
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button ThisButton = sender as Button;
            ThisButton.BackColor = Color.Gainsboro;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            hod = rnd.Next(0, 2);
            counter = 0;

            winnerText.Visible = false;
            drawText.Visible = false;

            if (hod == 0) // Нолик
            {
                Krestik.Visible = false;
                Nolik.Visible = true;
            }
            else // Крестик
            {
                Krestik.Visible = true;
                Nolik.Visible = false;
            }

            ClearButtons();
        }
    }
}
