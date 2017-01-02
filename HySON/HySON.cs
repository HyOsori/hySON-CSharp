using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HySON
{
    public class HySON
    {

        public HySON()
        {
        }

        /** parse Boolean Array **/
        public static String[] getArrayString(String jsonString)
        {
            String[] results = JsonConvert.DeserializeObject<string[]>(jsonString);

            return results;      
        }

        /** parse Boolean Array **/
        public static Boolean[] getArrayBoolean(String jsonString)
        {
            Boolean[] results = JsonConvert.DeserializeObject<Boolean[]>(jsonString);

            return results;
        }

        /** parse Integer Array **/
        public static int[] getArrayInt(String jsonString)
        {
            int[] results = JsonConvert.DeserializeObject<int[]>(jsonString);

            return results;
        }


    }
}
