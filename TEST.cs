using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_Cafe
{
    public class TEST
    {
        [TestMethod]
        public void Check_ListOfItems()
        {
            Menu content = new Menu();
            content.MealName = "Handwitch";

            string expected = "Handwitch";
            string actual = content.MealName;

            Assert.AreEqual(expected, actual);
             
           
        }



    }
}
