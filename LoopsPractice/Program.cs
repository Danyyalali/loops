using System;

namespace ArrayAndLoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Generate = new Random();
            Generate.Next(1, 4);
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine();

            // int aal = 0
            //System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //For 2d Jacked Array


            //Jacked array 
            int[][,] ArrayJagged = new int[2][,];

            //Inittialization of Array
            ArrayJagged[0] = new int[5, 5];
            ArrayJagged[1] = new int[5, 10];

            //Filling the array with random numbers
            for (int i = 0; i < ArrayJagged.Length; i++)
            {
                for (int j = 0; j < ArrayJagged[i].GetLength(0); j++)
{
                    for (int k = 0; k < ArrayJagged[i].GetLength(1); k++)
                    {
                        ArrayJagged[i][j, k] = Generate.Next(1, 10);
                    }
                }
            }

            //int arrayNumber1 = 1;
            //Printing the array
            for (int i = 0; i < ArrayJagged.Length; i++)
            {
                for (int j = 0; j < ArrayJagged[i].GetLength(0); j++)
                {
                    for (int k = 0; k < ArrayJagged[i].GetLength(1); k++)
                    {
                        //Console.WriteLine("The value at Row " + i + " Array " + arrayNumber1 + " at index [" + i + "] [" + j + "] is " + ArrayJagged[i][j]);
                        Console.Write("["+ArrayJagged[i][j, k]+"]");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////







            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //For single Jacked 

            /*  //Jacked array 
                int [][] ArrayJagged = new int[2][];

                //Inittialization of Array
                ArrayJagged[0] = new int[5];
                ArrayJagged[1] = new int[5];

                //Filling the array with random numbers
                for (int i = 0; i < ArrayJagged.Length; i++)
                {
                    for(int j = 0; j < ArrayJagged[i].Length; j++)
                    {
                        ArrayJagged[i][j] = Generate.Next(1, 10);
                    }
                }
                int arrayNumber = 1;
                //Printing the array
                for (int i = 0; i < ArrayJagged.Length; i++)
                {
                    arrayNumber = arrayNumber + i;
                    for (int j = 0; j < ArrayJagged[i].Length; j++)
                    {
                        Console.WriteLine("The value at Row " + i + " Array " + arrayNumber + " at index ["+i+"] [" +j+"] is " +ArrayJagged[i][j]);
                    }
                }
            */



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





            /*          //for Array Practice
                        int[] OneD = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        int[,] TwoD = new int[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };


                        for(int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("From One Dimentional Array " + OneD[i]);
                        }


                        Console.WriteLine("Moving toward the Two dimentional array");

                        for (int i = 0; i < 3; i++)
                        {
                            for(int j = 0; j < 3; j++)
                            {
                                Console.WriteLine("From Two Dimentional Array " + TwoD[i,j]);
                            }
                        }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //For the loops practice
            /*
                        while (aal < 10)
                        {
                            Console.WriteLine("Hello " + aal + " FrOm While Loop");
                            aal++;
                        }
                        aal = 0;

                        do
                        {
                            Console.WriteLine("Hello" + aal + " from Do While Loop");
                            aal++;
                        } while (aal < 10);

                        int[] Arr=new int[10]; 
                        for(int i = 0; i < 10; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    Console.WriteLine("Hello " + i + " from Switch Case " + i + " ForEach Loop");
                                    return;

                                case 2:
                                    Console.WriteLine("Hello " + i + " from Switch Case " + i + " ForEach Loop");
                                    return;

                                case 3:
                                    Console.WriteLine("Hello " + i + " from Switch Case " + i + " ForEach Loop");
                                    return;

                                case 4:
                                    Console.WriteLine("Hello " + i + " from Switch Case " + i + " ForEach Loop");
                                    return;
                            }
                            Console.WriteLine("Hello" + i + " from For Loop");
                            Arr[i] = i;

                        }

                        foreach (int a in Arr)
                        {
                            Console.WriteLine("Hello" + a + " from Do ForEach Loop");


                        }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            Console.ReadKey();

        }
    }
}
