using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GraphicKolkoKrzyzyk
{
    public partial class Form1 : Form
    {
        private GomokuEngine GomokuObj;
        private bool Ready = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GomokuObj = new GomokuEngine();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
                if (textPlayer1.Text.Length > 0 && textPlayer2.Text.Length > 0)
                {
                    
                    GomokuObj.Player1 = textPlayer1.Text;
                    GomokuObj.Player2 = textPlayer2.Text;

                    GomokuObj.Start();

                    Ready = true;
                }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is Button && (Controls[i] as Button).Tag != null)
                {
                    (Controls[i] as Button).Text = "";
                }
            }
            GomokuObj.NewGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Ready)
            {
                MessageBox.Show("Podaj imiona graczy!");
                return;
            }
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            if (!GomokuObj.Set(p.X, p.Y))
            {
                MessageBox.Show("To pole nie jest puste!!!");
                return;
            }

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Ready)
            {
                MessageBox.Show("Podaj imiona graczy!");
                return;
            }
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            if (!GomokuObj.Set(p.X, p.Y))
            {
                MessageBox.Show("To pole nie jest puste!!!");
                return;
            }

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Ready)
            {
                MessageBox.Show("Podaj imiona graczy!");
                return;
            }
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            if (!GomokuObj.Set(p.X, p.Y))
            {
                MessageBox.Show("To pole nie jest puste!!!");
                return;
            }

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Ready)
            {
                MessageBox.Show("Podaj imiona graczy!");
                return;
            }
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            if (!GomokuObj.Set(p.X, p.Y))
            {
                MessageBox.Show("To pole nie jest puste!!!");
                return;
            }

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!Ready)
            {
                MessageBox.Show("Podaj imiona graczy!");
                return;
            }
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            if (!GomokuObj.Set(p.X, p.Y))
            {
                MessageBox.Show("To pole nie jest puste!!!");
                return;
            }

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!Ready)
            {
                MessageBox.Show("Podaj imiona graczy!");
                return;
            }
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            if (!GomokuObj.Set(p.X, p.Y))
            {
                MessageBox.Show("To pole nie jest puste!!!");
                return;
            }

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!Ready)
            {
                MessageBox.Show("Podaj imiona graczy!");
                return;
            }
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            if (!GomokuObj.Set(p.X, p.Y))
            {
                MessageBox.Show("To pole nie jest puste!!!");
                return;
            }

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!Ready)
            {
                MessageBox.Show("Podaj imiona graczy!");
                return;
            }
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            if (!GomokuObj.Set(p.X, p.Y))
            {
                MessageBox.Show("To pole nie jest puste!!!");
                return;
            }

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!Ready)
            {
                MessageBox.Show("Podaj imiona graczy!");
                return;
            }
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            if (!GomokuObj.Set(p.X, p.Y))
            {
                MessageBox.Show("To pole nie jest puste!!!");
                return;
            }

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
            }
        }
    }
}
