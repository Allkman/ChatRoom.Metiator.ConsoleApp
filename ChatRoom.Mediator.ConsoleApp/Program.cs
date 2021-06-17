using ChatRoom.Mediator.Domain.Models;
using System;

namespace ChatRoom.Mediator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatRoom = new Room();
            var john = new User("John");
            var adam = new User("Adam");

            chatRoom.JoinChatRoom(john);
            chatRoom.JoinChatRoom(adam);

            john.Chat("hi");
            adam.Chat("hello");

            var simon = new User("Simon");

            chatRoom.JoinChatRoom(simon);

            simon.Chat("Hi everyone!");

            adam.PrivateMessage("Simon", "glad you could join us!");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue ... .. .");
            Console.ReadKey();
        }
    }
}
