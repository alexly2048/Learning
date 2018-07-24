using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using CloneExample.Interface;

namespace CloneExample
{
    [Serializable]
    public  class PeopleInfo : ShallowClone<PeopleInfo>,DeepClone<PeopleInfo>
    {
        private string name = string.Empty;
        private int age = 0;

        /// <summary>
        ///  利用Object.MemeberwiseClone()实现浅复制
        /// </summary>
        /// <returns></returns>
        public PeopleInfo ShallowClone()
        {           
            return (PeopleInfo)this.MemberwiseClone();
        }

        /// <summary>
        ///  利用MemoryStream()和BinaryFormatter()进行深度复制
        /// </summary>
        /// <returns></returns>
        public PeopleInfo DeepClone()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            try {
                bf.Serialize(memoryStream,this);
                memoryStream.Flush();
                memoryStream.Seek(0, SeekOrigin.Begin);
                return (PeopleInfo)bf.Deserialize(memoryStream);
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                memoryStream.Close();
                memoryStream.Dispose();
            }
        }
        #region Property
        public string Name
        {
            get{ return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name不能为NULL或空值.");
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                    throw new Exception("年龄必须大于零");
                this.age = value;
            }
        }
#endregion
    }
}
