/* QGame Puzzle Application
 * PROG2370 Assignment 2
 * 
 * Form Name: PlayForm.cs
 * 
 * Revision History
 *      Tonnicca Gelacio, 2018-11-02: Created
 *      Tonnicca Gelacio, 2018-11-02: UI Created
 *      Tonnicca Gelacio, 2018-11-03: Code Updated
 *      Tonnicca Gelacio, 2018-11-04: Code Updated
 *      Tonnicca Gelacio, 2018-11-04: Debugging
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGame
{
    /// <summary>
    /// Class to play QGame from a text file.
    /// </summary>
    public partial class PlayForm : Form
    {
        //Declarations - Global Variables
        int numberOfRows;
        int numberOfColumns;
        int row;
        int column;
        int tool;
        int refTile;
        int numberOfMoves = 0;
        int[,] levelArray;
        List<string> lines = new List<string>();
        Tile[,] tiles;
        Tile selectedTile;
        Tile modTile;
        Tile origTile;
        bool keepGoing;
        bool selected;

        //Declarations - Constants
        private const int INIT_TOP = 20;
        private const int INIT_LEFT = 20;
        private const int WIDTH = 60;
        private const int HEIGHT = 60;
        private const int NUMBER_OF_COLORS = 4;

        /// <summary>
        /// The default constructor of the class.
        /// </summary>
        public PlayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the game from a text file.
        /// </summary>
        /// <param name="fileName">String that specifies file name.</param>
        private void LoadFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string record;

            record = "";

            using (reader)
            {
                while ((record = reader.ReadLine()) != null)
                {
                    //add record to list
                    lines.Add(record);
                }
            }

            //Generate tiles
            GenerateLevelArray();
            DisplayTiles();

            //enable controller
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnLeft.Enabled = true;
            btnRight.Enabled = true;
        }

        /// <summary>
        /// Create array from file.
        /// </summary>
        private void GenerateLevelArray()
        {
            //Get number of rows and columns for list
            numberOfRows = int.Parse(lines[0]);
            numberOfColumns = int.Parse(lines[1]);

            //Initialize array
            levelArray = new int[numberOfRows, numberOfColumns];

            //Remove number of rows and columns from list
            lines.RemoveAt(0);
            lines.RemoveAt(0);

            //Generate array
            foreach (string line in lines)
            {
                string[] lineSplit = line.Split('|');

                row = int.Parse(lineSplit[0]);
                column = int.Parse(lineSplit[1]);
                tool = int.Parse(lineSplit[2]);

                levelArray[row, column] = tool;
            }
        }

        /// <summary>
        /// Display generated tiles on form.
        /// </summary>
        private void DisplayTiles()
        {
            tiles = new Tile[numberOfRows, numberOfColumns];

            //Generate picture boxes
            for (int i = 0; i < levelArray.GetLength(0); i++)
            {
                for (int j = 0; j < levelArray.GetLength(1); j++)
                {
                    Tile b = new Tile();

                    //Set Properties of Tiles
                    b.Left = INIT_LEFT + WIDTH * j;
                    b.Top = INIT_TOP + HEIGHT * i;
                    b.Width = WIDTH;
                    b.Height = HEIGHT;
                    //b.BorderStyle = BorderStyle.FixedSingle;

                    b.row = i;
                    b.column = j;
                    b.toolType = levelArray[i, j];

                    //Set tile image
                    if (b.toolType == 1)
                    {
                        b.Image = QGame.Properties.Resources.wall;
                    }

                    else if (b.toolType == 2)
                    {
                        b.Image = QGame.Properties.Resources.bluedoor;
                    }

                    else if (b.toolType == 3)
                    {
                        b.Image = QGame.Properties.Resources.greendoor;
                    }

                    else if (b.toolType == 4)
                    {
                        b.Image = QGame.Properties.Resources.reddoor;
                    }

                    else if (b.toolType == 5)
                    {
                        b.Image = QGame.Properties.Resources.yellowdoor;
                    }

                    else if (b.toolType == 6)
                    {
                        b.Image = QGame.Properties.Resources.bluebox;
                    }

                    else if (b.toolType == 7)
                    {
                        b.Image = QGame.Properties.Resources.greenbox;
                    }

                    else if (b.toolType == 8)
                    {
                        b.Image = QGame.Properties.Resources.redbox;
                    }

                    else if (b.toolType == 9)
                    {
                        b.Image = QGame.Properties.Resources.yellowbox;
                    }

                    else
                    {
                        b.Image = QGame.Properties.Resources.blank;
                    }

                    //Assign Event Handler
                    b.Click += B_Click;

                    //Add to picturebox array
                    tiles[i, j] = b;

                    //Add New Controls to Panel
                    pnlLayout.Controls.Add(b);
                }
            }
        }

        /// <summary>
        /// Click event handler of generated tiles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Click(object sender, EventArgs e)
        {
            selectedTile = (Tile)sender;

            if (selectedTile.toolType == 6 ||
                selectedTile.toolType == 7 ||
                selectedTile.toolType == 8 ||
                selectedTile.toolType == 9)
            {
                selectedTile.Select();
                selected = true;
            }

            else
            {
                MessageBox.Show("Please select a box.");
            }
        }

        /// <summary>
        /// Check the type of reference tile.
        /// </summary>
        /// <param name="row">Row of reference tile.</param>
        /// <param name="column">Column of reference tile.</param>
        /// <returns></returns>
        private int GetTile(int row, int column)
        {
            int refTile = levelArray[row, column];
            return refTile;
        }

        /// <summary>
        /// Count number of boxes remaining.
        /// </summary>
        /// <returns></returns>
        private void CheckBoxCount()
        {
            int boxCount = 0;

            for (int i = 0; i < levelArray.GetLength(0); i++)
            {
                for (int j = 0; j < levelArray.GetLength(1); j++)
                {
                    if (levelArray[i, j] == 6 ||
                        levelArray[i, j] == 7 ||
                        levelArray[i, j] == 8 ||
                        levelArray[i, j] == 9)
                    {
                        boxCount++;
                    }
                }
            }

            if (boxCount == 0)
            {
                EndGame();
            }
        }

        /// <summary>
        /// Remove selected tile from its original position. 
        /// </summary>
        /// <param name="row">Row of selected tile.</param>
        /// <param name="column">Column of selected tile.</param>
        private void RemoveTile(int row, int column)
        {
            levelArray[row, column] = 0;
            origTile = tiles[row, column];
            origTile.toolType = 0;
            origTile.Image = QGame.Properties.Resources.blank;
        }

        /// <summary>
        /// Move selected tile to new position.
        /// </summary>
        /// <param name="row">Row of selected tile's new position.</param>
        /// <param name="column">Column of of selected tile's new position.</param>
        /// <param name="tool">Selected tile's tool type.</param>
        private void MoveTile(int row, int column, int tool)
        {
            levelArray[row, column] = tool;
            modTile = tiles[row, column];
            modTile.toolType = tool;

            //Set tile image
            if (modTile.toolType == 6)
            {
                modTile.Image = QGame.Properties.Resources.bluebox;
            }

            else if (modTile.toolType == 7)
            {
                modTile.Image = QGame.Properties.Resources.greenbox;
            }

            else if (modTile.toolType == 8)
            {
                modTile.Image = QGame.Properties.Resources.redbox;
            }

            else
            {
                modTile.Image = QGame.Properties.Resources.yellowbox;
            }

            //update selected tile
            selectedTile = modTile;

        }

        /// <summary>
        /// Once game ends, clear form and display message box.
        /// </summary>
        private void EndGame()
        {
            MessageBox.Show("Congratulations! You have cleared this level." +
                "\nNumber of Moves: " + numberOfMoves,
                "Game End", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //clear array
            for (int i = 0; i < levelArray.GetLength(0); i++)
            {
                for (int j = 0; j < levelArray.GetLength(1); j++)
                {
                    levelArray[i, j] = 0;
                    tiles[i, j].toolType = 0;
                }
            }

            //remove  tiles from controls
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    pnlLayout.Controls.Remove(tiles[i, j]);
                }
            }

            //disable controller
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;

            //Clear number of moves
            txtNumberOfMoves.Text = "";
        }

        /// <summary>
        /// Click event handler of Up button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            // check if a box is selected
            if (!selected)
            {
                MessageBox.Show("Please select a box.");
            }

            else
            {
                //Declare local variables
                int modRow;

                //Initializations
                row = selectedTile.row;
                modRow = row;
                column = selectedTile.column;
                tool = selectedTile.toolType;
                keepGoing = true;

                do
                {
                    //Check reference tile
                    refTile = GetTile(modRow - 1, column);

                    //If reference tile is null...
                    if (refTile == 0)
                    {
                        //Continue checking...
                        modRow--;
                        keepGoing = true;
                    }

                    else
                    {
                        //If same color door...
                        if (refTile == (tool - NUMBER_OF_COLORS))
                        {
                            //remove selected tile from previous position
                            RemoveTile(row, column);

                            //set selected as null
                            selected = false;

                            //update number of moves
                            numberOfMoves++;
                            txtNumberOfMoves.Text = numberOfMoves.ToString();

                            //check if there are boxes left
                            CheckBoxCount();

                            keepGoing = false;
                        }

                        //If wall or different color door...
                        else
                        {
                            //move tile to new position
                            MoveTile(modRow, column, tool);

                            //remove selected tile from previous position
                            RemoveTile(row, column);

                            //update number of moves
                            numberOfMoves++;
                            txtNumberOfMoves.Text = numberOfMoves.ToString();

                            keepGoing = false;
                        }
                    }
                } while (keepGoing);
            }
        }

        /// <summary>
        /// Click event handler of Down button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            // check if a box is selected
            if (!selected)
            {
                MessageBox.Show("Please select a box.");
            }

            else
            {
                //Declare local variables
                int modRow;

                //Initializations
                row = selectedTile.row;
                modRow = row;
                column = selectedTile.column;
                tool = selectedTile.toolType;
                keepGoing = true;

                do
                {
                    //Check reference tile
                    refTile = GetTile(modRow + 1, column);

                    //If reference tile is null...
                    if (refTile == 0)
                    {
                        //Continue checking...
                        modRow++;
                        keepGoing = true;
                    }

                    else
                    {
                        //If same color door...
                        if (refTile == (tool - NUMBER_OF_COLORS))
                        {
                            //remove selected tile from previous position
                            RemoveTile(row, column);

                            //set selected as null
                            selected = false;

                            //update number of moves
                            numberOfMoves++;
                            txtNumberOfMoves.Text = numberOfMoves.ToString();

                            //check if there are boxes left
                            CheckBoxCount();

                            keepGoing = false;
                        }

                        //If wall or different color door...
                        else
                        {
                            //move tile to new position
                            MoveTile(modRow, column, tool);

                            //remove selected tile from previous position
                            RemoveTile(row, column);

                            //update number of moves
                            numberOfMoves++;
                            txtNumberOfMoves.Text = numberOfMoves.ToString();

                            keepGoing = false;
                        }
                    }
                } while (keepGoing);
            }
        }

        /// <summary>
        /// Click event handler of Right button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight_Click(object sender, EventArgs e)
        {
            // check if a box is selected
            if (!selected)
            {
                MessageBox.Show("Please select a box.");
            }

            else
            {
                //Declare local variables
                int modCol;

                //Initializations
                row = selectedTile.row;
                column = selectedTile.column;
                modCol = column;
                tool = selectedTile.toolType;
                keepGoing = true;

                do
                {
                    //Check reference tile
                    refTile = GetTile(row, modCol + 1);

                    //If reference tile is null...
                    if (refTile == 0)
                    {
                        //Continue checking...
                        modCol++;
                        keepGoing = true;
                    }

                    else
                    {
                        //If same color door...
                        if (refTile == (tool - NUMBER_OF_COLORS))
                        {
                            //remove selected tile from previous position
                            RemoveTile(row, column);

                            //set selected as null
                            selected = false;

                            //update number of moves
                            numberOfMoves++;
                            txtNumberOfMoves.Text = numberOfMoves.ToString();

                            //check if there are boxes left
                            CheckBoxCount();

                            keepGoing = false;
                        }

                        //If wall or different color door...
                        else
                        {
                            //move tile to new position
                            MoveTile(row, modCol, tool);

                            //remove selected tile from previous position
                            RemoveTile(row, column);

                            //update number of moves
                            numberOfMoves++;
                            txtNumberOfMoves.Text = numberOfMoves.ToString();

                            keepGoing = false;
                        }
                    }
                } while (keepGoing);
            }
        }

        /// <summary>
        /// Click event handler of Left button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeft_Click(object sender, EventArgs e)
        {
            // check if a box is selected
            if (!selected)
            {
                MessageBox.Show("Please select a box.");
            }

            else
            {
                //Declare local variables
                int modCol;

                //Initializations
                row = selectedTile.row;
                column = selectedTile.column;
                modCol = column;
                tool = selectedTile.toolType;
                keepGoing = true;

                do
                {
                    //Check reference tile
                    refTile = GetTile(row, modCol - 1);

                    //If reference tile is null...
                    if (refTile == 0)
                    {
                        //Continue checking...
                        modCol--;
                        keepGoing = true;
                    }

                    else
                    {
                        //If same color door...
                        if (refTile == (tool - NUMBER_OF_COLORS))
                        {
                            //remove selected tile from previous position
                            RemoveTile(row, column);

                            //set selected as null
                            selected = false;

                            //update number of moves
                            numberOfMoves++;
                            txtNumberOfMoves.Text = numberOfMoves.ToString();

                            //check if there are boxes left
                            CheckBoxCount();

                            keepGoing = false;
                        }

                        //If wall or different color door...
                        else
                        {
                            //move tile to new position
                            MoveTile(row, modCol, tool);

                            //remove selected tile from previous position
                            RemoveTile(row, column);

                            //update number of moves
                            numberOfMoves++;
                            txtNumberOfMoves.Text = numberOfMoves.ToString();

                            keepGoing = false;
                        }
                    }
                } while (keepGoing);
            }
        }

        /// <summary>
        /// Click event handler of Close in File menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Click event handler of Load Game in File menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgLoad.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    string fileName;
                    fileName = dlgLoad.FileName;

                    LoadFile(fileName);

                    MessageBox.Show("File successfully opened.", "File opened",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case DialogResult.Cancel:
                    break;

                default:
                    break;
            }
        }
    }
}
