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

namespace MsDynamicsTest.MsNavGeneralLedgerEntries {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="GeneralLedgerEntries_Binding", Namespace="urn:microsoft-dynamics-schemas/page/generalledgerentries")]
    public partial class GeneralLedgerEntries_Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ReadOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReadByRecIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReadMultipleOperationCompleted;
        
        private System.Threading.SendOrPostCallback IsUpdatedOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRecIdFromKeyOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GeneralLedgerEntries_Service() {
            this.Url = global::MsDynamicsTest.Properties.Settings.Default.MsDynamicsTest_MsNavGeneralLedgerEntries_GeneralLedgerEntries_Service;
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/generalledgerentries:Read", RequestNamespace="urn:microsoft-dynamics-schemas/page/generalledgerentries", ResponseElementName="Read_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/generalledgerentries", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("GeneralLedgerEntries")]
        public GeneralLedgerEntries Read(int Entry_No) {
            object[] results = this.Invoke("Read", new object[] {
                        Entry_No});
            return ((GeneralLedgerEntries)(results[0]));
        }
        
        /// <remarks/>
        public void ReadAsync(int Entry_No) {
            this.ReadAsync(Entry_No, null);
        }
        
        /// <remarks/>
        public void ReadAsync(int Entry_No, object userState) {
            if ((this.ReadOperationCompleted == null)) {
                this.ReadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadOperationCompleted);
            }
            this.InvokeAsync("Read", new object[] {
                        Entry_No}, this.ReadOperationCompleted, userState);
        }
        
        private void OnReadOperationCompleted(object arg) {
            if ((this.ReadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReadCompleted(this, new ReadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/generalledgerentries:ReadByRecId", RequestNamespace="urn:microsoft-dynamics-schemas/page/generalledgerentries", ResponseElementName="ReadByRecId_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/generalledgerentries", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("GeneralLedgerEntries")]
        public GeneralLedgerEntries ReadByRecId(string recId) {
            object[] results = this.Invoke("ReadByRecId", new object[] {
                        recId});
            return ((GeneralLedgerEntries)(results[0]));
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/generalledgerentries:ReadMultiple", RequestNamespace="urn:microsoft-dynamics-schemas/page/generalledgerentries", ResponseElementName="ReadMultiple_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/generalledgerentries", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ReadMultiple_Result")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public GeneralLedgerEntries[] ReadMultiple([System.Xml.Serialization.XmlElementAttribute("filter")] GeneralLedgerEntries_Filter[] filter, string bookmarkKey, int setSize) {
            object[] results = this.Invoke("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize});
            return ((GeneralLedgerEntries[])(results[0]));
        }
        
        /// <remarks/>
        public void ReadMultipleAsync(GeneralLedgerEntries_Filter[] filter, string bookmarkKey, int setSize) {
            this.ReadMultipleAsync(filter, bookmarkKey, setSize, null);
        }
        
        /// <remarks/>
        public void ReadMultipleAsync(GeneralLedgerEntries_Filter[] filter, string bookmarkKey, int setSize, object userState) {
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/generalledgerentries:IsUpdated", RequestNamespace="urn:microsoft-dynamics-schemas/page/generalledgerentries", ResponseElementName="IsUpdated_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/generalledgerentries", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/generalledgerentries:GetRecIdFromKey", RequestNamespace="urn:microsoft-dynamics-schemas/page/generalledgerentries", ResponseElementName="GetRecIdFromKey_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/generalledgerentries", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/generalledgerentries")]
    public partial class GeneralLedgerEntries {
        
        private string keyField;
        
        private System.DateTime posting_DateField;
        
        private bool posting_DateFieldSpecified;
        
        private Document_Type document_TypeField;
        
        private bool document_TypeFieldSpecified;
        
        private string document_NoField;
        
        private string g_L_Account_NoField;
        
        private string g_L_Account_NameField;
        
        private string descriptionField;
        
        private string job_NoField;
        
        private string global_Dimension_1_CodeField;
        
        private string global_Dimension_2_CodeField;
        
        private string iC_Partner_CodeField;
        
        private Gen_Posting_Type gen_Posting_TypeField;
        
        private bool gen_Posting_TypeFieldSpecified;
        
        private string gen_Bus_Posting_GroupField;
        
        private string gen_Prod_Posting_GroupField;
        
        private decimal amountField;
        
        private bool amountFieldSpecified;
        
        private decimal additional_Currency_AmountField;
        
        private bool additional_Currency_AmountFieldSpecified;
        
        private decimal vAT_AmountField;
        
        private bool vAT_AmountFieldSpecified;
        
        private Bal_Account_Type bal_Account_TypeField;
        
        private bool bal_Account_TypeFieldSpecified;
        
        private string bal_Account_NoField;
        
        private string user_IDField;
        
        private string source_CodeField;
        
        private string reason_CodeField;
        
        private bool reversedField;
        
        private bool reversedFieldSpecified;
        
        private int reversed_by_Entry_NoField;
        
        private bool reversed_by_Entry_NoFieldSpecified;
        
        private int reversed_Entry_NoField;
        
        private bool reversed_Entry_NoFieldSpecified;
        
        private FA_Entry_Type fA_Entry_TypeField;
        
        private bool fA_Entry_TypeFieldSpecified;
        
        private int fA_Entry_NoField;
        
        private bool fA_Entry_NoFieldSpecified;
        
        private int entry_NoField;
        
        private bool entry_NoFieldSpecified;
        
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Posting_Date {
            get {
                return this.posting_DateField;
            }
            set {
                this.posting_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Posting_DateSpecified {
            get {
                return this.posting_DateFieldSpecified;
            }
            set {
                this.posting_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Document_Type Document_Type {
            get {
                return this.document_TypeField;
            }
            set {
                this.document_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Document_TypeSpecified {
            get {
                return this.document_TypeFieldSpecified;
            }
            set {
                this.document_TypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Document_No {
            get {
                return this.document_NoField;
            }
            set {
                this.document_NoField = value;
            }
        }
        
        /// <remarks/>
        public string G_L_Account_No {
            get {
                return this.g_L_Account_NoField;
            }
            set {
                this.g_L_Account_NoField = value;
            }
        }
        
        /// <remarks/>
        public string G_L_Account_Name {
            get {
                return this.g_L_Account_NameField;
            }
            set {
                this.g_L_Account_NameField = value;
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
        public string Job_No {
            get {
                return this.job_NoField;
            }
            set {
                this.job_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Global_Dimension_1_Code {
            get {
                return this.global_Dimension_1_CodeField;
            }
            set {
                this.global_Dimension_1_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Global_Dimension_2_Code {
            get {
                return this.global_Dimension_2_CodeField;
            }
            set {
                this.global_Dimension_2_CodeField = value;
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
        public Gen_Posting_Type Gen_Posting_Type {
            get {
                return this.gen_Posting_TypeField;
            }
            set {
                this.gen_Posting_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Gen_Posting_TypeSpecified {
            get {
                return this.gen_Posting_TypeFieldSpecified;
            }
            set {
                this.gen_Posting_TypeFieldSpecified = value;
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
        public string Gen_Prod_Posting_Group {
            get {
                return this.gen_Prod_Posting_GroupField;
            }
            set {
                this.gen_Prod_Posting_GroupField = value;
            }
        }
        
        /// <remarks/>
        public decimal Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Additional_Currency_Amount {
            get {
                return this.additional_Currency_AmountField;
            }
            set {
                this.additional_Currency_AmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Additional_Currency_AmountSpecified {
            get {
                return this.additional_Currency_AmountFieldSpecified;
            }
            set {
                this.additional_Currency_AmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal VAT_Amount {
            get {
                return this.vAT_AmountField;
            }
            set {
                this.vAT_AmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VAT_AmountSpecified {
            get {
                return this.vAT_AmountFieldSpecified;
            }
            set {
                this.vAT_AmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Bal_Account_Type Bal_Account_Type {
            get {
                return this.bal_Account_TypeField;
            }
            set {
                this.bal_Account_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Bal_Account_TypeSpecified {
            get {
                return this.bal_Account_TypeFieldSpecified;
            }
            set {
                this.bal_Account_TypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Bal_Account_No {
            get {
                return this.bal_Account_NoField;
            }
            set {
                this.bal_Account_NoField = value;
            }
        }
        
        /// <remarks/>
        public string User_ID {
            get {
                return this.user_IDField;
            }
            set {
                this.user_IDField = value;
            }
        }
        
        /// <remarks/>
        public string Source_Code {
            get {
                return this.source_CodeField;
            }
            set {
                this.source_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Reason_Code {
            get {
                return this.reason_CodeField;
            }
            set {
                this.reason_CodeField = value;
            }
        }
        
        /// <remarks/>
        public bool Reversed {
            get {
                return this.reversedField;
            }
            set {
                this.reversedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReversedSpecified {
            get {
                return this.reversedFieldSpecified;
            }
            set {
                this.reversedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int Reversed_by_Entry_No {
            get {
                return this.reversed_by_Entry_NoField;
            }
            set {
                this.reversed_by_Entry_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Reversed_by_Entry_NoSpecified {
            get {
                return this.reversed_by_Entry_NoFieldSpecified;
            }
            set {
                this.reversed_by_Entry_NoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int Reversed_Entry_No {
            get {
                return this.reversed_Entry_NoField;
            }
            set {
                this.reversed_Entry_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Reversed_Entry_NoSpecified {
            get {
                return this.reversed_Entry_NoFieldSpecified;
            }
            set {
                this.reversed_Entry_NoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public FA_Entry_Type FA_Entry_Type {
            get {
                return this.fA_Entry_TypeField;
            }
            set {
                this.fA_Entry_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FA_Entry_TypeSpecified {
            get {
                return this.fA_Entry_TypeFieldSpecified;
            }
            set {
                this.fA_Entry_TypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int FA_Entry_No {
            get {
                return this.fA_Entry_NoField;
            }
            set {
                this.fA_Entry_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FA_Entry_NoSpecified {
            get {
                return this.fA_Entry_NoFieldSpecified;
            }
            set {
                this.fA_Entry_NoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int Entry_No {
            get {
                return this.entry_NoField;
            }
            set {
                this.entry_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Entry_NoSpecified {
            get {
                return this.entry_NoFieldSpecified;
            }
            set {
                this.entry_NoFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/generalledgerentries")]
    public enum Document_Type {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Payment,
        
        /// <remarks/>
        Invoice,
        
        /// <remarks/>
        Credit_Memo,
        
        /// <remarks/>
        Finance_Charge_Memo,
        
        /// <remarks/>
        Reminder,
        
        /// <remarks/>
        Refund,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/generalledgerentries")]
    public enum Gen_Posting_Type {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Purchase,
        
        /// <remarks/>
        Sale,
        
        /// <remarks/>
        Settlement,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/generalledgerentries")]
    public enum Bal_Account_Type {
        
        /// <remarks/>
        G_L_Account,
        
        /// <remarks/>
        Customer,
        
        /// <remarks/>
        Vendor,
        
        /// <remarks/>
        Bank_Account,
        
        /// <remarks/>
        Fixed_Asset,
        
        /// <remarks/>
        IC_Partner,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/generalledgerentries")]
    public enum FA_Entry_Type {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Fixed_Asset,
        
        /// <remarks/>
        Maintenance,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/generalledgerentries")]
    public partial class GeneralLedgerEntries_Filter {
        
        private GeneralLedgerEntries_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        public GeneralLedgerEntries_Fields Field {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/generalledgerentries")]
    public enum GeneralLedgerEntries_Fields {
        
        /// <remarks/>
        Posting_Date,
        
        /// <remarks/>
        Document_Type,
        
        /// <remarks/>
        Document_No,
        
        /// <remarks/>
        G_L_Account_No,
        
        /// <remarks/>
        G_L_Account_Name,
        
        /// <remarks/>
        Description,
        
        /// <remarks/>
        Job_No,
        
        /// <remarks/>
        Global_Dimension_1_Code,
        
        /// <remarks/>
        Global_Dimension_2_Code,
        
        /// <remarks/>
        IC_Partner_Code,
        
        /// <remarks/>
        Gen_Posting_Type,
        
        /// <remarks/>
        Gen_Bus_Posting_Group,
        
        /// <remarks/>
        Gen_Prod_Posting_Group,
        
        /// <remarks/>
        Amount,
        
        /// <remarks/>
        Additional_Currency_Amount,
        
        /// <remarks/>
        VAT_Amount,
        
        /// <remarks/>
        Bal_Account_Type,
        
        /// <remarks/>
        Bal_Account_No,
        
        /// <remarks/>
        User_ID,
        
        /// <remarks/>
        Source_Code,
        
        /// <remarks/>
        Reason_Code,
        
        /// <remarks/>
        Reversed,
        
        /// <remarks/>
        Reversed_by_Entry_No,
        
        /// <remarks/>
        Reversed_Entry_No,
        
        /// <remarks/>
        FA_Entry_Type,
        
        /// <remarks/>
        FA_Entry_No,
        
        /// <remarks/>
        Entry_No,
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
        public GeneralLedgerEntries Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GeneralLedgerEntries)(this.results[0]));
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
        public GeneralLedgerEntries Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GeneralLedgerEntries)(this.results[0]));
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
        public GeneralLedgerEntries[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GeneralLedgerEntries[])(this.results[0]));
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