namespace TronScanApi;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class AddressTag
{
}

public class ContractData
{
    public int amount { get; set; }
    public string asset_name { get; set; }
    public string owner_address { get; set; }
    public string to_address { get; set; }
    public TokenInfo tokenInfo { get; set; }
}

public class ContractInfo
{
}

public class ContractMap
{
    public bool TVBkD4V2qmLGAoQjBgMEDoPihaYgEtiLau { get; set; }
    public bool TQ793kg2ckYZtbRcUQLfTLwtccCQgGuMyk { get; set; }
}

public class Cost
{
    public int net_fee_cost { get; set; }
    public int date_created { get; set; }
    public int fee { get; set; }
    public int energy_fee_cost { get; set; }
    public int net_usage { get; set; }
    public int multi_sign_fee { get; set; }
    public int net_fee { get; set; }
    public int energy_penalty_total { get; set; }
    public int energy_usage { get; set; }
    public int energy_fee { get; set; }
    public int energy_usage_total { get; set; }
    public int memoFee { get; set; }
    public int origin_energy_usage { get; set; }
    public int account_create_fee { get; set; }
}

public class Info
{
}

public class InternalTransactions
{
}

public class NormalAddressInfo
{
    public TVBkD4V2qmLGAoQjBgMEDoPihaYgEtiLau TVBkD4V2qmLGAoQjBgMEDoPihaYgEtiLau { get; set; }
    public TQ793kg2ckYZtbRcUQLfTLwtccCQgGuMyk TQ793kg2ckYZtbRcUQLfTLwtccCQgGuMyk { get; set; }
}

public class Root
{
    public ContractMap contract_map { get; set; }
    public string contractRet { get; set; }
    public string data { get; set; }
    public ContractInfo contractInfo { get; set; }
    public int contractType { get; set; }
    public string toAddress { get; set; }
    public bool confirmed { get; set; }
    public int block { get; set; }
    public bool riskTransaction { get; set; }
    public long timestamp { get; set; }
    public Info info { get; set; }
    public NormalAddressInfo normalAddressInfo { get; set; }
    public Cost cost { get; set; }
    public int noteLevel { get; set; }
    public AddressTag addressTag { get; set; }
    public bool revert { get; set; }
    public int confirmations { get; set; }
    public TriggerInfo trigger_info { get; set; }
    public List<object> signature_addresses { get; set; }
    public string ownerAddress { get; set; }
    public List<SrConfirmList> srConfirmList { get; set; }
    public string hash { get; set; }
    public ContractData contractData { get; set; }
    public InternalTransactions internal_transactions { get; set; }
}

public class SrConfirmList
{
    public string address { get; set; }
    public string name { get; set; }
    public int block { get; set; }
    public string url { get; set; }
}

public class TokenInfo
{
    public string tokenLevel { get; set; }
    public string tokenId { get; set; }
    public string tokenName { get; set; }
    public int tokenDecimal { get; set; }
    public string tokenAbbr { get; set; }
    public int tokenCanShow { get; set; }
    public string tokenType { get; set; }
    public bool vip { get; set; }
    public string tokenLogo { get; set; }
}

public class TQ793kg2ckYZtbRcUQLfTLwtccCQgGuMyk
{
    public bool risk { get; set; }
}

public class TriggerInfo
{
}

public class TVBkD4V2qmLGAoQjBgMEDoPihaYgEtiLau
{
    public bool risk { get; set; }
}
