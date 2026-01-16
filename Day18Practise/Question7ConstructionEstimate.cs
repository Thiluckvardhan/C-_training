namespace Day18{
    /// <summary>Captures construction and site area values for estimation.</summary>
    public class EstimateDetails
    {
        public float ConstructionArea{get;set;}
        public float SiteArea{get;set;}
    }

    /// <summary>Validates construction estimates and raises errors when area exceeds site limits.</summary>
    public class Question7
    {
        public EstimateDetails ValidateConstructionEstimate(float constructionArea,float siteArea)
        {
            if (constructionArea > siteArea)
            {
                // Block estimates where planned construction exceeds available site area
                throw new EstimateException();
            }
            // Return approved estimate values
            EstimateDetails estimateDetails=new EstimateDetails
            {
                ConstructionArea=constructionArea,
                SiteArea=siteArea
            };
            return estimateDetails;
        }

        /// <summary>Raised when the construction estimate cannot be approved.</summary>
        public class EstimateException : Exception
        {
            public EstimateException():base("Sorry your Construction Estimate is not approved.")
            {
                
            }
        }
    }
}