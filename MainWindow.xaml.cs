using MsDynamicsTest.Areass;
using MsDynamicsTest.Boms;
using MsDynamicsTest.CompanyInfo;
using MsDynamicsTest.Currencies;
using MsDynamicsTest.CustomerLists;
using MsDynamicsTest.InventoryPickss;
using MsDynamicsTest.InvPostingGroups;
using MsDynamicsTest.ItemLists;
using MsDynamicsTest.Languages;
using MsDynamicsTest.LocationLists;
using MsDynamicsTest.MsNav;
using MsDynamicsTest.MsNavAnalysisReportInventory;
using MsDynamicsTest.MsNavAnalysisViewListInventory;
using MsDynamicsTest.MsNavInventoryAnalysisLines;
using MsDynamicsTest.MsNavInventoryAnalysisMatrix;
using MsDynamicsTest.MsNavInventoryAnalysisReport;
using MsDynamicsTest.MsNavInventoryGLReconciliation2;
using MsDynamicsTest.MsNavInventoryPeriodEntries;
using MsDynamicsTest.MsNavInventoryPeriods;
using MsDynamicsTest.MsNavInventoryPostingSetup;
using MsDynamicsTest.MsNavInventoryPutAway;
using MsDynamicsTest.MsNavInventoryReportEntry;
using MsDynamicsTest.MsNavInvSetup;
using MsDynamicsTest.MsNavReportSelectionInv;
using MsDynamicsTest.PhysInvJournal;
using MsDynamicsTest.PhysInvLedgerEntries;
using MsDynamicsTest.PurchaseLists;
using MsDynamicsTest.PurchaseOrders;
using System;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web.Services.Protocols;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MsDynamicsTest.MsNavVendorList;
using MsDynamicsTest.MsNavVendorCard;
using MsDynamicsTest.MsNavCustomerPriceGroups;
using MsDynamicsTest.MsNavUsers;
using MsDynamicsTest.MsNavItemCard;
using MsDynamicsTest.MsNavSalesOrder;
using MsDynamicsTest.MsNavBlanketSalesOrder;
using System.Collections.Generic;
using MsDynamicsTest.MsNavGeneralLedgerEntries;
using System.Globalization;
using System.Threading;
using System.Windows.Markup;
using MsDynamicsTest.MsNavCustomerLedgerEntries;
using MsDynamicsTest.MsNavVendorLedgerEntries;
using MsDynamicsTest.MsNavItemLedgerEntries;
using MsDynamicsTest.MsNavSalesList;
using MsDynamicsTest.MsNavSalesLines;
using System.Text.RegularExpressions;
using System.Windows.Input;
using MsDynamicsTest.MsProdOrderLineList;

namespace MsDynamicsTest
{
    public partial class MainWindow : Window
    {
        class SalesOrderWrapper : SalesOrder
        {
            public SalesOrderWrapper(SalesOrder target)
            {
                CopyHelper.Copy(target, this);
            }

            public int SalesLinesCount
            {
                get
                {
                    return SalesLines.Length;
                }
            }
        }

        enum ServiceType
        {
            CompanyInfo,

            CustomerCard,

            Currencies,

            Languages,

            CustomerList,

            LocationList,

            ItemList,

            ItemCard,

            Bom,

            PurchaseOrder,

            PurchaseList,

            InventoryPicks,

            Areas,

            InventoryPostingGroups,

            PhysInventoryLedgerEntries,

            PhysInventoryJournal,

            InventorySetup,

            ReportSelectionInventory,

            InventoryPostingSetup,

            InventoryPeriods,

            InventoryPeriodEntries,

            InventoryGLReconciliation,

            InventoryGLReconciliation2,

            InventoryReportEntry,

            InventoryAnalysisLines,

            InventoryAnalysisReport,

            InventoryPutAway,

            InventoryAnalysisMatrix,

            AnalysisViewListInventory,

            AnalysisReportInventory,

            VendorList,

            VendorCard,

            CustomerPriceGroups,

            Users,

            SalesOrder,

            BlanketSalesOrder,

            GeneralLedgerEntries,

            CustomerLedgerEntries,

            VendorLedgerEntries,

            ItemLedgerEntries,

            SalesList,

            SalesLines,

            ProdOrderLineList
        };

        public MainWindow()
        {
            InitializeComponent();
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(
                XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));

