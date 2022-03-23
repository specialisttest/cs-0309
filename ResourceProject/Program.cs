using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceProject
{
    class DBConnection : IDisposable {
        public DBConnection() {
            Console.WriteLine("Open connection");
        }

        public void Execute() {
            Console.WriteLine("Execute command");
        }

        #region IDisposable Support
        private bool isDisposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                Console.WriteLine("Close connection");

                isDisposed = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~DBConnection() {
           // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
           Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion

    }

    class Program
    {
        ~Program()
        { 
        
        }

        
        //readonly DBConnection myDb = new DBConnection();

        static void Main(string[] args)
        {
            /*DBConnection db = new DBConnection();
            try
            {
                db.Execute();
            }
            finally
            {
                db.Dispose();
            }*/

            using (DBConnection db = new DBConnection()) {
                db.Execute();
            } // db.Dispose()
            //DBConnection db = new DBConnection();
            //db.Execute();




            Console.ReadKey();
        }
    }
}
