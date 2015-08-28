using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.Data.SQLite;

namespace PowerPOS
{
    public class Param
    {
        public static SQLiteConnection SQLiteConnection;
        public static CloudStorageAccount AzureStorageAccount;
        public static CloudTableClient AzureTableClient;

    }
}
