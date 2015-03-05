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
using System.Windows.Threading;

namespace GameBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private Board board = new Board("testmap.txt");
        private Grid[,] cells;
        SolidColorBrush grass = new SolidColorBrush(Colors.Green);
        SolidColorBrush mountain = new SolidColorBrush(Colors.Gray);
        SolidColorBrush water = new SolidColorBrush(Colors.Blue);
        SolidColorBrush swamp = new SolidColorBrush(Colors.Brown);
        SolidColorBrush black = new SolidColorBrush(Colors.Black);
        SolidColorBrush red = new SolidColorBrush(Colors.Red);
        SolidColorBrush moveOption = new SolidColorBrush(Colors.Yellow);
        private int selectedPlayerRow;
        private int selectedPlayerCol;

        /*
         * Initializes the GUI components, creates the cells 2d array, and renders the board/board spaces/characters, etc. for the first time.
         */
        public MainWindow()
        {
            InitializeComponent();
            selectedPlayerRow = 0;
            selectedPlayerCol = 0;
            cells = new Grid[board.numberRows, board.numberCols]; //a 2d array of references to the grid cells that make up the board tiles graphically
            board.boardSpace(selectedPlayerRow, selectedPlayerCol).tileCharacter = new Player(4);
            board.boardSpace(4, 1).tileCharacter = new Warrior(2);
            board.boardSpace(1, 2).tileCharacter = new Mage(3);
            board.boardSpace(11, 9).tileCharacter = new Enemy();
            board.boardSpace(13, 8).tileCharacter = new Enemy();
           
            render();
        }

        /*
         * After any changes to the stat of the board/the contained tiles & characters, or information on the display needs to be updated, this method is called.
         * Clears the UnifRomGrid that displays the board, and then remakes it, placing any characters & buttons as it goes along.
         */
        private void render()
        {
            TurnCounter.Content = ("Turn " + board.turnNumber);
            PlayerCounter.Content = ("Players Remaining: " + board.playerNumber);
            board.countEnemies();
            EnemyCounter.Content = ("Enemies Remaining: " + board.enemyNumber);

            Board.Children.Clear();
            for (int r = 0; r < board.numberRows; r++)
            {
                for (int c = 0; c < board.numberCols; c++)
                {
                    Grid cell = new Grid();
                    cells[r, c] = cell;
                    

                    switch (board.boardSpace(r, c).tileTerrain)
                    {
                        case 0: //grass tile
                            cell.Background = grass;
                            Board.Children.Add(cell);
                            break;
                        case 1: //mountain tile
                            cell.Background = mountain;
                            Board.Children.Add(cell);
                            break;
                        case 2: //water tile
                            cell.Background = water;
                            Board.Children.Add(cell);
                            break;
                        case 3: //swamp tile
                            cell.Background = swamp;
                            Board.Children.Add(cell);
                            break;
                    }
                    if (board.boardSpace(r, c).isMoveOption) //display buttons for the user to click to chose where to move the selected player.
                    {
                        Button button = new Button();
                        button.Background = moveOption;
                        button.Opacity = 0.35;
                        button.AddHandler(Button.ClickEvent, new RoutedEventHandler(MoveOption_Click));
                        cell.Children.Add(button);
                    }

                    if(board.boardSpace(r,c).containsCharacter() == true) 
                    {
                        if (board.boardSpace(r, c).tileCharacter.GetType() == typeof(GameBoard.Player) || board.boardSpace(r, c).tileCharacter.GetType().IsSubclassOf(typeof(GameBoard.Player)))
                        {
                            Ellipse circle = new Ellipse();
                            Button button = new Button();
                            circle.Fill = black;
                            button.Opacity = 0.0;
                            button.AddHandler(Button.ClickEvent, new RoutedEventHandler(Player_Click));
                            if(board.boardSpace(r, c).tileCharacter.hasMoved)
                            {
                                circle.Opacity = 0.8;
                            }
                            cell.Children.Add(circle);
                            cell.Children.Add(button); //places an invisible button over every player so that a player can be clicked on to be selected and to chose their actions
                        }
                        else if (board.boardSpace(r, c).tileCharacter.GetType() == typeof(GameBoard.Enemy) || board.boardSpace(r, c).tileCharacter.GetType().IsSubclassOf(typeof(GameBoard.Enemy)))
                        {
                            Ellipse circle = new Ellipse();
                            circle.Fill = red;
                            cell.Children.Add(circle);
                        }
                    }
                }
            }
        }

        //Events of test moving buttons being clicked - does not move enemies, doesn't count as a turn, to move the player without changing the board for ease of testing
        //Will be removed later.
        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedPlayerRow > 0 && board.boardSpace(selectedPlayerRow - 1, selectedPlayerCol).containsCharacter() == false)
            {
                board.moveCharacter(selectedPlayerRow, selectedPlayerCol, selectedPlayerRow - 1, selectedPlayerCol);
                selectedPlayerRow--;
                render();
            }
        }
        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedPlayerCol < 19 && board.boardSpace(selectedPlayerRow, selectedPlayerCol + 1).containsCharacter() == false)
            {
                board.moveCharacter(selectedPlayerRow, selectedPlayerCol, selectedPlayerRow, selectedPlayerCol + 1);
                selectedPlayerCol++;
                render();
            }
        }
        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedPlayerCol > 0 && board.boardSpace(selectedPlayerRow, selectedPlayerCol - 1).containsCharacter() == false)            
            {
                board.moveCharacter(selectedPlayerRow, selectedPlayerCol, selectedPlayerRow, selectedPlayerCol - 1);
                selectedPlayerCol--;
                render();
            }
        }
        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedPlayerRow < 19 && board.boardSpace(selectedPlayerRow + 1, selectedPlayerCol).containsCharacter() == false)
            {
                board.moveCharacter(selectedPlayerRow, selectedPlayerCol, selectedPlayerRow + 1, selectedPlayerCol);
                selectedPlayerRow++;
                render();
            }
        }
        //end of test buttons to be removed.

        /*
         * When the user clicks on a player character, bring up the interface to select their action/movement
         */
        private void Player_Click(object sender, RoutedEventArgs e)
        {
            board.clearMoveOptions(); //set all move options that were previously left as true to false before calculating the current ones.

            //loop through the grid cells/tiles to see which one the user's mouse was over when a player button was clicked - locates which player was selected
            for (int r = 0; r < board.numberRows; r++)
            {
                for (int c = 0; c < board.numberCols; c++)
                {
                    if (cells[r, c].IsMouseOver)
                    {
                        selectedPlayerRow = r;
                        selectedPlayerCol = c;
                    }
                }
            }
            if (!board.boardSpace(selectedPlayerRow, selectedPlayerCol).tileCharacter.hasMoved) //check to make sure the player hasn't already been moved, if not, bring up move options
            {
                board.moveOptions(board.boardSpace(selectedPlayerRow, selectedPlayerCol).tileCharacter.speed, selectedPlayerRow, selectedPlayerCol);
            }
            render(); 
        }

        /*
         * When a user clicks on one of the buttons to move to a tile, move the player character there, advance the turn if all players have been moved.
         */
        private void MoveOption_Click(object sender, RoutedEventArgs e)
        {
            int newRow = selectedPlayerRow;
            int newCol = selectedPlayerCol;
            //loop through the grid cells/tiles to see which one the user's mouse was over when a move button was clicked - locates which space was selected
            for (int r = 0; r < board.numberRows; r++)
            {
                for (int c = 0; c < board.numberCols; c++)
                {
                    if(cells[r, c].IsMouseOver)
                    {
                        newRow = r;
                        newCol = c;
                    }
                }
            }
            board.moveCharacter(selectedPlayerRow, selectedPlayerCol, newRow, newCol);
            board.boardSpace(newRow, newCol).tileCharacter.hasMoved = true;
            if (board.checkAllPlayersMoved())
            {
                board.nextTurn();
            }
            selectedPlayerRow = newRow;
            selectedPlayerCol = newCol;
            board.clearMoveOptions();
            render();
        }
    }
}