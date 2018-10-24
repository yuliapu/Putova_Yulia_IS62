using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1
{
    class RTF_builder : File_builder //класс конкретного строителя .rtf файлов. Содержит конкретные реализации методов File_builder
    {
        public override void SetPath()
        {
            Console.WriteLine("ENTER PATH\n1.Default '.../lab1/lab1/bin/Debug'\n2.Enter manually");
            string n = Console.ReadLine();

            switch (n)
            {
                case "1":
                    this.File.Path = System.IO.Path.Combine(@"", this.File.Name);
                    break;
                case "2":
                    string path = Console.ReadLine();
                    System.IO.Directory.CreateDirectory(path);
                    this.File.Path = System.IO.Path.Combine(path, this.File.Name) ;
                    break;
            }

        }

        public override void SetName()
        {
            Console.WriteLine("ENTER FILENAME");
            this.File.Name =  Console.ReadLine() + this.File.Resolution;


        }

        public override void SetResolution()
        {
            this.File.Resolution =  ".rtf";
        }
        public override void Touch()
        {

            if (!System.IO.File.Exists(this.File.Path))
            {
                System.IO.FileStream fs = System.IO.File.Create(this.File.Path);
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", this.File.Name);
                return;
            }
        }
    }
}
