using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;


namespace WappiNet.Function
{
    using AK.Wwise.Waapi;

    
    public static  class WaapiFunctionLibrary
    {
       public static async Task<JObject> GetWwiseInfo(this JsonClient client)
            =>await client.Call(ak.wwise.core.getInfo, null, null);
       
       
       public static async Task<JObject> ObjectCreate(this JsonClient client,object args = null, object options = null)
           =>await client.Call(ak.wwise.core.@object.create, args, options);
    }
}

