using System.Text;

namespace TronScanApi;

public static class Extension
{
    public static void PrintTransactionRisk(this Root root)
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"Состояние транзакции: {root.contractRet}")
                     .AppendLine($"Наличие риска: {root.riskTransaction}")
                     .AppendLine("Адреса:")
                     .AppendLine($"\t{root.normalAddressInfo.TVBkD4V2qmLGAoQjBgMEDoPihaYgEtiLau}")
                     .AppendLine($"\tРиск: {root.normalAddressInfo.TVBkD4V2qmLGAoQjBgMEDoPihaYgEtiLau.risk}")
                     .AppendLine($"\t{root.normalAddressInfo.TQ793kg2ckYZtbRcUQLfTLwtccCQgGuMyk}")
                     .AppendLine($"\tРиск: {root.normalAddressInfo.TQ793kg2ckYZtbRcUQLfTLwtccCQgGuMyk.risk}");

        stringBuilder.AppendLine("Список пакетов и адресов:");

        foreach (var confirm in root.srConfirmList)
        {
            stringBuilder.AppendLine($"\tАдрес: {confirm.address}")
                         .AppendLine($"\tИмя: {confirm.name}")
                         .AppendLine($"\tBlock: {confirm.block}")
                         .AppendLine($"\tURL: {confirm.url}");
        }

        // Выводим собранный текст
        Console.WriteLine(stringBuilder);
    }
}
