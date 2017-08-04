using System.Data.SqlClient;

namespace StorySite
{
    public class SortElement
    {
        private string comlumnName;
        private SortOrder sortOrder;

        public SortElement(string comlumnName, SortOrder sortOrder)
        {
            this.comlumnName = comlumnName;
            this.sortOrder = sortOrder;
        }
    }
}