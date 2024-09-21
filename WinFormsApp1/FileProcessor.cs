namespace Trading212TransactionCounter
{
    public class FileProcessor
    {

        public List<float> processSelectedFile(String filePath)
        {
            int actionIndex = 0;
            int resultIndex = 9;
            int totalIndex = 11;

            float totalProfit = 0;
            float totalMarketSell = 0;
            float totalMarketBuy = 0;
            float dividend = 0;



            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(",").ToList();

                    if (row[actionIndex].ToLower().Trim().Contains("market sell"))
                    {
                        totalProfit += float.Parse(row[resultIndex].Replace(".", ","));
                        totalMarketSell += float.Parse(row[totalIndex].Replace(".", ","));
                    }

                    if (row[actionIndex].ToLower().Trim().Contains("market buy"))
                    {
                        totalMarketBuy += float.Parse(row[totalIndex].Replace(".", ","));
                    }

                    if (row[actionIndex].ToLower().Trim().Contains("dividend"))
                    {
                        dividend += float.Parse(row[totalIndex].Replace(".", ","));
                    }
                }
            }

            return new List<float> { totalProfit, totalMarketSell, totalMarketBuy, dividend };
        }
    }
}
