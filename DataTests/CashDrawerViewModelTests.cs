using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests
{
    public class CashDrawerViewModelTests
    {
        [Fact]
        public void ShouldGetCorrectSubTotal()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.Equal(6.32, vm.SubTotal);
        }
        [Fact]
        public void ShouldGetCorrectTax()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.Equal(.76, vm.Tax);
        }
        [Fact]
        public void ShouldGetCorrectTotal()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.Equal(7.08, vm.Total);
        }
        [Fact]
        public void ShouldGetCorrectTenuredAmount()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            vm.Ones = 1;
            vm.Twos = 0;
            vm.Fives = 1;
            Assert.Equal(6, vm.AmountTenuered);
        }
        [Fact]
        public void ShouldGetCorrectAmountOwed()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            vm.Fives = 1;
            Assert.Equal(2.08, vm.AmountOwed);
        }
        [Fact]//FIXME needs to include multiple scenarios with a theory test
        public void ShouldGetCorrectChangeOwed()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            vm.Tens = 1;
            Assert.Equal(2.92, vm.ChangeOwed);
        }
        [Fact]
        public void ShouldBeAbleToSetTwos()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            vm.Twos = 1;
            Assert.Equal(1, vm.Twos);
        }
        [Fact]
        public void SettingTwosNotifiesTwosProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "Twos", () =>
            {
                vm.Twos = 1;

            });
        }
        [Fact]
        public void SettingTwosNotifiesAmountTenuredProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountTenured", () =>
            {
                vm.Twos = 1;

            });
        }
        [Fact]
        public void SettingTwosNotifiesAmountOwedProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountOwed", () =>
            {
                vm.Twos = 1;

            });
        }
        [Fact]
        public void SettingTwosNotifiesChangeOwedProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "ChangeOwed", () =>
            {
                vm.Twos = 1;

            });
        }
        [Fact]
        public void SettingTwosNotifiesAmountOwedDisplayProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountOwedDisplay", () =>
            {
                vm.Twos = 1;

            });
        }
        [Fact]
        public void SettingTwosNotifiesChangeOwedDisplayProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "ChangeOwedDisplay", () =>
            {
                vm.Twos = 1;

            });
        }
        [Fact]
        public void ShouldBeAbleToSetOnes()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            vm.Ones = 1;
            Assert.Equal(1, vm.Ones);
        }
        [Fact]
        public void SettingOnesNotifiesOnesProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "Ones", () =>
            {
                vm.Ones = 1;

            });
        }
        [Fact]
        public void SettingOnesNotifiesAmountTenuredProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountTenured", () =>
            {
                vm.Ones = 1;

            });
        }
        [Fact]
        public void SettingOnesNotifiesAmountOwedProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountOwed", () =>
            {
                vm.Ones = 1;

            });
        }
        [Fact]
        public void SettingOnesNotifiesChangeOwedProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "ChangeOwed", () =>
            {
                vm.Ones = 1;

            });
        }
        [Fact]
        public void SettingOnesNotifiesAmountOwedDisplayProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountOwedDisplay", () =>
            {
                vm.Ones = 1;

            });
        }
        [Fact]
        public void SettingOnesNotifiesChangeOwedDisplayProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "ChangeOwedDisplay", () =>
            {
                vm.Ones = 1;

            });
        }
        [Fact]
        public void ShouldBeAbleToSetFives()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            vm.Fives = 1;
            Assert.Equal(1, vm.Fives);
        }
        [Fact]
        public void SettingFivesNotifiesFivesProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "Fives", () =>
            {
                vm.Fives = 1;

            });
        }
        [Fact]
        public void SettingFivesNotifiesAmountTenuredProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountTenured", () =>
            {
                vm.Fives = 1;

            });
        }
        [Fact]
        public void SettingFivesNotifiesAmountOwedProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountOwed", () =>
            {
                vm.Fives = 1;

            });
        }
        [Fact]
        public void SettingFivesNotifiesChangeOwedProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "ChangeOwed", () =>
            {
                vm.Fives = 1;

            });
        }
        [Fact]
        public void SettingFivesNotifiesAmountOwedDisplayProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountOwedDisplay", () =>
            {
                vm.Fives = 1;

            });
        }
        [Fact]
        public void SettingFivesNotifiesChangeOwedDisplayProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "ChangeOwedDisplay", () =>
            {
                vm.Fives = 1;

            });
        }
        [Fact]
        public void ShouldBeAbleToSetTens()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            vm.Tens = 1;
            Assert.Equal(1, vm.Tens);
        }
        [Fact]
        public void SettingTensNotifiesTensProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "Tens", () =>
            {
                vm.Tens = 1;

            });
        }
        [Fact]
        public void SettingTensNotifiesAmountTenuredProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountTenured", () =>
            {
                vm.Tens = 1;

            });
        }
        [Fact]
        public void SettingTensNotifiesAmountOwedProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountOwed", () =>
            {
                vm.Tens = 1;

            });
        }
        [Fact]
        public void SettingTensNotifiesChangeOwedProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "ChangeOwed", () =>
            {
                vm.Tens = 1;

            });
        }
        [Fact]
        public void SettingTensNotifiesAmountOwedDisplayProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountOwedDisplay", () =>
            {
                vm.Tens = 1;

            });
        }
        [Fact]
        public void SettingTensNotifiesChangeOwedDisplayProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "ChangeOwedDisplay", () =>
            {
                vm.Tens = 1;

            });
        }
        [Fact]
        public void ShouldBeAbleToSetTwenties()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            vm.Twenties = 1;
            Assert.Equal(1, vm.Twenties);
        }
        [Fact]
        public void SettingTwentiesNotifiesTwentiesProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "Twenties", () =>
            {
                vm.Twenties = 1;

            });
        }
        [Fact]
        public void SettingTwentiesNotifiesAmountTenuredProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountTenured", () =>
            {
                vm.Twenties = 1;

            });
        }
        [Fact]
        public void SettingTwentiesNotifiesAmountOwedProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountOwed", () =>
            {
                vm.Twenties = 1;

            });
        }
        [Fact]
        public void SettingTwentiesNotifiesChangeOwedProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "ChangeOwed", () =>
            {
                vm.Twenties = 1;

            });
        }
        [Fact]
        public void SettingTwentiesNotifiesAmountOwedDisplayProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "AmountOwedDisplay", () =>
            {
                vm.Twenties = 1;

            });
        }
        [Fact]
        public void SettingTwentiesNotifiesChangeOwedDisplayProperty()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            CashDrawerViewModel vm = new CashDrawerViewModel(order, "Cash");
            Assert.PropertyChanged(vm, "ChangeOwedDisplay", () =>
            {
                vm.Twenties = 1;

            });
        }


    }
}
