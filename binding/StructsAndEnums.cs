using System;

namespace NewRelic
{
	public enum NRLogLevels {
		NRLogLevelNone    = 0,
		NRLogLevelError   = 1 << 0,
		NRLogLevelWarning = 1 << 1,
		NRLogLevelInfo    = 1 << 2,
		NRLogLevelVerbose = 1 << 3,
		NRLogLevelALL     = 0xffff
	}

	public enum NRLogTargets {
		NRLogTargetNone      = 0,
		NRLogTargetConsole   = 1 << 0,
		NRLogTargetFile      = 1 << 1,
		NRLogTargetALL       = 0xffff
	}
}

