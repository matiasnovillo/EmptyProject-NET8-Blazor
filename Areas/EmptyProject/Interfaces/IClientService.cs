using EmptyProject.Areas.EmptyProject.Entities;
using EmptyProject.Areas.EmptyProject.DTOs;
using System.Data;

/*
 * GUID:e6c09dfe-3a3e-461b-b3f9-734aee05fc7b
 * 
 * Coded by fiyistack.com
 * Copyright © 2024
 * 
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
 */

namespace EmptyProject.Areas.EmptyProject.Interfaces
{
    public interface IClientService
    {
        void ExportToExcel(string Path, DataTable dtClient);

        void ExportToCSV(string Path, List<Client> lstClient);

        void ExportToPDF(string Path, List<Client> lstClient);

        List<Client> ImportExcel(string Path);
    }
}