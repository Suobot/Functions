using Discord;
using Discord.Commands;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suobot
{
    class MyBot
    {
        DiscordClient discord;

        public MyBot()
        {
            discord = new DiscordClient(x =>
            {
                x.Loglevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("NDY5NDU2NzQ4MDcyMTQwODAy.DlLEaw.aqIBl2KgNz2Ihr7FeK7yfSBKQI0", TokenType.Bot);
            });
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }

    internal class DiscordClient
    {
        internal void ExecuteAndWait(Func<Task> p)
        {
            throw new NotImplementedException();
        }
    }
}
