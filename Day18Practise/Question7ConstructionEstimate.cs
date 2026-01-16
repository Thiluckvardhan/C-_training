namespace Day18{
    public class EstimateDetails
    {
        public float ConstructionArea{get;set;}
        public float SiteArea{get;set;}
    }

    public class Question7
    {
        public EstimateDetails ValidateConstructionEstimate(float constructionArea,float siteArea)
        {
            if (constructionArea > siteArea)
            {
                throw new EstimateException();
            }
            EstimateDetails estimateDetails=new EstimateDetails
            {
                ConstructionArea=constructionArea,
                SiteArea=siteArea
            };
            return estimateDetails;
        }

        public class EstimateException : Exception
        {
            public EstimateException():base("Sorry your Construction Estimate is not approved.")
            {
                
            }
        }
    }
}