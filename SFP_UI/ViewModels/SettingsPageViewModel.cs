﻿using Avalonia.Controls;

using ReactiveUI;

using SFP;

using SFP_UI.Views;

namespace SFP_UI.ViewModels
{
    public class SettingsPageViewModel : ViewModelBase
    {
        public static SettingsPageViewModel? Instance { get; private set; }

        public SettingsPageViewModel()
        {
            Instance = this;
        }

        private bool _shouldPatchOnStart = SFP.Properties.Settings.Default.ShouldPatchOnStart;

        public bool ShouldPatchOnStart
        {
            get => _shouldPatchOnStart;
            private set
            {
                this.RaiseAndSetIfChanged(ref _shouldPatchOnStart, value);
                SFP.Properties.Settings.Default.ShouldPatchOnStart = value;
            }
        }

        private bool _shouldPatchFriends = SFP.Properties.Settings.Default.ShouldPatchFriends;

        public bool ShouldPatchFriends
        {
            get => _shouldPatchFriends;
            private set
            {
                this.RaiseAndSetIfChanged(ref _shouldPatchFriends, value);
                SFP.Properties.Settings.Default.ShouldPatchFriends = value;
            }
        }

        private bool _shouldPatchLibrary = SFP.Properties.Settings.Default.ShouldPatchLibrary;

        public bool ShouldPatchLibrary
        {
            get => _shouldPatchLibrary;
            private set
            {
                this.RaiseAndSetIfChanged(ref _shouldPatchLibrary, value);
                SFP.Properties.Settings.Default.ShouldPatchLibrary = value;
            }
        }

        private bool _shouldScanFriends = SFP.Properties.Settings.Default.ShouldScanFriends;

        public bool ShouldScanFriends
        {
            get => _shouldScanFriends;
            private set
            {
                this.RaiseAndSetIfChanged(ref _shouldScanFriends, value);
                SFP.Properties.Settings.Default.ShouldScanFriends = value;
            }
        }

        private bool _shouldScanLibrary = SFP.Properties.Settings.Default.ShouldScanLibrary;

        public bool ShouldScanLibrary
        {
            get => _shouldScanLibrary;
            private set
            {
                this.RaiseAndSetIfChanged(ref _shouldScanLibrary, value);
                SFP.Properties.Settings.Default.ShouldScanLibrary = value;
            }
        }

        private bool _scanOnly = SFP.Properties.Settings.Default.ScanOnly;

        public bool ScanOnly
        {
            get => _scanOnly;
            private set
            {
                this.RaiseAndSetIfChanged(ref _scanOnly, value);
                SFP.Properties.Settings.Default.ScanOnly = value;
            }
        }

        private bool _restartSteamOnPatch = SFP.Properties.Settings.Default.RestartSteamOnPatch;

        public bool RestartSteamOnPatch
        {
            get => _restartSteamOnPatch;
            private set
            {
                this.RaiseAndSetIfChanged(ref _restartSteamOnPatch, value);
                SFP.Properties.Settings.Default.RestartSteamOnPatch = value;
            }
        }

        private bool _shouldScanOnStart = SFP.Properties.Settings.Default.ShouldScanOnStart;

        public bool ShouldScanOnStart
        {
            get => _shouldScanOnStart;
            private set
            {
                this.RaiseAndSetIfChanged(ref _shouldScanOnStart, value);
                SFP.Properties.Settings.Default.ShouldScanOnStart = value;
            }
        }

        private string _steamLaunchArgs = SFP.Properties.Settings.Default.SteamLaunchArgs;

        public string SteamLaunchArgs
        {
            get => _steamLaunchArgs;
            private set
            {
                this.RaiseAndSetIfChanged(ref _steamLaunchArgs, value);
                SFP.Properties.Settings.Default.SteamLaunchArgs = value;
            }
        }

        private string _steamDirectory = SteamModel.SteamDir ?? string.Empty;

        public string SteamDirectory
        {
            get => _steamDirectory;
            private set
            {
                this.RaiseAndSetIfChanged(ref _steamDirectory, value);
                SFP.Properties.Settings.Default.SteamDirectory = value;
            }
        }

        private string _cacheDirectory = SteamModel.CacheDir;

