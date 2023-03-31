using System;
using System.Collections.Generic;

namespace CryptoAirdropChecker
{
    class Wallet
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Token { get; set; }
        public bool IsEligible { get; set; }

        public Wallet(string name, string address, string token)
        {
            Name = name;
            Address = address;
            Token = token;
            IsEligible = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Wallet> wallets = new List<Wallet>();

            // add wallets
            wallets.Add(new Wallet("MyEtherWallet", "0x1234567890123456789012345678901234567890", "ETH"));
            wallets.Add(new Wallet("MetaMask", "0x2345678901234567890123456789012345678901", "UNI"));
            wallets.Add(new Wallet("Ledger Nano S", "0x3456789012345678901234567890123456789012", "BTC"));

            Console.WriteLine("Crypto Airdrop Checker");

            // check eligibility for each wallet
            foreach (Wallet wallet in wallets)
            {
                // check eligibility logic here
                bool isEligible = CheckEligibility(wallet.Address, wallet.Token);

                wallet.IsEligible = isEligible;

                Console.WriteLine(wallet.Name + " (" + wallet.Token + "): " + (isEligible ? "Eligible" : "Not Eligible"));
            }

            Console.ReadLine();
        }

        static bool CheckEligibility(string address, string token)
        {
            // logic to check eligibility for given address and token
            // return true if eligible, false if not eligible
            // example logic for ETH airdrop eligibility check
            if (token == "ETH" && address.StartsWith("0x"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

