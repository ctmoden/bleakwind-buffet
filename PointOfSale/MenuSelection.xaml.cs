using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Customization_Screens;
using PointOfSale.Customization_Screens.Drinks;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Order;
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
       
        public MenuSelection()
        {
            InitializeComponent();
            
        }

        public void MakeCombo(object sender, RoutedEventArgs e)
        {
            //only one of each can be selected
            //set some bool field to true if selected, create new combo instance
            //when selecting items, check for combo field
            //add to combo if user slects a combo
            //diable all other entrees/sides/drinks when one of each is selected
            //when full combo has been created, reenable combo and all other buttons
        }
        
        /// <summary>
        /// Finds the parent control and creates an object out of that then calls 
        /// newly created order control objects screen switching method
        /// </summary>
        /// <param name="screenToSwitchTo">specifies which screen to switch to from current screen</param>
        private void SendToScreenSwitcher(FrameworkElement screenToSwitchTo)
        {
            OrderComponent orderControler = this.FindControl<OrderComponent>();
            orderControler.SwitchScreens(screenToSwitchTo);
        }
        /// <summary>
        /// Button event for briarheart
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectBriarhearthBurger(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                BriarheartBurger burger = new BriarheartBurger();
                order.Add(burger);
                SendToScreenSwitcher(new BriarhearthCustomization(burger));
            }
            
          
        }
        /// <summary>
        /// Switches to customization screen
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectDoubleDraugr(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                DoubleDraugr dd = new DoubleDraugr();
                order.Add(dd);
                SendToScreenSwitcher(new DoubleDraugrCustomization(dd));
            }
            
            

        }
        /// <summary>
        /// Switches to customization screen
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectThalmorTriple(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                ThalmorTriple triple = new ThalmorTriple();
                order.Add(triple);
                SendToScreenSwitcher(new ThalmorTripleCustomization(triple));
            }
            


        }
        /// <summary>
        /// Switches to customization screen
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectPhillyPoacher(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                PhillyPoacher poacher = new PhillyPoacher();
                order.Add(poacher);
                SendToScreenSwitcher(new PhillyPoacherCustomization(poacher));
            }
            

        }
        /// <summary>
        /// Switches to customization screen
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                GardenOrcOmelette omelette = new GardenOrcOmelette();
                order.Add(omelette);
                SendToScreenSwitcher(new GardenOrcOmeletteCustomization(omelette));
            }
            
        }
        /// <summary>
        /// Switches to customization screen
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectSmokeHouse(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
                order.Add(skeleton);
                SendToScreenSwitcher(new SmokeHouseSkeletonCustomization(skeleton));
            }
            

        }

        /// <summary>
        /// Switches to customization screen
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectWaffleFries(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                DragonbornWaffleFries fries = new DragonbornWaffleFries();
                SendToScreenSwitcher(new SideCustomization(fries));
                order.Add(fries);
                
            }
            
        }
        /// <summary>
        /// Switches to customization screen
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectFriedMiraak(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                FriedMiraak miraak = new FriedMiraak();
                order.Add(miraak);
                SendToScreenSwitcher(new SideCustomization(miraak));
            }
            
            
        }
        /// <summary>
        /// Switches to customization screen
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectGrits(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                MadOtarGrits grits = new MadOtarGrits();
                order.Add(grits);
                SendToScreenSwitcher(new SideCustomization(grits));
            }
            
        }
        /// <summary>
        /// Button event for vokun salad
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectSalad(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                VokunSalad salad = new VokunSalad();
                order.Add(salad);
                SendToScreenSwitcher(new SideCustomization(salad));
            }
            
        }
        /// <summary>
        /// Button event for vokun salad
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectAppleJuice(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                order.Add(aj);
                SendToScreenSwitcher(new AretinoAppleJuiceCustomization(aj));
            }
            
        }
        /// <summary>
        /// Button event for vokun salad
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectCoffee(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                CandlehearthCoffee coffee = new CandlehearthCoffee();
                order.Add(coffee);
                SendToScreenSwitcher(new CoffeeCustomization(coffee));
            }
            
            
        }
        /// <summary>
        /// Button event for markarth milk
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectMilk(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                MarkarthMilk milk = new MarkarthMilk();
                order.Add(milk);
                SendToScreenSwitcher(new MarkarthMilkCustomizations(milk));
            }
            
        }
        /// <summary>
        /// Button event for sailor soda
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectSoda(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                SailorSoda soda = new SailorSoda();
                order.Add(soda);
                SendToScreenSwitcher(new SailorSodaCustomization(soda));
            }
            
        }
        /// <summary>
        /// Button event for sailor soda
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        private void SelectWater(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                WarriorWater water = new WarriorWater();
                order.Add(water);
                SendToScreenSwitcher(new WarriorWaterCustomizations(water));
            }
            
        }
    }
}
