using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Generator

	/* Name: Reggie Telemaque
	 * Date: 11/21/2019
	 * 
	 * FINAL: Character Generator Menu, Intro To Programming
	 * 
	 * Purpose: The intent of the program form is to give the user a start screen that starts the other character generator form.
	 * 
	 */
{
	public partial class BorderstringsMenu : Form
	{
		public BorderstringsMenu()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			// Open second form
			Borderstrings_Generator borderStrings = new Borderstrings_Generator();

			// Show second form
			borderStrings.Show();
		}
	}
}
