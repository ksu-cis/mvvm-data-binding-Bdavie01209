using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;
using System.Windows.Navigation;
using System.Windows.Controls;

namespace MVVMDataBinding
{
    public class CashResgisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// notifies when changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// the drarwer backing
        /// </summary>
        private CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// total value
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        /// <summary>
        /// pennies getter and setter
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                int quantity = value - drawer.Pennies;
                if (quantity > 0) drawer.AddCoin(Coins.Penny, quantity);
                else drawer.RemoveCoin(Coins.Penny, -quantity);
                invokePropertyChanged("Pennies");
            }
        }

        public int Nickels
        {
            get => drawer.Nickels;
            set
            {
                if (drawer.Nickels == value || value < 0) return;
                int quantaty = value - drawer.Nickels;
                if (quantaty > 0)
                {
                    drawer.AddCoin(Coins.Nickel, quantaty);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantaty);
                }
                invokePropertyChanged("Nickels");
            }

        }

        
        public int Dimes
        {
            get => drawer.Dimes;
            set
            {
                if (drawer.Dimes == value || value < 0) return;
                int quantaty = value - drawer.Dimes;
                if (quantaty > 0)
                {
                    drawer.AddCoin(Coins.Dime, quantaty);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantaty);
                }
                invokePropertyChanged("Dimes");
            }

        }
                
        public int Quarters
        {
            get => drawer.Quarters;
            set
            {
                if (value == drawer.Quarters || value < 0) return;
                int quantaty = value - drawer.Quarters;
                if (quantaty > 0)
                {
                    drawer.AddCoin(Coins.Quarter, quantaty);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Quarter, -quantaty);
                }
                invokePropertyChanged("Quarters");
            }

        }
        
        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                int quantity = value - drawer.HalfDollars;
                if (quantity > 0) drawer.AddCoin(Coins.HalfDollar, quantity);
                else drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                invokePropertyChanged("HalfDollars");
            }

        }
        public int Dollars
        {
            get => drawer.Dollars;
            set
            {
                if (value == drawer.Dollars || value < 0) return;
                int quantaty = value - drawer.Dollars;
                if (quantaty > 0)
                {
                    drawer.AddCoin(Coins.Dollar, quantaty);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dollar, -quantaty);
                }
                invokePropertyChanged("Dollars");
            }

        }
        
        public int Ones
        {
            get => drawer.Ones;
            set
            {
                if (value == drawer.Ones || value < 0) return;
                int quantaty = value - drawer.Ones;
                if (quantaty > 0)
                {
                    drawer.AddBill(Bills.One, quantaty);
                }
                else
                {
                    drawer.AddBill(Bills.One, -quantaty);
                }
                invokePropertyChanged("Ones");
            }

        }
             
        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (value == drawer.Twos || value < 0) return;
                int quantaty = value - drawer.Twos;
                if (quantaty > 0)
                {
                    drawer.AddBill(Bills.Two, quantaty);
                }
                else
                {
                    drawer.AddBill(Bills.Two, -quantaty);
                }
                invokePropertyChanged("Twos");
            }

        }
                     
        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (value == drawer.Fives || value < 0) return;
                int quantaty = value - drawer.Fives;
                if (quantaty > 0)
                {
                    drawer.AddBill(Bills.Five, quantaty);
                }
                else
                {
                    drawer.AddBill(Bills.Five, -quantaty);
                }
                invokePropertyChanged("Five");
            }

        }
                             
        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (value == drawer.Tens || value < 0) return;
                int quantaty = value - drawer.Tens;
                if (quantaty > 0)
                {
                    drawer.AddBill(Bills.Ten, quantaty);
                }
                else
                {
                    drawer.AddBill(Bills.Ten, -quantaty);
                }
                invokePropertyChanged("Tens");
            }

        }                             
        public int Twenties
        {
            get => drawer.Twenties;
            set
            {
                if (value == drawer.Twenties || value < 0) return;
                int quantaty = value - drawer.Twenties;
                if (quantaty > 0)
                {
                    drawer.AddBill(Bills.Twenty, quantaty);
                }
                else
                {
                    drawer.AddBill(Bills.Twenty, -quantaty);
                }
                invokePropertyChanged("Twenties");
            }

        }                             
        public int Fifties
        {
            get => drawer.Fifties;
            set
            {
                if (value == drawer.Fifties || value < 0) return;
                int quantaty = value - drawer.Fifties;
                if (quantaty > 0)
                {
                    drawer.AddBill(Bills.Fifty, quantaty);
                }
                else
                {
                    drawer.AddBill(Bills.Fifty, -quantaty);
                }
                invokePropertyChanged("Fifties");
            }

        }                             
        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (value == drawer.Hundreds || value < 0) return;
                int quantaty = value - drawer.Hundreds;
                if (quantaty > 0)
                {
                    drawer.AddBill(Bills.Hundred, quantaty);
                }
                else
                {
                    drawer.AddBill(Bills.Hundred, -quantaty);
                }
                invokePropertyChanged("Hundreds");
            }

        }

        /// <summary>
        /// helper for property changed invoke
        /// </summary>
        /// <param name="changed"></param>
        private void invokePropertyChanged(string changed)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(changed));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

    }
}
