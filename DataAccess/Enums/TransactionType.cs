using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace DataAccess.Enums;

[JsonConverter(typeof(StringEnumConverter))]
public enum TransactionType
{
    Payment,
    Credit
}