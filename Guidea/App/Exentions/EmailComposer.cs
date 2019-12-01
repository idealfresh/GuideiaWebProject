using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Exentions
{
    public static class EmailComposer
    {
        public static string Compose(this string msg,string name,string phoneNumber)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {name}");
            sb.AppendLine($"Phone Number: {phoneNumber}");
            sb.AppendLine();
            sb.AppendLine(msg);

            return sb.ToString();
        }
    }
}
