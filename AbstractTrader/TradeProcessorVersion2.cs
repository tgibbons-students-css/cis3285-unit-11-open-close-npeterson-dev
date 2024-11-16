using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTrader
{
    class TradeProcessorVersion2 : ITradeProcessor
    {

        public void ProcessTrades(Stream stream)
        {
            var tradeData = ReadTradeData(stream);
            var trades = ParseTrades(tradeData);
            StoreTrades(trades);
        }

        protected IEnumerable<string> ReadTradeData(Stream stream)
        {
            var tradeData = new List<string>();
            LogMessage("INFO: Simulating ReadTradeData version 2");
            return tradeData;
        }

        protected IEnumerable<TradeRecord> ParseTrades(IEnumerable<string> tradeData)
        {
            var trades = new List<TradeRecord>();
            LogMessage("INFO: Simulating ParseTrades version 2");
            return trades;
        }


        protected void StoreTrades(IEnumerable<TradeRecord> trades)
        {
            LogMessage("INFO: Simulating database connection in StoreTrades version 2");
            // Not really connecting to database in this sample
            LogMessage("INFO: {0} trades processed", trades.Count());
        }

        private void LogMessage(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }
}
