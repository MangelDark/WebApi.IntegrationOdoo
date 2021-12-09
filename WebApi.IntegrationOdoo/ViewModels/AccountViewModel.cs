using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApi.IntegrationOdoo.ViewModels
{
  
    public class AccountViewModel { 

        // res.currency
        public long? CurrencyId { get; set; }

        // required
        public string Code { get; set; }

        public bool? Deprecated { get; set; }

        public bool? Used { get; set; }

        // account.account.type
        // required
        public long UserTypeId { get; set; }

        public InternalTypeAccountAccountOdooEnum? InternalType { get; set; }

        public InternalGroupAccountAccountOdooEnum? InternalGroup { get; set; }

        public bool? Reconcile { get; set; }

        // account.tax
        public long[] TaxIds { get; set; }

        public string Note { get; set; }

        // res.company
        // required
        public long CompanyId { get; set; }

        // account.account.tag
        public long[] TagIds { get; set; }

        // account.group
        public long? GroupId { get; set; }

        // account.root
        public long? RootId { get; set; }

        // account.journal
        public long[] AllowedJournalIds { get; set; }

        public decimal? OpeningDebit { get; set; }

        public decimal? OpeningCredit { get; set; }

        public decimal? OpeningBalance { get; set; }

        public bool? IsOffBalance { get; set; }

        // required
        public string Name { get; set; }

        // res.currency
        public long[] ExcludeProvisionCurrencyIds { get; set; }

        // account.asset
        public long? AssetModel { get; set; }

        // required
        public CreateAssetAccountAccountOdooEnum CreateAsset { get; set; }

        public bool? CanCreateAsset { get; set; }

        public string FormViewRef { get; set; }

        public AssetTypeAccountAccountOdooEnum? AssetType { get; set; }

        public bool? MultipleAssetsPerLine { get; set; }

        public long Id { get; set; }

        public string DisplayName { get; set; }

        // res.users
        public long? CreateUid { get; set; }

        public DateTime? CreateDate { get; set; }

        // res.users
        public long? WriteUid { get; set; }

        public DateTime? WriteDate { get; set; }

        public DateTime? LastUpdate { get; set; }
    }


    // The 'Internal Type' is used for features available on different types of accounts: liquidity type is for cash or bank accounts, payable/receivable is for vendor/customer accounts.
    public enum InternalTypeAccountAccountOdooEnum
    {
        [EnumMember(Value = "other")]
        Regular = 1,

        [EnumMember(Value = "receivable")]
        Receivable = 2,

        [EnumMember(Value = "payable")]
        Payable = 3,

        [EnumMember(Value = "liquidity")]
        Liquidity = 4,
    }


    // The 'Internal Group' is used to filter accounts based on the internal group set on the account type.
    public enum InternalGroupAccountAccountOdooEnum
    {
        [EnumMember(Value = "equity")]
        Equity = 1,

        [EnumMember(Value = "asset")]
        Asset = 2,

        [EnumMember(Value = "liability")]
        Liability = 3,

        [EnumMember(Value = "income")]
        Income = 4,

        [EnumMember(Value = "expense")]
        Expense = 5,

        [EnumMember(Value = "off_balance")]
        OffBalance = 6,
    }


    public enum CreateAssetAccountAccountOdooEnum
    {
        [EnumMember(Value = "no")]
        No = 1,

        [EnumMember(Value = "draft")]
        CreateInDraft = 2,

        [EnumMember(Value = "validate")]
        CreateAndValidate = 3,
    }


    public enum AssetTypeAccountAccountOdooEnum
    {
        [EnumMember(Value = "sale")]
        DeferredRevenue = 1,

        [EnumMember(Value = "expense")]
        DeferredExpense = 2,

        [EnumMember(Value = "purchase")]
        Asset = 3,
    }
}
