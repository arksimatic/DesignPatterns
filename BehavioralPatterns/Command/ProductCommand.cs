using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Command
{
    public class ProductCommand : ICommand
    {
        Product _product;
        PriceAction _priceAction;
        int _amount;

        public ProductCommand(Product product, PriceAction priceAction, int amount)
        {
            _product = product;
            _priceAction = priceAction;
            _amount = amount;
        }

        public void ExecuteAction()
        {
            if (_priceAction == PriceAction.Increase) _product.IncresePrice(_amount);
            if (_priceAction == PriceAction.Decrease) _product.DecreasePrice(_amount);
        }
    }
}
