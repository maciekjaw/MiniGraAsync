using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MiniGraAsync
{
    public class Game
    {
        string[] word = { "M", "A" };

        public string ReceiveRandomLeter(Player player)
        {
            List<string> words = new List<string>();
            var thread = Thread.CurrentThread.ThreadState;
            var threadID = Thread.CurrentThread.ManagedThreadId;

            for (int i = 0; i < 4; i++)
            {
                repeat: Random rand = new Random();
                var randNum = rand.Next(0, 2);
                var randLetter = word.GetValue(randNum).ToString();

                var hour = DateTime.UtcNow.Hour;
                var minute = DateTime.UtcNow.Minute;
                var seconds = DateTime.UtcNow.Second;
                var milisecond = DateTime.UtcNow.Millisecond.ToString();

                var dateTime = DateTime.Now.ToString() + milisecond;
                var num = randNum;

                if (i == 0)
                {
                    if (randLetter == "M")
                    {
                        words.Add(randLetter);
                        Console.WriteLine("Player {0}, {1}, {2}, {3}, {4}, {5}", player.Name, player.Surname + " wylosowal", randLetter, "time is " + dateTime, milisecond + " thread state is " + thread, "thread ID is " + threadID);
                    }
                    else
                    {
                        goto repeat;
                    }
                }
                else if (i == 1)
                {
                    if (randLetter == "A")
                    {
                        words.Add(randLetter);
                        Console.WriteLine("Player {0}, {1}, {2}, {3}, {4}, {5}", player.Name, player.Surname + " wylosowal", randLetter, "time is " + dateTime, milisecond + " thread state is " + thread, "thread ID is " + threadID);
                    }
                    else
                    {
                        goto repeat;
                    }
                }
                else if (i == 2)
                {
                    if (randLetter == "M")
                    {
                        words.Add(randLetter);
                        Console.WriteLine("Player {0}, {1}, {2}, {3}, {4}, {5}", player.Name, player.Surname + " wylosowal", randLetter, "time is " + dateTime, milisecond + " thread state is " + thread, "thread ID is " + threadID);
                    }
                    else
                    {
                        goto repeat;
                    }
                }
                else if (i == 3)
                {
                    if (randLetter == "A")
                    {
                        words.Add(randLetter);
                        Console.WriteLine("Player {0}, {1}, {2}, {3}, {4}, {5}", player.Name, player.Surname + " wylosowal", randLetter, "time is " + dateTime, milisecond + " thread state is " + thread, "thread ID is " + threadID);
                    }
                    else
                    {
                        goto repeat;
                    }
                }
            }

            var mama = words[0] + words[1] + words[2] + words[3];

            return mama;
        }
    }
}
