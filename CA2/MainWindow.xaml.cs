/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 1-12-2019
 * Description : CA2 C# Code
 *
 * 
 * ############################# */

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

namespace CA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Activity> AllActivities = new List<Activity>();
        List<Activity> SelectedActivities = new List<Activity>();
        List<Activity> LandActivities = new List<Activity>();
        List<Activity> WaterActivities = new List<Activity>();
        List<Activity> AirActivities = new List<Activity>();

        public decimal RunningTotal;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //creating activity objects
            Activity a1 = new Activity("Trekking", "Instructor led group trek through local mountains.", new DateTime(2019, 06, 01), ActivityType.Land, 20m);
            Activity a2 = new Activity("Mountain Biking", "Instructor led half day mountain biking.  All equipment provided.", new DateTime(2019, 06, 02), ActivityType.Land, 30m);
            Activity a3 = new Activity("Abseiling", "Experience the rush of adrenaline as you descend cliff faces from 10-500m.", new DateTime(2019, 06, 03), ActivityType.Land, 40m);
            Activity a4 = new Activity("Kayaking", "Half day lakeland kayak with island picnic.", new DateTime(2019, 06, 01), ActivityType.Water, 40m);
            Activity a5 = new Activity("Surfing", "2 hour surf lesson on the wild atlantic way", new DateTime(2019, 06, 02), ActivityType.Water, 25m);
            Activity a6 = new Activity("Sailing", "Full day lakeland kayak with island picnic.", new DateTime(2019, 06, 03), ActivityType.Water, 50m);
            Activity a7 = new Activity("Parachuting", "Experience the thrill of free fall while you tandem jump from an airplane.", new DateTime(2019, 06, 01), ActivityType.Air, 100m);
            Activity a8 = new Activity("Hang Gliding", "Soar on hot air currents and enjoy spectacular views of the coastal region.", new DateTime(2019, 06, 02), ActivityType.Air, 80m);
            Activity a9 = new Activity("Helicopter Tour", "Experience the ultimate in aerial sight-seeing as you tour the area in our modern helicopters", new DateTime(2019, 06, 03), ActivityType.Air, 200m);


            //adding the activity objects to the list
            AllActivities.Add(a1);
            AllActivities.Add(a2);
            AllActivities.Add(a3);
            AllActivities.Add(a4);
            AllActivities.Add(a5);
            AllActivities.Add(a6);
            AllActivities.Add(a7);
            AllActivities.Add(a8);
            AllActivities.Add(a9);

            //implementing the IComparable to sort the Listbox by date on the window load
            AllActivities.Sort();
            //setting the itemsource for the first listbox to be the list 'activities' so that it is populated on window load
            lbxAllActivities.ItemsSource = AllActivities;

            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //declaring selectedActivity to store whatever item is selected from the first listbox
            Activity selectedActivity = lbxAllActivities.SelectedItem as Activity;

            //if statement to check if anything is selected or not (in the first listbox)
            if (selectedActivity != null)
            {
                //for loop with nested if statement to check that this selected activities date doesn't clash with any other selected date 
                for (int i = 0; i < SelectedActivities.Count; i++)
                {
                    if (selectedActivity.ActivityDate == SelectedActivities[i].ActivityDate)
                    {
                        MessageBox.Show("You already have an activity due on this date!!!");
                    }
                }
                //removes whatever item was selected from the all activities listbox 
                AllActivities.Remove(selectedActivity);
                //adds whatever item was selected to the selected activities listbox
                SelectedActivities.Add(selectedActivity);

                RunningTotal += selectedActivity.Cost;
                //calls the methods to refresh the listboxes and the textblock to display any changes 
                RefreshListBoxes();
                RefreshTotalTextBlock();
            }
            //if the add button is clicked and the object selectedActivity is null, an error message is dispalyed to the user
            else
            {
                MessageBox.Show("There was nothing selected to add");
            }
        }



        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //declaring selectedActivity to store whatever item is selected from the second listbox
            Activity selectedActivity = lbxSelectedActivities.SelectedItem as Activity;

            //if statement to check if anything is selected or not (in the second listbox)
            if (selectedActivity != null)
            {
                //removes whatever item was selected from the selected activities listbox 
                SelectedActivities.Remove(selectedActivity);
                //adds whatever item was selected back to the all activities listbox
                AllActivities.Add(selectedActivity);
                RunningTotal -= selectedActivity.Cost;
                //calls the method to refresh the listboxes and the textblock to display any changes 
                RefreshListBoxes();
                RefreshTotalTextBlock();
            }
            //if the add button is clicked and the object selectedActivity is null, an error message is dispalyed to the user
            else
            {
                MessageBox.Show("There was nothing selected to remove");
            }
        }
        private void RefreshListBoxes()
        {
            //sets the item source as null so it drops all data it currently holds
            lbxAllActivities.ItemsSource = null;
            //reassigns the item source so it can see that items were added to it
            AllActivities.Sort();
            lbxAllActivities.ItemsSource = AllActivities;
            //sets the item source as null so it drops all data it currently holds
            lbxSelectedActivities.ItemsSource = null;
            SelectedActivities.Sort();
            //reassigns the item source so it can see that items were added to it
            lbxSelectedActivities.ItemsSource = SelectedActivities;
        }
        //method for updating the contents within the TextBlock
        private void RefreshTotalTextBlock()
        {
            tblkTotalCost.Text = null;
            tblkTotalCost.Text = string.Format("{0:C}", RunningTotal);
        }

        private void lbxAllActivities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Activity selectedActivity = lbxAllActivities.SelectedItem as Activity;
            if (selectedActivity != null)
            {
                //shows the description for whichever activity is selected in the listbox
                tblkDescription.Text = (selectedActivity.Description);
            }
        }

        private void lbxSelectedActivities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void radioAll_Click(object sender, RoutedEventArgs e)
        {

            if (radioAll.IsChecked == true)
            {
                RefreshListBoxes();
            }
            else if (radioLand.IsChecked == true)
            {

                foreach (Activity activity in AllActivities)
                {
                    if (activity.TypeOfActivity == ActivityType.Land)
                    {
                        LandActivities.Add(activity);
                        lbxAllActivities.ItemsSource = null;
                        lbxAllActivities.ItemsSource = LandActivities;
                    }
                }
            }
            else if (radioWater.IsChecked == true)
            {
                foreach (Activity activity in AllActivities)
                {
                    if (activity.TypeOfActivity == ActivityType.Water)
                    {
                        WaterActivities.Add(activity);
                        lbxAllActivities.ItemsSource = null;
                        lbxAllActivities.ItemsSource = WaterActivities;
                    }
                }
            }
            else if (radioAir.IsChecked == true)
            {
                foreach (Activity activity in AllActivities)
                {
                    if (activity.TypeOfActivity == ActivityType.Air)
                    {
                        AirActivities.Add(activity);
                        lbxAllActivities.ItemsSource = null;
                        lbxAllActivities.ItemsSource = AirActivities;
                    }
                }
            }
        }

        private void tblkTotalCost_Loaded(object sender, RoutedEventArgs e)
        {
            tblkTotalCost.Text = string.Format("{0:C}", RunningTotal);
        }

        private void tblkDescription_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
