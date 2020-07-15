using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
 
    public string Description { get; set; }
    // this is an auto-implemented property
    private static List<Item> _instances = new List<Item> {};
    // this is a field bc it is private assignment
    
    public Item(string description)
    {
      Description = description;
      _instances.Add(this); // create a list of all instances of Items
    }

    //Item myToDo = new Item("pet the cat")
    // myToDo.GetAll() // won't work, can't do it
    // Item.GetAll() // will return a List of all Item objects that have been created.
    // Category myCategory = new Category("Monday To-Dos");
    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}