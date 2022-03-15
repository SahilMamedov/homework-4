using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int tipindən bir array olur içində müsbət və mənfi ədədlər olur 
               elə bir method yazın ki, bu array-i parametr olaraq qəbul etsin və
               qəbul etdiyi array-in əvvəlcədən assign olunması məcburi olsun 
               daha sonra içindəki mənfi ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın */

            int[] array = {-4,-5,6,4,2,3};
            
            method(ref array);
           

        }
        static int[] method(ref int[] array)
        {
          
            
            
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < 0)
                {
                    array[i] = array[i] * -1;
                   
                }
     
               Console.WriteLine(array[i]);
            }

            return array;
                
        }
        
    }
}
