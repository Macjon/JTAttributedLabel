//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace JTAttributedLabel {
	[Register("JTParagraphStyle", true)]
	public unsafe partial class JTParagraphStyle : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selLineSpacing = Selector.GetHandle ("lineSpacing");
		[CompilerGenerated]
		static readonly IntPtr selParagraphSpacing = Selector.GetHandle ("paragraphSpacing");
		[CompilerGenerated]
		static readonly IntPtr selAlignment = Selector.GetHandle ("alignment");
		[CompilerGenerated]
		static readonly IntPtr selHeadIndent = Selector.GetHandle ("headIndent");
		[CompilerGenerated]
		static readonly IntPtr selTailIndent = Selector.GetHandle ("tailIndent");
		[CompilerGenerated]
		static readonly IntPtr selFirstLineHeadIndent = Selector.GetHandle ("firstLineHeadIndent");
		[CompilerGenerated]
		static readonly IntPtr selMinimumLineHeight = Selector.GetHandle ("minimumLineHeight");
		[CompilerGenerated]
		static readonly IntPtr selMaximumLineHeight = Selector.GetHandle ("maximumLineHeight");
		[CompilerGenerated]
		static readonly IntPtr selLineBreakMode = Selector.GetHandle ("lineBreakMode");
		[CompilerGenerated]
		static readonly IntPtr selBaseWritingDirection = Selector.GetHandle ("baseWritingDirection");
		[CompilerGenerated]
		static readonly IntPtr selLineHeightMultiple = Selector.GetHandle ("lineHeightMultiple");
		[CompilerGenerated]
		static readonly IntPtr selParagraphSpacingBefore = Selector.GetHandle ("paragraphSpacingBefore");
		[CompilerGenerated]
		static readonly IntPtr selHyphenationFactor = Selector.GetHandle ("hyphenationFactor");
		[CompilerGenerated]
		static readonly IntPtr selDefaultParagraphStyle = Selector.GetHandle ("defaultParagraphStyle");
		[CompilerGenerated]
		static readonly IntPtr selDefaultWritingDirectionForLanguage_ = Selector.GetHandle ("defaultWritingDirectionForLanguage:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("JTParagraphStyle");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  JTParagraphStyle () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public JTParagraphStyle (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public JTParagraphStyle (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public JTParagraphStyle (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[Export ("defaultParagraphStyle")]
		[CompilerGenerated]
		public static JTParagraphStyle DefaultParagraphStyle ()
		{
			return (JTParagraphStyle) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDefaultParagraphStyle));
		}
		
		[Export ("defaultWritingDirectionForLanguage:")]
		[CompilerGenerated]
		public static NSWritingDirection DefaultWritingDirectionForLanguage (string languageName)
		{
			if (languageName == null)
				throw new ArgumentNullException ("languageName");
			var nslanguageName = NSString.CreateNative (languageName);
			
			NSWritingDirection ret;
			ret = (NSWritingDirection) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (class_ptr, selDefaultWritingDirectionForLanguage_, nslanguageName);
			NSString.ReleaseNative (nslanguageName);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual float LineSpacing {
			[Export ("lineSpacing")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLineSpacing);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selLineSpacing);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float ParagraphSpacing {
			[Export ("paragraphSpacing")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selParagraphSpacing);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selParagraphSpacing);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreText.CTTextAlignment Alignment {
			[Export ("alignment")]
			get {
				if (IsDirectBinding) {
					return (global::MonoTouch.CoreText.CTTextAlignment) MonoTouch.ObjCRuntime.Messaging.byte_objc_msgSend (this.Handle, selAlignment);
				} else {
					return (global::MonoTouch.CoreText.CTTextAlignment) MonoTouch.ObjCRuntime.Messaging.byte_objc_msgSendSuper (this.SuperHandle, selAlignment);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float HeadIndent {
			[Export ("headIndent")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selHeadIndent);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selHeadIndent);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float TailIndent {
			[Export ("tailIndent")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selTailIndent);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selTailIndent);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float FirstLineHeadIndent {
			[Export ("firstLineHeadIndent")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFirstLineHeadIndent);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selFirstLineHeadIndent);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float MinimumLineHeight {
			[Export ("minimumLineHeight")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinimumLineHeight);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinimumLineHeight);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float MaximumLineHeight {
			[Export ("maximumLineHeight")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMaximumLineHeight);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMaximumLineHeight);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreText.CTLineBreakMode LineBreakMode {
			[Export ("lineBreakMode")]
			get {
				if (IsDirectBinding) {
					return (global::MonoTouch.CoreText.CTLineBreakMode) MonoTouch.ObjCRuntime.Messaging.byte_objc_msgSend (this.Handle, selLineBreakMode);
				} else {
					return (global::MonoTouch.CoreText.CTLineBreakMode) MonoTouch.ObjCRuntime.Messaging.byte_objc_msgSendSuper (this.SuperHandle, selLineBreakMode);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSWritingDirection BaseWritingDirection {
			[Export ("baseWritingDirection")]
			get {
				if (IsDirectBinding) {
					return (NSWritingDirection) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selBaseWritingDirection);
				} else {
					return (NSWritingDirection) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selBaseWritingDirection);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float LineHeightMultiple {
			[Export ("lineHeightMultiple")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLineHeightMultiple);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selLineHeightMultiple);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float ParagraphSpacingBefore {
			[Export ("paragraphSpacingBefore")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selParagraphSpacingBefore);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selParagraphSpacingBefore);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float HyphenationFactor {
			[Export ("hyphenationFactor")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selHyphenationFactor);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selHyphenationFactor);
				}
			}
			
		}
		
	} /* class JTParagraphStyle */
}
