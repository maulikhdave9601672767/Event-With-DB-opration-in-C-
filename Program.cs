using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Order Order = new Order();
            Order.Key = 12;
            Order.Changed += Order_Changed;
            Order.Save();

           
        }

        private static void Order_Changed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    public delegate void ChangedEventHandler(object sender, EventArgs e);
    public class Order
    {
        public int Key { get; set; }
        public event ChangedEventHandler Changed;

        // Invoke the Changed event; called whenever list changes
        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        public Order Save()
        {
            Order Order = new Order();
            Order.Key = 12;


            OnChanged(EventArgs.Empty);
            return Order; 

        }

    }
}
