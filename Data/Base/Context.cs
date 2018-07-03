using Entities.Dto;
using System.Net;
using System.Web.Script.Serialization;

namespace Data.Base
{
    public class Context : IContext
    {
        public ClientResultDto ClientResult { get; set; }
        public PolicyResultDto PolicyResult { get; set; }

        public Context()
        {
            this.LoadContext(); // Cargamos los datos provenientes de las APIs. Lo ideal seria cargarlo una unica vez y no en cada llamada.
        }

        private void LoadContext()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("http://www.mocky.io/v2/580891a4100000e8242b75c5");

                this.PolicyResult = new JavaScriptSerializer().Deserialize<PolicyResultDto>(json);

                var clientJS = wc.DownloadString("http://www.mocky.io/v2/5808862710000087232b75ac");

                this.ClientResult = new JavaScriptSerializer().Deserialize<ClientResultDto>(clientJS);
            }
        }

    }
}
