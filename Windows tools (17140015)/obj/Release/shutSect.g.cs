﻿#pragma checksum "..\..\shutSect.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1773AECE10AA2EDC74124B3515330F80"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Windows_tools__17140015_;


namespace Windows_tools__17140015_ {
    
    
    /// <summary>
    /// shutSect
    /// </summary>
    public partial class shutSect : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\shutSect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hh;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\shutSect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mm;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\shutSect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ss;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\shutSect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ok;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\shutSect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Xtimer;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\shutSect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox options;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\shutSect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label info;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Windows tools (17140015);component/shutsect.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\shutSect.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.hh = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.mm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ss = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ok = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\shutSect.xaml"
            this.ok.Click += new System.Windows.RoutedEventHandler(this.ok_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Xtimer = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\shutSect.xaml"
            this.Xtimer.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.options = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\shutSect.xaml"
            this.options.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.options_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 24 "..\..\shutSect.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Shutdown_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 25 "..\..\shutSect.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Shutdownf_Selected);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 26 "..\..\shutSect.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Shutdownt_Selected);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 27 "..\..\shutSect.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.restart_Selected);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 28 "..\..\shutSect.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.sleep_Selected);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 29 "..\..\shutSect.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.signout_Selected);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 30 "..\..\shutSect.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.hibernate_Selected);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 31 "..\..\shutSect.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.lock_Selected);
            
            #line default
            #line hidden
            return;
            case 15:
            this.info = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

