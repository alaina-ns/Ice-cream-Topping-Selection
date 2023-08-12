using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // allows for streamwriter and streamreader
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Due Date: 4/11/2022
// Programmer: Alaina Smith
// project description: ice cream flavor and topping selector that saves.
namespace Lab5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //call custom method to populate combo box and list box
              PopulateBoxes();


            // set default selection for combo box
            flavorsComboBox.SelectedItem = "Vanilla";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // write order information to output file
                // this opens text files
                StreamWriter outputFile;
                outputFile = File.AppendText("Orders.txt");

                // writes current data to file
                outputFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));

                if (sugarConeRadioButton.Checked)
                {
                    outputFile.WriteLine("Sugar Cone");
                }
                else
                {
                    outputFile.WriteLine("Waffle Cone");
                }

                // write selected ice cream to file
                outputFile.WriteLine(flavorsComboBox.SelectedItem.ToString());

                for (int count = 0; count < toppingsListBox.Items.Count; count++)
                {
                    // geSelected method to determine if a list box is selected or not
                    if (toppingsListBox.GetSelected(count))
                    {
                        outputFile.WriteLine(toppingsListBox.Items[count]);
                    }

                }
                outputFile.WriteLine();
                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display mesage if error occurs when attempting to write file
                this.Close();
            }
            //reset form to its original apperance
            sugarConeRadioButton.Checked = true; // selects suagr cone button
            flavorsComboBox.SelectedItem = "Vanilla"; // default selection is vanilla for combo box
            toppingsListBox.ClearSelected(); // clear any selection of toppings
            sugarConeRadioButton.Focus(); // send focus to first data entry control on form
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the form
        }

        // custom method to load data from external files into combo box n list box
        private void PopulateBoxes()
        {
            try //assure that input file specified is readable
            {
                StreamReader inputFile;

                inputFile = File.OpenText("Flavors.txt");
                while (!inputFile.EndOfStream)
                {
                    flavorsComboBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close(); // close input file after reading date

                inputFile = File.OpenText("Toppings.txt");
                while (!inputFile.EndOfStream)
                {
                    // read line from input file to the list box
                    toppingsListBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display mesage if error occurs when attempting to open file
                this.Close();
            }

        }
    }
}
