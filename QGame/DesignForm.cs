/* QGame Puzzle Application
 * PROG2370 Assignment 2
 * 
 * Form Name: DesignForm.cs
 * 
 * Revision History
 *      Tonnicca Gelacio, 2018-09-22: Created
 *      Tonnicca Gelacio, 2018-09-22: UI Created
 *      Tonnicca Gelacio, 2018-09-24: Code Updated
 *      Tonnicca Gelacio, 2018-09-25: Code Updated
 *      Tonnicca Gelacio, 2018-09-26: Debugging
 *      Tonnicca Gelacio, 2020-05-11: Updated door icons
 * 
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
    /// Class to design a level for QGame.
    /// </summary>
    public partial class DesignForm : Form
    {
        //Declare enum MyTool
        enum MyTool
        {
            None,
            Wall,
            BlueDoor,
            GreenDoor,
            RedDoor,
            YellowDoor,
            BlueBox,
            GreenBox,
            RedBox,
            YellowBox
        }

        //Declarations - Global Variables
        int numberOfRows;
        int numberOfColumns;
        MyTool currentTool;
        Tile[,] tiles;

        //Declarations - Constants
        private const int INIT_TOP = 20;
        private const int INIT_LEFT = 20;
        private const int WIDTH = 65;
        private const int HEIGHT = 65;
        private const int VGAP = 10;

        /// <summary>
        /// The default constructor of the class.
        /// </summary>
        public DesignForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event handler of Generate button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                numberOfRows = int.Parse(txtNumberOfRows.Text);

                try
                {
                    numberOfColumns = int.Parse(txtNumberOfColumns.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid number for number of columns.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error in Number of Columns: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for number of rows.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error in Number of Rows: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Declarations and Initializations
            tiles = new Tile[numberOfRows, numberOfColumns];
            int x = INIT_LEFT;
            int y = INIT_TOP;

            //Generate picture boxes
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Tile b = new Tile();
                    tiles[i, j] = b;

                    //Set Properties of Tiles
                    b.Left = x;
                    b.Top = y;
                    b.Width = WIDTH;
                    b.Height = HEIGHT;
                    b.BorderStyle = BorderStyle.Fixed3D;
                    b.row = i;
                    b.column = j;

                    //Add New Controls to Panel
                    pnlLayout.Controls.Add(b);

                    //Assign Event Handler
                    b.Click += B_Click;

                    x += WIDTH + VGAP;

                }

                //Modify Next Tile
                x = INIT_LEFT;
                y += HEIGHT + VGAP;
            }
        }

        /// <summary>
        /// Click event handler of generated picture boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Click(object sender, EventArgs e)
        {
            Tile b = (Tile)sender;

            switch (currentTool)
            {
                case MyTool.None:
                    b.Image = QGame.Properties.Resources.blank;
                    b.toolType = 0;
                    break;
                case MyTool.Wall:
                    b.Image = QGame.Properties.Resources.wall;
                    b.toolType = 1;
                    break;
                case MyTool.BlueDoor:
                    b.Image = QGame.Properties.Resources.bluedoor;
                    b.toolType = 2;
                    break;
                case MyTool.GreenDoor:
                    b.Image = QGame.Properties.Resources.greendoor;
                    b.toolType = 3;
                    break;
                case MyTool.RedDoor:
                    b.Image = QGame.Properties.Resources.reddoor;
                    b.toolType = 4;
                    break;
                case MyTool.YellowDoor:
                    b.Image = QGame.Properties.Resources.yellowdoor;
                    b.toolType = 5;
                    break;
                case MyTool.BlueBox:
                    b.Image = QGame.Properties.Resources.bluebox;
                    b.toolType = 6;
                    break;
                case MyTool.GreenBox:
                    b.Image = QGame.Properties.Resources.greenbox;
                    b.toolType = 7;
                    break;
                case MyTool.RedBox:
                    b.Image = QGame.Properties.Resources.redbox;
                    b.toolType = 8;
                    break;
                case MyTool.YellowBox:
                    b.Image = QGame.Properties.Resources.yellowbox;
                    b.toolType = 9;
                    break;
                default:
                    b.toolType = 0;
                    break;
            }
        }

        /// <summary>
        /// Click event handler of toolbox item - None button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNone_Click(object sender, EventArgs e)
        {
            currentTool = MyTool.None;
        }

        /// <summary>
        /// Click event handler of toolbox item - Wall button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWall_Click(object sender, EventArgs e)
        {
            currentTool = MyTool.Wall;
        }

        /// <summary>
        /// Click event handler of toolbox item - Blue Door button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlueDoor_Click(object sender, EventArgs e)
        {
            currentTool = MyTool.BlueDoor;
        }

        /// <summary>
        /// Click event handler of toolbox item - Blue Box button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlueBox_Click(object sender, EventArgs e)
        {
            currentTool = MyTool.BlueBox;
        }

        /// <summary>
        /// Click event handler of toolbox item - Green Door button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGreenDoor_Click(object sender, EventArgs e)
        {
            currentTool = MyTool.GreenDoor;
        }

        /// <summary>
        /// Click event handler of toolbox item - Green Box button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGreenBox_Click(object sender, EventArgs e)
        {
            currentTool = MyTool.GreenBox;
        }

        /// <summary>
        /// Click event handler of toolbox item - Red Door button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRedDoor_Click(object sender, EventArgs e)
        {
            currentTool = MyTool.RedDoor;
        }

        /// <summary>
        /// Click event handler of toolbox item - Red Box button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRedBox_Click(object sender, EventArgs e)
        {
            currentTool = MyTool.RedBox;
        }

        /// <summary>
        /// Click event handler of toolbox item - Yellow Door button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYellowDoor_Click(object sender, EventArgs e)
        {
            currentTool = MyTool.YellowDoor;
        }

        /// <summary>
        /// Click event handler of toolbox item - Yellow Box button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYellowBox_Click(object sender, EventArgs e)
        {
            currentTool = MyTool.YellowBox;
        }

        /// <summary>
        /// Click event handler of Save in File menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSave.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    string fileName;
                    fileName = dlgSave.FileName;

                    SaveFile(fileName);

                    MessageBox.Show("File successfully saved.", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    break;

                case DialogResult.Cancel:
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Save the maze as a text file.
        /// </summary>
        /// <param name="fileName">String containing file name.</param>
        private void SaveFile(string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(numberOfRows);
            writer.WriteLine(numberOfColumns);

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    // save tile details to file
                    writer.WriteLine(i.ToString() + "|" +
                        j.ToString() + "|" +
                        tiles[i, j].toolType.ToString());
                }
            }

            writer.Close();
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
    }
}
