﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NetWorkBackEnd
{
    public class ValueHolder
    {
        string IsrName = Environment.UserName;
        //dať si pozor na cestu pri najhoršom sa upraví 


        string FolderPath => $@"C:\\Users\\{IsrName}\\WebSwitcher";


        // it string FolderPath => $@"C:\\WebSwitcher";
 
        
        string FilePath => Path.Combine(FolderPath, "path.txt");

        public void CreateFiles()
        {
            if(!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);
            if(!File.Exists(FilePath))
                File.WriteAllText(FilePath, string.Empty);
        }
        public void WriteScript(string script)
        {
            File.WriteAllText(FilePath, script);

        }
        public String ReadScript()
        {
            if (File.Exists(FilePath))
                return File.ReadAllText(FilePath);
            else
                return string.Empty; 
        }
    }
} 
