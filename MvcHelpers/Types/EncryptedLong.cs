using MvcHelpers.Types.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcHelpers.Types
{
    public struct EncryptedLong
    {
        public EncryptedLong(long n)
        {
            _value = n;
        }

        public EncryptedLong(string encryptedValue)
        {
            _value = 0;
            if (!string.IsNullOrWhiteSpace(encryptedValue))
            {
                long longValue = EncryptHelper.DecryptToLong(encryptedValue);
                _value = longValue;
            }
        }

        private long _value;

        public long Value
        {
            get { return _value; }
            set
            {
                _value = value;
            }
        }

        private string GetEncryptedValue()
        {
            return _value > 0 ? EncryptHelper.Encrypt(_value) : "";
        }

        public static implicit operator EncryptedLong(long value)
        {
            EncryptedLong a = new EncryptedLong();
            a._value = value;
            return a;
        }

        public static implicit operator long(EncryptedLong value)
        {
            return value._value;
        }

        public override string ToString()
        {
            return GetEncryptedValue();
        }
    }
}