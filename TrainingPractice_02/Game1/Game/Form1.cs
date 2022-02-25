using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game : Form
    {
        GameL game;
        public Game ()
        {
            InitializeComponent();
            game = new GameL(4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start_game();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.check_nubers())
            {
                MessageBox.Show("Вы выиграли");
                start_game();
            }
        }

        private Button button(int position)
        {
            switch (position)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return null;
            }

        }

        private void Menu_start_Click(object sender, EventArgs e)
        {
            start_game();
        }

        private void start_game() // отвечает за сколько раз размешивание клеток
        {
            game.start();
            for (int j = 0; j < 7; j++)
                game.shift_random();
            refresh();
        }

        private void refresh ()
        {
            for (int position = 0; position < 16; position++)
            {
                int nr = game.Get_number(position);
                button(position).Text = nr.ToString();
                button(position).Visible = (nr > 0);
            }
        }
    }
}
