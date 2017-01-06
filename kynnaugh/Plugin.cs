using kynnaugh.TS3Api;
using System;
using System.Runtime.InteropServices;
using D3F00FF1770DED978EC774BA389F2DC901F4.B00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000.C00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000.D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000.E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000.F00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000;

namespace kynnaugh
{
	public static class Plugin
	{
		// based on / a port of https://github.com/allquixotic/kynnaugh-cc/blob/master/kynnaugh.cpp
		const string PluginName = "kynnaugh";
		const string PluginVersion = "1.0";
		const int PluginApiVersion = 21;
		const string PluginAuthor = "RootAccessOrg";
		const string PluginDescription = "Speech recognition and text to speech for deaf users.";

		static string PluginId;

		static SampleHandler Handler = new SampleHandler();

		/*********************************** Required functions ************************************/
		/*
         * If any of these required functions is not implemented, TS3 will refuse to load the plugin
         */

		/// <summary>
		/// Unique name identifying this plugin
		/// </summary>
		/// <returns></returns>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static IntPtr ts3plugin_name()
		{
			return StringUtils.NativeUtf8FromString(PluginName);
		}

		/// <summary>
		/// Plugin version
		/// </summary>
		/// <returns></returns>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static IntPtr ts3plugin_version()
		{
			return StringUtils.NativeUtf8FromString(PluginVersion);
		}

		/// <summary>
		/// Plugin API version. Must be the same as the clients API major version, else the plugin fails to load.
		/// </summary>
		/// <returns></returns>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static int ts3plugin_apiVersion()
		{
			return PluginApiVersion;
		}

		/// <summary>
		/// Plugin author
		/// </summary>
		/// <returns></returns>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static IntPtr ts3plugin_author()
		{
			return StringUtils.NativeUtf8FromString(PluginAuthor);
		}

		/// <summary>
		/// Plugin description
		/// </summary>
		/// <returns></returns>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static IntPtr ts3plugin_description()
		{
			return StringUtils.NativeUtf8FromString(PluginDescription);
		}

		/// <summary>
		/// Set TeamSpeak 3 callback functions
		/// </summary>
		/// <param name="funcs"></param>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static void ts3plugin_setFunctionPointers(TS3Functions funcs)
		{
			Console.WriteLine("Kynnaugh setFunctionPointers()");
			Handler.TS3Functions = funcs;
			// TODO: fix printMessageToCurrentTab function. currently ANSI, not UTF8
			funcs.printMessageToCurrentTab("Function pointers received");
		}

		/// <summary>
		/// Custom code called right after loading the plugin. Returns 0 on success, 1 on failure.
		/// If the function returns 1 on failure, the plugin will be unloaded again.
		/// </summary>
		/// <returns></returns>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static int ts3plugin_init()
		{
			Console.WriteLine("Kynnaugh init()");

			AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

			return 0;
		}

		private static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			var name = args.Name;

			IntPtr bufSize = (IntPtr)1024;
			var buf = Marshal.AllocHGlobal(bufSize);
			Handler.TS3Functions.getConfigPath(buf, bufSize);
			string configPath = StringUtils.StringFromNativeUtf8(buf);
			Marshal.FreeHGlobal(buf);

			var asmDir = System.IO.Path.Combine(configPath, "plugins", "kynnaugh");
			return System.Reflection.Assembly.LoadFrom(System.IO.Path.Combine(asmDir, new System.Reflection.AssemblyName(name).Name + ".dll"));
		}

		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			Console.WriteLine(e.ExceptionObject.ToString());
			Console.WriteLine("Press any key to quit...");
			Console.ReadKey(true);
		}

		/// <summary>
		/// Custom code called right before the plugin is unloaded
		/// </summary>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static void ts3plugin_shutdown()
		{
			AppDomain.CurrentDomain.AssemblyResolve -= CurrentDomain_AssemblyResolve;
		}

		/// <summary>
		/// If the plugin wants to use error return codes, plugin commands, hotkeys or menu items, it needs to register a command ID. This function will be
		/// automatically called after the plugin was initialized.This function is optional.If you don't use these features, this function can be omitted.
		/// Note the passed pluginID parameter is no longer valid after calling this function, so you must copy it and store it in the plugin.
		/// </summary>
		/// <param name="id"></param>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static void ts3plugin_registerPluginID(IntPtr id)
		{
			PluginId = StringUtils.StringFromNativeUtf8(id);
			Console.WriteLine("registerPluginId() " + PluginId);
		}

		/// <summary>
		/// Required to release the memory for parameter "data" allocated in ts3plugin_infoData and ts3plugin_initMenus
		/// </summary>
		/// <param name="data"></param>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static void ts3plugin_freeMemory(IntPtr data)
		{
			Marshal.FreeHGlobal(data);
		}


		/// <summary>
		/// Plugin requests to be always automatically loaded by the TeamSpeak 3 client unless
		/// the user manually disabled it in the plugin dialog.
		/// This function is optional.If missing, no autoload is assumed.
		/// </summary>
		/// <returns></returns>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static int ts3plugin_requestAutoload()
		{
			return 1;  // 1 = request autoloaded, 0 = do not request autoload
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="serverConnectionHandlerID"></param>
		/// <param name="clientID"></param>
		/// <param name="samples">short*</param>
		/// <param name="sampleCount"></param>
		/// <param name="channels"></param>
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static void ts3plugin_onEditPlaybackVoiceDataEvent(UInt64 serverConnectionHandlerID, UInt16 clientID, IntPtr samples,
														int sampleCount, int channels)
		{
			short[] managedSamples = new short[sampleCount];
			Marshal.Copy(samples, managedSamples, 0, sampleCount);

			Console.WriteLine("Sample received");
			Handler.AddSample(serverConnectionHandlerID, clientID, managedSamples, channels);
		}


	}
}
