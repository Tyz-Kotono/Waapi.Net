using System.Linq;
using System.Threading.Tasks;

namespace AK.Wwise.Waapi.SubSystem
{

    public class ClientSubSystem:Singleton<ClientSubSystem>
    {
        private AK.Wwise.Waapi.JsonClient client;
        public AK.Wwise.Waapi.JsonClient Client => client;

        public ClientSubSystem()
        {
           
        }
        
        public void Initialization()
        {
            client = new AK.Wwise.Waapi.JsonClient();
        }
        
        // Try to connect to running instance of Wwise on localhost, default port
        public  async Task<bool> ConnectWwise()
        {
            await Client.Connect();
            return true;
        }
    
        public void SubscribeDisconnected(Wamp.DisconnectedHandler handler)
            => Client.Disconnected += handler;

    }
}