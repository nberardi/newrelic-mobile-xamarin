using System;
using MonoTouch.Foundation;
using MonoTouch.CoreLocation;

namespace NewRelic {

	[BaseType (typeof (NSObject))]
	public interface NewRelicAgent {
		[Static, Export ("startWithApplicationToken:")]
		void StartWithApplicationToken (string appToken);

		[Static, Export ("startWithApplicationToken:withoutSecurity:")]
		void StartWithApplicationToken (string applicationToken, bool withoutSecurity);

		[Static, Export ("setDeviceLocation:")]
		void SetDeviceLocation (CLLocation options);
	}

	[BaseType(typeof(NSObject))]
	public interface NRLogger {
		[Static, Export ("setLogLevels:")]
		void SetLogLevels (int levels);

		[Static, Export ("setLogTargets:")]
		void SetLogTargets (int targets);
	}
}