            serviceComboBox.Items.Add(ServiceType.CompanyInfo);
            serviceComboBox.Items.Add(ServiceType.CustomerCard);
            serviceComboBox.Items.Add(ServiceType.CustomerList);
            serviceComboBox.Items.Add(ServiceType.Currencies);
            serviceComboBox.Items.Add(ServiceType.Languages);
            serviceComboBox.Items.Add(ServiceType.LocationList);
            serviceComboBox.Items.Add(ServiceType.ItemList);
            serviceComboBox.Items.Add(ServiceType.ItemCard);
            serviceComboBox.Items.Add(ServiceType.Bom);
            serviceComboBox.Items.Add(ServiceType.PurchaseOrder);
            serviceComboBox.Items.Add(ServiceType.PurchaseList);
            serviceComboBox.Items.Add(ServiceType.Areas);
            serviceComboBox.Items.Add(ServiceType.InventoryPostingGroups);
            serviceComboBox.Items.Add(ServiceType.PhysInventoryLedgerEntries);
            serviceComboBox.Items.Add(ServiceType.PhysInventoryJournal);
            serviceComboBox.Items.Add(ServiceType.InventorySetup);
            serviceComboBox.Items.Add(ServiceType.ReportSelectionInventory);
            serviceComboBox.Items.Add(ServiceType.InventoryPostingSetup);
            serviceComboBox.Items.Add(ServiceType.InventoryPeriods);
            serviceComboBox.Items.Add(ServiceType.InventoryPeriodEntries);
            serviceComboBox.Items.Add(ServiceType.InventoryGLReconciliation);
            serviceComboBox.Items.Add(ServiceType.InventoryGLReconciliation2);
            serviceComboBox.Items.Add(ServiceType.InventoryReportEntry);
            serviceComboBox.Items.Add(ServiceType.InventoryAnalysisLines);
            serviceComboBox.Items.Add(ServiceType.InventoryAnalysisReport);
            serviceComboBox.Items.Add(ServiceType.InventoryPutAway);
            serviceComboBox.Items.Add(ServiceType.InventoryPicks);
            serviceComboBox.Items.Add(ServiceType.InventoryAnalysisMatrix);
            serviceComboBox.Items.Add(ServiceType.AnalysisViewListInventory);
            serviceComboBox.Items.Add(ServiceType.AnalysisReportInventory);
            serviceComboBox.Items.Add(ServiceType.VendorList);
            serviceComboBox.Items.Add(ServiceType.VendorCard);
            serviceComboBox.Items.Add(ServiceType.CustomerPriceGroups);
            serviceComboBox.Items.Add(ServiceType.Users);
            serviceComboBox.Items.Add(ServiceType.SalesOrder);
            serviceComboBox.Items.Add(ServiceType.BlanketSalesOrder);
            serviceComboBox.Items.Add(ServiceType.GeneralLedgerEntries);
            serviceComboBox.Items.Add(ServiceType.CustomerLedgerEntries);
            serviceComboBox.Items.Add(ServiceType.VendorLedgerEntries);
            serviceComboBox.Items.Add(ServiceType.ItemLedgerEntries);
            serviceComboBox.Items.Add(ServiceType.SalesList);
            serviceComboBox.Items.Add(ServiceType.SalesLines);
            serviceComboBox.Items.Add(ServiceType.ProdOrderLineList);

