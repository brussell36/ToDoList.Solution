using ToDoList.Models;
using System;
using System.Collections.Generic;

namespace ToDoList
{
  class Program
  {
    List<Item> newList = new List<Item> {}; 
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List!");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string input = Console.ReadLine();

        if (input == "Add")
        {
          AddTask(input);     
        }
        else 
        {
          Console.WriteLine("Would you like to view your task list? (View)");
          string input2 = Console.ReadLine();
          if (input2 == "View")
          {
            ViewList();
          }
          else
          {
            Main();
          }  
    }
  }
    public static void AddTask(string input)
    { 
      Console.WriteLine("Please enter the description for the new item.");
      string description = Console.ReadLine();
      Item newItem = new Item(description);          
      string addItem = newItem.Description;
      Console.WriteLine(addItem + " has been added to your list. Would you like to add an item to your list or view you list?(Add/View)");
      input = Console.ReadLine();           
    }
    public static void ViewList()
    {
      Console.WriteLine("View List");
      string list = Console.ReadLine();
      List<Item> result = Item.GetAll();
      Console.WriteLine("Your list items: " + result);
      
    }
  }
}



