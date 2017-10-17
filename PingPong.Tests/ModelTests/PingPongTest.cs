using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;
using System;
using System.Collections.Generic;

namespace PingPong.TestTools
{
  [TestClass]
  public class PingPongTest
  {

    //to test entire list
    [TestMethod]
    public void GetResult_ListofFifteen_pingpong()
    {
      PingPong testPingPong = new PingPong();
      List<string>  expected = new List<string> {"1","2","Ping","4","Pong","Ping","7","8","Ping","Pong","11","Ping","13","14","PingPong"};
      List<string> result = testPingPong.GetResult(15);
      foreach (string item in result)
      {
        Console.WriteLine("Output: " + item);
      }
      CollectionAssert.AreEqual(expected, result);

    }

    //actual testing of individual results
    [TestMethod]
    public void GetResult_NumberMultipleOfFifteen_pingpong()
    {

      PingPong testPingPong = new PingPong();

      List<string> result = testPingPong.GetResult(15);

      Assert.AreEqual("PingPong", result[14]);

    }

    [TestMethod]
    public void GetResult_NumberMultipleOfFive_pong()
    {
      PingPong testPingPong = new PingPong();

      List<string> result = testPingPong.GetResult(5);

      Assert.AreEqual("pong", result[4]);
    }

    [TestMethod]
    public void GetResult_NumberMultipleOfThree_ping()
    {
      PingPong testPingPong = new PingPong();

      List<string> result = testPingPong.GetResult(3);

      Assert.AreEqual("ping", result[2]);
    }

    [TestMethod]
    public void GetResult_NumberNotAMultipleOfAbove_2()
    {
      PingPong testPingPong = new PingPong();

      List<string> result = testPingPong.GetResult(2);

      Assert.AreEqual("2", result[1]);
    }
  }
}
