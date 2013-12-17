using System;

namespace NewRelic
{
	[Flags]
	public enum NRLogLevels {
		None = 0,
		Error = 1 << 0,
		Warning = 1 << 1,
		Info = 1 << 2,
		Verbose = 1 << 3,
		All = 0xffff
	}

	[Flags]
	public enum NRLogTargets {
		None = 0,
		Console = 1 << 0,
		File = 1 << 1,
		All = 0xfff
	}

	public enum NRTraceType {
		None,
		ViewLoading,
		Layout,
		Database,
		Images,
		Json,
		Network
	}

	public enum NRNetworkFailureCode {
		URLErrorUnknown = -1,
		URLErrorCancelled = -999,
		URLErrorBadURL = -1000,
		URLErrorTimedOut = -1001,
		URLErrorUnsupportedURL = -1002,
		URLErrorCannotFindHost = -1003,
		URLErrorCannotConnectToHost = -1004,
		URLErrorDataLengthExceedsMaximum = -1103,
		URLErrorNetworkConnectionLost = -1005,
		URLErrorDNSLookupFailed = -1006,
		URLErrorHTTPTooManyRedirects = -1007,
		URLErrorResourceUnavailable = -1008,
		URLErrorNotConnectedToInternet = -1009,
		URLErrorRedirectToNonExistentLocation = -1010,
		URLErrorBadServerResponse = -1011,
		URLErrorUserCancelledAuthentication = -1012,
		URLErrorUserAuthenticationRequired = -1013,
		URLErrorZeroByteResource = -1014,
		URLErrorCannotDecodeRawData = -1015,
		URLErrorCannotDecodeContentData = -1016,
		URLErrorCannotParseResponse = -1017,
		URLErrorInternationalRoamingOff = -1018,
		URLErrorCallIsActive = -1019,
		URLErrorDataNotAllowed = -1020,
		URLErrorRequestBodyStreamExhausted = -1021,
		URLErrorFileDoesNotExist = -1100,
		URLErrorFileIsDirectory = -1101,
		URLErrorNoPermissionsToReadFile = -1102,
		URLErrorSecureConnectionFailed = -1200,
		URLErrorServerCertificateHasBadDate = -1201,
		URLErrorServerCertificateUntrusted = -1202,
		URLErrorServerCertificateHasUnknownRoot = -1203,
		URLErrorServerCertificateNotYetValid = -1204,
		URLErrorClientCertificateRejected = -1205,
		URLErrorClientCertificateRequired = -1206,
		URLErrorCannotLoadFromNetwork = -2000,
		URLErrorCannotCreateFile = -3000,
		URLErrorCannotOpenFile = -3001,
		URLErrorCannotCloseFile = -3002,
		URLErrorCannotWriteToFile = -3003,
		URLErrorCannotRemoveFile = -3004,
		URLErrorCannotMoveFile = -3005,
		URLErrorDownloadDecodingFailedMidStream = -3006,
		URLErrorDownloadDecodingFailedToComplete = -3007
	}
}