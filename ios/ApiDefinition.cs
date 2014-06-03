using System;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

namespace NewRelic {

	[BaseType (typeof (NSObject))]
	public partial interface NRTimer {

		[Export ("startTimeMillis")]
		double StartTimeMillis { get; }

		[Export ("endTimeMillis")]
		double EndTimeMillis { get; }

		[Export ("startTimeInMillis")] //, Verify ("ObjC method massaged into getter property", "/Users/nick/Projects/caddio/vendor/newrelic/ios/NewRelic_iOS_Agent_3.324/NewRelicAgent.framework/Versions/A/Headers/NRTimer.h", Line = 38)]
		double StartTimeInMillis { get; }

		[Export ("endTimeInMillis")] //, Verify ("ObjC method massaged into getter property", "/Users/nick/Projects/caddio/vendor/newrelic/ios/NewRelic_iOS_Agent_3.324/NewRelicAgent.framework/Versions/A/Headers/NRTimer.h", Line = 39)]
		double EndTimeInMillis { get; }

		[Export ("restartTimer")]
		void RestartTimer ();

		[Export ("stopTimer")]
		void StopTimer ();

		[Export ("hasRunAndFinished")] //, Verify ("ObjC method massaged into getter property", "/Users/nick/Projects/caddio/vendor/newrelic/ios/NewRelic_iOS_Agent_3.324/NewRelicAgent.framework/Versions/A/Headers/NRTimer.h", Line = 42)]
		bool HasRunAndFinished { get; }

		[Export ("timeElapsedInSeconds")] //, Verify ("ObjC method massaged into getter property", "/Users/nick/Projects/caddio/vendor/newrelic/ios/NewRelic_iOS_Agent_3.324/NewRelicAgent.framework/Versions/A/Headers/NRTimer.h", Line = 43)]
		double TimeElapsedInSeconds { get; }

		[Export ("timeElapsedInMilliSeconds")] //, Verify ("ObjC method massaged into getter property", "/Users/nick/Projects/caddio/vendor/newrelic/ios/NewRelic_iOS_Agent_3.324/NewRelicAgent.framework/Versions/A/Headers/NRTimer.h", Line = 44)]
		double TimeElapsedInMilliSeconds { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface NewRelic {

		[Static, Export ("enableFeatures:")]
		void EnableFeatures (NRMAFeatureFlags featureFlags);

		[Static, Export ("disableFeatures:")]
		void DisableFeatures (NRMAFeatureFlags featureFlags);

		[Static, Export ("applicationVersion")] //, Verify ("ObjC method massaged into setter property", "/Users/nick/Projects/caddio/vendor/newrelic/ios/NewRelic_iOS_Agent_3.324/NewRelicAgent.framework/Versions/A/Headers/NewRelic.h", Line = 54)]
		string ApplicationVersion { set; }

		[Static, Export ("startWithApplicationToken:")]
		void StartWithApplicationToken (string appToken);

		[Static, Export ("startWithApplicationToken:withoutSecurity:")]
		void StartWithApplicationToken (string appToken, bool disableSSL);

		[Static, Export ("createAndStartTimer")] //, Verify ("ObjC method massaged into getter property", "/Users/nick/Projects/caddio/vendor/newrelic/ios/NewRelic_iOS_Agent_3.324/NewRelicAgent.framework/Versions/A/Headers/NewRelic.h", Line = 90)]
		NRTimer CreateAndStartTimer { get; }

		[Static, Export ("startInteractionFromMethodName:object:")]
		void StartInteractionFromMethodName (string selectorName, NSObject obj);

		[Static, Export ("startInteractionFromMethodName:object:customizedName:")]
		void StartInteractionFromMethodName (string selectorName, NSObject obj, string interactionName);

		[Static, Export ("startInteractionFromMethodName:object:customizedName:cancelRunningTrace:")]
		void StartInteractionFromMethodName (string selectorName, NSObject obj, string interactionName, bool cancel);

		[Static, Export ("startTracingMethod:object:timer:category:")]
		void StartTracingMethod (Selector selector, NSObject obj, NRTimer timer, NRTraceType category);

		[Static, Export ("endTracingMethodWithTimer:")]
		void EndTracingMethodWithTimer (NRTimer timer);

		[Static, Export ("recordMetricWithName:category:")]
		void RecordMetricWithName (string name, string category);

		[Static, Export ("recordMetricWithName:category:value:")]
		void RecordMetricWithName (string name, string category, NSNumber value);

		[Static, Export ("recordMetricWithName:category:value:valueUnits:")]
		void RecordMetricWithName (string name, string category, NSNumber value, string valueUnits);

		[Static, Export ("recordMetricWithName:category:value:valueUnits:countUnits:")]
		void RecordMetricWithName (string name, string category, NSNumber value, string valueUnits, string countUnits);

		[Static, Export ("noticeNetworkRequestForURL:withTimer:responseHeaders:statusCode:bytesSent:bytesReceived:responseData:andParams:")]
		void NoticeNetworkRequestForURL (NSUrl url, NRTimer timer, NSDictionary headers, int httpStatusCode, uint bytesSent, uint bytesReceived, NSData responseData, NSDictionary paramsDictionary);

		[Static, Export ("noticeNetworkFailureForURL:withTimer:andFailureCode:")]
		void NoticeNetworkFailureForURL (NSUrl url, NRTimer timer, int iOSFailureCode);
	}

	[BaseType (typeof (NSObject))]
	public partial interface NRCustomMetrics {

		[Static, Export ("recordMetricWithName:category:")]
		void RecordMetricWithName (string name, string category);

		[Static, Export ("recordMetricWithName:category:value:")]
		void RecordMetricWithName (string name, string category, NSNumber value);

		[Static, Export ("recordMetricWithName:category:value:valueUnits:")]
		void RecordMetricWithName (string name, string category, NSNumber value, string valueUnits);

		[Static, Export ("recordMetricWithName:category:value:valueUnits:countUnits:")]
		void RecordMetricWithName (string name, string category, NSNumber value, string valueUnits, string countUnits);
	}

	[BaseType (typeof (NSObject))]
	public partial interface NRLogger {

		[Static, Export ("log:inFile:atLine:inMethod:withMessage:")]
		void Log (uint level, string file, uint line, string method, string message);

		[Static, Export ("logLevels")] //, Verify ("ObjC method massaged into setter property", "/Users/nick/Projects/caddio/vendor/newrelic/ios/NewRelic_iOS_Agent_3.324/NewRelicAgent.framework/Versions/A/Headers/NRLogger.h", Line = 106)]
		uint LogLevels { set; }

		[Static, Export ("logTargets")] //, Verify ("ObjC method massaged into setter property", "/Users/nick/Projects/caddio/vendor/newrelic/ios/NewRelic_iOS_Agent_3.324/NewRelicAgent.framework/Versions/A/Headers/NRLogger.h", Line = 116)]
		uint LogTargets { set; }

		[Static, Export ("logFilePath")] //, Verify ("ObjC method massaged into getter property", "/Users/nick/Projects/caddio/vendor/newrelic/ios/NewRelic_iOS_Agent_3.324/NewRelicAgent.framework/Versions/A/Headers/NRLogger.h", Line = 123)]
		string LogFilePath { get; }

		[Static, Export ("clearLog")]
		void ClearLog ();
	}
}