            serviceComboBox.SelectedIndex = 0;
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReadData();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ReadData()
        {
            int maxCount = int.Parse(maxCountTextBox.Text.Trim());
            string param = string.IsNullOrEmpty(paramTextBox.Text) ? null : paramTextBox.Text;

            switch ((ServiceType)serviceComboBox.SelectedItem)
            {
                case ServiceType.CustomerCard:
                    ReadCustomers();
                    break;
                case ServiceType.CustomerList:
                    ReadCustomerList();
                    break;
                case ServiceType.CompanyInfo:
                    ReadCompanyInfo();
                    break;
                case ServiceType.Currencies:
                    ReadCurrencies();
                    break;
                case ServiceType.Languages:
                    ReadLangs();
                    break;
                case ServiceType.LocationList:
                    ReadLocationList();
                    break;
                case ServiceType.ItemList:
                    ReadItemList(maxCount);
                    break;
                case ServiceType.ItemCard:
                    ReadItemCard(maxCount);
                    break;
                case ServiceType.Bom:
                    ReadBom(maxCount);
                    break;
                case ServiceType.PurchaseOrder:
                    ReadPurchaseOrder(maxCount);
                    break;
                case ServiceType.PurchaseList:
                    ReadPurchaseList(maxCount);
                    break;
                case ServiceType.Areas:
                    ReadAreas(maxCount);
                    break;
                case ServiceType.InventoryPicks:
                    ReadInventoryPicks(maxCount);
                    break;
                case ServiceType.InventoryPostingGroups:
                    ReadInventoryPostingGroups(maxCount);
                    break;
                case ServiceType.PhysInventoryLedgerEntries:
                    ReadPhysInventoryLedgerEntries(maxCount);
                    break;
                case ServiceType.PhysInventoryJournal:
                    ReadPhysInventoryJournal(maxCount, param);
                    break;
                case ServiceType.InventorySetup:
                    ReadInventorySetup(maxCount);
                    break;
                case ServiceType.ReportSelectionInventory:
                    ReadReportSelectionInventory(maxCount, param);
                    break;
                case ServiceType.InventoryPostingSetup:
                    ReadInventoryPostingSetup(maxCount);
                    break;
                case ServiceType.InventoryAnalysisLines:
                    ReadInventoryAnalysisLines(maxCount, param);
                    break;
                case ServiceType.InventoryPeriods:
                    ReadInventoryPeriods(maxCount);
                    break;
                case ServiceType.InventoryPeriodEntries:
                    ReadInventoryPeriodEntries(maxCount);
                    break;
                case ServiceType.InventoryGLReconciliation:
                    ReadInventoryGLReconciliation(maxCount);
                    break;
                case ServiceType.InventoryGLReconciliation2:
                    ReadInventoryGLReconciliation2(maxCount);
                    break;
                case ServiceType.InventoryReportEntry:
                    ReadInventoryReportEntry(maxCount);
                    break;
                case ServiceType.InventoryAnalysisReport:
                    ReadInventoryAnalysisReport(maxCount);
                    break;
                case ServiceType.InventoryPutAway:
                    ReadInventoryPutAway(maxCount);
                    break;
                case ServiceType.InventoryAnalysisMatrix:
                    ReadInventoryAnalysisMatrix(maxCount);
                    break;
                case ServiceType.AnalysisViewListInventory:
                    ReadAnalysisViewListInventory(maxCount);
                    break;
                case ServiceType.AnalysisReportInventory:
                    ReadAnalysisReportInventory(maxCount);
                    break;
                case ServiceType.VendorList:
                    ReadVendorList(maxCount);
                    break;
                case ServiceType.VendorCard:
                    ReadVendorCard(maxCount);
                    break;
                case ServiceType.CustomerPriceGroups:
                    ReadCustomerPriceGroups(maxCount);
                    break;
                case ServiceType.Users:
                    ReadUsers(maxCount);
                    break;
                case ServiceType.SalesOrder:
                    ReadSalesOrder(maxCount);
                    break;
                case ServiceType.BlanketSalesOrder:
                    ReadBlanketSalesOrder(maxCount);
                    break;
                case ServiceType.GeneralLedgerEntries:
                    ReadGeneralLedgerEntries(maxCount);
                    break;
                case ServiceType.CustomerLedgerEntries:
                    ReadCustomerLedgerEntries(maxCount);
                    break;
                case ServiceType.VendorLedgerEntries:
                    ReadVendorLedgerEntries(maxCount);
                    break;
                case ServiceType.ItemLedgerEntries:
                    ReadItemLedgerEntries(maxCount);
                    break;
                case ServiceType.SalesList:
                    ReadSalesList(maxCount);
                    break;
                case ServiceType.SalesLines:
                    ReadSalesLines(maxCount);
                    break;
                case ServiceType.ProdOrderLineList:
                    ReadProdOrderLineList(maxCount);
                    break;
                default:
                    MessageBox.Show("Not supported: " + serviceComboBox.SelectedItem.ToString(), "Warning",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    break;
            }
        }

        void ReadProdOrderLineList(int maxCount)
        {
            var service = new ProdOrderLineList_Service();
            ConfigService(service);

            ProdOrderLineList[] po = service.ReadMultiple(null, null, maxCount);

            FillData("ProdOrderLineList", po);
        }

        void ReadSalesLines(int maxCount)
        {
            var service = new SalesLines_Service();
            ConfigService(service);

            SalesLines[] po = service.ReadMultiple(null, null, maxCount);

            FillData("SalesLines", po);
        }

        void ReadSalesList(int maxCount)
        {
            var service = new SalesList_Service();
            ConfigService(service);

            SalesList[] po = service.ReadMultiple(null, null, maxCount);

            FillData("SalesList", po);
        }

        void ReadItemLedgerEntries(int maxCount)
        {
            var service = new ItemLedgerEntries_Service();
            ConfigService(service);

            ItemLedgerEntries[] po = service.ReadMultiple(null, null, maxCount);

            FillData("ItemLedgerEntries", po);
        }

        void ReadVendorLedgerEntries(int maxCount)
        {
            var service = new VendorLedgerEntries_Service();
            ConfigService(service);

            VendorLedgerEntries[] po = service.ReadMultiple(null, null, maxCount);

            FillData("VendorLedgerEntries", po);
        }

        void ReadCustomerLedgerEntries(int maxCount)
        {
            var service = new CustomerLedgerEntries_Service();
            ConfigService(service);

            CustomerLedgerEntries[] po = service.ReadMultiple(null, null, maxCount);

            FillData("CustomerLedgerEntries", po);
        }

        void ReadGeneralLedgerEntries(int maxCount)
        {
            var service = new GeneralLedgerEntries_Service();
            ConfigService(service);

            GeneralLedgerEntries[] po = service.ReadMultiple(null, null, maxCount);

            FillData("GeneralLedgerEntries", po);
        }

        void ReadBlanketSalesOrder(int maxCount)
        {
            var service = new BlanketSalesOrder_Service();
            ConfigService(service);

            BlanketSalesOrder[] po = service.ReadMultiple(null, null, maxCount);

            FillData("BlanketSalesOrder", po);
        }

        void ReadSalesOrder(int maxCount)
        {
            var service = new SalesOrder_Service();
            ConfigService(service);

            SalesOrder[] po = service.ReadMultiple(null, null, maxCount).Select(p => new SalesOrderWrapper(p)).ToArray();

            FillData("SalesOrder", po);
        }

        void ReadUsers(int maxCount)
        {
            var service = new Users_Service();
            ConfigService(service);

            Users[] po = service.ReadMultiple(null, null, maxCount);

            FillData("Users", po);
        }

        void ReadCustomerPriceGroups(int maxCount)
        {
            var service = new CustomerPriceGroups_Service();
            ConfigService(service);

            CustomerPriceGroups[] po = service.ReadMultiple(null, null, maxCount);

            FillData("CustomerPriceGroups", po);
        }

        void ReadVendorCard(int maxCount)
        {
            var service = new VendorCard_Service();
            ConfigService(service);

            VendorCard[] po = service.ReadMultiple(null, null, maxCount);

            FillData("VendorCard", po);
        }

        void ReadVendorList(int maxCount)
        {
            var service = new VendorList_Service();
            ConfigService(service);

            VendorList[] po = service.ReadMultiple(null, null, maxCount);

            FillData("VendorList", po);
        }

        void ReadAnalysisReportInventory(int maxCount)
        {
            var service = new AnalysisReportInventory_Service();
            ConfigService(service);

            AnalysisReportInventory[] po = service.ReadMultiple(null, null, maxCount);

            FillData("AnalysisReportInventory", po);
        }

        void ReadAnalysisViewListInventory(int maxCount)
        {
            var service = new AnalysisViewListInventory_Service();
            ConfigService(service);

            AnalysisViewListInventory[] po = service.ReadMultiple(null, null, maxCount);

            FillData("AnalysisViewListInventory", po);
        }

        void ReadInventoryGLReconciliation2(int maxCount)
        {
            var service = new InventoryGLReconciliation2_Service();
            ConfigService(service);

            InventoryGLReconciliation2[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventoryGLReconciliation2", po);
        }

        void ReadInventoryAnalysisMatrix(int maxCount)
        {
            var service = new InventoryAnalysisMatrix_Service();
            ConfigService(service);

            InventoryAnalysisMatrix[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventoryAnalysisMatrix", po);
        }

        void ReadInventoryPutAway(int maxCount)
        {
            var service = new InventoryPutAway_Service();
            ConfigService(service);

            InventoryPutAway[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventoryPutAway", po);
        }

        void ReadInventoryAnalysisReport(int maxCount)
        {
            var service = new InventoryAnalysisReport_Service();
            ConfigService(service);

            InventoryAnalysisReport[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventoryAnalysisReport", po);
        }

        void ReadInventoryAnalysisLines(int maxCount, string param)
        {
            var service = new InventoryAnalysisLines_Service();
            ConfigService(service);

            InventoryAnalysisLines[] po = service.ReadMultiple(param, null, null, maxCount);

            FillData("InventoryAnalysisLines", po);
        }

        void ReadInventoryReportEntry(int maxCount)
        {
            var service = new InventoryReportEntry_Service();
            ConfigService(service);

            InventoryReportEntry[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventoryReportEntry", po);
        }

        void ReadInventoryGLReconciliation(int maxCount)
        {
            var service = new InventoryPeriodEntries_Service();
            ConfigService(service);

            InventoryPeriodEntries[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventoryGLReconciliation", po);
        }

        void ReadInventoryPeriodEntries(int maxCount)
        {
            var service = new InventoryPeriodEntries_Service();
            ConfigService(service);

            InventoryPeriodEntries[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventoryPeriodEntries", po);
        }

        void ReadInventoryPeriods(int maxCount)
        {
            var service = new InventoryPeriods_Service();
            ConfigService(service);

            InventoryPeriods[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventoryPeriods", po);
        }

        void ReadInventoryPostingSetup(int maxCount)
        {
            var service = new InventoryPostingSetup_Service();
            ConfigService(service);

            InventoryPostingSetup[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventoryPostingSetup", po);
        }

        void ReadReportSelectionInventory(int maxCount, string param)
        {
            var service = new ReportSelectionInventory_Service();
            ConfigService(service);

            ReportSelectionInventory[] po = service.ReadMultiple(param, null, null, maxCount);

            FillData("ReportSelectionInventory", po);
        }

        void ReadInventorySetup(int maxCount)
        {
            var service = new InventorySetup_Service();
            ConfigService(service);

            InventorySetup[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventorySetup", po);
        }

        void ReadPhysInventoryJournal(int maxCount, string param)
        {
            var service = new PhysInventoryJournal_Service();
            ConfigService(service);

            PhysInventoryJournal[] po = service.ReadMultiple(param, null, null, maxCount);

            FillData("PhysInventoryJournal", po);

        }

        void ReadPhysInventoryLedgerEntries(int maxCount)
        {
            var service = new PhysInventoryLedgerEntries_Service();
            ConfigService(service);

            PhysInventoryLedgerEntries[] po = service.ReadMultiple(null, null, maxCount);

            FillData("PhysInventoryLedgerEntries", po);
        }

        private void ConfigService(WebClientProtocol service)
        {
            service.Url = CalcUrl(service.Url);
            service.UseDefaultCredentials = false;
            service.Credentials = new NetworkCredential(Properties.Settings.Default.ApiLogin, Properties.Settings.Default.ApiPassword);
        }

        private string CalcUrl(string urlTest)
        {
            var splitted = urlTest.Split('/');

            if (splitted.Length > 2)
            {
                return String.Format("{0}/{1}/{2}", Properties.Settings.Default.ApiUrl, splitted[splitted.Length - 2], splitted[splitted.Length - 1]);
            }

            throw new InvalidOperationException("Invalid api url");
        }

        private bool SearchFilter(object obj, string text, IList<PropertyInfo> props)
        {   
            if (text.Length > 0)
            {
                text = text.ToLower();
                Regex regx = null;
                Regex regxValue = new Regex("^" + text + "$", RegexOptions.IgnoreCase);

                if (text.Contains('='))
                {
                    var splitted = text.Split('=');
                    var name = splitted[0].Trim();
                    text = splitted[1].Trim();

                    regxValue = new Regex("^" + text + "$", RegexOptions.IgnoreCase);

                    if (name.Length > 0)
                    {
                        regx = new Regex("^" + name + "$", RegexOptions.IgnoreCase);
                    }
                }                

                foreach (var prop in props.Where(p => regx == null || regx.IsMatch(p.Name)))
                {
                    var val = prop.GetValue(obj);                    

                    if (val != null)
                    {
                        string str = val != null ? val.ToString() : string.Empty;

                        if (str.Length > 0 && regxValue.IsMatch(str))
                        {
                            return true;
                        }
                    }
                }

                return false;
            }

            return true;
        }

        private void FillData(string name, object[] po)
        {
            var parent = new TreeViewItem();
            parent.Header = string.Format("{0}: {1} items", name, po.Length);

            tree.Items.Add(parent);

            if (po.Length > 0)
            {
                Func<PropertyInfo, bool> predicate = (p) =>
                    {
                        if (ShowAllCheckBox.IsChecked == true)
                        {
                            return true;
                        }

                        return !(p.Name.EndsWith("Specified") || p.Name == "Key");
                    };


                ListView listView = new ListView();
                parent.Items.Add(listView);
                GridView grid = new GridView();
                listView.View = grid;
                var props = po[0].GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => predicate(p))
                    .ToList();
                var dateType = typeof(DateTime);

                Func<PropertyInfo, PropertyInfo, int> comparisonProps = (p1, p2) =>
                {
                    if (p1 == p2)
                    {
                        return 0;
                    }

                    if (p1.Name == "No")
                    {
                        return -1;
                    }

                    if (p2.Name == "No")
                    {
                        return 1;
                    }

                    int? res = CompareProps(p1, p2, p => p.Name.Contains("Status"));

                    if (res.HasValue)
                    {
                        return res.Value;
                    }

                    if (p1.Name == "Quantity")
                    {
                        return -1;
                    }

                    if (p2.Name == "Quantity")
                    {
                        return 1;
                    }

                    res = CompareProps(p1, p2, p => p.Name.EndsWith("Quantity"));

                    if (res.HasValue)
                    {
                        return res.Value;
                    }

                    res = CompareProps(p1, p2, p => p.Name.EndsWith("No"));

                    if (res.HasValue)
                    {
                        return res.Value;
                    }

                    res = CompareProps(p1, p2, p => p.PropertyType.Equals(dateType));

                    if (res.HasValue)
                    {
                        return res.Value;
                    }

                    return p1.Name.CompareTo(p2.Name);
                };

                props.Sort((p1, p2) => comparisonProps(p1, p2));

                foreach (var prop in props)
                {
                    grid.Columns.Add(new GridViewColumn() { Header = new TextBlock() { Text = prop.Name }, DisplayMemberBinding = new Binding(prop.Name) });
                }

                PropertyInfo modifiedProp = props.FirstOrDefault(p => p.Name.Contains("Modified") && p.PropertyType.Equals(typeof(DateTime)));

                Func<object, object, int> comparison = (p1, p2) =>
                {
                    if (modifiedProp != null)
                    {
                        var d1 = (DateTime)modifiedProp.GetValue(p1);
                        var d2 = (DateTime)modifiedProp.GetValue(p2);

                        return -d1.CompareTo(d2);
                    }

                    return 0;
                };

                var searchText = paramTextBox.Text.Trim();
                var list = po.Where(p => SearchFilter(p, searchText, props)).ToList();
                parent.Header = string.Format("{0}: {1} items/{2} fields", name, list.Count, props.Count);

                list.Sort((p1, p2) => comparison(p1, p2));

                foreach (var info in list)
                {
                    listView.Items.Add(info);
                }
            }
        }

        private int? CompareProps(PropertyInfo p1, PropertyInfo p2, Func<PropertyInfo, bool> handler)
        {
            var no1 = handler(p1);
            var no2 = handler(p2);

            if (no1 || no2)
            {
                if (!(no1 && no2))
                {
                    if (no1)
                    {
                        return -1;
                    }

                    return 1;
                }

                return p1.Name.CompareTo(p2.Name);
            }

            return (int?)null;
        }

        void ReadInventoryPostingGroups(int maxCount)
        {
            var service = new InventoryPostingGroups_Service();
            ConfigService(service);

            InventoryPostingGroups[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventoryPostingGroups", po);
        }

        void ReadInventoryPicks(int maxCount)
        {
            var service = new InventoryPicks_Service();
            ConfigService(service);

            InventoryPicks[] po = service.ReadMultiple(null, null, maxCount);

            FillData("InventoryPicks", po);
        }

        void ReadPurchaseList(int maxCount)
        {
            var service = new PurchaseList_Service();
            ConfigService(service);

            PurchaseList[] po = service.ReadMultiple(null, null, maxCount);

            FillData("PurchaseList", po);
        }

        void ReadAreas(int maxCount)
        {
            var service = new Areas_Service();
            ConfigService(service);

            Areas[] po = service.ReadMultiple(null, null, maxCount);

            FillData("Areas", po);
        }

        void ReadPurchaseOrder(int maxCount)
        {
            var service = new PurchaseOrder_Service();
            ConfigService(service);

            PurchaseOrder[] po = service.ReadMultiple(null, null, maxCount);

            FillData("PurchaseOrder", po);
        }


        void ReadBom(int maxCount)
        {
            var service = new Bom_Service();
            ConfigService(service);

            Bom[] boms = service.ReadMultiple(null, null, maxCount);

            FillData("Bom", boms);
        }

        void ReadItemList(int maxCount)
        {
            var service = new ItemList_Service();
            ConfigService(service);

            ItemList[] items = service.ReadMultiple(null, null, maxCount);

            FillData("ItemList", items);
        }

        void ReadItemCard(int maxCount)
        {
            var service = new ItemCard_Service();
            ConfigService(service);

            ItemCard[] items = service.ReadMultiple(null, null, maxCount);

            FillData("ItemCard", items);
        }

        void ReadLocationList()
        {
            var service = new LocationList_Service();
            ConfigService(service);

            LocationList[] locationLists = service.ReadMultiple(null, null, 100);

            FillData("LocationList", locationLists);
        }

        void ReadCustomerList()
        {
            var service = new CustomerList_Service();
            ConfigService(service);

            CustomerList[] customerLists = service.ReadMultiple(null, null, 100);

            FillData("CustomerList", customerLists);
        }

        void ReadLangs()
        {
            Languages_Service service = new Languages_Service();
            ConfigService(service);

            Languages.Languages[] langs = service.ReadMultiple(null, null, 100);

            FillData("Languages", langs);
        }

        void ReadCurrencies()
        {
            Currencies_Service service = new Currencies_Service();
            ConfigService(service);

            Currencies.Currencies[] currencies = service.ReadMultiple(null, null, 100);

            FillData("Currencies", currencies);
        }

        void ReadCompanyInfo()
        {
            CompanyInfo_Service service = new CompanyInfo_Service();
            ConfigService(service);

            CompanyInfo.CompanyInfo[] infos = service.ReadMultiple(new CompanyInfo_Filter[0], null, 100);

            FillData("CompanyInfo", infos);
        }

        void ReadCustomers()
        {
            Customer_Service service = new Customer_Service();
            ConfigService(service);

            // Run the actual search.
            Customer[] list = service.ReadMultiple(null, null, 100);

            FillData("Customer", list);
        }

        void AddObject(TreeViewItem item, object obj, PropertyInfo[] properties, int index)
        {
            var child = new TreeViewItem();
            child.Header = "Item " + index;
            item.Items.Add(child);

            foreach (var property in properties)
            {
                var value = property.GetValue(obj);

                StackPanel panel = new StackPanel()
                {
                    Orientation = Orientation.Horizontal
                };
                panel.Children.Add(new TextBlock() { Text = property.Name, Margin = new Thickness(3), VerticalAlignment = VerticalAlignment.Center });
                panel.Children.Add(new TextBlock()
                {
                    Text = value != null ? value.ToString() : "null",
                    FontWeight = FontWeights.Bold,
                    VerticalAlignment = VerticalAlignment.Center
                });

                child.Items.Add(panel);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            tree.Items.Clear();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(paramTextBox.Text.Trim()))
            {
                MessageBox.Show("Input param", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            WrapException(() =>
            {
                var service = new ItemCard_Service();
                ConfigService(service);
                ItemCard item = new ItemCard()
                {
                    No = paramTextBox.Text.Trim()
                };

                service.Create(ref item);

                item.Description = item.No + " -Description";

                service.Update(ref item);

                MessageBox.Show("Successfully created!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            });
        }

        private void WrapException(Action action)
        {
            try
            {
                action();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(paramTextBox.Text.Trim()))
            {
                MessageBox.Show("Input param", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            WrapException(() =>
            {
                var service = new ItemCard_Service();
                ConfigService(service);
                var item = service.ReadMultiple(null, null, 100000).FirstOrDefault(p => p.No == paramTextBox.Text.Trim());

                if (item != null)
                {
                    service.Delete(item.Key);
                    MessageBox.Show("Successfully deleted!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Item not found!", "Success", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            });
        }

        private void paramTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ExecuteButton_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
