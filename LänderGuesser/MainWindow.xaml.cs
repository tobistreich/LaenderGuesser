﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LänderGuesser
{
    public partial class MainWindow : Window
    {
        int level;
        int maxLevel = 14;
        int health = 3;
        static bool gamePlayed = false;
        string currentDirectory = System.IO.Directory.GetCurrentDirectory();

        List<int> availableLevels = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            startMessage();

            /* put all available Levels into the list */
            for (int i = 1; i <= maxLevel; i++) 
            {
                availableLevels.Add(i);
            }

            // Start the first level
            randomNewLevel();
            updateImage();

            updateHealth();
            Heart1.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/heart.png")));
            Heart2.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/heart.png")));
            Heart3.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/heart.png")));
        }
        private void checkInputButtonClicked(object sender, RoutedEventArgs e)
        {
            if (level == 1 && Input_TextBox.Text == "DEUTSCHLAND" || Input_TextBox.Text == "GERMANY" ||
                level == 2 && Input_TextBox.Text == "ITALIEN" || Input_TextBox.Text == "ITALY" ||
                level == 3 && Input_TextBox.Text == "JAPAN" || 
                level == 4 && Input_TextBox.Text == "KENIA" || Input_TextBox.Text == "KENYA" ||
                level == 5 && Input_TextBox.Text == "LITAUEN" || Input_TextBox.Text == "LITHUANIA" ||
                level == 6 && Input_TextBox.Text == "MALTA" ||
                level == 7 && Input_TextBox.Text == "MONACCO" || Input_TextBox.Text == "MONAKKO" ||
                level == 8 && Input_TextBox.Text == "KANADA" || Input_TextBox.Text == "CANADA" ||
                level == 9 && Input_TextBox.Text == "DENMARK" || Input_TextBox.Text == "DÄNEMARK" ||
                level == 10 && Input_TextBox.Text == "FRANKREICH" || Input_TextBox.Text == "FRANCE" ||
                level == 11 && Input_TextBox.Text == "INDIEN" || Input_TextBox.Text == "INDIA" ||
                level == 12 && Input_TextBox.Text == "IRLAND" || Input_TextBox.Text == "IRELAND" ||
                level == 13 && Input_TextBox.Text == "LUXEMBURG" || Input_TextBox.Text == "LUXEMBOURG" ||
                level == 14 && Input_TextBox.Text == "MEXIKO" || Input_TextBox.Text == "MEXICO"
                ) 
            {
                Next_Button.Visibility = Visibility.Visible;
                Input_TextBox.Background = Brushes.Green;
            }
            else
            {
                Guess_Button.Background = Brushes.Red;
                Input_TextBox.Background = Brushes.Red;
                health--;
                updateHealth();
            }
        }


        private void nextButtonClicked(object sender, RoutedEventArgs e)
        {
            Input_TextBox.Background = Brushes.Transparent;
            Guess_Button.Background = Brushes.Transparent;
            Input_TextBox.Clear();
            Next_Button.Visibility = Visibility.Collapsed;

            if (availableLevels.Count > 0)
            {
                randomNewLevel();
                updateImage();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Congratulations! You've completed all levels! Do you want to play again?", "Game Over", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    resetGame();
                }
                else
                {
                    Close();
                }
            }
        }

        private void updateImage()
        {
            if (level == 1) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/germany.png")));
            else if (level == 2) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/italy.jpg")));
            else if (level == 3) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/japan.jpg")));
            else if (level == 4) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/kenya.jpg")));
            else if (level == 5) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/lithuania.jpg")));
            else if (level == 6) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/malta.jpg")));
            else if (level == 7) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/monaco.jpg")));
            else if (level == 8) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/canada.jpg")));
            else if (level == 9) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/denmark.jpg")));
            else if (level == 10) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/france.jpg")));
            else if (level == 11) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/india.jpg")));
            else if (level == 12) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/ireland.jpg")));
            else if (level == 13) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/luxembourg.jpg")));
            else if (level == 14) LevelImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, "Images/mexico.jpg")));

        }

        private void updateHealth()
        {
            if (health <= 0)
            {
                MessageBox.Show("GAME OVER, dein Score ist: " + level.ToString());
                MainWindow window = new MainWindow();
                window.Show();
                this.Visibility = Visibility.Collapsed;
            }
            else if (health == 3)
            {
                Heart1.Visibility = Visibility.Visible;
                Heart2.Visibility = Visibility.Visible;
                Heart3.Visibility = Visibility.Visible;
            }
            else if (health == 2)
            {
                Heart1.Visibility = Visibility.Visible;
                Heart2.Visibility = Visibility.Visible;
                Heart3.Visibility = Visibility.Collapsed;
            }
            else if (health == 1)
            {
                Heart1.Visibility = Visibility.Visible;
                Heart2.Visibility = Visibility.Collapsed;
                Heart3.Visibility = Visibility.Collapsed;
            }
        }

        private void randomNewLevel()
        {
            // Choose a random level from the available levels
            int randomLevel = new Random().Next(availableLevels.Count);
            // Get the level from the list
            level = availableLevels[randomLevel];
            // Remove the chosen level from the list to avoid repetition
            availableLevels.RemoveAt(randomLevel);
        }

        private void resetGame()
        {
            availableLevels.Clear();
            for (int i = 1; i <= maxLevel; i++)
            {
                availableLevels.Add(i);
            }

            level = 1;
            health = 3;
            
            MainWindow window = new MainWindow();
            window.Show();
            this.Visibility = Visibility.Collapsed;

            randomNewLevel();
            updateImage();
            updateHealth();
        }
        private void startMessage()
        {
            if (!gamePlayed)
            {
                MessageBox.Show("Um dieses Spiel zu spielen gib bitte das zu sehende Land auf Deutsch oder Englisch ein, " +
                "wenn du dir sicher bist drückst du auf den Guess Knopf, um zu sehen ob es dieses Land war," +
                " wenn nicht wird dir ein Leben abgezogen, Leben hast du insgesamt 3 Stück, sind sie weg: GAME OVER. Wenn das Land korrekt erraten wurde," +
                " erscheint ein Next Knopf mit dem du auf das nächste Level kommst");
                gamePlayed = true;
            }

        }

        private void showHelpMenu(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Um dieses Spiel zu spielen gib bitte das zu sehende Land auf Deutsch oder Englisch ein, " +
                "wenn du dir sicher bist drückst du auf den Guess Knopf, um zu sehen ob es dieses Land war," +
                " wenn nicht wird dir ein Leben abgezogen, Leben hast du insgesamt 3 Stück, sind sie weg: GAME OVER. Wenn das Land korrekt erraten wurde," +
                " erscheint ein Next Knopf mit dem du auf das nächste Level kommst");
        }
    }
}
