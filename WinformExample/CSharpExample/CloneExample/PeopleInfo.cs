using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloneExample.Interface;

namespace CloneExample
{
   public  class PeopleInfo : ShallowClone<PeopleInfo>
    {
        private string name = string.Empty;
        private int age = 0;
        public PeopleInfo Clone()
        {
            return this.Clone();
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
                if (age <= 0)
                    throw new Exception("年龄必须大于零");
                this.age = value;
            }
        }
#endregion
    }
}
