using System;
using System.Collections.Generic;


namespace PingPong
{
  public class PingPong
  {
    // private int _number;

    // private static List<string> _instances = new List<string> {};

    // public PingPong(number)
    // {
    //   _number = number;
    // }

    // public static List<string> GetAll();
    // {
    //   return _instances.Add(this);
    // }

    public List<string> GetResult(int number)
    {
      List<string> _instances = new List<string> {};
      for(var i=1; i <=number; i++)
      {
        if (i % 15 == 0)
        {
          _instances.Add("PingPong");
        }
        else if (i % 5 == 0)
        {
          _instances.Add("Pong");
        }
        else if (i % 3 == 0)
        {
          _instances.Add("Ping");
        }
        else
        {
          _instances.Add(i.ToString());
        }
      }
      return _instances;
    }

  }
}
