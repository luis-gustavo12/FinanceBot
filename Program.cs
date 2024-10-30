using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;




namespace FinanceBot {

    public class Program {


        private static DiscordSocketClient _client;

        public static async Task Main() {

            Console.WriteLine("START");

            _client = new DiscordSocketClient();
            _client.Log += Log;


            var token = "FIRST_LAUNCH";

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();


            await Task.Delay(-1);
        }

        private static Task Log(LogMessage msg) {

            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;

        }

    }




}