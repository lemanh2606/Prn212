﻿#pragma checksum "..\..\..\WindowAddRoom.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6E4AE50382EEA41C7EF1076BF9301585D7900CCC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LeChiManhWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace LeChiManhWPF {
    
    
    /// <summary>
    /// WindowAddRoom
    /// </summary>
    public partial class WindowAddRoom : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 87 "..\..\..\WindowAddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbStatus;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\WindowAddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRoomNumber;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\WindowAddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescription;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\WindowAddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbbCapacity;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\WindowAddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbbRoomType;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\WindowAddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrice;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\WindowAddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\WindowAddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LeChiManhWPF;component/windowaddroom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowAddRoom.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\WindowAddRoom.xaml"
            ((LeChiManhWPF.WindowAddRoom)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ckbStatus = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.txtRoomNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 89 "..\..\..\WindowAddRoom.xaml"
            this.txtRoomNumber.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\WindowAddRoom.xaml"
            this.txtRoomNumber.LostFocus += new System.Windows.RoutedEventHandler(this.txtPrice_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CbbCapacity = ((System.Windows.Controls.ComboBox)(target));
            
            #line 98 "..\..\..\WindowAddRoom.xaml"
            this.CbbCapacity.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbbCapacity_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CbbRoomType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.txtPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 104 "..\..\..\WindowAddRoom.xaml"
            this.txtPrice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 104 "..\..\..\WindowAddRoom.xaml"
            this.txtPrice.LostFocus += new System.Windows.RoutedEventHandler(this.txtPrice_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\WindowAddRoom.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\WindowAddRoom.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

