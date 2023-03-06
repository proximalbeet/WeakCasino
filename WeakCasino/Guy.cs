using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGuy_AM
{
    public class Guy
    {
        public string Name { get; set; }
        public int Cash { get; set; }

        public string WriteMyInfo() 
        {
            return $"{Name} has {Cash} bucks.";
        }

        public int GiveCash(int amount) 
        {
            if (amount<= 0) 
            {
                throw new Exception("Amount givern must be > 0");
            }

            if (amount > Cash) 
            { 
                throw new Exception("You do not have enough Cash");
            }

            Cash -= amount;
            return amount;
        }

        public void RecieveCash(int amount) 
        {
            if (amount <= 0)
            {
                throw new Exception("I don't take amounts <=0");
            }
            else 
            { 
            Cash += amount;
            }
        }

        public int GiveCashTo(int amount, Guy g) 
        { 
         int output = GiveCash(amount);
         g.RecieveCash(amount);
         
         return output;
        }
        
    }
}
