﻿#pragma checksum "C:\Users\carl\Visual Studio\Projects\RemotePotatoServer\SilverPotato\XAML\Low-Level Xaml\VolumePopupHorizontal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A5526596D7D08E02610BA4762C205899"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SilverPotato {
    
    
    public partial class VolumePopupHorizontal : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Border brdVolSlider;
        
        internal System.Windows.Controls.Slider sldVolume;
        
        internal System.Windows.Controls.Image imgCurrentVolume;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverPotato;component/XAML/Low-Level%20Xaml/VolumePopupHorizontal.xaml", System.UriKind.Relative));
            this.brdVolSlider = ((System.Windows.Controls.Border)(this.FindName("brdVolSlider")));
            this.sldVolume = ((System.Windows.Controls.Slider)(this.FindName("sldVolume")));
            this.imgCurrentVolume = ((System.Windows.Controls.Image)(this.FindName("imgCurrentVolume")));
        }
    }
}
