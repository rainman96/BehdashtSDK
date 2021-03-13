using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.Helper
{
    internal class Data
    {


        internal Data(byte[] b)
        {
            this._MaxBytes = 0;
            this._MinBytes = 0;
            this._StepBytes = 0;
            this.Encoding = Data.DefaultEncoding;
            this._b = b;
        }

        internal Data(string s, Encoding encoding)
        {
            this._MaxBytes = 0;
            this._MinBytes = 0;
            this._StepBytes = 0;
            this.Encoding = Data.DefaultEncoding;
            this.Encoding = encoding;
            this.Text = s;
        }

        internal byte[] Bytes
        {
            get
            {
                checked
                {
                    if (this._MaxBytes > 0 && this._b.Length > this._MaxBytes)
                    {
                        byte[] array = new byte[this._MaxBytes - 1 + 1];
                        Array.Copy(this._b, array, array.Length);
                        this._b = array;
                    }
                    if (this._MinBytes > 0 && this._b.Length < this._MinBytes)
                    {
                        byte[] array2 = new byte[this._MinBytes - 1 + 1];
                        Array.Copy(this._b, array2, this._b.Length);
                        this._b = array2;
                    }
                    return this._b;
                }
            }
            set
            {
                this._b = value;
            }
        }
        internal string Text
        {
            get
            {
                if (this._b == null)
                {
                    return "";
                }
                int num = Array.IndexOf<byte>(this._b, 0);
                if (num >= 0)
                {
                    return this.Encoding.GetString(this._b, 0, num);
                }
                return this.Encoding.GetString(this._b);
            }
            set
            {
                this._b = this.Encoding.GetBytes(value);
            }
        }

        private byte[] _b;

        private int _MaxBytes;

        private int _MinBytes;

        private int _StepBytes;

        public static Encoding DefaultEncoding;

        public Encoding Encoding;
    }
}
