using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kynnaugh.TS3Api
{
    // similar to https://github.com/dimentox/c_sharp_teamspeak_plugin/blob/master/TS/tscrap.cs
    // but manually done cause their autogen one is broken and crashes TS
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct TS3Functions
    {
        IntPtr getClientLibVersion;
        IntPtr getClientLibVersionNumber;
        IntPtr spawnNewServerConnectionHandler;
        IntPtr destroyServerConnectionHandler;

        /* Error handling */
        IntPtr getErrorMessage;

        /* Memory management */
        IntPtr freeMemory;

        /* Logging */
        IntPtr logMessage;

        /* Sound */
        IntPtr getPlaybackDeviceList;
        IntPtr getPlaybackModeList;
        IntPtr getCaptureDeviceList;
        IntPtr getCaptureModeList;
        IntPtr getDefaultPlaybackDevice;
        IntPtr getDefaultPlayBackMode;
        IntPtr getDefaultCaptureDevice;
        IntPtr getDefaultCaptureMode;
        IntPtr openPlaybackDevice;
        IntPtr openCaptureDevice;
        IntPtr getCurrentPlaybackDeviceName;
        IntPtr getCurrentPlayBackMode;
        IntPtr getCurrentCaptureDeviceName;
        IntPtr getCurrentCaptureMode;
        IntPtr initiateGracefulPlaybackShutdown;
        IntPtr closePlaybackDevice;
        IntPtr closeCaptureDevice;
        IntPtr activateCaptureDevice;
        IntPtr playWaveFileHandle;
        IntPtr pauseWaveFileHandle;
        IntPtr closeWaveFileHandle;
        IntPtr playWaveFile;
        IntPtr registerCustomDevice;
        IntPtr unregisterCustomDevice;
        IntPtr processCustomCaptureData;
        IntPtr acquireCustomPlaybackData;

        /* Preprocessor */
        IntPtr getPreProcessorInfoValueFloat;
        IntPtr getPreProcessorConfigValue;
        IntPtr setPreProcessorConfigValue;

        /* Encoder */
        IntPtr getEncodeConfigValue;

        /* Playback */
        IntPtr getPlaybackConfigValueAsFloat;
        IntPtr setPlaybackConfigValue;
        IntPtr setClientVolumeModifier;

        /* Recording */
        IntPtr startVoiceRecording;
        IntPtr stopVoiceRecording;

        /* 3d sound positioning */
        IntPtr systemset3DListenerAttributes;
        IntPtr set3DWaveAttributes;
        IntPtr systemset3DSettings;
        IntPtr channelset3DAttributes;

        /* Interaction with the server */
        IntPtr startConnection;
        IntPtr stopConnection;
        IntPtr requestClientMove;
        IntPtr requestClientVariables;
        IntPtr requestClientKickFromChannel;
        IntPtr requestClientKickFromServer;
        IntPtr requestChannelDelete;
        IntPtr requestChannelMove;
        IntPtr requestSendPrivateTextMsg;
        IntPtr requestSendChannelTextMsg;
        IntPtr requestSendServerTextMsg;
        IntPtr requestConnectionInfo;
        IntPtr requestClientSetWhisperList;
        IntPtr requestChannelSubscribe;
        IntPtr requestChannelSubscribeAll;
        IntPtr requestChannelUnsubscribe;
        IntPtr requestChannelUnsubscribeAll;
        IntPtr requestChannelDescription;
        IntPtr requestMuteClients;
        IntPtr requestUnmuteClients;
        IntPtr requestClientPoke;
        IntPtr requestClientIDs;
        IntPtr clientChatClosed;
        IntPtr clientChatComposing;
        IntPtr requestServerTemporaryPasswordAdd;
        IntPtr requestServerTemporaryPasswordDel;
        IntPtr requestServerTemporaryPasswordList;

        /* Access clientlib information */

        /* Query own client ID */
        IntPtr getClientID;

        /* Client info */
        IntPtr getClientSelfVariableAsInt;
        IntPtr getClientSelfVariableAsString;
        IntPtr setClientSelfVariableAsInt;
        IntPtr setClientSelfVariableAsString;
        IntPtr flushClientSelfUpdates;
        IntPtr getClientVariableAsInt;
        IntPtr getClientVariableAsUInt64;
        IntPtr getClientVariableAsString;
        IntPtr getClientList;
        IntPtr getChannelOfClient;

        /* Channel info */
        IntPtr getChannelVariableAsInt;
        IntPtr getChannelVariableAsUInt64;
        IntPtr getChannelVariableAsString;
        IntPtr getChannelIDFromChannelNames;
        IntPtr setChannelVariableAsInt;
        IntPtr setChannelVariableAsUInt64;
        IntPtr setChannelVariableAsString;
        IntPtr flushChannelUpdates;
        IntPtr flushChannelCreation;
        IntPtr getChannelList;
        IntPtr getChannelClientList;
        IntPtr getParentChannelOfChannel;

        /* Server info */
        IntPtr getServerConnectionHandlerList;
        IntPtr getServerVariableAsInt;
        IntPtr getServerVariableAsUInt64;
        IntPtr getServerVariableAsString;
        IntPtr requestServerVariables;

        /* Connection info */
        IntPtr getConnectionStatus;
        IntPtr getConnectionVariableAsUInt64;
        IntPtr getConnectionVariableAsDouble;
        IntPtr getConnectionVariableAsString;
        IntPtr cleanUpConnectionInfo;

        /* Client related */
        IntPtr requestClientDBIDfromUID;
        IntPtr requestClientNamefromUID;
        IntPtr requestClientNamefromDBID;
        IntPtr requestClientEditDescription;
        IntPtr requestClientSetIsTalker;
        IntPtr requestIsTalker;

        /* Plugin related */
        IntPtr requestSendClientQueryCommand;

        /* Filetransfer */
        IntPtr getTransferFileName;
        IntPtr getTransferFilePath;
        IntPtr getTransferFileSize;
        IntPtr getTransferFileSizeDone;
        IntPtr isTransferSender;
        IntPtr getTransferStatus;
        IntPtr getCurrentTransferSpeed;
        IntPtr getAverageTransferSpeed;
        IntPtr getTransferRunTime;
        IntPtr sendFile;
        IntPtr requestFile;
        IntPtr haltTransfer;
        IntPtr requestFileList;
        IntPtr requestFileInfo;
        IntPtr requestDeleteFile;
        IntPtr requestCreateDirectory;
        IntPtr requestRenameFile;

        /* Offline message management */
        IntPtr requestMessageAdd;
        IntPtr requestMessageDel;
        IntPtr requestMessageGet;
        IntPtr requestMessageList;
        IntPtr requestMessageUpdateFlag;

        /* Interacting with the server - confirming passwords */
        IntPtr verifyServerPassword;
        IntPtr verifyChannelPassword;

        /* Interacting with the server - banning */
        IntPtr banclient;
        IntPtr banadd;
        IntPtr banclientdbid;
        IntPtr bandel;
        IntPtr bandelall;
        IntPtr requestBanList;

        /* Interacting with the server - complain */
        IntPtr requestComplainAdd;
        IntPtr requestComplainDel;
        IntPtr requestComplainDelAll;
        IntPtr requestComplainList;

        /* Permissions */
        IntPtr requestServerGroupList;
        IntPtr requestServerGroupAdd;
        IntPtr requestServerGroupDel;
        IntPtr requestServerGroupAddClient;
        IntPtr requestServerGroupDelClient;
        IntPtr requestServerGroupsByClientID;
        IntPtr requestServerGroupAddPerm;
        IntPtr requestServerGroupDelPerm;
        IntPtr requestServerGroupPermList;
        IntPtr requestServerGroupClientList;
        IntPtr requestChannelGroupList;
        IntPtr requestChannelGroupAdd;
        IntPtr requestChannelGroupDel;
        IntPtr requestChannelGroupAddPerm;
        IntPtr requestChannelGroupDelPerm;
        IntPtr requestChannelGroupPermList;
        IntPtr requestSetClientChannelGroup;
        IntPtr requestChannelAddPerm;
        IntPtr requestChannelDelPerm;
        IntPtr requestChannelPermList;
        IntPtr requestClientAddPerm;
        IntPtr requestClientDelPerm;
        IntPtr requestClientPermList;
        IntPtr requestChannelClientAddPerm;
        IntPtr requestChannelClientDelPerm;
        IntPtr requestChannelClientPermList;
        IntPtr privilegeKeyUse;
        IntPtr requestPermissionList;
        IntPtr requestPermissionOverview;

        /* Helper Functions */
        IntPtr clientPropertyStringToFlag;
        IntPtr channelPropertyStringToFlag;
        IntPtr serverPropertyStringToFlag;

        /* Client functions */
        IntPtr getAppPath;
        IntPtr getResourcesPath;
        IntPtr getConfigPath;
        IntPtr getPluginPath;
        IntPtr getCurrentServerConnectionHandlerID;
        IntPtr printMessage;
        IntPtr printMessageToCurrentTab;
        IntPtr urlsToBB;
        IntPtr sendPluginCommand;
        IntPtr getDirectories;
        IntPtr getServerConnectInfo;
        IntPtr getChannelConnectInfo;
        IntPtr createReturnCode;
        IntPtr requestInfoUpdate;
        IntPtr getServerVersion;
        IntPtr isWhispering;
        IntPtr isReceivingWhisper;
        IntPtr getAvatar;
        IntPtr setPluginMenuEnabled;
        IntPtr showHotkeySetup;
        IntPtr requestHotkeyInputDialog;
        IntPtr getHotkeyFromKeyword;
        IntPtr getClientDisplayName;
        IntPtr getBookmarkList;
        IntPtr getProfileList;
        IntPtr guiConnect;
        IntPtr guiConnectBookmark;
        IntPtr createBookmark;
        IntPtr getPermissionIDByName;
        IntPtr getClientNeededPermission;
    }
}
