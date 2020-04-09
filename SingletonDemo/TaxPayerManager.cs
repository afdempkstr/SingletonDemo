using System.Collections.Generic;

namespace SingletonDemo
{
    public class TaxPayerManager
    {
        private static TaxPayerManager _instance;
        private static object syncLock = new object();

        public static TaxPayerManager Instance
        {
            get
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new TaxPayerManager();
                    }
                }

                return _instance;
            }
        }

        private List<string> _taxPayers;

        private TaxPayerManager()
        {
            _taxPayers = new List<string>();
        }

        public void AddTaxPayer(string name)
        { }

    }
}
