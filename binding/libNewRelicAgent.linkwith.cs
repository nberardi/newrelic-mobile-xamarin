using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libNewRelicAgent.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
