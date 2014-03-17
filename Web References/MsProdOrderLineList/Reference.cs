﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18408.
// 
#pragma warning disable 1591

namespace MsDynamicsTest.MsProdOrderLineList {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ProdOrderLineList_Binding", Namespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist")]
    public partial class ProdOrderLineList_Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ReadOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReadByRecIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReadMultipleOperationCompleted;
        
        private System.Threading.SendOrPostCallback IsUpdatedOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRecIdFromKeyOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ProdOrderLineList_Service() {
            this.Url = global::MsDynamicsTest.Properties.Settings.Default.MsDynamicsTest_MsProdOrderLineList_ProdOrderLineList_Service;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ReadCompletedEventHandler ReadCompleted;
        
        /// <remarks/>
        public event ReadByRecIdCompletedEventHandler ReadByRecIdCompleted;
        
        /// <remarks/>
        public event ReadMultipleCompletedEventHandler ReadMultipleCompleted;
        
        /// <remarks/>
        public event IsUpdatedCompletedEventHandler IsUpdatedCompleted;
        
        /// <remarks/>
        public event GetRecIdFromKeyCompletedEventHandler GetRecIdFromKeyCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/prodorderlinelist:Read", RequestNamespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist", ResponseElementName="Read_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ProdOrderLineList")]
        public ProdOrderLineList Read(string Status, string Prod_Order_No) {
            object[] results = this.Invoke("Read", new object[] {
                        Status,
                        Prod_Order_No});
            return ((ProdOrderLineList)(results[0]));
        }
        
        /// <remarks/>
        public void ReadAsync(string Status, string Prod_Order_No) {
            this.ReadAsync(Status, Prod_Order_No, null);
        }
        
        /// <remarks/>
        public void ReadAsync(string Status, string Prod_Order_No, object userState) {
            if ((this.ReadOperationCompleted == null)) {
                this.ReadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadOperationCompleted);
            }
            this.InvokeAsync("Read", new object[] {
                        Status,
                        Prod_Order_No}, this.ReadOperationCompleted, userState);
        }
        
        private void OnReadOperationCompleted(object arg) {
            if ((this.ReadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReadCompleted(this, new ReadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/prodorderlinelist:ReadByRecId", RequestNamespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist", ResponseElementName="ReadByRecId_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ProdOrderLineList")]
        public ProdOrderLineList ReadByRecId(string recId) {
            object[] results = this.Invoke("ReadByRecId", new object[] {
                        recId});
            return ((ProdOrderLineList)(results[0]));
        }
        
        /// <remarks/>
        public void ReadByRecIdAsync(string recId) {
            this.ReadByRecIdAsync(recId, null);
        }
        
        /// <remarks/>
        public void ReadByRecIdAsync(string recId, object userState) {
            if ((this.ReadByRecIdOperationCompleted == null)) {
                this.ReadByRecIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadByRecIdOperationCompleted);
            }
            this.InvokeAsync("ReadByRecId", new object[] {
                        recId}, this.ReadByRecIdOperationCompleted, userState);
        }
        
        private void OnReadByRecIdOperationCompleted(object arg) {
            if ((this.ReadByRecIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReadByRecIdCompleted(this, new ReadByRecIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/prodorderlinelist:ReadMultiple", RequestNamespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist", ResponseElementName="ReadMultiple_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ReadMultiple_Result")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ProdOrderLineList[] ReadMultiple([System.Xml.Serialization.XmlElementAttribute("filter")] ProdOrderLineList_Filter[] filter, string bookmarkKey, int setSize) {
            object[] results = this.Invoke("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize});
            return ((ProdOrderLineList[])(results[0]));
        }
        
        /// <remarks/>
        public void ReadMultipleAsync(ProdOrderLineList_Filter[] filter, string bookmarkKey, int setSize) {
            this.ReadMultipleAsync(filter, bookmarkKey, setSize, null);
        }
        
        /// <remarks/>
        public void ReadMultipleAsync(ProdOrderLineList_Filter[] filter, string bookmarkKey, int setSize, object userState) {
            if ((this.ReadMultipleOperationCompleted == null)) {
                this.ReadMultipleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadMultipleOperationCompleted);
            }
            this.InvokeAsync("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize}, this.ReadMultipleOperationCompleted, userState);
        }
        
        private void OnReadMultipleOperationCompleted(object arg) {
            if ((this.ReadMultipleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReadMultipleCompleted(this, new ReadMultipleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/prodorderlinelist:IsUpdated", RequestNamespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist", ResponseElementName="IsUpdated_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("IsUpdated_Result")]
        public bool IsUpdated(string Key) {
            object[] results = this.Invoke("IsUpdated", new object[] {
                        Key});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void IsUpdatedAsync(string Key) {
            this.IsUpdatedAsync(Key, null);
        }
        
        /// <remarks/>
        public void IsUpdatedAsync(string Key, object userState) {
            if ((this.IsUpdatedOperationCompleted == null)) {
                this.IsUpdatedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsUpdatedOperationCompleted);
            }
            this.InvokeAsync("IsUpdated", new object[] {
                        Key}, this.IsUpdatedOperationCompleted, userState);
        }
        
        private void OnIsUpdatedOperationCompleted(object arg) {
            if ((this.IsUpdatedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsUpdatedCompleted(this, new IsUpdatedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/prodorderlinelist:GetRecIdFromKey", RequestNamespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist", ResponseElementName="GetRecIdFromKey_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("GetRecIdFromKey_Result")]
        public string GetRecIdFromKey(string Key) {
            object[] results = this.Invoke("GetRecIdFromKey", new object[] {
                        Key});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetRecIdFromKeyAsync(string Key) {
            this.GetRecIdFromKeyAsync(Key, null);
        }
        
        /// <remarks/>
        public void GetRecIdFromKeyAsync(string Key, object userState) {
            if ((this.GetRecIdFromKeyOperationCompleted == null)) {
                this.GetRecIdFromKeyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRecIdFromKeyOperationCompleted);
            }
            this.InvokeAsync("GetRecIdFromKey", new object[] {
                        Key}, this.GetRecIdFromKeyOperationCompleted, userState);
        }
        
        private void OnGetRecIdFromKeyOperationCompleted(object arg) {
            if ((this.GetRecIdFromKeyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRecIdFromKeyCompleted(this, new GetRecIdFromKeyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist")]
    public partial class ProdOrderLineList {
        
        private string keyField;
        
        private Status statusField;
        
        private bool statusFieldSpecified;
        
        private string prod_Order_NoField;
        
        private string item_NoField;
        
        private string variant_CodeField;
        
        private string descriptionField;
        
        private string description_2Field;
        
        private string shortcut_Dimension_1_CodeField;
        
        private string shortcut_Dimension_2_CodeField;
        
        private string shortcutDimCode3Field;
        
        private string shortcutDimCode4Field;
        
        private string shortcutDimCode5Field;
        
        private string shortcutDimCode6Field;
        
        private string shortcutDimCode7Field;
        
        private string shortcutDimCode8Field;
        
        private string location_CodeField;
        
        private decimal quantityField;
        
        private bool quantityFieldSpecified;
        
        private decimal finished_QuantityField;
        
        private bool finished_QuantityFieldSpecified;
        
        private decimal remaining_QuantityField;
        
        private bool remaining_QuantityFieldSpecified;
        
        private decimal scrap_PercentField;
        
        private bool scrap_PercentFieldSpecified;
        
        private System.DateTime due_DateField;
        
        private bool due_DateFieldSpecified;
        
        private System.DateTime starting_DateField;
        
        private bool starting_DateFieldSpecified;
        
        private System.DateTime starting_TimeField;
        
        private bool starting_TimeFieldSpecified;
        
        private System.DateTime ending_DateField;
        
        private bool ending_DateFieldSpecified;
        
        private System.DateTime ending_TimeField;
        
        private bool ending_TimeFieldSpecified;
        
        private string production_BOM_NoField;
        
        private decimal unit_CostField;
        
        private bool unit_CostFieldSpecified;
        
        private decimal cost_AmountField;
        
        private bool cost_AmountFieldSpecified;
        
        /// <remarks/>
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public Status Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Prod_Order_No {
            get {
                return this.prod_Order_NoField;
            }
            set {
                this.prod_Order_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Item_No {
            get {
                return this.item_NoField;
            }
            set {
                this.item_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Variant_Code {
            get {
                return this.variant_CodeField;
            }
            set {
                this.variant_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Description_2 {
            get {
                return this.description_2Field;
            }
            set {
                this.description_2Field = value;
            }
        }
        
        /// <remarks/>
        public string Shortcut_Dimension_1_Code {
            get {
                return this.shortcut_Dimension_1_CodeField;
            }
            set {
                this.shortcut_Dimension_1_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Shortcut_Dimension_2_Code {
            get {
                return this.shortcut_Dimension_2_CodeField;
            }
            set {
                this.shortcut_Dimension_2_CodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShortcutDimCode[3]")]
        public string ShortcutDimCode3 {
            get {
                return this.shortcutDimCode3Field;
            }
            set {
                this.shortcutDimCode3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShortcutDimCode[4]")]
        public string ShortcutDimCode4 {
            get {
                return this.shortcutDimCode4Field;
            }
            set {
                this.shortcutDimCode4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShortcutDimCode[5]")]
        public string ShortcutDimCode5 {
            get {
                return this.shortcutDimCode5Field;
            }
            set {
                this.shortcutDimCode5Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShortcutDimCode[6]")]
        public string ShortcutDimCode6 {
            get {
                return this.shortcutDimCode6Field;
            }
            set {
                this.shortcutDimCode6Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShortcutDimCode[7]")]
        public string ShortcutDimCode7 {
            get {
                return this.shortcutDimCode7Field;
            }
            set {
                this.shortcutDimCode7Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShortcutDimCode[8]")]
        public string ShortcutDimCode8 {
            get {
                return this.shortcutDimCode8Field;
            }
            set {
                this.shortcutDimCode8Field = value;
            }
        }
        
        /// <remarks/>
        public string Location_Code {
            get {
                return this.location_CodeField;
            }
            set {
                this.location_CodeField = value;
            }
        }
        
        /// <remarks/>
        public decimal Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified {
            get {
                return this.quantityFieldSpecified;
            }
            set {
                this.quantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Finished_Quantity {
            get {
                return this.finished_QuantityField;
            }
            set {
                this.finished_QuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Finished_QuantitySpecified {
            get {
                return this.finished_QuantityFieldSpecified;
            }
            set {
                this.finished_QuantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Remaining_Quantity {
            get {
                return this.remaining_QuantityField;
            }
            set {
                this.remaining_QuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Remaining_QuantitySpecified {
            get {
                return this.remaining_QuantityFieldSpecified;
            }
            set {
                this.remaining_QuantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Scrap_Percent {
            get {
                return this.scrap_PercentField;
            }
            set {
                this.scrap_PercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Scrap_PercentSpecified {
            get {
                return this.scrap_PercentFieldSpecified;
            }
            set {
                this.scrap_PercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Due_Date {
            get {
                return this.due_DateField;
            }
            set {
                this.due_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Due_DateSpecified {
            get {
                return this.due_DateFieldSpecified;
            }
            set {
                this.due_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Starting_Date {
            get {
                return this.starting_DateField;
            }
            set {
                this.starting_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Starting_DateSpecified {
            get {
                return this.starting_DateFieldSpecified;
            }
            set {
                this.starting_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime Starting_Time {
            get {
                return this.starting_TimeField;
            }
            set {
                this.starting_TimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Starting_TimeSpecified {
            get {
                return this.starting_TimeFieldSpecified;
            }
            set {
                this.starting_TimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Ending_Date {
            get {
                return this.ending_DateField;
            }
            set {
                this.ending_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Ending_DateSpecified {
            get {
                return this.ending_DateFieldSpecified;
            }
            set {
                this.ending_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime Ending_Time {
            get {
                return this.ending_TimeField;
            }
            set {
                this.ending_TimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Ending_TimeSpecified {
            get {
                return this.ending_TimeFieldSpecified;
            }
            set {
                this.ending_TimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Production_BOM_No {
            get {
                return this.production_BOM_NoField;
            }
            set {
                this.production_BOM_NoField = value;
            }
        }
        
        /// <remarks/>
        public decimal Unit_Cost {
            get {
                return this.unit_CostField;
            }
            set {
                this.unit_CostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Unit_CostSpecified {
            get {
                return this.unit_CostFieldSpecified;
            }
            set {
                this.unit_CostFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Cost_Amount {
            get {
                return this.cost_AmountField;
            }
            set {
                this.cost_AmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Cost_AmountSpecified {
            get {
                return this.cost_AmountFieldSpecified;
            }
            set {
                this.cost_AmountFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist")]
    public enum Status {
        
        /// <remarks/>
        Simulated,
        
        /// <remarks/>
        Planned,
        
        /// <remarks/>
        Firm_Planned,
        
        /// <remarks/>
        Released,
        
        /// <remarks/>
        Finished,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist")]
    public partial class ProdOrderLineList_Filter {
        
        private ProdOrderLineList_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        public ProdOrderLineList_Fields Field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        public string Criteria {
            get {
                return this.criteriaField;
            }
            set {
                this.criteriaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/prodorderlinelist")]
    public enum ProdOrderLineList_Fields {
        
        /// <remarks/>
        Status,
        
        /// <remarks/>
        Prod_Order_No,
        
        /// <remarks/>
        Item_No,
        
        /// <remarks/>
        Variant_Code,
        
        /// <remarks/>
        Description,
        
        /// <remarks/>
        Description_2,
        
        /// <remarks/>
        Shortcut_Dimension_1_Code,
        
        /// <remarks/>
        Shortcut_Dimension_2_Code,
        
        /// <remarks/>
        ShortcutDimCode_x005B_3_x005D_,
        
        /// <remarks/>
        ShortcutDimCode_x005B_4_x005D_,
        
        /// <remarks/>
        ShortcutDimCode_x005B_5_x005D_,
        
        /// <remarks/>
        ShortcutDimCode_x005B_6_x005D_,
        
        /// <remarks/>
        ShortcutDimCode_x005B_7_x005D_,
        
        /// <remarks/>
        ShortcutDimCode_x005B_8_x005D_,
        
        /// <remarks/>
        Location_Code,
        
        /// <remarks/>
        Quantity,
        
        /// <remarks/>
        Finished_Quantity,
        
        /// <remarks/>
        Remaining_Quantity,
        
        /// <remarks/>
        Scrap_Percent,
        
        /// <remarks/>
        Due_Date,
        
        /// <remarks/>
        Starting_Date,
        
        /// <remarks/>
        Starting_Time,
        
        /// <remarks/>
        Ending_Date,
        
        /// <remarks/>
        Ending_Time,
        
        /// <remarks/>
        Production_BOM_No,
        
        /// <remarks/>
        Unit_Cost,
        
        /// <remarks/>
        Cost_Amount,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ReadCompletedEventHandler(object sender, ReadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProdOrderLineList Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProdOrderLineList)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ReadByRecIdCompletedEventHandler(object sender, ReadByRecIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReadByRecIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReadByRecIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProdOrderLineList Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProdOrderLineList)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ReadMultipleCompletedEventHandler(object sender, ReadMultipleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReadMultipleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReadMultipleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProdOrderLineList[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProdOrderLineList[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void IsUpdatedCompletedEventHandler(object sender, IsUpdatedCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsUpdatedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsUpdatedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetRecIdFromKeyCompletedEventHandler(object sender, GetRecIdFromKeyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRecIdFromKeyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRecIdFromKeyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591