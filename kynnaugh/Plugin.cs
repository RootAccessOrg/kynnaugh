using kynnaugh.TS3Api;
using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace kynnaugh
{
    public class Plugin
    {
        // based on / a port of https://github.com/allquixotic/kynnaugh-cc/blob/master/kynnaugh.cpp
        const string PluginName = "kynnaugh";
        const string PluginVersion = "1.0";
        const int PluginApiVersion = 21;
        const string PluginAuthor = "RootAccessOrg";
        const string PluginDescription = "Speech recognition and text to speech for deaf users.";

        string PluginId;

        /*********************************** Required functions ************************************/
        /*
         * If any of these required functions is not implemented, TS3 will refuse to load the plugin
         */

        /// <summary>
        /// Unique name identifying this plugin
        /// </summary>
        /// <returns></returns>
        [DllExport]
        IntPtr ts3plugin_name()
        {
            return StringUtils.NativeUtf8FromString(PluginName);
        }

        /// <summary>
        /// Plugin version
        /// </summary>
        /// <returns></returns>
        [DllExport]
        IntPtr ts3plugin_version()
        {
            return StringUtils.NativeUtf8FromString(PluginVersion);
        }

        /// <summary>
        /// Plugin API version. Must be the same as the clients API major version, else the plugin fails to load.
        /// </summary>
        /// <returns></returns>
        [DllExport]
        int ts3plugin_apiVersion()
        {
            return PluginApiVersion;
        }

        /// <summary>
        /// Plugin author
        /// </summary>
        /// <returns></returns>
        [DllExport]
        IntPtr ts3plugin_author()
        {
            return StringUtils.NativeUtf8FromString(PluginAuthor);
        }

        /// <summary>
        /// Plugin description
        /// </summary>
        /// <returns></returns>
        [DllExport]
        IntPtr ts3plugin_description()
        {
            return StringUtils.NativeUtf8FromString(PluginDescription);
        }

        /// <summary>
        /// Set TeamSpeak 3 callback functions
        /// </summary>
        /// <param name="funcs"></param>
        [DllExport]
        void ts3plugin_setFunctionPointers(TS3Functions funcs)
        {
            //ts3Functions = funcs;
        }

        /// <summary>
        /// Custom code called right after loading the plugin. Returns 0 on success, 1 on failure.
        /// If the function returns 1 on failure, the plugin will be unloaded again.
        /// </summary>
        /// <returns></returns>
        [DllExport]
        int ts3plugin_init()
        {
            Console.WriteLine("Kynnaugh plugin_init()");
            return 0;
        }

        /// <summary>
        /// Custom code called right before the plugin is unloaded
        /// </summary>
        [DllExport]
        void ts3plugin_shutdown()
        {
            
        }

        /// <summary>
        /// If the plugin wants to use error return codes, plugin commands, hotkeys or menu items, it needs to register a command ID. This function will be
        /// automatically called after the plugin was initialized.This function is optional.If you don't use these features, this function can be omitted.
        /// Note the passed pluginID parameter is no longer valid after calling this function, so you must copy it and store it in the plugin.
        /// </summary>
        /// <param name="id"></param>
        [DllExport]
        void ts3plugin_registerPluginID(IntPtr id)
        {
            PluginId = StringUtils.StringFromNativeUtf8(id);
            Console.WriteLine("registerPluginId() " + PluginId);
        }

        /// <summary>
        /// Required to release the memory for parameter "data" allocated in ts3plugin_infoData and ts3plugin_initMenus
        /// </summary>
        /// <param name="data"></param>
        [DllExport]
        void ts3plugin_freeMemory(IntPtr data)
        {
            Marshal.FreeHGlobal(data);
        }
        

        /// <summary>
        /// Plugin requests to be always automatically loaded by the TeamSpeak 3 client unless
        /// the user manually disabled it in the plugin dialog.
        /// This function is optional.If missing, no autoload is assumed.
        /// </summary>
        /// <returns></returns>
        [DllExport]
        int ts3plugin_requestAutoload()
        {
            return 1;  /* 1 = request autoloaded, 0 = do not request autoload */
        }

    }
}
