using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment2_CT_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            int target = 9;
            int[] r = TargetRange(l1, target);

            // Write your code to print range r here
            Console.WriteLine("Question 2");
            string s = "University of South Florida ";
            string rs = StringReverse(s);
            Console.WriteLine(rs);

            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 2,2,3,5,6 };
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);

            Console.WriteLine("Question 4");
            string s2 = "Dell";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);

            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect1(nums1, nums2);
            Console.WriteLine("Part 1- Intersection of two arrays is: ");
            DisplayArray(intersect1);
            Console.WriteLine("\n");
            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2);
            Console.WriteLine("Part 2- Intersection of two arrays is: ");
            DisplayArray(intersect2);
            Console.WriteLine("\n");

            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));

            Console.WriteLine("Question 7");
            int rodLength = 4;
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine(priceProduct);

            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            
        Console.WriteLine(DictSearch(userDict, keyword));
            Console.WriteLine("Question 8");
            SolvePuzzle();
        }
        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }
        public static int[] TargetRange(int[] l1, int t)
        {
            try
            {
                //initialize an Arraylist
                ArrayList al = new ArrayList();
                //traverse along the given array l1
                for(int i = 0;i < l1.Length; i++)
                {
                    //if the element at the index equals the target,the index is added to arraylist
                    if (l1[i] == t)
                    {
                        al.Add(i);
                    }
                   


                }
                
               //initializing integer n and storing last index of arraylist
                int n = al.Count - 1;
                //if the arraylist is empty,print the [-1,-1]
                
                //convert n to string
                string b = n.ToString();
                //Print the first and last elements of arraylist
                if (al != null)
                {
                    Console.WriteLine("Array is [" + al[0] + "," + al[n] + "]");
                }
                else
                    Console.WriteLine("[-1,-1]");

            }
            catch (Exception)
            {
                
                throw;
            }
            return new int[] { };
        }
        public static string StringReverse(string s)
        {
            try
            {
                
                ArrayList ar = new ArrayList();
                int n = s.Length;
                string temp = "";
                // Split the sentence by words by space and store the words in array
                for (int i = 0; i < s.Length; i++)
                {

                    if (s[i] != ' ')
                    {
                        temp = temp + s[i];
                        continue;
                    }
                    //reverse the words and print
                    string rev = null;
                    int l = temp.Length - 1;
                    while (l >= 0)
                    {
                        rev = rev + temp[l];
                        l--;

                    }
                    Console.Write(rev + " ");
                    ar.Add(temp);

                    temp = "";

                }


                

}
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        public static int MinimumSum(int[] l2)
        {
            try
            {
                int a=0;
                int sum = 0;
                //travers the array 
                for(int i = 0;i<l2.Length;i++)
                {
                   /*if the value in l2[i] already exists in array and which is stored in a,then 
                   increase the value by 1*/
                    if(a==l2[i])
                    {
                        l2[i]++;
                        
                    }
                    //store value of l2[i] in a
                    a = l2[i];
                    
                }
                Console.Write("Array with distinct elements is : ");
                foreach (int b in l2)
                    Console.Write(b+" ");
                //Sum of elements in array
                for(int j=0;j<l2.Length;j++)
                {
                    sum = sum + l2[j];
                }
                Console.WriteLine();
                Console.WriteLine("Sum is :" + sum);
               
            }
            catch (Exception)
            {
                throw;
            }
            return 0;
        }
        public static string FreqSort(string s2)
    
        {
             try
             {
                int[] c = new int[(int)char.MaxValue];
                // 3.
                // Iterate over each character.
                foreach (char t in s2)
                {
                    // Increment table.
                    c[(int)t]++;
                }
                // 4.
                // Write all letters found.
                for (int i = 0; i < (int)char.MaxValue; i++)
                {
                    if (c[i] > 0 && char.IsLetterOrDigit((char)i))
                    {
                        Console.WriteLine("Letter: {0}  Frequency: {1}", (char)i,c[i]);
                    }
                }
                

            }
                catch (Exception)
            {
                throw;
            }
            return null;
            }
public static int[] Intersect1(int[] nums1, int[] nums2)
{
            try
            {
                int n = nums1.Length;
                int m = nums2.Length;
                int i = 0;
                int j = 0;
                while(i<n && j<m)
                {
                    if(nums1[i]>nums2[j])
                    {
                        j++;
                    }
                    else if(nums2[j]>nums1[i])
                    {
                        i++;
                    }
                    else
                    {
                        Console.Write(nums1[i] + " ");
                        i++;
                        j++;
                    }
                }
                //Console.ReadLine();
            }
            
            catch
             {
            throw;
             }
             return new int[] { };
       }

    

public static int[] Intersect2(int[] nums1, int[] nums2)
{
    try
    {
     
            }
    catch
    {
        throw;
    }
    return new int[] { };
}
public static bool ContainsDuplicate(char[] arr, int k)
{
    try
    {
                ArrayList al = new ArrayList();
                ArrayList indices = new ArrayList();
                int[] num = new int[] { };
                int i = 0;
                int j = 1;
                int diff;
                while(i<arr.Length && j<arr.Length)
                {
                    if(arr[i] ==arr[j])
                    {
                        
                        al.Add(arr[i]);
                        indices.Add(i);
                        indices.Add(j);
                        diff = j - i;
                        if(diff==k)
                        { 
                            return true;
                        }
                        i++;
                        j = i + 1;

                    }
                    else
                    {
                        j++;
                    }
                }
                Console.Write("Char which are equal : ");
                foreach (char a in al)
                    Console.Write(a + " ");
                Console.WriteLine();
                Console.WriteLine("Indices are:");
                foreach (int b in indices)
                    Console.Write(b + " ");
                Console.ReadLine();
            }
    catch (Exception)
    {
        throw;
    }
    return default;
}
public static int GoldRod(int rodLength)
{
    try
    {
        //Write Your Code Here
        
    }
    catch (Exception)
    {
        throw;
    }
    return 0;
}
public static bool DictSearch(string[] userDict, string keyword)
{
    try
    {
        //Write Your Code Here
    }
    catch (Exception)
    {
        throw;
    }
    return default;
}
public static void SolvePuzzle()
{
    try
    {
        //Write Your Code Here
    }
    catch (Exception)
    {
        throw;
    }
}
}
}