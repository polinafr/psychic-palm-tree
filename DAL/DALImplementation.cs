using BELayer;
using System;
using System.Collections.Generic;
using System.Text;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

/* Credit for this guy for brilliant explanation of Firebase Database usage:
 * https://www.youtube.com/watch?v=QE5UV8NyYqg
 */
namespace DAL
{
    public class DALImplementation : IDAL
    {
        private List<Good> catalog = new List<Good>();
        private List<Bucket> shoppingLists = new List<Bucket>();
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "ABAdEUajJeEWzBaQcr80vQnOQ5cbE95VGC6qFsi8",
            BasePath = "https://shoppingsystem-6521c-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        

        public bool AddNewBucket(Bucket bucket)
        {
            throw new NotImplementedException();
        }

        public bool AddNewGood(Good good)
        {
            //List<Good> catalog = GetCatalog();
            throw new NotImplementedException();

        }

        public List<Good> GetCatalog()
        {
            return catalog;
        }

        public Queue<Bucket> GetPreviousBuckets()
        {
            throw new NotImplementedException();
        }

        public bool UpdateGood(Good good)
        {
            throw new NotImplementedException();
        }

        public bool EstablishDatabaseConnection()
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
