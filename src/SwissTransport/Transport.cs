using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace SwissTransport
{
    //http://transport.opendata.ch/docs.html

    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        { 
            return GetResponse<Stations>("http://transport.opendata.ch/v1/locations?query=" + query);
        }

        public StationBoardRoot GetStationBoard(string station)
        {
            return GetResponse<StationBoardRoot>("http://transport.opendata.ch/v1/stationboard?station=" + station);
        }

        public StationBoardRoot GetStationBoard(string station, DateTime departure)
        {
            return GetResponse<StationBoardRoot>("http://transport.opendata.ch/v1/stationboard?station=" + station + "&datetime=" + departure.ToString("yyyy-MM-dd hh:mm"));
        }

        public Connections GetConnections(string fromStation, string toStattion)
        {
            return GetResponse<Connections>("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion);
        }

        public Connections GetConnections(string fromStation, string toStattion, DateTime time, bool isArrivalTime)
        {
            string date = time.ToString("yyyy-MM-dd");
            string timestring = time.ToString("HH:mm");

            return GetResponse<Connections>("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion + "&date=" + date + "&time=" + timestring + "&isArrivalTime=" + Convert.ToInt32(isArrivalTime).ToString());
        }

        private static T GetResponse<T>(string query)
        {
            var request = CreateWebRequest(query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var result =
                        JsonConvert.DeserializeObject<T>(readToEnd);
                return result;
            }

            return default(T);
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;

            return request;
        }
    }
}
