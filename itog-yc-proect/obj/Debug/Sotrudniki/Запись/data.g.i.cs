﻿#pragma checksum "..\..\..\..\Sotrudniki\Запись\data.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9E03DD37B539CAC7C93E21592F99FB5C09E644F02B7A49EA46BEF6CB20E6721F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using itog_yc_proect.Sotrudniki.Запись;


namespace itog_yc_proect.Sotrudniki.Запись {
    
    
    /// <summary>
    /// data
    /// </summary>
    public partial class data : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\Sotrudniki\Запись\data.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid spisok;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Sotrudniki\Запись\data.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox date;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Sotrudniki\Запись\data.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox vrema;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Sotrudniki\Запись\data.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cab;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Sotrudniki\Запись\data.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dob;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Sotrudniki\Запись\data.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button del;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Sotrudniki\Запись\data.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izm;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Sotrudniki\Запись\data.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nazad;
        
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
            System.Uri resourceLocater = new System.Uri("/itog-yc-proect;component/sotrudniki/%d0%97%d0%b0%d0%bf%d0%b8%d1%81%d1%8c/data.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Sotrudniki\Запись\data.xaml"
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
            this.spisok = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.date = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.vrema = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cab = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.dob = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Sotrudniki\Запись\data.xaml"
            this.dob.Click += new System.Windows.RoutedEventHandler(this.dob_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.del = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Sotrudniki\Запись\data.xaml"
            this.del.Click += new System.Windows.RoutedEventHandler(this.del_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.izm = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Sotrudniki\Запись\data.xaml"
            this.izm.Click += new System.Windows.RoutedEventHandler(this.izm_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.nazad = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\Sotrudniki\Запись\data.xaml"
            this.nazad.Click += new System.Windows.RoutedEventHandler(this.nazad_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

