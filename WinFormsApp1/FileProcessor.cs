namespace Trading212TransactionCounter
{
    public class FileProcessor
    {

        public List<float> processSelectedFile(String filePath)
        {
            // Possitions of important values
            int actionIndex = 0;
            int resultIndex = 0;
            int totalIndex = 0;

            // Result values for return
            float totalProfit = 0;
            float totalMarketSell = 0;
            float totalMarketBuy = 0;
            float dividend = 0;



            using (var reader = new StreamReader(filePath))
            {
                // Reads file
                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(",").ToList();

                    // Gets index number of column with needed values 
                    for (int i = 0; i < row.Count; i++)
                    {
                        if (row[i].ToLower().Trim().Equals("result"))
                            resultIndex = i;

                        if (row[i].ToLower().Trim().Equals("total"))
                            totalIndex = i;
                    }

                    if (row[actionIndex].ToLower().Trim().Contains("market sell"))
                    {
                        // Counts result (profit made) and total market sell value
                        totalProfit += float.Parse(row[resultIndex].Replace(".", ","));
                        totalMarketSell += float.Parse(row[totalIndex].Replace(".", ","));
                    }

                    if (row[actionIndex].ToLower().Trim().Contains("market buy"))
                    {
                        // Counts total market buy value
                        totalMarketBuy += float.Parse(row[totalIndex].Replace(".", ","));
                    }

                    if (row[actionIndex].ToLower().Trim().Contains("dividend"))
                    {
                        // Counts dividend total value
                        dividend += float.Parse(row[totalIndex].Replace(".", ","));
                    }
                }
            }

            return new List<float> { totalProfit, totalMarketSell, totalMarketBuy, dividend };
        }
    }
}
