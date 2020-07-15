using ToDoList.Models;
using System;
using System.Collections.Generic;

namespace ToDoList
{
  class Program
  {

    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List!");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string input = Console.ReadLine();
      
        if (input == "Add")
        {
          Console.WriteLine("Please enter the description for the new item.");
          string description = Console.ReadLine();
          Item newItem = new Item(description);
          List<Item> ItemList = new List<Item>{};  
          string addItem = newItem.Description;
          Console.WriteLine(addItem + " has been added to your list. Would you like to add an item to you list or view you list?(Add/View)");
        }
        else if (input == "View")
        {
          List<Item> result = Item.GetAll();
          Console.WriteLine(result);
        }
        else
        {
          Main();
        }    }
  }
}