        public string CacheDirectory
        {
            get => _cacheDirectory;
            private set
            {
                this.RaiseAndSetIfChanged(ref _cacheDirectory, value);
                SFP.Properties.Settings.Default.CacheDirectory = value;
            }
        }

        private bool _checkForUpdates = SFP.Properties.Settings.Default.CheckForUpdates;

        public bool CheckForUpdates
        {
            get => _checkForUpdates;
            private set
            {
                this.RaiseAndSetIfChanged(ref _checkForUpdates, value);
                SFP.Properties.Settings.Default.CheckForUpdates = value;
            }
        }

        private bool _showTrayIcon = SFP.Properties.Settings.Default.ShowTrayIcon;

        public bool ShowTrayIcon
        {
            get => _showTrayIcon;
            private set
            {
                this.RaiseAndSetIfChanged(ref _showTrayIcon, value);
                SFP.Properties.Settings.Default.ShowTrayIcon = value;
            }
        }

        private bool _minimizeToTray = SFP.Properties.Settings.Default.MinimizeToTray;

        public bool MinimizeToTray
        {
            get => _minimizeToTray;
            private set
            {
                this.RaiseAndSetIfChanged(ref _minimizeToTray, value);
                SFP.Properties.Settings.Default.MinimizeToTray = value;
            }
        }

        private bool _startMinimized = SFP.Properties.Settings.Default.StartMinimized;

        public bool StartMinimized
        {
            get => _startMinimized;
            private set
            {
                this.RaiseAndSetIfChanged(ref _startMinimized, value);
                SFP.Properties.Settings.Default.StartMinimized = value;
            }
        }

        /*
        private bool startWithOS = SFP.Properties.Settings.Default.StartWithOS;

        public bool StartWithOS
        {
            get => startMinimized;
            private set
            {
                this.RaiseAndSetIfChanged(ref startWithOS, value);
                SFP.Properties.Settings.Default.StartWithOS = value;
            }
        }
        */

        public static void OnSaveCommand()
        {
            SFP.Properties.Settings.Default.Save();
        }

        public void OnReloadCommand()
        {
            SFP.Properties.Settings.Default.Reload();
            ShouldPatchOnStart = SFP.Properties.Settings.Default.ShouldPatchOnStart;
            ShouldPatchFriends = SFP.Properties.Settings.Default.ShouldPatchFriends;
            ShouldPatchLibrary = SFP.Properties.Settings.Default.ShouldPatchLibrary;
            ShouldScanFriends = SFP.Properties.Settings.Default.ShouldScanFriends;
            ShouldScanLibrary = SFP.Properties.Settings.Default.ShouldScanLibrary;
            ScanOnly = SFP.Properties.Settings.Default.ScanOnly;
            RestartSteamOnPatch = SFP.Properties.Settings.Default.RestartSteamOnPatch;
            ShouldScanOnStart = SFP.Properties.Settings.Default.ShouldScanOnStart;
            SteamDirectory = SteamModel.SteamDir ?? string.Empty;
            SteamLaunchArgs = SFP.Properties.Settings.Default.SteamLaunchArgs;
            CacheDirectory = SteamModel.CacheDir;
        }

        public async void OnBrowseSteamCommand()
        {
            if (MainWindow.Instance != null)
            {
                var dialog = new OpenFolderDialog();
                string? result = await dialog.ShowAsync(MainWindow.Instance);
                SteamDirectory = result ?? SteamDirectory;
            }
        }

        public async void OnBrowseCacheCommand()
        {
            if (MainWindow.Instance != null)
            {
                var dialog = new OpenFolderDialog();
                string? result = await dialog.ShowAsync(MainWindow.Instance);
                CacheDirectory = result ?? CacheDirectory;
            }
        }

        public void OnResetSteamCommand()
        {
            SFP.Properties.Settings.Default.SteamDirectory = string.Empty;
            SteamDirectory = SteamModel.SteamDir ?? string.Empty;
        }

        public void OnResetCacheCommand()
        {
            SFP.Properties.Settings.Default.CacheDirectory = string.Empty;
            CacheDirectory = SteamModel.CacheDir;
        }
    }
}
