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

namespace MsDynamicsTest.MsNavVendorList {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="VendorList_Binding", Namespace="urn:microsoft-dynamics-schemas/page/vendorlist")]
    public partial class VendorList_Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ReadOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReadByRecIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReadMultipleOperationCompleted;
        
        private System.Threading.SendOrPostCallback IsUpdatedOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRecIdFromKeyOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public VendorList_Service() {
            this.Url = global::MsDynamicsTest.Properties.Settings.Default.MsDynamicsTest_MsNavVendorList_VendorList_Service;
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/vendorlist:Read", RequestNamespace="urn:microsoft-dynamics-schemas/page/vendorlist", ResponseElementName="Read_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/vendorlist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("VendorList")]
        public VendorList Read(string No) {
            object[] results = this.Invoke("Read", new object[] {
                        No});
            return ((VendorList)(results[0]));
        }
        
        /// <remarks/>
        public void ReadAsync(string No) {
            this.ReadAsync(No, null);
        }
        
        /// <remarks/>
        public void ReadAsync(string No, object userState) {
            if ((this.ReadOperationCompleted == null)) {
                this.ReadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadOperationCompleted);
            }
            this.InvokeAsync("Read", new object[] {
                        No}, this.ReadOperationCompleted, userState);
        }
        
        private void OnReadOperationCompleted(object arg) {
            if ((this.ReadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReadCompleted(this, new ReadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/vendorlist:ReadByRecId", RequestNamespace="urn:microsoft-dynamics-schemas/page/vendorlist", ResponseElementName="ReadByRecId_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/vendorlist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("VendorList")]
        public VendorList ReadByRecId(string recId) {
            object[] results = this.Invoke("ReadByRecId", new object[] {
                        recId});
            return ((VendorList)(results[0]));
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/vendorlist:ReadMultiple", RequestNamespace="urn:microsoft-dynamics-schemas/page/vendorlist", ResponseElementName="ReadMultiple_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/vendorlist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ReadMultiple_Result")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public VendorList[] ReadMultiple([System.Xml.Serialization.XmlElementAttribute("filter")] VendorList_Filter[] filter, string bookmarkKey, int setSize) {
            object[] results = this.Invoke("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize});
            return ((VendorList[])(results[0]));
        }
        
        /// <remarks/>
        public void ReadMultipleAsync(VendorList_Filter[] filter, string bookmarkKey, int setSize) {
            this.ReadMultipleAsync(filter, bookmarkKey, setSize, null);
        }
        
        /// <remarks/>
        public void ReadMultipleAsync(VendorList_Filter[] filter, string bookmarkKey, int setSize, object userState) {
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/vendorlist:IsUpdated", RequestNamespace="urn:microsoft-dynamics-schemas/page/vendorlist", ResponseElementName="IsUpdated_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/vendorlist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/vendorlist:GetRecIdFromKey", RequestNamespace="urn:microsoft-dynamics-schemas/page/vendorlist", ResponseElementName="GetRecIdFromKey_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/vendorlist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/vendorlist")]
    public partial class VendorList {
        
        private string keyField;
        
        private string noField;
        
        private string nameField;
        
        private string responsibility_CenterField;
        
        private string location_CodeField;
        
        private string post_CodeField;
        
        private string country_Region_CodeField;
        
        private string phone_NoField;
        
        private string fax_NoField;
        
        private string iC_Partner_CodeField;
        
        private string contactField;
        
        private string purchaser_CodeField;
        
        private string vendor_Posting_GroupField;
        
        private string gen_Bus_Posting_GroupField;
        
        private string vAT_Bus_Posting_GroupField;
        
        private string payment_Terms_CodeField;
        
        private string fin_Charge_Terms_CodeField;
        
        private string currency_CodeField;
        
        private string language_CodeField;
        
        private string search_NameField;
        
        private Blocked blockedField;
        
        private bool blockedFieldSpecified;
        
        private System.DateTime last_Date_ModifiedField;
        
        private bool last_Date_ModifiedFieldSpecified;
        
        private Application_Method application_MethodField;
        
        private bool application_MethodFieldSpecified;
        
        private string shipment_Method_CodeField;
        
        private string lead_Time_CalculationField;
        
        private string base_Calendar_CodeField;
        
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
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Responsibility_Center {
            get {
                return this.responsibility_CenterField;
            }
            set {
                this.responsibility_CenterField = value;
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
        public string Post_Code {
            get {
                return this.post_CodeField;
            }
            set {
                this.post_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Country_Region_Code {
            get {
                return this.country_Region_CodeField;
            }
            set {
                this.country_Region_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Phone_No {
            get {
                return this.phone_NoField;
            }
            set {
                this.phone_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Fax_No {
            get {
                return this.fax_NoField;
            }
            set {
                this.fax_NoField = value;
            }
        }
        
        /// <remarks/>
        public string IC_Partner_Code {
            get {
                return this.iC_Partner_CodeField;
            }
            set {
                this.iC_Partner_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
        
        /// <remarks/>
        public string Purchaser_Code {
            get {
                return this.purchaser_CodeField;
            }
            set {
                this.purchaser_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Vendor_Posting_Group {
            get {
                return this.vendor_Posting_GroupField;
            }
            set {
                this.vendor_Posting_GroupField = value;
            }
        }
        
        /// <remarks/>
        public string Gen_Bus_Posting_Group {
            get {
                return this.gen_Bus_Posting_GroupField;
            }
            set {
                this.gen_Bus_Posting_GroupField = value;
            }
        }
        
        /// <remarks/>
        public string VAT_Bus_Posting_Group {
            get {
                return this.vAT_Bus_Posting_GroupField;
            }
            set {
                this.vAT_Bus_Posting_GroupField = value;
            }
        }
        
        /// <remarks/>
        public string Payment_Terms_Code {
            get {
                return this.payment_Terms_CodeField;
            }
            set {
                this.payment_Terms_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Fin_Charge_Terms_Code {
            get {
                return this.fin_Charge_Terms_CodeField;
            }
            set {
                this.fin_Charge_Terms_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Currency_Code {
            get {
                return this.currency_CodeField;
            }
            set {
                this.currency_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Language_Code {
            get {
                return this.language_CodeField;
            }
            set {
                this.language_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Search_Name {
            get {
                return this.search_NameField;
            }
            set {
                this.search_NameField = value;
            }
        }
        
        /// <remarks/>
        public Blocked Blocked {
            get {
                return this.blockedField;
            }
            set {
                this.blockedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlockedSpecified {
            get {
                return this.blockedFieldSpecified;
            }
            set {
                this.blockedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Last_Date_Modified {
            get {
                return this.last_Date_ModifiedField;
            }
            set {
                this.last_Date_ModifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Last_Date_ModifiedSpecified {
            get {
                return this.last_Date_ModifiedFieldSpecified;
            }
            set {
                this.last_Date_ModifiedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Application_Method Application_Method {
            get {
                return this.application_MethodField;
            }
            set {
                this.application_MethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Application_MethodSpecified {
            get {
                return this.application_MethodFieldSpecified;
            }
            set {
                this.application_MethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Shipment_Method_Code {
            get {
                return this.shipment_Method_CodeField;
            }
            set {
                this.shipment_Method_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Lead_Time_Calculation {
            get {
                return this.lead_Time_CalculationField;
            }
            set {
                this.lead_Time_CalculationField = value;
            }
        }
        
        /// <remarks/>
        public string Base_Calendar_Code {
            get {
                return this.base_Calendar_CodeField;
            }
            set {
                this.base_Calendar_CodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/vendorlist")]
    public enum Blocked {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Payment,
        
        /// <remarks/>
        All,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/vendorlist")]
    public enum Application_Method {
        
        /// <remarks/>
        Manual,
        
        /// <remarks/>
        Apply_to_Oldest,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/vendorlist")]
    public partial class VendorList_Filter {
        
        private VendorList_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        public VendorList_Fields Field {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/vendorlist")]
    public enum VendorList_Fields {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Name,
        
        /// <remarks/>
        Responsibility_Center,
        
        /// <remarks/>
        Location_Code,
        
        /// <remarks/>
        Post_Code,
        
        /// <remarks/>
        Country_Region_Code,
        
        /// <remarks/>
        Phone_No,
        
        /// <remarks/>
        Fax_No,
        
        /// <remarks/>
        IC_Partner_Code,
        
        /// <remarks/>
        Contact,
        
        /// <remarks/>
        Purchaser_Code,
        
        /// <remarks/>
        Vendor_Posting_Group,
        
        /// <remarks/>
        Gen_Bus_Posting_Group,
        
        /// <remarks/>
        VAT_Bus_Posting_Group,
        
        /// <remarks/>
        Payment_Terms_Code,
        
        /// <remarks/>
        Fin_Charge_Terms_Code,
        
        /// <remarks/>
        Currency_Code,
        
        /// <remarks/>
        Language_Code,
        
        /// <remarks/>
        Search_Name,
        
        /// <remarks/>
        Blocked,
        
        /// <remarks/>
        Last_Date_Modified,
        
        /// <remarks/>
        Application_Method,
        
        /// <remarks/>
        Shipment_Method_Code,
        
        /// <remarks/>
        Lead_Time_Calculation,
        
        /// <remarks/>
        Base_Calendar_Code,
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
        public VendorList Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VendorList)(this.results[0]));
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
        public VendorList Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VendorList)(this.results[0]));
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
        public VendorList[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VendorList[])(this.results[0]));
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