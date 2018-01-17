// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct TimeVal : IEquatable<TimeVal> {

		private IntPtr tv_sec;
		public long TvSec {
			get {
				return (long) tv_sec;
			}
			set {
				tv_sec = new IntPtr (value);
			}
		}
		private IntPtr tv_usec;
		public long TvUsec {
			get {
				return (long) tv_usec;
			}
			set {
				tv_usec = new IntPtr (value);
			}
		}

		public static GLib.TimeVal Zero = new GLib.TimeVal ();

		public static GLib.TimeVal New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return GLib.TimeVal.Zero;
			return (GLib.TimeVal) Marshal.PtrToStructure (raw, typeof (GLib.TimeVal));
		}

		delegate void d_g_time_val_add(IntPtr raw, IntPtr microseconds);
		static d_g_time_val_add g_time_val_add = Marshal.GetDelegateForFunctionPointer<d_g_time_val_add>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GLib), "g_time_val_add"));

		public void Add(long microseconds) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			g_time_val_add(this_as_native, new IntPtr (microseconds));
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		delegate IntPtr d_g_time_val_to_iso8601(IntPtr raw);
		static d_g_time_val_to_iso8601 g_time_val_to_iso8601 = Marshal.GetDelegateForFunctionPointer<d_g_time_val_to_iso8601>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GLib), "g_time_val_to_iso8601"));

		public string ToIso8601() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = g_time_val_to_iso8601(this_as_native);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		delegate bool d_g_time_val_from_iso8601(IntPtr iso_date, IntPtr time_);
		static d_g_time_val_from_iso8601 g_time_val_from_iso8601 = Marshal.GetDelegateForFunctionPointer<d_g_time_val_from_iso8601>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GLib), "g_time_val_from_iso8601"));

		public static bool FromIso8601(string iso_date, out GLib.TimeVal time_) {
			IntPtr native_iso_date = GLib.Marshaller.StringToPtrGStrdup (iso_date);
			IntPtr native_time_ = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (GLib.TimeVal)));
			bool raw_ret = g_time_val_from_iso8601(native_iso_date, native_time_);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_iso_date);
			time_ = GLib.TimeVal.New (native_time_);
			Marshal.FreeHGlobal (native_time_);
			return ret;
		}

		static void ReadNative (IntPtr native, ref GLib.TimeVal target)
		{
			target = New (native);
		}

		public bool Equals (TimeVal other)
		{
			return true && TvSec.Equals (other.TvSec) && TvUsec.Equals (other.TvUsec);
		}

		public override bool Equals (object other)
		{
			return other is TimeVal && Equals ((TimeVal) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType().FullName.GetHashCode() ^ TvSec.GetHashCode () ^ TvUsec.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
