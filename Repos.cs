using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_Cafe
{
    public class Menu 
    { 
    public int MealNumber { get; set; }
    public string MealName { get; set; }
    public string Description { get; set; }
    public decimal PriceOfMeal { get; set; }

    public Menu() { }
    public Menu(int mealNumber, string mealName, string description, decimal priceOfMeal)
    {
        MealNumber = mealNumber;
        MealName = mealName;
        Description = description;
        PriceOfMeal = priceOfMeal;
    }
    private List<Menu> _menuItems = new List<Menu>();
        
            //c
        public void AddMenuItemToList(Menu item)
            {
            _menuItems.Add(item);
            }
        //r
        public List<Menu> GetMenus()
        {
            return _menuItems;
        }
            
            //d
        public bool RemoveMenuItemFromList(short id)
        {
                Menu content = GetMealByNumber(id);

                if (content == null)
                {
                    return false;
                }
                int initialCount = _menuItems.Count;
                _menuItems.Remove(content);
                if (initialCount > _menuItems.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
            //h
        public Menu GetMealByNumber(int mealNumber)
        {
                foreach (Menu content in _menuItems)
                {
                    if (content.MealNumber == mealNumber)
                    {
                        return content;
                    }
                }
                return null;
        }

        
    }

}
