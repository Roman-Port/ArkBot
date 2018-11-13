using DiscordBotFrame;
using DSharpPlus;
using System;
using System.Threading.Tasks;

namespace ArkBot4
{
    class Program
    {
        public static DiscordInterface discord;

        static void Main(string[] args)
        {
            discord = new DiscordInterface("%", "", (DSharpPlus.Entities.DiscordUser u, DSharpPlus.Entities.DiscordChannel c) =>
            {
                return DiscordPermissionLevel.Owner;
            });
            
        }
        
    }

    
}
