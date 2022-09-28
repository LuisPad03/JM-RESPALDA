using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

public class _7Zip
{
    public string ruta7zip = "";
    public string error = "";

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
            if (Directory.Exists(carpetaComprimir) && Directory.Exists(carpetaDestino))
            {
                DateTime todaysdate;
                todaysdate = DateTime.Now;
                string zipName = "BackUp" + "-" + todaysdate.Year.ToString() + "-"
                   + todaysdate.Month.ToString() + "-" + todaysdate.Day.ToString() + "_"
                   + todaysdate.Hour.ToString() + "-"
                   + todaysdate.Minute.ToString() + "-"
                   + todaysdate.Second.ToString() + ".zip";

                ProcessStartInfo p = new ProcessStartInfo();
                p.FileName = ruta7zip;  /*Ruta del .exe del 7zip C:\Program Files\7-Zip\7z.exe*/
                p.Arguments = "a -t7z \"" + carpetaDestino + "\\" + zipName + "\" \"" + carpetaComprimir + "\" -mx=" + nivelCompresion.ToString(); /*-mx="nivel de compresion"*/
                p.WindowStyle = ProcessWindowStyle.Hidden;
                Process x = Process.Start(p);
                x.WaitForExit();

                return true;
            }
            else 
            {
                error = "Ruta(s) no encontrada(s):";
                error = !Directory.Exists(carpetaComprimir) ? error + "\n\n" + carpetaComprimir : error + "";
                error = !Directory.Exists(carpetaDestino) ? error + "\n\n" + carpetaDestino : error;
                
                return false;
            }
        }
        catch (Exception e)
        {
            error = e.Message;
            return false;
        }
        
    }

    public bool ComprimeArchivo(string archivoComprimir, string archivoDestino, int nivelCompresion)
    {
        try
        {
            if (File.Exists(archivoComprimir) && File.Exists(archivoDestino))
            {
                DateTime todaysdate;
                todaysdate = DateTime.Now;
                string zipName = "BackUp" + "-" + todaysdate.Year.ToString() + "-"
                   + todaysdate.Month.ToString() + "-" + todaysdate.Day.ToString() + "_"
                   + todaysdate.Hour.ToString() + "-"
                   + todaysdate.Minute.ToString() + "-"
                   + todaysdate.Second.ToString() + ".zip";

                ProcessStartInfo p = new ProcessStartInfo();
                p.FileName = ruta7zip;  /*Ruta del .exe del 7zip C:\Program Files\7-Zip\7z.exe*/
                p.Arguments = "a -tgzip \"" + archivoDestino + "\\" + zipName + "\" \"" + archivoComprimir + "\" -mx=" + nivelCompresion.ToString(); /*-mx="nivel de compresion"*/
                p.WindowStyle = ProcessWindowStyle.Hidden;
                Process x = Process.Start(p);
                x.WaitForExit();

                return true;
            }
            else
            {
                error = "Ruta(s) no encontrada(s):";
                error = !File.Exists(archivoComprimir) ? error + "\n\n" + archivoComprimir : error + "";
                error = !File.Exists(archivoDestino) ? error + "\n\n" + archivoDestino : error;

                return false;
            }
            
        }
        catch (Exception e)
        {
            error = e.Message;
            return false;
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
            error = e.Message;
            return false;
        }
    }

}

