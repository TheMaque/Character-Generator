using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Font and Load Files
using System.IO;
using System.Drawing.Text;
using System.Media;

namespace Character_Generator

/* Name: Reggie Telemaque
 * Date: 11/21/2019
 * 
 * FINAL: Character Generator, Intro To Programming
 * 
 * Purpose: The intent of the program is to make a game character generator that can display attributes and other images with the use of many different programming tools. 
 * 
 */

{
	public partial class Borderstrings_Generator : Form
	{


		// Font collection to import fonts
		PrivateFontCollection borderstringsfonts = new PrivateFontCollection();



		public Borderstrings_Generator()
		{
			InitializeComponent();
		}



		// Method to switch genders and enable or disable radio buttons
		private void GenderRadioButtons(object sender, EventArgs e)
		{
			RadioButton rdoGenderClicked = (RadioButton)sender;

			switch (rdoGenderClicked.Name)
			{
				// Switch statement to switch to male and enable or disable radio buttons
				case "rdoMale":
					if (rdoGenderClicked.Checked)
					{
						rdoFl4k.Enabled = true;
						rdoZero.Enabled = true;
						rdoMaya.Enabled = false;
						rdoLilith.Enabled = false;

						btnReset.Enabled = true;

					}
					else
					{
						rdoFl4k.Checked = false;
						rdoZero.Checked = false;

						rdoFl4k.Enabled = false;
						rdoZero.Enabled = false;
						rdoMaya.Enabled = true;
						rdoLilith.Enabled = true;

						btnReset.Enabled = false;


						picCharacter.Image = null;
					}
					break;
				// Switch statement to switch to female and enable or disable radio buttons
				case "rdoFemale":
					if (rdoGenderClicked.Checked)
					{
						rdoFl4k.Enabled = false;
						rdoZero.Enabled = false;
						rdoMaya.Enabled = true;
						rdoLilith.Enabled = true;

						btnReset.Enabled = true;
						btnClear.Enabled = true;

					}
					else
					{
						rdoMaya.Checked = false;
						rdoLilith.Checked = false;

						rdoFl4k.Enabled = true;
						rdoZero.Enabled = true;
						rdoMaya.Enabled = false;
						rdoLilith.Enabled = false;

						btnReset.Enabled = false;
						btnClear.Enabled = false;

						picCharacter.Image = null;

					}
					break;
			}

		}

		// Method to switch characters and disable or enable checkboxex
		private void CharacterRadioButtons(object sender, EventArgs e)
		{
			RadioButton rdoCharacterClicked = (RadioButton)sender;

			switch (rdoCharacterClicked.Name)
			{
				case "rdoFl4k":
					if (rdoCharacterClicked.Checked)
					{
						// Change Picturebox to Fl4k
						picCharacter.Image = Character_Generator.Properties.Resources.Fl4k;

						// Check Skills assigned to Fl4k
						chkSkillOff1.Checked = true;
						chkSkillOff2.Checked = true;
						chkSkillOff3.Checked = true;
						chkSkillOff4.Checked = true;
						chkSkillOff5.Checked = true;
						chkSkillOff6.Checked = true;
						chkSkillOff7.Checked = true;
						chkSkillOff8.Checked = true;
						chkSkillOff9.Checked = true;
						chkSkillOff10.Checked = true;


						txtCriticalDamage.Text = "200";
						txtMovementSpeed.Text = ".25";
						txtShield.Text = "4500";
						txtHealth.Text = "5500";

						btnReset.Enabled = true;
						btnClear.Enabled = true;
						btnPowerLevel.Enabled = true;

						chkSkillOff1.Enabled = true;
						chkSkillOff2.Enabled = true;
						chkSkillOff3.Enabled = true;
						chkSkillOff4.Enabled = true;
						chkSkillOff5.Enabled = true;
						chkSkillOff6.Enabled = true;
						chkSkillOff7.Enabled = true;
						chkSkillOff8.Enabled = true;
						chkSkillOff9.Enabled = true;
						chkSkillOff10.Enabled = true;
						chkSkillDef1.Enabled = true;
						chkSkillDef2.Enabled = true;
						chkSkillDef3.Enabled = true;
						chkSkillDef4.Enabled = true;
						chkSkillDef5.Enabled = true;
						chkSkillDef6.Enabled = true;
						chkSkillDef7.Enabled = true;
						chkSkillDef8.Enabled = true;
						chkSkillDef9.Enabled = true;
						chkSkillDef10.Enabled = true;
						chkSkillSte1.Enabled = true;
						chkSkillSte2.Enabled = true;
						chkSkillSte3.Enabled = true;
						chkSkillSte4.Enabled = true;
						chkSkillSte5.Enabled = true;
						chkSkillSte6.Enabled = true;
						chkSkillSte7.Enabled = true;
						chkSkillSte8.Enabled = true;
						chkSkillSte9.Enabled = true;
						chkSkillSte10.Enabled = true;


					}
					else
					{
						// Clear picture box
						picCharacter.Image = null;

						// Uncheck Skills assigned to Fl4k
						chkSkillOff1.Checked = false;
						chkSkillOff2.Checked = false;
						chkSkillOff3.Checked = false;
						chkSkillOff4.Checked = false;
						chkSkillOff5.Checked = false;
						chkSkillOff6.Checked = false;
						chkSkillOff7.Checked = false;
						chkSkillOff8.Checked = false;
						chkSkillOff9.Checked = false;
						chkSkillOff10.Checked = false;

						chkSkillSte1.Checked = false;
						chkSkillSte2.Checked = false;
						chkSkillSte3.Checked = false;
						chkSkillSte4.Checked = false;
						chkSkillSte5.Checked = false;
						chkSkillSte6.Checked = false;
						chkSkillSte7.Checked = false;
						chkSkillSte8.Checked = false;
						chkSkillSte9.Checked = false;
						chkSkillSte10.Checked = false;

						chkSkillDef1.Checked = false;
						chkSkillDef2.Checked = false;
						chkSkillDef3.Checked = false;
						chkSkillDef4.Checked = false;
						chkSkillDef5.Checked = false;
						chkSkillDef6.Checked = false;
						chkSkillDef7.Checked = false;
						chkSkillDef8.Checked = false;
						chkSkillDef9.Checked = false;
						chkSkillDef10.Checked = false;

						txtCriticalDamage.Text = null;
						txtMovementSpeed.Text = null;
						txtShield.Text = null;
						txtHealth.Text = null;

						lblPowerLevel.Text = null;


						btnReset.Enabled = false;
						btnClear.Enabled = false;
						btnPowerLevel.Enabled = false;

						chkSkillOff1.Enabled = false;
						chkSkillOff2.Enabled = false;
						chkSkillOff3.Enabled = false;
						chkSkillOff4.Enabled = false;
						chkSkillOff5.Enabled = false;
						chkSkillOff6.Enabled = false;
						chkSkillOff7.Enabled = false;
						chkSkillOff8.Enabled = false;
						chkSkillOff9.Enabled = false;
						chkSkillOff10.Enabled = false;
						chkSkillDef1.Enabled = false;
						chkSkillDef2.Enabled = false;
						chkSkillDef3.Enabled = false;
						chkSkillDef4.Enabled = false;
						chkSkillDef5.Enabled = false;
						chkSkillDef6.Enabled = false;
						chkSkillDef7.Enabled = false;
						chkSkillDef8.Enabled = false;
						chkSkillDef9.Enabled = false;
						chkSkillDef10.Enabled = false;
						chkSkillSte1.Enabled = false;
						chkSkillSte2.Enabled = false;
						chkSkillSte3.Enabled = false;
						chkSkillSte4.Enabled = false;
						chkSkillSte5.Enabled = false;
						chkSkillSte6.Enabled = false;
						chkSkillSte7.Enabled = false;
						chkSkillSte8.Enabled = false;
						chkSkillSte9.Enabled = false;
						chkSkillSte10.Enabled = false;

					}
					break;
				case "rdoZero":
					if (rdoCharacterClicked.Checked)
					{
						// Change Picturebox to Zero
						picCharacter.Image = Character_Generator.Properties.Resources.Zero;

						// Check Skills assigned to Zero
						chkSkillSte1.Checked = true;
						chkSkillSte2.Checked = true;
						chkSkillSte3.Checked = true;
						chkSkillSte4.Checked = true;
						chkSkillSte5.Checked = true;
						chkSkillSte6.Checked = true;
						chkSkillSte7.Checked = true;
						chkSkillSte8.Checked = true;
						chkSkillSte9.Checked = true;
						chkSkillSte10.Checked = true;

						txtCriticalDamage.Text = "350";
						txtMovementSpeed.Text = ".50";
						txtShield.Text = "5800";
						txtHealth.Text = "2750";

						btnReset.Enabled = true;
						btnClear.Enabled = true;
						btnPowerLevel.Enabled = true;

						chkSkillOff1.Enabled = true;
						chkSkillOff2.Enabled = true;
						chkSkillOff3.Enabled = true;
						chkSkillOff4.Enabled = true;
						chkSkillOff5.Enabled = true;
						chkSkillOff6.Enabled = true;
						chkSkillOff7.Enabled = true;
						chkSkillOff8.Enabled = true;
						chkSkillOff9.Enabled = true;
						chkSkillOff10.Enabled = true;
						chkSkillDef1.Enabled = true;
						chkSkillDef2.Enabled = true;
						chkSkillDef3.Enabled = true;
						chkSkillDef4.Enabled = true;
						chkSkillDef5.Enabled = true;
						chkSkillDef6.Enabled = true;
						chkSkillDef7.Enabled = true;
						chkSkillDef8.Enabled = true;
						chkSkillDef9.Enabled = true;
						chkSkillDef10.Enabled = true;
						chkSkillSte1.Enabled = true;
						chkSkillSte2.Enabled = true;
						chkSkillSte3.Enabled = true;
						chkSkillSte4.Enabled = true;
						chkSkillSte5.Enabled = true;
						chkSkillSte6.Enabled = true;
						chkSkillSte7.Enabled = true;
						chkSkillSte8.Enabled = true;
						chkSkillSte9.Enabled = true;
						chkSkillSte10.Enabled = true;
					}
					else
					{
						// Clear picture box
						picCharacter.Image = null;

						// Uncheck Skills assigned to Zero
						chkSkillSte1.Checked = false;
						chkSkillSte2.Checked = false;
						chkSkillSte3.Checked = false;
						chkSkillSte4.Checked = false;
						chkSkillSte5.Checked = false;
						chkSkillSte6.Checked = false;
						chkSkillSte7.Checked = false;
						chkSkillSte8.Checked = false;
						chkSkillSte9.Checked = false;
						chkSkillSte10.Checked = false;

						chkSkillSte1.Checked = false;
						chkSkillSte2.Checked = false;
						chkSkillSte3.Checked = false;
						chkSkillSte4.Checked = false;
						chkSkillSte5.Checked = false;
						chkSkillSte6.Checked = false;
						chkSkillSte7.Checked = false;
						chkSkillSte8.Checked = false;
						chkSkillSte9.Checked = false;
						chkSkillSte10.Checked = false;

						chkSkillDef1.Checked = false;
						chkSkillDef2.Checked = false;
						chkSkillDef3.Checked = false;
						chkSkillDef4.Checked = false;
						chkSkillDef5.Checked = false;
						chkSkillDef6.Checked = false;
						chkSkillDef7.Checked = false;
						chkSkillDef8.Checked = false;
						chkSkillDef9.Checked = false;
						chkSkillDef10.Checked = false;

						txtCriticalDamage.Text = null;
						txtMovementSpeed.Text = null;
						txtShield.Text = null;
						txtHealth.Text = null;

						lblPowerLevel.Text = null;

						btnReset.Enabled = false;
						btnClear.Enabled = false;

						btnPowerLevel.Enabled = false;

						chkSkillOff1.Enabled = false;
						chkSkillOff2.Enabled = false;
						chkSkillOff3.Enabled = false;
						chkSkillOff4.Enabled = false;
						chkSkillOff5.Enabled = false;
						chkSkillOff6.Enabled = false;
						chkSkillOff7.Enabled = false;
						chkSkillOff8.Enabled = false;
						chkSkillOff9.Enabled = false;
						chkSkillOff10.Enabled = false;
						chkSkillDef1.Enabled = false;
						chkSkillDef2.Enabled = false;
						chkSkillDef3.Enabled = false;
						chkSkillDef4.Enabled = false;
						chkSkillDef5.Enabled = false;
						chkSkillDef6.Enabled = false;
						chkSkillDef7.Enabled = false;
						chkSkillDef8.Enabled = false;
						chkSkillDef9.Enabled = false;
						chkSkillDef10.Enabled = false;
						chkSkillSte1.Enabled = false;
						chkSkillSte2.Enabled = false;
						chkSkillSte3.Enabled = false;
						chkSkillSte4.Enabled = false;
						chkSkillSte5.Enabled = false;
						chkSkillSte6.Enabled = false;
						chkSkillSte7.Enabled = false;
						chkSkillSte8.Enabled = false;
						chkSkillSte9.Enabled = false;
						chkSkillSte10.Enabled = false;





					}
					break;
				case "rdoMaya":
					if (rdoCharacterClicked.Checked)
					{
						// Change PictureBox to Maya
						picCharacter.Image = Character_Generator.Properties.Resources.Maya;

						// Check Skills assigned to Maya
						chkSkillDef1.Checked = true;
						chkSkillDef2.Checked = true;
						chkSkillDef3.Checked = true;
						chkSkillDef4.Checked = true;
						chkSkillDef5.Checked = true;
						chkSkillDef6.Checked = true;
						chkSkillDef7.Checked = true;
						chkSkillDef8.Checked = true;
						chkSkillDef9.Checked = true;
						chkSkillDef10.Checked = true;

						txtCriticalDamage.Text = "150";
						txtMovementSpeed.Text = ".15";
						txtShield.Text = "6500";
						txtHealth.Text = "4750";

						btnReset.Enabled = true;
						btnClear.Enabled = true;
						btnPowerLevel.Enabled = true;

						chkSkillOff1.Enabled = true;
						chkSkillOff2.Enabled = true;
						chkSkillOff3.Enabled = true;
						chkSkillOff4.Enabled = true;
						chkSkillOff5.Enabled = true;
						chkSkillOff6.Enabled = true;
						chkSkillOff7.Enabled = true;
						chkSkillOff8.Enabled = true;
						chkSkillOff9.Enabled = true;
						chkSkillOff10.Enabled = true;
						chkSkillDef1.Enabled = true;
						chkSkillDef2.Enabled = true;
						chkSkillDef3.Enabled = true;
						chkSkillDef4.Enabled = true;
						chkSkillDef5.Enabled = true;
						chkSkillDef6.Enabled = true;
						chkSkillDef7.Enabled = true;
						chkSkillDef8.Enabled = true;
						chkSkillDef9.Enabled = true;
						chkSkillDef10.Enabled = true;
						chkSkillSte1.Enabled = true;
						chkSkillSte2.Enabled = true;
						chkSkillSte3.Enabled = true;
						chkSkillSte4.Enabled = true;
						chkSkillSte5.Enabled = true;
						chkSkillSte6.Enabled = true;
						chkSkillSte7.Enabled = true;
						chkSkillSte8.Enabled = true;
						chkSkillSte9.Enabled = true;
						chkSkillSte10.Enabled = true;
					}
					else
					{
						// Clear picture box
						picCharacter.Image = null;

						// Uncheck Skills assigned to Maya
						chkSkillDef1.Checked = false;
						chkSkillDef2.Checked = false;
						chkSkillDef3.Checked = false;
						chkSkillDef4.Checked = false;
						chkSkillDef5.Checked = false;
						chkSkillDef6.Checked = false;
						chkSkillDef7.Checked = false;
						chkSkillDef8.Checked = false;
						chkSkillDef9.Checked = false;
						chkSkillDef10.Checked = false;

						chkSkillOff1.Checked = false;
						chkSkillOff2.Checked = false;
						chkSkillOff3.Checked = false;
						chkSkillOff4.Checked = false;
						chkSkillOff5.Checked = false;
						chkSkillOff6.Checked = false;
						chkSkillOff7.Checked = false;
						chkSkillOff8.Checked = false;
						chkSkillOff9.Checked = false;
						chkSkillOff10.Checked = false;

						chkSkillSte1.Checked = false;
						chkSkillSte2.Checked = false;
						chkSkillSte3.Checked = false;
						chkSkillSte4.Checked = false;
						chkSkillSte5.Checked = false;
						chkSkillSte6.Checked = false;
						chkSkillSte7.Checked = false;
						chkSkillSte8.Checked = false;
						chkSkillSte9.Checked = false;
						chkSkillSte10.Checked = false;

						txtCriticalDamage.Text = null;
						txtMovementSpeed.Text = null;
						txtShield.Text = null;
						txtHealth.Text = null;

						txtCriticalDamage.Text = "200";
						txtMovementSpeed.Text = ".20";
						txtShield.Text = "3500";
						txtHealth.Text = "6500";

						lblPowerLevel.Text = null;

						btnReset.Enabled = false;
						btnClear.Enabled = false;
						btnPowerLevel.Enabled = false;

						chkSkillOff1.Enabled = false;
						chkSkillOff2.Enabled = false;
						chkSkillOff3.Enabled = false;
						chkSkillOff4.Enabled = false;
						chkSkillOff5.Enabled = false;
						chkSkillOff6.Enabled = false;
						chkSkillOff7.Enabled = false;
						chkSkillOff8.Enabled = false;
						chkSkillOff9.Enabled = false;
						chkSkillOff10.Enabled = false;
						chkSkillDef1.Enabled = false;
						chkSkillDef2.Enabled = false;
						chkSkillDef3.Enabled = false;
						chkSkillDef4.Enabled = false;
						chkSkillDef5.Enabled = false;
						chkSkillDef6.Enabled = false;
						chkSkillDef7.Enabled = false;
						chkSkillDef8.Enabled = false;
						chkSkillDef9.Enabled = false;
						chkSkillDef10.Enabled = false;
						chkSkillSte1.Enabled = false;
						chkSkillSte2.Enabled = false;
						chkSkillSte3.Enabled = false;
						chkSkillSte4.Enabled = false;
						chkSkillSte5.Enabled = false;
						chkSkillSte6.Enabled = false;
						chkSkillSte7.Enabled = false;
						chkSkillSte8.Enabled = false;
						chkSkillSte9.Enabled = false;
						chkSkillSte10.Enabled = false;


					}
					break;
				case "rdoLilith":
					if (rdoCharacterClicked.Checked)
					{
						// Change PictureBox to Lilith
						picCharacter.Image = Character_Generator.Properties.Resources.Lilith;

						// Check Skills Assinged to Lilith
						chkSkillDef1.Checked = true;
						chkSkillDef2.Checked = true;
						chkSkillDef3.Checked = true;
						chkSkillDef4.Checked = true;
						chkSkillDef5.Checked = true;
						chkSkillDef6.Checked = true;
						chkSkillDef7.Checked = true;
						chkSkillDef8.Checked = true;
						chkSkillDef9.Checked = true;
						chkSkillDef10.Checked = true;

						btnReset.Enabled = true;
						btnClear.Enabled = true;
						btnPowerLevel.Enabled = true;

						chkSkillOff1.Enabled = true;
						chkSkillOff2.Enabled = true;
						chkSkillOff3.Enabled = true;
						chkSkillOff4.Enabled = true;
						chkSkillOff5.Enabled = true;
						chkSkillOff6.Enabled = true;
						chkSkillOff7.Enabled = true;
						chkSkillOff8.Enabled = true;
						chkSkillOff9.Enabled = true;
						chkSkillOff10.Enabled = true;
						chkSkillDef1.Enabled = true;
						chkSkillDef2.Enabled = true;
						chkSkillDef3.Enabled = true;
						chkSkillDef4.Enabled = true;
						chkSkillDef5.Enabled = true;
						chkSkillDef6.Enabled = true;
						chkSkillDef7.Enabled = true;
						chkSkillDef8.Enabled = true;
						chkSkillDef9.Enabled = true;
						chkSkillDef10.Enabled = true;
						chkSkillSte1.Enabled = true;
						chkSkillSte2.Enabled = true;
						chkSkillSte3.Enabled = true;
						chkSkillSte4.Enabled = true;
						chkSkillSte5.Enabled = true;
						chkSkillSte6.Enabled = true;
						chkSkillSte7.Enabled = true;
						chkSkillSte8.Enabled = true;
						chkSkillSte9.Enabled = true;
						chkSkillSte10.Enabled = true;
					}
					else
					{
						// Clear picture box
						picCharacter.Image = null;

						// Uncheck Skills Assigned to Lilith
						chkSkillDef1.Checked = false;
						chkSkillDef2.Checked = false;
						chkSkillDef3.Checked = false;
						chkSkillDef4.Checked = false;
						chkSkillDef5.Checked = false;
						chkSkillDef6.Checked = false;
						chkSkillDef7.Checked = false;
						chkSkillDef8.Checked = false;
						chkSkillDef9.Checked = false;
						chkSkillDef10.Checked = false;

						chkSkillOff1.Checked = false;
						chkSkillOff2.Checked = false;
						chkSkillOff3.Checked = false;
						chkSkillOff4.Checked = false;
						chkSkillOff5.Checked = false;
						chkSkillOff6.Checked = false;
						chkSkillOff7.Checked = false;
						chkSkillOff8.Checked = false;
						chkSkillOff9.Checked = false;
						chkSkillOff10.Checked = false;

						chkSkillSte1.Checked = false;
						chkSkillSte2.Checked = false;
						chkSkillSte3.Checked = false;
						chkSkillSte4.Checked = false;
						chkSkillSte5.Checked = false;
						chkSkillSte6.Checked = false;
						chkSkillSte7.Checked = false;
						chkSkillSte8.Checked = false;
						chkSkillSte9.Checked = false;
						chkSkillSte10.Checked = false;

						txtCriticalDamage.Text = null;
						txtMovementSpeed.Text = null;
						txtShield.Text = null;
						txtHealth.Text = null;
						lblPowerLevel.Text = null;

						btnReset.Enabled = false;
						btnClear.Enabled = false;
						btnPowerLevel.Enabled = false;

						chkSkillOff1.Enabled = false;
						chkSkillOff2.Enabled = false;
						chkSkillOff3.Enabled = false;
						chkSkillOff4.Enabled = false;
						chkSkillOff5.Enabled = false;
						chkSkillOff6.Enabled = false;
						chkSkillOff7.Enabled = false;
						chkSkillOff8.Enabled = false;
						chkSkillOff9.Enabled = false;
						chkSkillOff10.Enabled = false;
						chkSkillDef1.Enabled = false;
						chkSkillDef2.Enabled = false;
						chkSkillDef3.Enabled = false;
						chkSkillDef4.Enabled = false;
						chkSkillDef5.Enabled = false;
						chkSkillDef6.Enabled = false;
						chkSkillDef7.Enabled = false;
						chkSkillDef8.Enabled = false;
						chkSkillDef9.Enabled = false;
						chkSkillDef10.Enabled = false;
						chkSkillSte1.Enabled = false;
						chkSkillSte2.Enabled = false;
						chkSkillSte3.Enabled = false;
						chkSkillSte4.Enabled = false;
						chkSkillSte5.Enabled = false;
						chkSkillSte6.Enabled = false;
						chkSkillSte7.Enabled = false;
						chkSkillSte8.Enabled = false;
						chkSkillSte9.Enabled = false;
						chkSkillSte10.Enabled = false;


					}
					break;


			}
		}

		private void AddFont(string font)
		{
			// Add Fonts
			borderstringsfonts.AddFontFile(font);
		}

		private void LoadFonts()
		{
			// Add font "CompactBT.ttf"
			AddFont(Path.Combine(Directory.GetCurrentDirectory(), "CompactaBT.ttf"));

			// Add font "Fear Factor.ttf"
			AddFont(Path.Combine(Directory.GetCurrentDirectory(), "Fear Factor.ttf"));
		}


		private void Borderstrings_Generator_Load(object sender, EventArgs e)
		{
			// Recall back to LoadFonts Method
			LoadFonts();



			// Tools using "Fear Factor.ttf"
			rdoFemale.Font = new Font(borderstringsfonts.Families[1], 8, FontStyle.Regular);
			rdoMale.Font = new Font(borderstringsfonts.Families[1], 8, FontStyle.Regular);
			rdoFl4k.Font = new Font(borderstringsfonts.Families[1], 8, FontStyle.Regular);
			rdoZero.Font = new Font(borderstringsfonts.Families[1], 8, FontStyle.Regular);
			rdoMaya.Font = new Font(borderstringsfonts.Families[1], 8, FontStyle.Regular);
			rdoLilith.Font = new Font(borderstringsfonts.Families[1], 8, FontStyle.Regular);
			grpAttributes.Font = new Font(borderstringsfonts.Families[1], 8, FontStyle.Regular);
			txtCriticalDamage.Font = new Font(borderstringsfonts.Families[1], 8, FontStyle.Regular);
			txtMovementSpeed.Font = new Font(borderstringsfonts.Families[1], 8, FontStyle.Regular);
			txtShield.Font = new Font(borderstringsfonts.Families[1], 8, FontStyle.Regular);
			txtHealth.Font = new Font(borderstringsfonts.Families[1], 8, FontStyle.Regular);
			lblSkillCounter.Font = new Font(borderstringsfonts.Families[1], 6, FontStyle.Regular);
			lblMaxAbilities.Font = new Font(borderstringsfonts.Families[1], 6, FontStyle.Regular);



			// Tools using "Compacta BT.ttf"
			msFile.Font = new Font(borderstringsfonts.Families[0], 15, FontStyle.Regular);
			msLoad.Font = new Font(borderstringsfonts.Families[0], 15, FontStyle.Regular);
			msSave.Font = new Font(borderstringsfonts.Families[0], 15, FontStyle.Regular);
			grpGender.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblTatical.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblCompanionControl.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblRangedAttack.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblElementalDamage.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblPhasing.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblInfluencing.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblInvisability.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblAgility.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblDexertity.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblReviving.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblEndurance.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblRestoration.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblInertia.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblPhaselock.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblInstinct.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblDominance.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblTeleport.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblSmarts.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblPersuasion.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblProtection.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblFlexablity.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblPower.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblGammaDamage.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblStrength.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblDestruction.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblSilent.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblSneaking.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblBlock.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblReflection.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);
			lblStealth.Font = new Font(borderstringsfonts.Families[0], 12, FontStyle.Regular);
			lblOffensive.Font = new Font(borderstringsfonts.Families[0], 12, FontStyle.Regular);
			lblDefensive.Font = new Font(borderstringsfonts.Families[0], 12, FontStyle.Regular);
			lblCriticalDamage.Font = new Font(borderstringsfonts.Families[0], 11, FontStyle.Regular);
			lblMovementSpeed.Font = new Font(borderstringsfonts.Families[0], 11, FontStyle.Regular);
			lblShield.Font = new Font(borderstringsfonts.Families[0], 11, FontStyle.Regular);
			lblHealth.Font = new Font(borderstringsfonts.Families[0], 11, FontStyle.Regular);
			lblCharacterOverPowerLevel.Font = new Font(borderstringsfonts.Families[0], 10, FontStyle.Bold);
			txtCharacterName.Font = new Font(borderstringsfonts.Families[0], 14, FontStyle.Regular);
			lblPowerLevel.Font = new Font(borderstringsfonts.Families[0], 14, FontStyle.Regular);
			lblSneak.Font = new Font(borderstringsfonts.Families[0], 9, FontStyle.Regular);

		}
		private int checkCounter;

		private void OnCheckedChanged(object sender, EventArgs e)
		{
			// Increase or decrease the check counter
			CheckBox box = (CheckBox)sender;
			if (box.Checked)
				checkCounter++;

			else
				checkCounter--;

			// prevent checking
			if (checkCounter == 16)
			{
				MessageBox.Show("No More Than 15 Selected Abilities!", "Error: Exceeded Max Abilites");
				box.Checked = false;
			}
			lblSkillCounter.Text = checkCounter.ToString();
		}

		// Save Button Click
		private void msSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Title = "Save Character";
			save.Filter = "CSV (*.csv) | *.csv";



			if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				StreamWriter write = new StreamWriter(File.Create(save.FileName));

				write.WriteLine(txtCharacterName.Text);
				write.Dispose();

			}

		}

		// Open Button Click
		private void msLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog load = new OpenFileDialog();
			load.Title = "Load Character";
			load.Filter = "CSV (*.csv) | *.csv";



			if (load.ShowDialog() == DialogResult.OK)
			{
				StreamReader read = new StreamReader(File.OpenRead(load.FileName));

				txtCharacterName.Text = read.ReadToEnd();
				read.Dispose();
			}
		}

		// Reset Button Cick
		private void btnReset_Click(object sender, EventArgs e)
		{
			// Reset radio buttons and name box
			txtCharacterName.Clear();
			rdoMale.Checked = false;
			rdoFemale.Checked = false;
			rdoFl4k.Checked = false;
			rdoZero.Checked = false;
			rdoMaya.Checked = false;
			rdoLilith.Checked = false;

			// Clear Offensive Skills
			chkSkillOff1.Checked = false;
			chkSkillOff2.Checked = false;
			chkSkillOff3.Checked = false;
			chkSkillOff4.Checked = false;
			chkSkillOff5.Checked = false;
			chkSkillOff6.Checked = false;
			chkSkillOff7.Checked = false;
			chkSkillOff8.Checked = false;
			chkSkillOff9.Checked = false;
			chkSkillOff10.Checked = false;

			// Clear Defensive Skills
			chkSkillDef1.Checked = false;
			chkSkillDef2.Checked = false;
			chkSkillDef3.Checked = false;
			chkSkillDef4.Checked = false;
			chkSkillDef5.Checked = false;
			chkSkillDef6.Checked = false;
			chkSkillDef7.Checked = false;
			chkSkillDef8.Checked = false;
			chkSkillDef9.Checked = false;
			chkSkillDef10.Checked = false;

			// Clear Stealth Skills
			chkSkillSte1.Checked = false;
			chkSkillSte2.Checked = false;
			chkSkillSte3.Checked = false;
			chkSkillSte4.Checked = false;
			chkSkillSte5.Checked = false;
			chkSkillSte6.Checked = false;
			chkSkillSte7.Checked = false;
			chkSkillSte8.Checked = false;
			chkSkillSte9.Checked = false;
			chkSkillSte10.Checked = false;


		}

		private void Borderstrings_Generator_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Close Application from second form
			Application.Exit();
		}


		private void btnClear_Click(object sender, EventArgs e)
		{
			txtCharacterName.Clear();
			// Clear Offensive Skills
			chkSkillOff1.Checked = false;
			chkSkillOff2.Checked = false;
			chkSkillOff3.Checked = false;
			chkSkillOff4.Checked = false;
			chkSkillOff5.Checked = false;
			chkSkillOff6.Checked = false;
			chkSkillOff7.Checked = false;
			chkSkillOff8.Checked = false;
			chkSkillOff9.Checked = false;
			chkSkillOff10.Checked = false;

			// Clear Defensive Skills
			chkSkillDef1.Checked = false;
			chkSkillDef2.Checked = false;
			chkSkillDef3.Checked = false;
			chkSkillDef4.Checked = false;
			chkSkillDef5.Checked = false;
			chkSkillDef6.Checked = false;
			chkSkillDef7.Checked = false;
			chkSkillDef8.Checked = false;
			chkSkillDef9.Checked = false;
			chkSkillDef10.Checked = false;

			// Clear Stealth Skills
			chkSkillSte1.Checked = false;
			chkSkillSte2.Checked = false;
			chkSkillSte3.Checked = false;
			chkSkillSte4.Checked = false;
			chkSkillSte5.Checked = false;
			chkSkillSte6.Checked = false;
			chkSkillSte7.Checked = false;
			chkSkillSte8.Checked = false;
			chkSkillSte9.Checked = false;
			chkSkillSte10.Checked = false;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnPowerLevel_Click(object sender, EventArgs e)
		{
			// Variables
			int criticalDamage, shield, health;
			double overpowerLevel, movementSpeed;

			// Revert variables back to textbox
			criticalDamage = int.Parse(txtCriticalDamage.Text);
			movementSpeed = double.Parse(txtMovementSpeed.Text);
			shield = int.Parse(txtShield.Text);
			health = int.Parse(txtShield.Text);

			// Compute Overpower Level
			overpowerLevel = ((shield * health / 2 * movementSpeed) / criticalDamage) * 3.5;

			lblPowerLevel.Text = overpowerLevel.ToString("N");


		}

	}
}



