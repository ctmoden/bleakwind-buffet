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
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        bool isCombo = false;
        Combo combo;
        int comboCount = 0;

        public MenuSelection()
        {
            InitializeComponent();
            
        }
        
        void MakeCombo(object sender, RoutedEventArgs e)
        {
            combo = new Combo();
            isCombo = true;
            //only one of each can be selected
            //set some bool field to true if selected, create new combo instance
            //when selecting items, check for combo field
            //add to combo if user slects a combo
            //diable all other entrees/sides/drinks when one of each is selected
            //when full combo has been created, reenable combo and all other buttons
        }
        /// <summary>
        /// Checks to see if combo has been finalized.  If it has then this method
        /// reenable all buttons and adds the combo object to the order 
        /// </summary>
        void FinalizeCombo()
        {
            if(comboCount == 3)
            {
                if(DataContext is Order order)
                {
                    order.Add(combo);
                    BriarButton.Visibility = Visibility.Visible;
                    DoubleButton.Visibility = Visibility.Visible;
                    ThalmorButton.Visibility = Visibility.Visible;
                    PoacherButton.Visibility = Visibility.Visible;
                    SmokeButton.Visibility = Visibility.Visible;
                    OmeletteButton.Visibility = Visibility.Visible;
                    TBoneButton.Visibility = Visibility.Visible;
                    FriesButton.Visibility = Visibility.Visible;
                    MiraakButton.Visibility = Visibility.Visible;
                    GritsButton.Visibility = Visibility.Visible;
                    SaladButton.Visibility = Visibility.Visible;
                    AJButton.Visibility = Visibility.Visible;
                    MilkButton.Visibility = Visibility.Visible;
                    SodaButton.Visibility = Visibility.Visible;
                    CoffeeButton.Visibility = Visibility.Visible;
                    WaterButton.Visibility = Visibility.Visible;

                }
            }
        }
        
        /// <summary>
        /// Finds the parent control and creates an object out of that then calls 
        /// newly created order control objects screen switching method
        /// </summary>
        /// <param name="screenToSwitchTo">specifies which screen to switch to from current screen</param>
        void SendToScreenSwitcher(FrameworkElement screenToSwitchTo)
        {
            OrderComponent orderController = this.FindControl<OrderComponent>();
            
            orderController.SwitchScreens(screenToSwitchTo);
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
                //order.Add(burger);
                if (isCombo)
                {
                    combo.Entree = burger;
                    comboCount++;
                    
                    DoubleButton.Visibility = Visibility.Collapsed;
                    ThalmorButton.Visibility = Visibility.Collapsed;
                    PoacherButton.Visibility = Visibility.Collapsed;
                    SmokeButton.Visibility = Visibility.Collapsed;
                    OmeletteButton.Visibility = Visibility.Collapsed;
                    TBoneButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(burger);
                SendToScreenSwitcher(new BriarhearthCustomization(this,burger));
                
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
                
                if (isCombo)
                {
                    combo.Entree = dd;
                    comboCount++;
                    
                    BriarButton.Visibility = Visibility.Collapsed;
                    ThalmorButton.Visibility = Visibility.Collapsed;
                    PoacherButton.Visibility = Visibility.Collapsed;
                    SmokeButton.Visibility = Visibility.Collapsed;
                    OmeletteButton.Visibility = Visibility.Collapsed;
                    TBoneButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(dd);
                SendToScreenSwitcher(new DoubleDraugrCustomization(this,dd));
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
                
                if (isCombo)
                {
                    combo.Entree = triple;
                    comboCount++;
                    
                    BriarButton.Visibility = Visibility.Collapsed;
                    DoubleButton.Visibility = Visibility.Collapsed;
                    PoacherButton.Visibility = Visibility.Collapsed;
                    SmokeButton.Visibility = Visibility.Collapsed;
                    OmeletteButton.Visibility = Visibility.Collapsed;
                    TBoneButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(triple);
                SendToScreenSwitcher(new ThalmorTripleCustomization(this, triple));
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
                
                if (isCombo)
                {
                    combo.Entree = poacher;
                    comboCount++;
                    
                    BriarButton.Visibility = Visibility.Collapsed;
                    ThalmorButton.Visibility = Visibility.Collapsed;
                    DoubleButton.Visibility = Visibility.Collapsed;
                    SmokeButton.Visibility = Visibility.Collapsed;
                    OmeletteButton.Visibility = Visibility.Collapsed;
                    TBoneButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(poacher);
                SendToScreenSwitcher(new PhillyPoacherCustomization(this, poacher));
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
                
                if (isCombo)
                {
                    combo.Entree = omelette;
                    comboCount++;
                    
                    BriarButton.Visibility = Visibility.Collapsed;
                    ThalmorButton.Visibility = Visibility.Collapsed;
                    PoacherButton.Visibility = Visibility.Collapsed;
                    SmokeButton.Visibility = Visibility.Collapsed;
                    DoubleButton.Visibility = Visibility.Collapsed;
                    TBoneButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(omelette);
                SendToScreenSwitcher(new GardenOrcOmeletteCustomization(this, omelette));
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
                
                if (isCombo)
                {
                    combo.Entree = skeleton;
                    comboCount++;
                    
                    BriarButton.Visibility = Visibility.Collapsed;
                    ThalmorButton.Visibility = Visibility.Collapsed;
                    PoacherButton.Visibility = Visibility.Collapsed;
                    DoubleButton.Visibility = Visibility.Collapsed;
                    OmeletteButton.Visibility = Visibility.Collapsed;
                    TBoneButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(skeleton);
                SendToScreenSwitcher(new SmokeHouseSkeletonCustomization(this, skeleton));
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
                
                if (isCombo)
                {
                    combo.Side = fries;
                    comboCount++;
                    
                    MiraakButton.Visibility = Visibility.Collapsed;
                    GritsButton.Visibility = Visibility.Collapsed;
                    SaladButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(fries);
                SendToScreenSwitcher(new SideCustomization(this, fries));
                
                
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
                
                if (isCombo)
                {
                    combo.Side = miraak;
                    comboCount++;
                    
                    FriesButton.Visibility = Visibility.Collapsed;
                    GritsButton.Visibility = Visibility.Collapsed;
                    SaladButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(miraak);
                SendToScreenSwitcher(new SideCustomization(this, miraak));
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
                
                if (isCombo)
                {
                    combo.Side = grits;
                    comboCount++;
                    
                    MiraakButton.Visibility = Visibility.Collapsed;
                    FriesButton.Visibility = Visibility.Collapsed;
                    SaladButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(grits);
                SendToScreenSwitcher(new SideCustomization(this, grits));
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
                
                if (isCombo)
                {
                    combo.Side = salad;
                    comboCount++;
                    
                    MiraakButton.Visibility = Visibility.Collapsed;
                    GritsButton.Visibility = Visibility.Collapsed;
                    FriesButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(salad);
                SendToScreenSwitcher(new SideCustomization(this, salad));
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
                
                if (isCombo)
                {
                    combo.Drink = aj;
                    comboCount++;
                    
                    CoffeeButton.Visibility = Visibility.Collapsed;
                    MilkButton.Visibility = Visibility.Collapsed;
                    SodaButton.Visibility = Visibility.Collapsed;
                    WaterButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(aj);
                SendToScreenSwitcher(new AretinoAppleJuiceCustomization(this, aj));
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
                
                if (isCombo)
                {
                    combo.Drink = coffee;
                    comboCount++;
                    
                    AJButton.Visibility = Visibility.Collapsed;
                    MilkButton.Visibility = Visibility.Collapsed;
                    SodaButton.Visibility = Visibility.Collapsed;
                    WaterButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(coffee);
                SendToScreenSwitcher(new CoffeeCustomization(this, coffee));
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
                
                if (isCombo)
                {
                    combo.Drink = milk;
                    comboCount++;
                    
                    AJButton.Visibility = Visibility.Collapsed;
                    CoffeeButton.Visibility = Visibility.Collapsed;
                    SodaButton.Visibility = Visibility.Collapsed;
                    WaterButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(milk);
                SendToScreenSwitcher(new MarkarthMilkCustomizations(this, milk));
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
                
                if (isCombo)
                {
                    combo.Drink = soda;
                    comboCount++;
                    
                    AJButton.Visibility = Visibility.Collapsed;
                    MilkButton.Visibility = Visibility.Collapsed;
                    CoffeeButton.Visibility = Visibility.Collapsed;
                    WaterButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(soda);
                SendToScreenSwitcher(new SailorSodaCustomization(this, soda));
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
                
                if (isCombo)
                {
                    combo.Drink = water;
                    comboCount++;
                    
                    AJButton.Visibility = Visibility.Collapsed;
                    MilkButton.Visibility = Visibility.Collapsed;
                    SodaButton.Visibility = Visibility.Collapsed;
                    CoffeeButton.Visibility = Visibility.Collapsed;
                    FinalizeCombo();
                }
                else order.Add(water);
                SendToScreenSwitcher(new WarriorWaterCustomizations(this, water));
            }
            
        }
    }
}
