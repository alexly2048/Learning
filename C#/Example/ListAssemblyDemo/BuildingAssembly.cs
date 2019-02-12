using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ListAssemblyDemo
{
    public class BuildingAssembly
    {
        public void BuildDependecntAssembly(string path,StringCollection assemblies)
        {
            if(assemblies == null)
            {
                assemblies = new StringCollection();
            }
            if (assemblies.Contains(path) == true)
                return;
            try
            {
                Assembly asm = null;
                if (path.IndexOf(@"\",0,path.Length,StringComparison.Ordinal) != -1 ||
                        path.IndexOf(@"/",0,path.Length,StringComparison.Ordinal) != -1){
                    // 给定路径，从路径中加载程序集
                    asm = Assembly.LoadFrom(path);
                }
                else
                {
                    // 尝试用于程序集名称
                    asm = Assembly.Load(path);
                }
                // 将程序集添加到列表中
                if (asm != null)
                {
                    assemblies.Add(path);
                }
                // 获得引用的程序集
                AssemblyName[] imports = asm.GetReferencedAssemblies();

                foreach (AssemblyName asmName in imports)
                {
                    // 递归调用此程序集以获得它引用的新模块
                    BuildDependecntAssembly(asmName.FullName, assemblies);
                }
            }catch(FileLoadException fle)
            {
                Console.WriteLine(fle);
            }
        }
    }
}
