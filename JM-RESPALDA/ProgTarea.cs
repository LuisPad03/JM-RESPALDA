using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;


public class ProgTarea
{
    private string nombreTarea = "", descripcionTarea = "", autor = "", fechaPrimerEjecucion = "", fechaExpiracion = "", periodicidad = "";
    public string error = "";
    public int diames = 1;
    public DaysOfTheWeek diaSemana;
    public DaysOfTheWeek[] diasSemana;

    public ProgTarea(string nombreTarea, string descripcionTarea, string autor, string fechaPrimerEjecucion, string periodicidad)
    {
        this.nombreTarea = nombreTarea;
        this.descripcionTarea = descripcionTarea;
        this.autor = autor;
        this.fechaPrimerEjecucion = fechaPrimerEjecucion;
        this.periodicidad = periodicidad;
    }

    public bool CreaTarea()
    {
        try
        {
            TaskService ts = new TaskService();
            TaskDefinition td = ts.NewTask();
            td.RegistrationInfo.Description = descripcionTarea;
            td.RegistrationInfo.Author = autor;
            CultureInfo cultinfo = new CultureInfo("es-MX");
            DateTime startDate = Convert.ToDateTime(fechaPrimerEjecucion, cultinfo); //30/09/2022 04:50:00 PM
            //DateTime EndDate = Convert.ToDateTime(fechaExpiracion, cultinfo); //30/10/2022 12:10:15 AM
            switch (periodicidad)
            {
                case "Diario":
                    Trigger(td, startDate, DaysOfTheWeek.AllDays);
                    break;
                case "Semanal":
                    Trigger(td, startDate, diaSemana);
                    break;
                case "Mensual":
                    td.Triggers.Add(new MonthlyTrigger
                    {
                        StartBoundary = startDate,
                        MonthsOfYear = MonthsOfTheYear.AllMonths,
                        DaysOfMonth = new int[] { diames },
                        //EndBoundary = EndDate,
                        Enabled = true
                    });
                    break;
                case "Personalizado":
                    foreach(DaysOfTheWeek dia in diasSemana)
                    {
                        Trigger(td, startDate, dia);
                    }
                    break;

                default:                    
                    break;
            }
            //td.Actions.Add(new ExecAction("notepad.exe", @"C:\Program Files\Notepad++\notepad++.exe", null));
            td.Actions.Add(new ExecAction(@"C:\Program Files\Notepad++\notepad++.exe", null));

            var folder = TaskService.Instance.RootFolder;
            string archivotxt = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegTaskFolders.txt");
            if (!File.Exists(archivotxt))
            {
                using (StreamWriter sw = File.CreateText(archivotxt)) //Crea el archivo
                {
                    sw.WriteLine("JM-SUC"); //Escribe nombre de carpeta
                }
                var folderCreate = TaskService.Instance.RootFolder.CreateFolder("JM-SUC");
                folder = folderCreate;
            }
            else
            {
                var folderExist = TaskService.Instance.GetFolder("JM-SUC");
                folder = folderExist;
            }

            folder.RegisterTaskDefinition(nombreTarea, td);
            return true;
        }
        catch(Exception e)
        {
            error = e.Message;
            return false;
        }
                
    }

    private void Trigger(TaskDefinition td, DateTime startDate, DaysOfTheWeek dia)
    {        
        td.Triggers.Add(new WeeklyTrigger
        {
            StartBoundary = startDate,
            DaysOfWeek = dia,
            //EndBoundary = EndDate, 
            Enabled = true
        });
    }

}
