using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApplication.Models
{
    public class Coins
    {
        public int Id { get; set; }
        public string Coin { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public object Message { get; set; }
    }

    public class CoinData
    {
        public string ID_COIN { get; set; }

        public DateTime REF_DATE { get; set; }
    }

    public class CoinQuote
    {
        public string ID_COIN { get; set; }

        public int QUOTE_COD { get; set; }
    }

    public class QuoteDate
    {
        public decimal QUOTE_PRICE { get; set; }

        public int QUOTE_COD { get; set; }

        public DateTime QUOTE_DATE { get; set; }
    }

    public class QuoteCoinResult
    {
        public string ID_COIN { get; set; }
        public DateTime REF_DATE { get; set; }
        public decimal QUOTE_PRICE { get; set; }
    }

    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class root
    {

        private rootElement[] elementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("element")]
        public rootElement[] element
        {
            get
            {
                return this.elementField;
            }
            set
            {
                this.elementField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootElement
    {

        private string iD_COINField;

        private byte qUOTE_CODField;

        /// <remarks/>
        public string ID_COIN
        {
            get
            {
                return this.iD_COINField;
            }
            set
            {
                this.iD_COINField = value;
            }
        }

        /// <remarks/>
        public byte QUOTE_COD
        {
            get
            {
                return this.qUOTE_CODField;
            }
            set
            {
                this.qUOTE_CODField = value;
            }
        }
    }


}
