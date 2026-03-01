namespace SearchAlgorithmsLibrary
{
    public class Order
    {
        public string CheckShipping(int weight, bool isInternational, bool express)
        {
            if (weight > 0)
            {
                if (isInternational && express)
                {
                    return "International Express";
                }
                else if (isInternational)
                {
                    return "International Standard";
                }
                else
                {
                    return "Domestic";
                }
            }

            return "Invalid Weight";
        }
    }
}