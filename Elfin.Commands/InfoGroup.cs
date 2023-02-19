using Elfin.Attributes;
using DSharpPlus.Entities;

namespace Elfin.Commands
{
    [ElfinGroup("info")]
    public class ElfinInfoCommandGroup
    {
        [ElfinCommand("helloworld")]
        [ElfinAliases(new string[] { "hworld" })]
        [ElfinDescription("Hello, world!")]
        public static async Task HelloWorld(DiscordMessage message, string[] args)
        {
            await message.RespondAsync("Hello, world!");
        }

        [ElfinCommand("userinfo")]
        [ElfinAliases(new string[] { "uinfo" })]
        [ElfinDescription("Sends information on a user.")]
        public static async Task UserInfo(DiscordMessage message, string[] args)
        {
            await message.RespondAsync("some info here idk!");
        }
    }
}