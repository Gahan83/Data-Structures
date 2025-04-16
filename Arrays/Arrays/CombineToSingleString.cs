namespace Arrays.Arrays
{
    public class CombineToSingleString
    {
         public void Combine(string[] names)
        {
            string result = string.Empty;

            foreach (var name in names)
            {
                result= result + name + ",";
            }

            int lastIndex= result.LastIndexOf(',');
            result =result.Remove(lastIndex);

            Console.WriteLine(result);
        }
    }
}
