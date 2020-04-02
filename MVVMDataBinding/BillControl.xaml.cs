using CashRegister;
using System;
using System.Collections.Generic;
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

namespace MVVMDataBinding
{
    /// <summary>
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {

        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                "Denomination",
                typeof(Bills),
                typeof(BillControl),
                new PropertyMetadata(Bills.One)
                );


        public Bills Denomination
        {
            get => (Bills)GetValue(DenominationProperty);
            set { SetValue(DenominationProperty, value); }
        }

        public static DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                "Quantity",
                typeof(int),
                typeof(BillControl),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );


        public int Quantity
        {
            get => (int)GetValue(QuantityProperty);
            set { SetValue(QuantityProperty, value); }
        }



        public BillControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Increases the quantity of the bound coinage by one
        /// </summary>
        /// <param name="sender">The coinage quanity (as an int)</param>
        /// <param name="args">The event args</param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs args)
        {
            Quantity++;
        }

        /// <summary>
        /// Decreases the quantity of the bound coinage by one
        /// </summary>
        /// <param name="sender">The coinage quantity (as in int)</param>
        /// <param name="args">The event args</param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs args)
        {
            Quantity--;
        }

    }
}
