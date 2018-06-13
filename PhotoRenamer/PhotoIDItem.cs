namespace PhotoRenamer
{
    internal class PhotoIDItem
    {
        public string ContractorID { get; private set; }
        public string SupplierID { get; private set; }
        
        public PhotoIDItem(string contractorId, string supplierId)
        {
            this.ContractorID = contractorId;
            this.SupplierID = supplierId;            
        }
    }
}
