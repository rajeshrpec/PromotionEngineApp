namespace PromotionEngine
{
    public class ProductService:IProductService
    {
    
        public int GetTotalPrice( List<Products> products)
        {
            int counterA=0;
            int counterB=0;
            int counterC=0;
            int counterD=0;
            
            foreach (Product product in products)
            {
                if(product.Id=="A" || product.Id=="a")
                {
                    counterA=counterA+1;
                }
                if(product.Id=="B" || product.Id=="b")
                {
                    counterB=counterB+1;
                }
                if(product.Id=="C" || product.Id=="c")
                {
                    counterC=counterC+1;
                }
                if(product.Id=="D" || product.Id=="d")
                {
                    counterD=counterD+1;
                }

            }
            
            nt totalPriceofA=(counterA/3)*130+(counterA%3+priceofA);
            int totalPriceofB=(counterB/2)*45+(counterB%2+priceofB);
            
            if(counterC==1 && counterD==1)
            {
                totalPriceofC=counterC*priceofC-5;
                totalPriceofD=counterD*priceofD;
            }
            else
            {
                totalPriceofC=counterC*priceofC;
                totalPriceofD=counterD*priceofD;
            }

            return totalPriceofA+totalPriceofB+totalPriceofC+totalPriceofD;
        }
    
    }
    
}
