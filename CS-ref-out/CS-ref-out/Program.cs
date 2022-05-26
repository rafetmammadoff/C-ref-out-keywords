using System;

namespace CS_ref_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 3, 5, 2 };

            AddElementToArray(ref numbers, 21); //*** 1-ci Tapsiriq metodu ********************************************

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            string text = "     a   r a f e t  s     f   f sa f";
            TrimText(ref text); //********** 2-ci Tapsiriq metodu *****************************************************
            Console.WriteLine(text);
            int num = -9;
            Console.WriteLine(num);
            ConvertNum(ref num); //********** 3-ci Tapsiriq metodu *****************************************************
            Console.WriteLine(num);

            int[] numbers1 = { 4, -5, -23, -42, -44, 32, 893, 43, 9 };

            ConvertArray(ref numbers1); //*** 4-cu Tapsiriq metodu *****************************************************

            foreach (var item in numbers1)
            {
                Console.WriteLine(item);
            }
        }

        #region 1-ci tapsiriq******************************************************************************************
                // Parameter olaraq integer array variable-i ve bir integer value qebul eden ve
                // hemin integer value-nu integer array-e yeni element kimi elave eden metod.

        static void AddElementToArray(ref int[] numbers,int num)
        {
            int[] newArr = new int[numbers.Length+1];
            for (int i = 0; i < numbers.Length; i++)
            {
                newArr[i] = numbers[i];
            }
            newArr[newArr.Length-1] = num;
            numbers = newArr;
        }
        #endregion

        #region 2-ci tapsiriq******************************************************************************************
                // Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri
                // əvvəlində və sonunda boşluqlar qalmayacaq hala gətirən metod.

        static void TrimText(ref string text)
        {
            string createText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    createText += text[i];
                }
            }
            text = createText;
        }
        #endregion

        #region 3-cu tapsiriq******************************************************************************************
                // Qəbul etdiyi ədədi musbətə ceviren metod

        static void ConvertNum(ref int num)
        {
            if (num < 0)
            {
                num *= -1;
            }
        }
        #endregion

        #region 4-ci tapsiriq******************************************************************************************
                // Qəbul etdiyi ədədlər siyahısının içərisindəki bütün ədədləri müsbət hala gətirən metod

        static void ConvertArray(ref int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] *= -1;
                }
            }
        }
        #endregion

    }
}
