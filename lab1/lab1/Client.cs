using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Director //класс распорядителя. Работает с файлом через File_builder
    {

        private int files_count; //количество создаваемых файлов
        public File create(File_builder file_builder)
        {
            
                file_builder.CreateFile();  
                file_builder.SetResolution(); 
                file_builder.SetName();
                file_builder.SetPath();
                file_builder.Touch();
                return file_builder.File;
            }
        public void hello() //выбор конкретного строителя: с каким расширением будут создаваться файлы
        {
            bool flag = true;           
            while (flag)
            {
               
                files_count = count();
                Console.WriteLine("CHOOSE FILE RESOLUTION\n1.doc\n2.txt\n3.jpeg\n4.rtf\n");
                string answ = Console.ReadLine();
                switch (answ)
                {
                    case "1":
                        {
                            File_builder docbuilder = new DOC_builder();
                            for (int i = 0; i < files_count; i++)
                            {
                                File docfile = create(docbuilder);
                                Console.WriteLine("File created!");
                            }
                        } break;
                    case "2":
                        {
                            File_builder txtbuilder = new TXT_builder();
                            for (int i = 0; i < files_count; i++)
                            {
                                File docfile = create(txtbuilder);
                                Console.WriteLine("File created!");
                            }
                        } break;
                    case "3":
                        {
                            File_builder jpegbuilder = new JPEG_builder();
                            for (int i = 0; i < files_count; i++)
                            {
                                File docfile = create(jpegbuilder);
                                Console.WriteLine("File created!");
                            }
                        } break;
                    case "4":
                        {
                            File_builder rtfbuilder = new RTF_builder(); 
                            for (int i = 0; i < files_count; i++)
                            {
                                File docfile = create(rtfbuilder);
                                Console.WriteLine("File created!");
                            }
                        } break;
                    case "e": flag = false; break;
                    default: Console.WriteLine("Try again"); break;

                } 
                Console.WriteLine("Continue?(y/n)");
                answ = Console.ReadLine(); if (answ != "y") flag = false;
                            }
        }
        public int count() //выбор количества создаваемых файлов
        {
            Console.WriteLine("ENTER NUMBER OF FILES");
            do {
                try {
                    files_count = Convert.ToInt32(Console.ReadLine());
                    break;
                    }
                catch (FormatException){
                    Console.WriteLine("Please enter integer");
                    }
            }
            while (true);
          if (files_count < 0) { files_count *= -1; }
          return files_count;
        }
    }
}
