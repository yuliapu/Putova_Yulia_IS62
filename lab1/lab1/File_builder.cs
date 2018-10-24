using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    abstract class File_builder //класс Строителя. Предоставляет методы для сборки частей объекта - файла и создает сам файл
    {
        public File File { get; private set; }

       public void CreateFile()
       {
             File = new File();
        
       }
       
        public abstract void SetPath();
        public abstract void SetResolution();
        public abstract void SetName();
        public abstract void Touch();
    }
}
