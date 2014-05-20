using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQuerying.Models
{
    class ResultRecords
    {
        private string _queryExecuted;
        private bool _isQueryError;
        private string _errorException;
        private int _numberOfRecords;
        Dictionary<int, Dictionary<string, string>> _records = new Dictionary<int, Dictionary<string, string>>();

        public ResultRecords(string queryExecuted)
        {
            this.queryExecuted = queryExecuted;
        }

        public Dictionary<int, Dictionary<string, string>> records
        {
            get { return _records; }
        }

        public string queryExecuted
        {
            get { return _queryExecuted; }
            set { this._queryExecuted = value; }
        }

        public bool isQueryError
        {
            get { return _isQueryError; }
            set { this._isQueryError = value; }
        }

        public string errorException
        {
            get { return _errorException; }
            set { this._errorException = value; }
        }

        public int numberOfRecords
        {
            get { return _numberOfRecords; }
            set { this._numberOfRecords = value; }
        }

    }
}
