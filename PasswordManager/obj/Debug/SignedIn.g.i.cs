﻿#pragma checksum "..\..\SignedIn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "77A69BBD9D8857E96C9E46DF4A8CC026357DC834753F60A0AA3EECFA2E557CBB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PasswordManager;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace PasswordManager {
    
    
    /// <summary>
    /// SignedIn
    /// </summary>
    public partial class SignedIn : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\SignedIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Logout;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\SignedIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox_records;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\SignedIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_show;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\SignedIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_add;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SignedIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_edit;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\SignedIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_delete;
        
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
            System.Uri resourceLocater = new System.Uri("/PasswordManager;component/signedin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SignedIn.xaml"
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
            this.Logout = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\SignedIn.xaml"
            this.Logout.Click += new System.Windows.RoutedEventHandler(this.Logout_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listBox_records = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.button_show = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\SignedIn.xaml"
            this.button_show.Click += new System.Windows.RoutedEventHandler(this.button_show_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_add = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\SignedIn.xaml"
            this.button_add.Click += new System.Windows.RoutedEventHandler(this.button_add_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_edit = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\SignedIn.xaml"
            this.button_edit.Click += new System.Windows.RoutedEventHandler(this.button_edit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button_delete = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\SignedIn.xaml"
            this.button_delete.Click += new System.Windows.RoutedEventHandler(this.button_delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

