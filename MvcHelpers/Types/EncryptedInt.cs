using MvcHelpers.Types.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcHelpers.Types
{
    public struct EncryptedInt  //: IComparable, IFormattable, IConvertible, IComparable<int>, IEquatable<int>
    {

       
        public EncryptedInt(int n)
        {
            _value = n;
        }
        public EncryptedInt(string encryptedValue)
        {
            _value = 0;
            if (!string.IsNullOrWhiteSpace(encryptedValue))
            {
                int intValue = EncryptHelper.Decrypt(encryptedValue);
                _value = intValue;
            }
        }

        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
            }
        }

        public string Encrypted { get { return GetEncryptedValue(); } }

        private string GetEncryptedValue()
        {
            return _value > 0 ? EncryptHelper.Encrypt(_value) : "";
        }

        public static implicit operator EncryptedInt(int value)
        {
            EncryptedInt a = new EncryptedInt();
            a._value = value;
            return a;
        }

        public static implicit operator int(EncryptedInt value)
        {
            return value._value;
        }

        public static implicit operator string(EncryptedInt value)
        {
            return value.ToString();
        }

        public override string ToString()
        {
            return GetEncryptedValue();
        }
    }
}