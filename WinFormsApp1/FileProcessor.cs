namespace Trading212TransactionCounter
{
    public class FileProcessor
    {

        public List<float> processSelectedFile(String filePath)
        {
            int actionIndex = 0;
            int resultIndex = 9;
            int totalIndex = 11;

            float totalResult = 0;
            float totalSalesValue = 0;



            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(",").ToList();

                    if (row[actionIndex].ToLower().Trim().Equals("market sell"))
                    {
                        totalResult += float.Parse(row[resultIndex].Replace(".", ","));
                        totalSalesValue += float.Parse(row[totalIndex].Replace(".", ","));
                    }
                }
            }

            return new List<float> { totalResult, totalSalesValue };
        }
    }
}
