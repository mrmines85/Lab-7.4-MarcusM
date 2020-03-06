using System;
using System.Collections.Generic;
using System.Text;

namespace _7_4DatingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile kyle = new DatingProfile("Kyle", "Reese", 30, "Male");
            kyle.WriteBio("Soldier from the future");

            DatingProfile sarah = new DatingProfile("Sarah", "Connor", 25, "Female");
            sarah.WriteBio("It's supposed to be the 80s right? What's a dating app?");

            kyle.SendMessage("Hello Sarah", "Come with me if you want to live!", sarah);
            sarah.ReadMessage();
        }
    }
}