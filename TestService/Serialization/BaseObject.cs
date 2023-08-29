using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data.SqlTypes;
using System.Runtime.Serialization;
using System.Reflection;
using System.Security.Principal;
using Newtonsoft.Json;

namespace TestService.Serialization
{
    [Serializable]
    public class BaseObject
    {
        private string _name;

        private Type _classType;

        public string Name 
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _name = _classType.Name;
                }
                _name = value;
            }
        }

        [JsonIgnore]
        public bool IsLeafInfo
        {
            get
            {
                return Properties == null || Properties.Count == 0;
            }
        }

        [JsonIgnore]
        public virtual Dictionary<string, object> ToInfoDictionary
        {
            get
            {
                var retVal = new Dictionary<string, object>();
                //just return the empty dictionary if this is a leaf
                if (IsLeafInfo)
                {
                    return retVal;
                }
                //add object properties defined in the class that should be serialized into this object
                var propInfo = ClassType.GetProperties();
                if (propInfo != null)
                {
                    foreach (PropertyInfo classProp in propInfo)
                    {
                        if (classProp.GetCustomAttributes(typeof(SerializableProp), false).Any())
                        {
                            object? val = classProp.GetValue(this, null);
                            if (val != null)
                            {
                                retVal.Add(classProp.Name, val);
                            }
                        }
                    }
                }
                //add the properties that are not explicity defined on the class
                /*foreach (string name in Properties.Keys)
                {
                    retVal.Add()
                }*/
                return retVal;
            }
        }

        [JsonIgnore]
        public Type ClassType { get => _classType; }

        public string ClassName { get => ClassType.Name; }

        public string AssemblyClassName { get => ClassType.FullName; }

        public virtual Dictionary<string, object> Data { get => ToInfoDictionary; }

        public Dictionary<string, object> Properties { get; }

        public BaseObject()
        {
            _classType = GetType();
            _name = _classType.Name;
            Properties = new Dictionary<string, object>();
        }
    }

    [Serializable]
    public class BaseObject<T> : BaseObject
    {
        public T? Value { get; set; } = default;
    }

}
