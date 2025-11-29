namespace drawingLetters
{
    internal class Program
    {
        static void DrawingLetterA(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (
                        i == 0                                   
                        || j == 0                                
                        || j == size - 1                         
                        || i == size / 2                         
                    )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterB(int b)
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (j == 0 || i == 0 || i == b - 1 || i == b / 2 || j == b - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterC(int c)
        {
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i == 0 || j == 0 || i == c - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterE(int e)
        {
            for (int i = 0; i < e; i++)
            {
                for (int j = 0; j < e; j++)
                {
                    if (i == 0 || i == e / 2 || i == e - 1 || j == 0)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterF(int f)
        {
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < f; j++)
                {
                    if (i == 0 || j == 0 || i == f / 2)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterG(int g)
        {
            for (int i = 0; i < g; i++)
            {
                for (int j = 0; j < g; j++)
                {
                    if (i == 0 || j == 0 || i == g - 1 || (j == g - 1 && i >= g / 2) || (i == g / 2 && j >= g / 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterH(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (i == h / 2 || j == 0 || j == h - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterI(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == size / 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterJ(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || (j == size / 2 && i != size - 1) || (i == size - 1 && j <= size / 2 && j != 0) || (j == 0 && i >= size - 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterK(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 || i + j == size / 2 || i - j == size / 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterL(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 || i == size - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterM(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 || j == size - 1 || (i == j && i <= size / 2) || (i + j == size - 1 && i <= size / 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterN(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 || j == size - 1 || i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterO(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterP(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 || i == 0 || i == size / 2 || (j == size - 1 && i <= size / 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterQ(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 2 || j == 0 || j == size - 2 || (i == j && i >= size / 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterR(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 || i == 0 || i == size / 2 || (j == size - 1 && i <= size / 2) || (i - j == size / 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterS(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size / 2 || i == size - 1 || (j == 0 && i < size / 2) || (j == size - 1 && i > size / 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterT(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || j == size / 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterU(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j == 0 && i != size - 1) || (j == size - 1 && i != size - 1) || (i == size - 1 && j != 0 && j != size - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterV(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j == i && i < size / 2) || (j + i == size - 1 && i < size / 2) || (i >= size / 2 && (j == size / 2 - (i - size / 2) || j == size / 2 + (i - size / 2))))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterW(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 || j == size - 1 || (i >= size / 2 && (j == i || j == size - 1 - i)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterX(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j || i + j == size - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawingLetterY(int y)
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if ((i == j && i < y / 2) ||
                        (i + j == y - 1 && i < y / 2) ||
                        (i >=
                        y / 2 && j == y / 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrowingLetterZ(int size)
        {
            int arrSize = size;
            for (int i = 0; i <= arrSize; i++)
            {
                for (int j = 0; j <= arrSize; j++)
                {
                    if (i == 0 || i == arrSize || i + j == arrSize)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write('\n');
            }

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Drawing Letters From A to Z");

            DrawingLetterA(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterB(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterC(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterE(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterF(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterG(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterH(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterI(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterJ(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterK(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterL(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterM(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterN(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterO(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterP(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterQ(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterR(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterS(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterT(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterU(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterV(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterW(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterX(7);
            Console.WriteLine("=====================================\n");

            DrawingLetterY(7);
            Console.WriteLine("=====================================\n");

            DrowingLetterZ(7);
        }
    }
}
