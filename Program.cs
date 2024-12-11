
/*
You are given an N x N 2D matrix representing an image, rotate 
the image by 90 degrees clockwise.
You have to rotate the image in place, don't allocate to 
anoother matrix to rotate. 
*/

//sort, or push data to the right? for 90 degrees = 1 turn
//switch out specific data
//reverse array? 
//select corner points as a sort and switch elements?

//nested for loop? hit both/all N element rings?
//swap the i and j?

namespace Assignment_6._4
{
    public class Solution
    {
        //double arrays!
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            //built matrix based on n
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    //swap them
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i]; //jajajajaja
                    matrix[j][i] = temp;
                }
            }
            //turn the rubiks cube upside down through reversal
            for (int i = 0; i < n; i++)
            {
                int left = 0, right = n - 1;
                while (left < right)
                    //for for to for while is weird
                {
                    //swap again for double swap to reverse on different angles or whatever
                    int temp = matrix[i][left];
                    matrix[i][left] = matrix[i][right];
                    matrix[i][right] = temp;

                    left++;
                    right--;
                }
            }
        }
        public void DisplayMatrix(int[][] matrix)
        {
            int n = matrix.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        internal class Program
        {
            static void Main()
            {
                Console.WriteLine("It's a 2D rubiks cube!");
                Console.WriteLine("");
                Console.WriteLine("Watch it spin!");
                //Console.WriteLine("");

                //hardcode
                //int[][] matrix =

                //{
                //new int[] {1, 2, 3},
                //new int[] {4, 5, 6},
                //new int[] {7, 8, 9}
                //};

                //hardcode 4 elements deep?
                int[][] matrix =

                {
                new int[] {1, 2, 3, 4},
                new int[] {5, 6, 7, 8},
                new int[] {9, 10, 11, 12},
                new int[] {11, 12, 13, 14}
                };
                //larger numbers don 't line up very well when printed

                Console.WriteLine("");
                Solution solution = new Solution();

                Console.WriteLine("Initial Hardcoded Matrix:");
                Console.WriteLine("");
                solution.DisplayMatrix(matrix);

                solution.Rotate(matrix);
                Console.WriteLine("");
                Console.WriteLine("Matrix after 1 spin:");
                Console.WriteLine("");
                //Console.WriteLine("Matrix after [k] spin:");
                solution.DisplayMatrix(matrix);

                //do while to spin again?
            }
        }
    }

}
