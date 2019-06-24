using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library.Extension
{
    public static class Extensions
    {
        public static T Changer<T>(this object source)
        {
            //T Tipinde instance oluştur ve onu oluşan instance'ı yine T tipinde bir değişkene ata
            T target = Activator.CreateInstance<T>();

            Type targetType = target.GetType();
            PropertyInfo[] targetProperties = targetType.GetProperties();

            Type sourceType = source.GetType();
            PropertyInfo[] sourceProperties = sourceType.GetProperties();

            foreach (PropertyInfo pInf in sourceProperties)
            {
                object value = pInf.GetValue(source);
                PropertyInfo targetpInf = targetProperties.FirstOrDefault(x => x.Name == pInf.Name);
                if (targetpInf != null)
                {
                    targetpInf.SetValue(target, value);
                }
            }
            return target;
        }
    }
}
