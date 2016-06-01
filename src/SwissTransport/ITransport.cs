using System;

namespace SwissTransport
{
	public interface ITransport
	{
		Stations GetStations(string query);
		StationBoardRoot GetStationBoard(string station);
        StationBoardRoot GetStationBoard(string station, DateTime departure);
        Connections GetConnections(string fromStation, string toStattion);
        Connections GetConnections(string fromStation, string toStattion, DateTime departure, bool isArrivalTime);
    }
}