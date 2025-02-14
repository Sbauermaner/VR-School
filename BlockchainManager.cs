using Nethereum; // Библиотека для работы с Ethereum
using UnityEngine;

public class BlockchainManager : MonoBehaviour
{
    private string contractAddress = "0x123...";
    private string privateKey = "YOUR_PRIVATE_KEY";

    public async void StoreCertificateHash(string studentId, string hash)
    {
        var web3 = new Web3("https://mainnet.infura.io/v3/YOUR_PROJECT_ID");
        var contract = web3.Eth.GetContract(ABI, contractAddress);
        var function = contract.GetFunction("storeHash");

        var transactionHash = await function.SendTransactionAsync(
            privateKey,
            studentId,
            hash
        );

        Debug.Log($"Хеш записан в блокчейн: {transactionHash}");
    }
}
