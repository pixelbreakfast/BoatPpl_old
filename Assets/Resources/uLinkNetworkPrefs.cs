/* uLink Autogenerated Settings. This file can be overwritten at any time. */

using System;
using uLink;

public static class uLinkNetworkPrefs
{
	static uLinkNetworkPrefs() 
	{
		Network.symmetricKeySize = 128;
		Network.incomingPassword = "";
		Network.maxManualViewIDs = 1000;
		Network.sendRate = BitConverter.ToSingle(new byte[] { 255, 255, 111, 65, }, 0);
		Network.trackRate = BitConverter.ToSingle(new byte[] { 0, 0, 0, 64, }, 0);
		Network.trackMaxDelta = BitConverter.ToSingle(new byte[] { 0, 0, 0, 0, }, 0);
		Network.isAuthoritativeServer = true;
		Network.minimumAllocatableViewIDs = 1000;
		Network.minimumUsedViewIDs = 1;
		Network.useRedirect = false;
		Network.redirectIP = "";
		Network.redirectPort = 0;
		Network.useDifferentStateForOwner = true;
		Network.useProxy = false;
		Network.requireSecurityForConnecting = false;
		Network.emulation.maxBandwidth = BitConverter.ToSingle(new byte[] { 0, 0, 0, 0, }, 0);
		Network.emulation.chanceOfLoss = BitConverter.ToSingle(new byte[] { 0, 0, 0, 0, }, 0);
		Network.emulation.chanceOfDuplicates = BitConverter.ToSingle(new byte[] { 0, 0, 0, 0, }, 0);
		Network.emulation.minLatency = BitConverter.ToSingle(new byte[] { 0, 0, 0, 0, }, 0);
		Network.emulation.maxLatency = BitConverter.ToSingle(new byte[] { 0, 0, 0, 0, }, 0);
		MasterServer.comment = "";
		MasterServer.dedicatedServer = false;
		MasterServer.gameLevel = "";
		MasterServer.gameMode = "";
		MasterServer.gameName = "";
		MasterServer.gameType = "";
		MasterServer.ipAddress = "unitypark.dyndns.org";
		MasterServer.password = "";
		MasterServer.port = 23466;
		MasterServer.updateRate = BitConverter.ToSingle(new byte[] { 10, 215, 35, 60, }, 0);
		NetworkLog.minLevel = (NetworkLogLevel)2;
		NetworkLog.errorFlags = (NetworkLogFlags)0;
		NetworkLog.warningFlags = (NetworkLogFlags)0;
		NetworkLog.infoFlags = (NetworkLogFlags)0;
		NetworkLog.debugFlags = (NetworkLogFlags)0;
	}
}
