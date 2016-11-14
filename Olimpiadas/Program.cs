using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region p1
            int[] input = { 5, 10, 5, 20, 10, 5 ,10, 20, 10 };
            //int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //          G           B           C
            int[] b1 = {input[0], input[1], input[2]};
            int[] b2 = {input[3], input[4], input[5]};
            int[] b3 = {input[6], input[7], input[8]};
            //                G                B                 C
            int gbc = (b2[0] + b3[0]) + (b1[1] + b3[1]) + (b1[2] + b2[2]);
            //                G                C                 B
            int gcb = (b2[0] + b3[0]) + (b1[2] + b3[2]) + (b1[1] + b2[1]);
            //                B                G                 C
            int bgc = (b2[1] + b3[1]) + (b1[0] + b3[0]) + (b1[2] + b2[2]);
            //                B                C                 G
            int bcg = (b2[1] + b3[1]) + (b1[2] + b3[2]) + (b1[0] + b2[0]);

            int cgb = (b2[2] + b3[2]) + (b1[0] + b3[0]) + (b1[1] + b2[1]);
            int cbg = (b2[2] + b3[2]) + (b1[1] + b3[1]) + (b1[0] + b2[0]);

            List<Combinatory> listComb = new List<Combinatory>();
            listComb.Add(new Combinatory() { Combo = "gbc", Moves = gbc});
            listComb.Add(new Combinatory() { Combo = "gcb", Moves = gcb });
            listComb.Add(new Combinatory() { Combo = "bgc", Moves = bgc });
            listComb.Add(new Combinatory() { Combo = "bcg", Moves = bcg });
            listComb.Add(new Combinatory() { Combo = "cgb", Moves = cgb });
            listComb.Add(new Combinatory() { Combo = "cbg", Moves = cbg });

            var result = listComb.OrderBy(x => x.Moves);
            foreach (var combinatory in result)
            {
                Console.WriteLine($"{combinatory.Combo}: {combinatory.Moves}");
            }
            

           // Console.ReadLine();



            #endregion

            #region p2
            Routes =new List<string>();
            char[,] dungeon =
            {
               {'*','*','*','*','*','*','*','*','*','*'},
               {'*','E','*','*','*','*','*','*','*','*'},
               {'*',' ','*','*','*','*','*','*','*','*'},
               {'*',' ',' ',' ',' ',' ',' ','*','*','*'},
               {'*',' ','*','*',' ','*','*','*','*','*'},
               {'*',' ',' ',' ',' ',' ',' ',' ',' ','*'},
               {'*',' ','*','*','*','*','*',' ','*','*'},
               {'*',' ',' ',' ',' ',' ',' ',' ','*','*'},
               {'*',' ','*','*','*','*','*','*','*','*'},
               {'*',' ',' ',' ',' ',' ',' ',' ',' ','S'},
               {'*','*','*','*','*','*','*','*','*','*'}
            };


            recorre(1,1,ref dungeon,0,"");
            foreach (var r in Routes)
            {
                Console.WriteLine(r +" "+ r.Length);
            }
            Console.ReadLine();

            #endregion
        }

        public class Combinatory    
        {
            public string Combo { get; set; }
            public int Moves { get; set; }
        }

        public static List<string> Routes;
        public static void recorre(int x, int y, ref char[,] dungeon, int count, string route )
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(dungeon[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            if (dungeon[x,y] == 'S')
            {
                Routes.Add(route);
               
            }
            else
            {
                dungeon[x, y] = '*';
                if (dungeon[x + 1, y] != '*')
                {
                    route += "A";                    
                    recorre(x+1,y,ref dungeon, count++,route);
                }

                if (dungeon[x,y+1] != '*')
                {
                    route += "B";
                    recorre(x, y+1, ref dungeon, count++, route);
                }

                if (dungeon[x - 1, y] != '*')
                {
                    route += "C";
                    recorre(x - 1, y, ref dungeon, count++, route);
                }

                if (dungeon[x, y-1] != '*')
                {
                    route += "D";
                    recorre(x, y-1, ref dungeon, count++, route);
                }
                dungeon[x, y] = ' ';
            }
        }


    }
}
