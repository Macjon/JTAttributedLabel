using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libJTAttributedLabel.a", LinkTarget.ArmV7 | LinkTarget.Simulator, Frameworks = "QuartzCore CoreText Foundation CoreGraphics", ForceLoad = true)]
