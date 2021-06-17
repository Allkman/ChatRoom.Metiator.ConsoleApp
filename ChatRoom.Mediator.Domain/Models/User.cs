using ChatRoom.Mediator.Domain.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Mediator.Domain.Models
{
    public class User : Person
    {
        public string UserName { get; set; }
        public Room Room { get; set; }
        private List<string> ChatLog { get; set; } = new List<string>();

        public User(string userName)
        {
            UserName = userName;
        }
        public void Chat(string message)
        {
            Room.Broadcast(UserName, message);
        }
        public void PrivateMessage(string recipient, string message)
        {
            Room.Message(UserName, recipient, message);
        }
        public void ReceiveMessage(string sender, string message)
        {
            string msgString = $"{sender}: '{message}'";
            ChatLog.Add(msgString);
            Console.WriteLine($"[{UserName}'s chat session] {msgString}");
        }
    }
   
}
