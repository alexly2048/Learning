using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ListAssemblyDemo
{
    public static class AssemblyExtend
    {

    

        public static IEnumerable<MemberInfo> GetMembersInAssembly(this Assembly asm, string memberName) =>
from type in asm.GetTypes()
from ms in type.GetMember(memberName, MemberTypes.All, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance)
select ms;

    public static IEnumerable<MemberInfo> GetSerializableTypes(this Assembly asm) =>
        from type in asm.GetTypes()
        where type.IsSerializable && !type.IsNestedPrivate
        select type;
}
}
