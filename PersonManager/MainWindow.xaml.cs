using PersonManager.Models;
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

namespace PersonManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //get the listView object
            ListView availablePersonsLV = this.FindName("availablePersonsLV") as ListView;
            

        }

        private void Add_New_Person_Click(object sender, RoutedEventArgs e)
        {
            //create a person model using textbox input
            PersonModel personModel = new PersonModel(first_name_txt.Text, last_name_txt.Text, menu_txt.Text);

            //add person to the List View to be displayed
            availablePersonsLV.Items.Add(personModel);

            //clear the textbox
            first_name_txt.Text = "";
            last_name_txt.Text = "";
            menu_txt.Text = "";

            //print the added person to output for debugging
            Console.WriteLine(personModel);

        }
        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            
                foreach (PersonModel l in availablePersonsLV.Items)

                {
                //  Console.WriteLine("Persoana: {0}", l.ToString());
                //  Console.WriteLine("Selected: {0}", availablePersonsLV.SelectedItems[0]);

                if (String.Equals(l.ToString(), availablePersonsLV.SelectedItems[0].ToString()))
                {
                    dinnerInvitesLV.Items.Add(l);
                }               
                }
        }
        private void btn_Click_Menu(object sender, RoutedEventArgs e)
        {

            foreach (PersonModel person in dinnerInvitesLV.Items)

            {
                
                if (String.Equals(person.ToString(),dinnerInvitesLV.SelectedItems[0].ToString()))
                {
                    personmenu_txt.Text = person.Menu;
                }

            }
        }

    }
} 

   