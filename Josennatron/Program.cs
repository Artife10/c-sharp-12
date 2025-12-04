namespace Josennatron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            string alap = "This was a triumph.\r\nI'm making a note here:\r\nhuge success.\r\n\r\nIt's hard to overstate\r\nMy satisfaction.\r\n\r\nAperture Science.\r\nWe do what we must\r\nBecause we can.\r\nFor the good of all of us.\r\nExcept the ones who are dead.\r\n\r\nBut there's no sense crying\r\nOver every mistake.\r\nYou just keep on trying\r\nTill you run out of cake.\r\nAnd the Science gets done.\r\nAnd you make a neat gun.\r\nFor the people who are\r\nStill alive.\r\n\r\nI'm not even angry.\r\nI'm being so sincere right now.\r\nEven though you broke my heart.\r\nAnd killed me.\r\n\r\nAnd tore me to pieces.\r\nAnd threw every piece into a fire.\r\nAs they burned it hurt because\r\nI was so happy for you!\r\n\r\nNow these points of data\r\nMake a beautiful line.\r\nAnd we're out of beta.\r\nWe're releasing on time.\r\nSo I'm GLaD. I got burned.\r\nThink of all the things we learned\r\nFor the people who are\r\nStill alive.\r\n\r\nGo ahead and leave me.\r\nI think I prefer to stay inside.\r\nMaybe you'll find someone else\r\nTo help you.\r\nMaybe Black Mesa...\r\nTHAT WAS A JOKE, HA HA, FAT CHANCE.\r\n\r\nAnyway this cake is great\r\nIt's so delicious and moist\r\n\r\nLook at me still talking when there's science to do\r\nWhen I look out there\r\nIt makes me GLaD I'm not you.\r\n\r\nI've experiments to run\r\nThere is research to be done\r\nOn the people who are\r\nStill alive.\r\n\r\nAnd believe me I am still alive\r\nI'm doing science and I'm still alive\r\nI feel FANTASTIC and I'm still alive\r\nWhile you're dying I'll be still alive\r\nAnd when you're dead I will be still alive\r\nStill alive\r\nStill alive.";
            string[] worked = alap.Split("\r\n");

            foreach (var item in worked)
            {
                Thread.Sleep(800);
                Console.WriteLine(item);
            }
        }
    }
}
