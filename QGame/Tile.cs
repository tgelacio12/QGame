/* QGame Puzzle Application
 * PROG2370 Assignment 1
 * 
 * Class Name: Tile.cs
 * 
 * Revision History
 *      Tonnicca Gelacio, 2018-09-24: Created
 *      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGame
{
    /// <summary>
    /// Class for Tile.
    /// </summary>
    public class Tile : PictureBox
    {
        public int row;
        public int column;
        public int toolType;
    }
}
