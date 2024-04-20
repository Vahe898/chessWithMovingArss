using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessWithMovingArss
{
    internal class Rook
    {
        private int _numberForRook;
        private Letters _letterForRook;
        
        public int NumberForRook
        {
            get
            {
                return _numberForRook;
            }
            set
            {
                if (value > 0 && value < 9)
                {
                    _numberForRook = value;
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }
        public Letters LetterForRook
        {
            get
            {
                return _letterForRook;

            }
            set
            {
                if (Enum.IsDefined(typeof(Letters), value))/*senc nayum em tenam tvacs enumis meja te che*/
                {
                    _letterForRook = (Letters)Enum.Parse(typeof(Letters), value.ToString().ToUpper());/*tvacs tary vory stringa darcnuma enum*/
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }

        public void MatricOfRook(int inputNum, Letters inputLet,ref int[,] arr)
        {
            Point PointOfRook = new Point(inputNum, inputLet);
            for (int i = 0; i <8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((inputNum == i && inputLet == (Letters)(j)))
                    {
                        arr[i, j] = 9;
                    }
                    else if (PointOfRook.Number == i && Array.IndexOf(Enum.GetValues(PointOfRook.Letter.GetType()), PointOfRook.Letter) != Array.IndexOf(Enum.GetValues(((Letters)j).GetType()), (Letters)j))
                    {
                        arr[i, j] = 2;
                    }
                    /*uxxahayaca etum nuyn cev*/
                    else if (NumberForRook != inputNum && Array.IndexOf(Enum.GetValues(PointOfRook.Letter.GetType()), PointOfRook.Letter) == Array.IndexOf(Enum.GetValues(((Letters)j).GetType()), (Letters)j))
                    {
                        arr[i, j] = 2;
                    }
                    

                }

            }
        }
        //public void RookIsMoving(ref int inputNum, ref char inputLet)
        //{
        //    do /*tivy kara luboy lini*/
        //    {
        //        Console.WriteLine("Enter number where to move ");
        //        NumberForRook = int.Parse(Console.ReadLine());
        //    } while (NumberForRook < 1 || NumberForRook > 8);
        //    do
        //    {
        //        Console.WriteLine("enter letter where to move");
        //        LetterForRook = Console.ReadKey().KeyChar;
        //        /*araji ify horizonakan dirqov kara gna sax tarerov baci vori vra ka*/
        //        if (NumberForRook == inputNum && Array.IndexOf(letterSForRook, LetterForRook) != Array.IndexOf(letterSForRook, inputLet))
        //        {
        //            Console.WriteLine();
        //            break;
        //        }
        //        /*uxxahayaca etum nuyn cev*/
        //        else if (NumberForRook != inputNum && Array.IndexOf(letterSForRook, LetterForRook) == Array.IndexOf(letterSForRook, inputLet))
        //        {
        //            Console.WriteLine();
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine();
        //            do /*tivy kara luboy lini*/
        //            {
        //                Console.WriteLine("Enter number where to move ");
        //                NumberForRook = int.Parse(Console.ReadLine());
        //            } while (NumberForRook < 1 || NumberForRook > 8);
        //        }
        //    } while (true);
        //    inputNum = NumberForRook;
        //    inputLet = LetterForRook;
        //}
    }
}
