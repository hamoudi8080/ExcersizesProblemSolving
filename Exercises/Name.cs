namespace Excersize.Exercises
{
    internal class Name
    {

        public static string namesFunction(string[] names)
        {

          
            List<string> nameList = new List<string>(names);

          
            for (int i = 0; i < nameList.Count; i++)
            {
                if (nameList[i].StartsWith("B"))
                {
                    nameList.RemoveAt(i);

                    Console.WriteLine(nameList[i]);

                }
            }

          
            //for (int i = 0; i < nameList.Count; i++)
            //{
            //    Console.WriteLine(nameList[i]);   
            //}

          
            return string.Join(", ", nameList);


        }


    }
}
