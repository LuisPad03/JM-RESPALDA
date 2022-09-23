using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

public class _7Zip
{
    public string ruta7zip = "";
    public string error = string.Empty;
    public string ruta = string.Empty;

    public _7Zip()
    {
        ruta = Environment.CurrentDirectory;
        if (Environment.Is64BitOperatingSystem) ruta7zip = "";
        else ruta7zip = "";
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

