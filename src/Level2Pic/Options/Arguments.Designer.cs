﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Level2Pic.Options {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0")]
    internal sealed partial class Arguments : global::System.Configuration.ApplicationSettingsBase {
        
        private static Arguments defaultInstance = ((Arguments)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Arguments())));
        
        public static Arguments Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Level_AutoSize {
            get {
                return ((bool)(this["Level_AutoSize"]));
            }
            set {
                this["Level_AutoSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default")]
        public string Level_Background {
            get {
                return ((string)(this["Level_Background"]));
            }
            set {
                this["Level_Background"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Blue")]
        public global::System.Drawing.Color Level_BackgroundColor {
            get {
                return ((global::System.Drawing.Color)(this["Level_BackgroundColor"]));
            }
            set {
                this["Level_BackgroundColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Level_BackgroundImagePath {
            get {
                return ((string)(this["Level_BackgroundImagePath"]));
            }
            set {
                this["Level_BackgroundImagePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Trebuchet MS, 12pt")]
        public global::System.Drawing.Font Level_Font {
            get {
                return ((global::System.Drawing.Font)(this["Level_Font"]));
            }
            set {
                this["Level_Font"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color Level_FontColor {
            get {
                return ((global::System.Drawing.Color)(this["Level_FontColor"]));
            }
            set {
                this["Level_FontColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Level_Text {
            get {
                return ((string)(this["Level_Text"]));
            }
            set {
                this["Level_Text"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Zone_AutoSize {
            get {
                return ((bool)(this["Zone_AutoSize"]));
            }
            set {
                this["Zone_AutoSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color Zone_Color {
            get {
                return ((global::System.Drawing.Color)(this["Zone_Color"]));
            }
            set {
                this["Zone_Color"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Zone_Cropping {
            get {
                return ((bool)(this["Zone_Cropping"]));
            }
            set {
                this["Zone_Cropping"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public uint Zone_EndPosition {
            get {
                return ((uint)(this["Zone_EndPosition"]));
            }
            set {
                this["Zone_EndPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Trebuchet MS, 12pt")]
        public global::System.Drawing.Font Zone_Font {
            get {
                return ((global::System.Drawing.Font)(this["Zone_Font"]));
            }
            set {
                this["Zone_Font"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255")]
        public byte Zone_Opacity {
            get {
                return ((byte)(this["Zone_Opacity"]));
            }
            set {
                this["Zone_Opacity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public uint Zone_StartPosition {
            get {
                return ((uint)(this["Zone_StartPosition"]));
            }
            set {
                this["Zone_StartPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Text")]
        public string Zone_Text {
            get {
                return ((string)(this["Zone_Text"]));
            }
            set {
                this["Zone_Text"] = value;
            }
        }
    }
}
