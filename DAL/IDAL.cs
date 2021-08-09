





using System;
using BELayer;
using System.Collections.Generic;

namespace DAL
{
    public interface IDAL
    {
        List<Good> GetCatalog();
        Queue<Bucket> GetPreviousBuckets(); //queue to make easier time division monitoring

        public bool AddNewGood(Good good);
        public bool AddNewBucket(Bucket bucket);
        public bool UpdateGood(Good good);
        public List<Bucket> GetShoppingListsFromTill(DateTime start, DateTime finish);
        public List<Good> UnupdatedGoods();
    }
}
