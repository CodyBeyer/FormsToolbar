// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace FormsToolbar {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class ToolBarPage : ContentPage {
        
        private ToolbarItem Menu1;
        
        private ToolbarItem Menu2;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(ToolBarPage));
            Menu1 = this.FindByName <ToolbarItem>("Menu1");
            Menu2 = this.FindByName <ToolbarItem>("Menu2");
        }
    }
}