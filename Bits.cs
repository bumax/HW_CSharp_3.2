using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB
{
    public interface IBits
    {
        public abstract static T SetBit<T>(T var, int index, bool value) where T : new();

    }
    public class Bits:IBits
    {
        public static T SetBit<T>(T val, int index, bool value) where T : new()
        {
            switch (Type.GetTypeCode(val.GetType()))
            {
                case TypeCode.Int64:
                    return (T)Convert.ChangeType((Convert.ToInt64(val) | Convert.ToInt64(value) << index), typeof(T));
                case TypeCode.Int32:
                    return (T)Convert.ChangeType((Convert.ToInt32(val) | Convert.ToInt32(value) << index), typeof(T));
                case TypeCode.Byte:
                    return (T)Convert.ChangeType((Convert.ToByte(val) | Convert.ToByte(value) << index), typeof(T));
                default:
                    return default(T);
            }
            
        }
    }
}
