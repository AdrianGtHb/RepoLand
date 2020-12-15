using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFtest14._12._20
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int player = 1;
        int flipper = 1;
        int score1 = 0;
        int score2 = 0;
        int k = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pchanger()
        {
            if (flipper % 2 == 0)
                player = 1;
            else
                player = 2;
            flipper++;
        }

        

        private void logic()
        {
            int i = 0;
            k++;
            char p;
            if (player == 1)
                p = 'X';
            else
                p = 'O';
            
            if (Convert.ToChar(eins.Content) == p && Convert.ToChar(zwei.Content) == p && Convert.ToChar(drei.Content) == p || Convert.ToChar(vier.Content) == p && Convert.ToChar(fünf.Content) == p && Convert.ToChar(sechs.Content) == p || Convert.ToChar(sieben.Content) == p && Convert.ToChar(acht.Content) == p && Convert.ToChar(neun.Content) == p)
                i++;
            if (Convert.ToChar(eins.Content) == p && Convert.ToChar(vier.Content) == p && Convert.ToChar(sieben.Content) == p || Convert.ToChar(zwei.Content) == p && Convert.ToChar(fünf.Content) == p && Convert.ToChar(acht.Content) == p || Convert.ToChar(drei.Content) == p && Convert.ToChar(sechs.Content) == p && Convert.ToChar(neun.Content) == p)
                i++;
            if (Convert.ToChar(eins.Content) == p && Convert.ToChar(fünf.Content) == p && Convert.ToChar(neun.Content) == p || Convert.ToChar(drei.Content) == p && Convert.ToChar(fünf.Content) == p && Convert.ToChar(sieben.Content) == p)
                i++;
            if (i > 0)
            {
                lbl_Won.Content = "Spieler " + player + " hat gewonnen!";
                eins.IsEnabled = false;
                zwei.IsEnabled = false;
                drei.IsEnabled = false;
                vier.IsEnabled = false;
                fünf.IsEnabled = false;
                sechs.IsEnabled = false;
                sieben.IsEnabled = false;
                acht.IsEnabled = false;
                neun.IsEnabled = false;
                if (player == 1)
                    score1++;
                else
                    score2++;
                lbl_Score.Content = "Player 1: " + score1 + "                      Player 2: " + score2;
                newg.IsEnabled = true;
            }
            else if (k == 9)
            {
                lbl_Won.Content = "Draw!";
                newg.IsEnabled = true;
            }
        }

        private void eins_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                eins.Content = "X";
                eins.Foreground = Brushes.Blue;
            }
            else
            {
                eins.Content = "O";
                eins.Foreground = Brushes.Red;
            }
            eins.IsEnabled = false;
            logic();
            Pchanger();
        }

        private void zwei_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                zwei.Content = "X";
                zwei.Foreground = Brushes.Blue;
            }
            else
            {
                zwei.Content = "O";
                zwei.Foreground = Brushes.Red;
            }
            zwei.IsEnabled = false;
            logic();
            Pchanger();
        }

        private void drei_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                drei.Content = "X";
                drei.Foreground = Brushes.Blue;
            }
            else
            {
                drei.Content = "O";
                drei.Foreground = Brushes.Red;
            }
            drei.IsEnabled = false;
            logic();
            Pchanger();
        }

        private void vier_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                vier.Content = "X";
                vier.Foreground = Brushes.Blue;
            }
            else
            {
                vier.Content = "O";
                vier.Foreground = Brushes.Red;
            }
            vier.IsEnabled = false;
            logic();
            Pchanger();
        }

        private void fünf_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                fünf.Content = "X";
                fünf.Foreground = Brushes.Blue;
            }
            else
            {
                fünf.Content = "O";
                fünf.Foreground = Brushes.Red;
            }
            fünf.IsEnabled = false;
            logic();
            Pchanger();
        }

        private void sechs_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                sechs.Content = "X";
                sechs.Foreground = Brushes.Blue;
            }
            else
            {
                sechs.Content = "O";
                sechs.Foreground = Brushes.Red;
            }
            sechs.IsEnabled = false;
            logic();
            Pchanger();
        }

        private void sieben_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                sieben.Content = "X";
                sieben.Foreground = Brushes.Blue;
            }
            else
            {
                sieben.Content = "O";
                sieben.Foreground = Brushes.Red;
            }
            sieben.IsEnabled = false;
            logic();
            Pchanger();
        }

        private void acht_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                acht.Content = "X";
                acht.Foreground = Brushes.Blue;
            }
            else
            {
                acht.Content = "O";
                acht.Foreground = Brushes.Red;
            }
            acht.IsEnabled = false;
            logic();
            Pchanger();
        }

        private void neun_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                neun.Content = "X";
                neun.Foreground = Brushes.Blue;
            }
            else
            {
                neun.Content = "O";
                neun.Foreground = Brushes.Red;
            }
            neun.IsEnabled = false;
            logic();
            Pchanger();
        }

        private void newg_Click(object sender, RoutedEventArgs e)
        {
            eins.IsEnabled = true;
            zwei.IsEnabled = true;
            drei.IsEnabled = true;
            vier.IsEnabled = true;
            fünf.IsEnabled = true;
            sechs.IsEnabled = true;
            sieben.IsEnabled = true;
            acht.IsEnabled = true;
            neun.IsEnabled = true;
            eins.Content = " ";
            zwei.Content = " ";
            drei.Content = " ";
            vier.Content = " ";
            fünf.Content = " ";
            sechs.Content = " ";
            sieben.Content = " ";
            acht.Content = " ";
            neun.Content = " ";
            lbl_Won.Content = " ";
            k = 0;
            flipper = 1;
            player = 1;
            newg.IsEnabled = false;
        }
    }
}
