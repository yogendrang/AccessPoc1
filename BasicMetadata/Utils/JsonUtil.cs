using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using BasicQuerying.Models;

namespace BasicQuerying.Utils
{
    class JsonUtil
    {
        public static IDictionary<string, object> convertJsonToObject(string jsonAtHand)
        {
            ExpandoObject jsonAsExpando = JsonConvert.DeserializeObject<ExpandoObject>(
                                               jsonAtHand, new ExpandoObjectConverter());
            IDictionary<string, object> propertyValues = (IDictionary<string, object>)jsonAsExpando;
            return propertyValues;
        }

        public static string convertObjectToJson(object results)
        {
            return JsonConvert.SerializeObject(results);
        }
    }
}
