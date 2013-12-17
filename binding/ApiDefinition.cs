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

		[Export ("startTimeInMillis")]
		double StartTimeInMillis { get; }

		[Export ("endTimeInMillis")]
		double EndTimeInMillis { get; }

		[Export ("restartTimer")]
		void RestartTimer ();

		[Export ("stopTimer")]
		void StopTimer ();

		[Export ("hasRunAndFinished")]
		bool HasRunAndFinished { get; }

		[Export ("timeElapsedInSeconds")]
		float TimeElapsedInSeconds { get; }

		[Export ("timeElapsedInMilliSeconds")]
		double TimeElapsedInMilliSeconds { get; }

//		[DllImport ("/Users/nick/Projects/caddio/vendor/newrelic/binding/NewRelic_iOS_Agent_3.154/NewRelicAgent.framework/Versions/A/Headers/NRTimer.h")]
//		double NR_NanosecondsFromTimeInterval (double timeInterval);
	}

	[BaseType (typeof (NSObject))]
	public partial interface NRLogger {

		[Static, Export ("log:inFile:atLine:inMethod:withMessage:")]
		void Log (uint level, string file, uint line, string method, string message);

		[Static, Export ("logLevels")]
		uint LogLevels { set; }

		[Static, Export ("logTargets")]
		uint LogTargets { set; }

		[Static, Export ("logFilePath")]
		string LogFilePath { get; }

		[Static, Export ("clearLog")]
		void ClearLog ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface NewRelic {

		[Static, Export ("startWithApplicationToken:")]
		void StartWithApplicationToken (string appToken);

		[Static, Export ("startWithApplicationToken:withoutSecurity:")]
		void StartWithApplicationToken (string appToken, bool disableSSL);

		[Static, Export ("createAndStartTimer")]
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
		void NoticeNetworkRequestForURL (NSUrl url, NRTimer timer, NSDictionary headers, int httpStatusCode, uint bytesSent, uint bytesReceived, NSData responseData, NSDictionary parameters);

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

//		[DllImport ("/Users/nick/Projects/caddio/vendor/newrelic/binding/NewRelic_iOS_Agent_3.154/NewRelicAgent.framework/Versions/A/Headers/NRGCDOverride.h")]
//		void NR__dispatch_async (NSObject queue, dispatch_block_t block);
//
//		[DllImport ("/Users/nick/Projects/caddio/vendor/newrelic/binding/NewRelic_iOS_Agent_3.154/NewRelicAgent.framework/Versions/A/Headers/NRGCDOverride.h")]
//		void NR__dispatch_sync (NSObject queue, dispatch_block_t block);
//
//		[DllImport ("/Users/nick/Projects/caddio/vendor/newrelic/binding/NewRelic_iOS_Agent_3.154/NewRelicAgent.framework/Versions/A/Headers/NRGCDOverride.h")]
//		void NR__dispatch_after (dispatch_time_t when, NSObject queue, dispatch_block_t block);
//
//		[DllImport ("/Users/nick/Projects/caddio/vendor/newrelic/binding/NewRelic_iOS_Agent_3.154/NewRelicAgent.framework/Versions/A/Headers/NRGCDOverride.h")]
//		void NR__dispatch_apply (size_t iterations, NSObject queue, Delegate block);
//
//		[DllImport ("/Users/nick/Projects/caddio/vendor/newrelic/binding/NewRelic_iOS_Agent_3.154/NewRelicAgent.framework/Versions/A/Headers/NRGCDOverride.h")]
//		void NR__dispatch_once ([unmapped: pointer: Pointer] once, dispatch_block_t block);
	}
}
