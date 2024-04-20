namespace chessWithMovingArss
{
    internal class Program
    {
        public static void MakeMatric(int inputNumForRedKing, Letters inputLetForRedKing, int inputNumForRedRook, Letters inputLetForRedRook,ref int[,] arrForRedRook, int inputNumForRedRook2, Letters inputLetForRedRook2, ref int[,] arrForRedRook2, int inputNumForBlueKing, Letters inputLetForBlueKing)
        {
            King redKing = new King();
            Point PointOfRedKing = new Point(inputNumForRedKing, inputLetForRedKing);
            int[,] arrForRedKing = new int[8,8];
            redKing.MatricOfKing(PointOfRedKing.Number, PointOfRedKing.Letter, ref arrForRedKing);

            King blueKing = new King();
            Point PointOfBlueKing = new Point(inputNumForBlueKing, inputLetForBlueKing);
            int[,] arrForBlueKing = new int[8, 8];
            blueKing.MatricOfKing(PointOfBlueKing.Number, PointOfBlueKing.Letter, ref arrForBlueKing);


            Rook redRook = new Rook();
            Point PoinntOfRedRook = new Point(inputNumForRedRook, inputLetForRedRook);
            redRook.MatricOfRook(PoinntOfRedRook.Number, PoinntOfRedRook.Letter, ref arrForRedRook);


            Rook redRook2 = new Rook();
            Point PoinntOfRedRook2 = new Point(inputNumForRedRook2, inputLetForRedRook2);
            redRook2.MatricOfRook(PoinntOfRedRook2.Number, PoinntOfRedRook2.Letter, ref arrForRedRook2);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (arrForRedKing[i,j] + arrForRedRook[i,j] >9)/*ena vor gci vra yngav araji kingy*/
                    {

                        if (PoinntOfRedRook.Number < PointOfRedKing.Number)/*kingy verevna*/
                        {
                            for (int k = PointOfRedKing.Number;  k < 8; k++)/*toxer*/
                            {
                                arrForRedRook[k, j] = 0;
                            }
                   
                        }
                        else if(PoinntOfRedRook.Number >PointOfRedKing.Number)/*kingy nerqevna*/
                        {
                           for(int k = 0; k <= PointOfRedKing.Number; k++)/*toxer*/
                           {
                                arrForRedRook[k, j] = 0;
                           }
                        }
                        else if(Array.IndexOf(Enum.GetValues(PoinntOfRedRook.Letter.GetType()), PoinntOfRedRook.Letter) > Array.IndexOf(Enum.GetValues(PointOfRedKing.Letter.GetType()), PointOfRedKing.Letter))
                        {
                            for (int k = Array.IndexOf(Enum.GetValues(PointOfRedKing.Letter.GetType()), PointOfRedKing.Letter); k >=0; k--)/*toxer*/
                            {
                                arrForRedRook[i, k] = 0;
                            }
                        }
                        else if(Array.IndexOf(Enum.GetValues(PoinntOfRedRook.Letter.GetType()), PoinntOfRedRook.Letter) < Array.IndexOf(Enum.GetValues(PointOfRedKing.Letter.GetType()), PointOfRedKing.Letter))
                        {
                            for (int k = Array.IndexOf(Enum.GetValues(PointOfRedKing.Letter.GetType()), PointOfRedKing.Letter); k < 8; k++)/*toxer*/
                            {
                                arrForRedRook[i, k] = 0;
                            }
                        }
                        
                    }
                    if (arrForBlueKing[i, j] + arrForRedRook[i, j] > 9)/*ena vor gci vra yngav kaput kingy*/
                    {

                        if (PoinntOfRedRook.Number < PointOfBlueKing.Number)/*kingy verevna*/
                        {
                            for (int k = PointOfBlueKing.Number; k < 8; k++)/*toxer*/
                            {
                                arrForRedRook[k, j] = 0;
                            }

                        }
                        else if (PoinntOfRedRook.Number > PointOfBlueKing.Number)/*kingy nerqevna*/
                        {
                            for (int k = 0; k <= PointOfBlueKing.Number; k++)/*toxer*/
                            {
                                arrForRedRook[k, j] = 0;
                            }
                        }
                        else if (Array.IndexOf(Enum.GetValues(PoinntOfRedRook.Letter.GetType()), PoinntOfRedRook.Letter) > Array.IndexOf(Enum.GetValues(PointOfBlueKing.Letter.GetType()), PointOfBlueKing.Letter))
                        {
                            for (int k = Array.IndexOf(Enum.GetValues(PointOfBlueKing.Letter.GetType()), PointOfBlueKing.Letter); k >= 0; k--)/*toxer*/
                            {
                                arrForRedRook[i, k] = 0;
                            }
                        }
                        else if (Array.IndexOf(Enum.GetValues(PoinntOfRedRook.Letter.GetType()), PoinntOfRedRook.Letter) < Array.IndexOf(Enum.GetValues(PointOfBlueKing.Letter.GetType()), PointOfBlueKing.Letter))
                        {
                            for (int k = Array.IndexOf(Enum.GetValues(PointOfBlueKing.Letter.GetType()), PointOfBlueKing.Letter); k < 8; k++)/*toxer*/
                            {
                                arrForRedRook[i, k] = 0;
                            }
                        }

                    }
                    if (arrForRedKing[i, j] + arrForRedRook2[i, j] > 9)/*ena vor gci vra yngav kingy 2rd i hamar*/
                    {

                        if (PoinntOfRedRook2.Number < PointOfRedKing.Number)/*kingy verevna*/
                        {
                            for (int k = PointOfRedKing.Number; k < 8; k++)/*toxer*/
                            {
                                arrForRedRook2[k, j] = 0;
                            }

                        }
                        else if (PoinntOfRedRook2.Number > PointOfRedKing.Number)/*kingy nerqevna*/
                        {
                            for (int k = 0; k <= PointOfRedKing.Number; k++)/*toxer*/
                            {
                                arrForRedRook2[k, j] = 0;
                            }
                        }
                        else if (Array.IndexOf(Enum.GetValues(PoinntOfRedRook2.Letter.GetType()), PoinntOfRedRook2.Letter) > Array.IndexOf(Enum.GetValues(PointOfRedKing.Letter.GetType()), PointOfRedKing.Letter))
                        {
                            for (int k = Array.IndexOf(Enum.GetValues(PointOfRedKing.Letter.GetType()), PointOfRedKing.Letter); k >= 0; k--)/*toxer*/
                            {
                                arrForRedRook2[i, k] = 0;
                            }
                        }
                        else if (Array.IndexOf(Enum.GetValues(PoinntOfRedRook2.Letter.GetType()), PoinntOfRedRook2.Letter) < Array.IndexOf(Enum.GetValues(PointOfRedKing.Letter.GetType()), PointOfRedKing.Letter))
                        {
                            for (int k = Array.IndexOf(Enum.GetValues(PointOfRedKing.Letter.GetType()), PointOfRedKing.Letter); k < 8; k++)/*toxer*/
                            {
                                arrForRedRook2[i, k] = 0;
                            }
                        }

                    }
                    if (arrForBlueKing[i, j] + arrForRedRook2[i, j] > 9)/*ena vor gci vra yngav kaput kingy 2rd i hamar*/
                    {

                        if (PoinntOfRedRook2.Number < PointOfBlueKing.Number)/*kingy verevna*/
                        {
                            for (int k = PointOfBlueKing.Number; k < 8; k++)/*toxer*/
                            {
                                arrForRedRook2[k, j] = 0;
                            }

                        }
                        else if (PoinntOfRedRook2.Number > PointOfBlueKing.Number)/*kingy nerqevna*/
                        {
                            for (int k = 0; k <= PointOfBlueKing.Number; k++)/*toxer*/
                            {
                                arrForRedRook2[k, j] = 0;
                            }
                        }
                        else if (Array.IndexOf(Enum.GetValues(PoinntOfRedRook2.Letter.GetType()), PoinntOfRedRook2.Letter) > Array.IndexOf(Enum.GetValues(PointOfBlueKing.Letter.GetType()), PointOfBlueKing.Letter))
                        {
                            for (int k = Array.IndexOf(Enum.GetValues(PointOfRedKing.Letter.GetType()), PointOfRedKing.Letter); k >= 0; k--)/*toxer*/
                            {
                                arrForRedRook2[i, k] = 0;
                            }
                        }
                        else if (Array.IndexOf(Enum.GetValues(PoinntOfRedRook2.Letter.GetType()), PoinntOfRedRook2.Letter) < Array.IndexOf(Enum.GetValues(PointOfBlueKing.Letter.GetType()), PointOfBlueKing.Letter))
                        {
                            for (int k = Array.IndexOf(Enum.GetValues(PointOfRedKing.Letter.GetType()), PointOfRedKing.Letter); k < 8; k++)/*toxer*/
                            {
                                arrForRedRook2[i, k] = 0;
                            }
                        }

                    }
                }
                
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(arrForRedRook[i, j]);
                }
                Console.WriteLine();
            }

        }
        public static void MakeChessWithMatric(int inputNumForRedKing, Letters inputLetForRedKing, string inputFigurForRedKing, int inputNumForRedRook, Letters inputLetForRedRook, string inputFigurForRedRook, int inputNumForRedRook2, Letters inputLetForRedRook2, string inputFigurForRedRook2, int inputNumForBlueKing, Letters inputLetForBlueKing, string inputFigurForBlueKing)
        
        {
            int[,] arrForRedRook = new int[8, 8];
            int[,] arrForRedRook2 = new int[8, 8];
            Point PoinntOfRedRook = new Point(inputNumForRedRook, inputLetForRedRook);
            Point PointOfRedKing = new Point(inputNumForRedKing, inputLetForRedKing);
            Point PoinntOfRedRook2 = new Point(inputNumForRedRook2, inputLetForRedRook2);
            Point PointOfBlueKing = new Point(inputNumForBlueKing, inputLetForBlueKing);
            MakeMatric(PointOfRedKing.Number-1, PointOfRedKing.Letter, PoinntOfRedRook.Number-1, PoinntOfRedRook.Letter, ref arrForRedRook,PoinntOfRedRook2.Number-1,PoinntOfRedRook2.Letter,ref arrForRedRook2,PointOfBlueKing.Number-1,PointOfBlueKing.Letter);/*nayuma vor navy kingi vriv chancni*/
            King redKing = new King();           
            int[,] arrForRedKing = new int[8, 8];
            redKing.MatricOfKing(PointOfRedKing.Number-1, PointOfRedKing.Letter, ref arrForRedKing);

            King blueKing = new King();
            int[,] arrForBlueKing = new int[8, 8];
            blueKing.MatricOfKing(PointOfBlueKing.Number - 1, PointOfBlueKing.Letter, ref arrForBlueKing);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0 && i < 8)/*tverna tpum*/
                    {
                        Console.Write(i + 1);
                    }
                    else if (i == 8 && j >= 0)/*tareri hamra*/
                    {
                        Console.Write($"  {(Letters)j}");
                    }

                    if ((i + j) % 2 == 0 && i < 8)/*guynenrna*/
                    {

                        Console.BackgroundColor = ConsoleColor.White;

                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    /*karmiri figury*/
                    if (i + 1 == PointOfRedKing.Number && (Letters)j == PointOfRedKing.Letter) /*nayuma koordinatnery hamynknuma*/
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(inputFigurForRedKing + "  ");
                    }
                    
                    /*kaputi figury*/
                    else if (i + 1 == PoinntOfRedRook.Number && (Letters)j == PoinntOfRedRook.Letter) /*nayuma koordinatnery hamynknuma*/
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(inputFigurForRedRook + "  ");
                    }
                    else if (i + 1 == PoinntOfRedRook2.Number && (Letters)j == PoinntOfRedRook2.Letter) /*nayuma koordinatnery hamynknuma*/
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(inputFigurForRedRook2 + "  ");
                    }
                    else if (i + 1 == PointOfBlueKing.Number && (Letters)j == PointOfBlueKing.Letter) /*nayuma koordinatnery hamynknuma*/
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(inputFigurForBlueKing + "  ");
                    }
                    /*karmiri vandakanishnery*/
                    else if (i < 8 && arrForRedRook[i, j] + arrForRedKing[i, j] == 3 || arrForRedRook2[i, j] + arrForRedKing[i, j] == 3 || arrForRedRook[i, j] + arrForBlueKing[i, j] == 3 || arrForRedRook2[i, j] + arrForBlueKing[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" # ");
                    }

                    else if (i<8 && arrForRedRook[i,j] == 2 || arrForRedRook2[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" # ");
                    }
                    else if (i<8 && arrForRedKing[i,j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" # ");
                    }
                    else if (i < 8 && arrForBlueKing[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" # ");
                    }

                    else if (i != 8 && j >= 0)
                    {
                        Console.Write("   ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }

        }

        public static void MakingChessWithFigurArss(int inputNumForRedKing,Letters inputLetForRedKing,string inputFigurForRedKing, int inputNumForBlueKing, Letters inputLetForBlueKing, string inputFigurForBlueKing)
        {
            List<int> ColordNumForRedKing = new List<int>();
            List<Letters> ColordLetForRedKing = new List<Letters>();
            int counterForRedKing = 0;
            King redKing = new King();
            Point PointForRedKing = new Point(inputNumForRedKing, inputLetForRedKing);
            redKing.KingStepArss(PointForRedKing.Number, PointForRedKing.Letter, ref ColordNumForRedKing, ref ColordLetForRedKing);
            /*kaputi hamar*/
            List<int> ColordNumForBlueKing = new List<int>();
            List<Letters> ColordLetForBlueKing = new List<Letters>();
            int counterForBlueKing = 0;
            King BlueKing = new King();
            Point PointForBlueKing = new Point(inputNumForBlueKing, inputLetForBlueKing);
            BlueKing.KingStepArss(PointForBlueKing.Number, PointForBlueKing.Letter, ref ColordNumForBlueKing, ref ColordLetForBlueKing);


            for (int i = 0; i <9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0 && i < 8)/*tverna tpum*/
                    {
                        Console.Write( i+1);
                    }
                    else if (i == 8 && j >= 0)/*tareri hamra*/
                    {
                        Console.Write($"  {(Letters)j}");
                    }
                    
                    if ((i + j) % 2 == 0 && i < 8)/*guynenrna*/
                    {

                        Console.BackgroundColor = ConsoleColor.White;

                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    /*karmiri figury*/
                    if ( i+1 == PointForRedKing.Number && (Letters)j == PointForRedKing.Letter) /*nayuma koordinatnery hamynknuma*/
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(inputFigurForRedKing + "  ");
                    }
                    /*kaputi figury*/
                    else if (i + 1 == PointForBlueKing.Number && (Letters)j == PointForBlueKing.Letter) /*nayuma koordinatnery hamynknuma*/
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(inputFigurForBlueKing + "  ");
                    }
                    /*karmiri vandakanishnery*/
                    else if (counterForRedKing < ColordLetForRedKing.Count && ColordLetForRedKing[counterForRedKing] == (Letters)j && ColordNumForRedKing[counterForRedKing] == i + 1)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" # ");
                        counterForRedKing++;

                    }
                    /*kaputi vandakanishnery*/
                    else if (counterForBlueKing < ColordLetForBlueKing.Count && ColordLetForBlueKing[counterForBlueKing] == (Letters)j && ColordNumForBlueKing[counterForBlueKing] == i + 1)
                    {

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" # ");
                        counterForBlueKing++;

                    }
                    else if (i != 8 && j >= 0)
                    {
                        Console.Write("   ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //MakingChessWithFigurArss(1, Letters.C, "k",8,Letters.B,"k");
            //King a = new King();
            //int[,] arr = new int[8, 8];
            //int[,] arr2 = new int[8, 8];
            //Rook aa = new Rook();
            //int c = 4;
            //int b = 4;
            //a.MatricOfKing(c-1, Letters.F, ref arr);
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(  );
            //Console.WriteLine(  );

            //aa.MatricOfRook(b-1, Letters.C, ref arr2);
            //for(int i = 0; i < 8; i++)
            //{
            //    for(int j = 0; j < 8; j++)
            //    {
            //        Console.Write(arr2[i, j]);
            //    }
            //    Console.WriteLine(  );
            //}
            //Console.WriteLine(  );
            //Console.WriteLine(  );


            //MakeMatric(c-1, Letters.F, b-1, Letters.C);
            MakeChessWithMatric(5, Letters.F, "k", 7, Letters.F, "r",2,Letters.B,"r",4,Letters.B,"k");
           

        }
    }
}
