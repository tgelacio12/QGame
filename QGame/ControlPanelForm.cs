/* QGame Puzzle Application
 * PROG2370 Assignment 2
 * 
 * Form Name: ControlPanelForm.cs
 * 
 * Revision History
 *      Tonnicca Gelacio, 2018-09-22: Created
 *      Tonnicca Gelacio, 2018-09-22: UI Created
 *      Tonnicca Gelacio, 2018-11-02: Updated event handler for Play button
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGame
{
    /// <summary>
    /// Control panel form for QGame Puzzle Application.
    /// </summary>
    public partial class ControlPanelForm : Form
    {
        /// <summary>
        /// The default constructor of the class.
        /// </summary>
        public ControlPanelForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event handler of Design button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesign_Click(object sender, EventArgs e)
        {
            DesignForm designForm;
            designForm = new DesignForm();

            designForm.Show();
        }

        /// <summary>
        /// Click event handler of Exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Click event handler of Play button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm;
            playForm = new PlayForm();

            playForm.Show();
        }
    }
}
