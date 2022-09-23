using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

public class _7Zip
{
    public string ruta7zip = "";
    public string error = string.Empty;

    public _7Zip()
    {
        //string carpeta7zip = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "7Zip\\x64\\7z.exe");

        //string dirName = AppDomain.CurrentDomain.BaseDirectory; // Starting Dir
        //FileInfo fileInfo = new FileInfo(dirName);
        //DirectoryInfo parentDir = fileInfo.Directory.Parent;
        //string parentDirName = parentDir.FullName; // Parent of Starting Dir
        //FileInfo fileInfo2 = new FileInfo(parentDirName);
        //DirectoryInfo parentDir2 = fileInfo2.Directory.Parent;
        //string parentDirName2 = parentDir2.FullName; // Parent of Starting Dir

        //string path = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.FullName;

        //string fullimagepath = Path.Combine(Application.StartupPath, "7Zip\\x64\\7z.exe");

        ruta7zip = @"E:\Source\Repos\JM-RESPALDA\JM-RESPALDA\7Zip\x64\7z.exe";

        //if (Environment.Is64BitOperatingSystem) ruta7zip = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "7Zip\\x64\\7z.exe");
        //else ruta7zip = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "7Zip\\x86\\7z.exe");

    }

    public bool ComprimeCarpeta(string carpetaComprimir, string carpetaDestino, int nivelCompresion)
    {
        
        try
        {            
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = ruta7zip;  /*Ruta del .exe del 7zip C:\Program Files\7-Zip\7z.exe*/
            p.Arguments = "a -t7z \"" + carpetaDestino + "\" \"" + carpetaComprimir + "\" -mx=" + nivelCompresion.ToString(); /*-mx="nivel de compresion"*/
            p.WindowStyle = ProcessWindowStyle.Hidden;
            Process x = Process.Start(p);
            x.WaitForExit();

            return true;
        }
        catch (Exception e)
        {
            return false;
            error = e.Message;
        }
        
    }

    public bool ComprimeArchivo(string archivoComprimir, string archivoDestino, int nivelCompresion)
    {
        try
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = ruta7zip;  /*Ruta del .exe del 7zip C:\Program Files\7-Zip\7z.exe*/
            p.Arguments = "a -tgzip \"" + archivoDestino + "\" \"" + archivoComprimir + "\" -mx=" + nivelCompresion.ToString(); /*-mx="nivel de compresion"*/
            p.WindowStyle = ProcessWindowStyle.Hidden;
            Process x = Process.Start(p);
            x.WaitForExit();

            return true;
        }
        catch (Exception e)
        {
            return false;
            error = e.Message;
        }

    }

    public bool ExtractFile(string archivo7zip, string carpetaDestino)
    {
        if (!Directory.Exists(carpetaDestino))
            Directory.CreateDirectory(carpetaDestino);

        string zPath = ruta7zip;
        try
        {
            ProcessStartInfo pro = new ProcessStartInfo();
            pro.WindowStyle = ProcessWindowStyle.Hidden;
            pro.FileName = zPath;
            pro.Arguments = "x \"" + archivo7zip + "\" -o" + carpetaDestino;
            Process x = Process.Start(pro);
            x.WaitForExit();

            return true;
        }
        catch (Exception e)
        {
            return false;
            error = e.Message;
        }
    }

}

