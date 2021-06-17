using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Mediator.Domain.Models
{
    public class Room
    {
        private List<User> Users { get; set; } = new List<User>();
        public void JoinChatRoom(User user)
        {
            string joinMsg = $"{user.UserName} joins the chat";
            Broadcast("Room", joinMsg);
            //to initialize the room
            user.Room = this;
            Users.Add(user);
        }

        public void Broadcast(string source, string message)
        {
            foreach (var u in Users)
            {
                if (u.UserName != source)
                {
                    u.ReceiveMessage(source, message);
                }
            }
        }
        public void Message(string sourse, string destination, string message)
        {
            Users.FirstOrDefault(u => u.UserName == destination)
                ?.ReceiveMessage(sourse, message);
        }
    }
}
