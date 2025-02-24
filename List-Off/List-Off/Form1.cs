using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace List_Off
{
    public partial class List : Form
    {
        /// <summary>
        ///  Disables the ability to scale the Windows Form App via cursor drag or Minimise & Maximise Buttons Built in from Windows.
        /// </summary>
        public List()
        {
            InitializeComponent();

            // Disables ability to scale application. This ensures the view of the app will appear as intended.
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        /// <summary>
        /// Adds a Warning box after user clicks "Clear" button, this button will clear all the content on the shopping list after the user selects "Yes" on the pop up.
        /// If the user selects "no" it will back out and no data will be lost.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            // This If Statement will trigger on button click, once clicked the program will ask the user if they really want to clear the list.
            if (MessageBox.Show("Are you sure you want to Permenantly delete all List Content?", "Clear List", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                shoppingList.Items.Clear();
            }
        }

        /// <summary>
        /// This Function holds the "Add" Button code, End User will be able to input their own data to the list rather than predefined data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            // Using Visual Basic's Input box added via reference in solution explorer, users can enter their own data for the list
            // This can also define where the box will appear on the screen per an entered X & Y Coordinate.
            string listInput = Interaction.InputBox("Enter an Item:", "Add an item to Shopping List", "", 750, 350);

            // If Statement used to prevent the end user from entering x amount of characters as an input.
            // This would result in text going out of the List Border.
            if (listInput.Length > 20)
            {
                MessageBox.Show("Too Long! Try Again.");
            }

            // This else if will check if the user is inputing a null or empty value with an added space, will throw an error.
            // Also Extends to special characters like # or £.
            else if (listInput.Any(inputData => !char.IsLetterOrDigit(inputData)))
            {
                MessageBox.Show("Special Characters or No Input Detected! Try again.");
            }

            // This else if will check if the end user is trying to input a null / empty value, will throw an error.
            else if (string.IsNullOrEmpty(listInput))
            {
                MessageBox.Show("No Input Detected! Try Again.");
            }

            // if all conditions pass from above, the users input will be added to the shopping List. 
            else
            {
                shoppingList.Items.Add(listInput);
            }
        }
    }
}
