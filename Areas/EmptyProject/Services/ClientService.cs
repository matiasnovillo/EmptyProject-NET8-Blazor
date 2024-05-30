﻿using ClosedXML.Excel;
using IronPdf;
using CsvHelper;
using EmptyProject.Areas.EmptyProject.Entities;
using EmptyProject.Areas.EmptyProject.Interfaces;
using System.Data;
using System.Globalization;

namespace EmptyProject.Areas.EmptyProject.Services
{
    public class ClientService : IClientService
    {
        #region Exportations
        public void ExportToExcel(string Path, DataTable dtClient)
        {
            using var Book = new XLWorkbook();

            DataTable dtClientOriginal = new DataTable();
            dtClientOriginal.TableName = "Client";

            //We define another DataTable dtClientCopy to avoid issue related to DateTime conversion
            DataTable dtClientCopy = new DataTable();
            dtClientCopy.TableName = "Client";

            #region Define columns for dtClientCopy
            DataColumn dtColumnClientIdFordtClientCopy = new DataColumn();
            dtColumnClientIdFordtClientCopy.DataType = typeof(string);
            dtColumnClientIdFordtClientCopy.ColumnName = "ClientId";
            dtClientCopy.Columns.Add(dtColumnClientIdFordtClientCopy);

            DataColumn dtColumnActiveFordtClientCopy = new DataColumn();
            dtColumnActiveFordtClientCopy.DataType = typeof(string);
            dtColumnActiveFordtClientCopy.ColumnName = "Active";
            dtClientCopy.Columns.Add(dtColumnActiveFordtClientCopy);

            DataColumn dtColumnDateTimeCreationFordtClientCopy = new DataColumn();
            dtColumnDateTimeCreationFordtClientCopy.DataType = typeof(string);
            dtColumnDateTimeCreationFordtClientCopy.ColumnName = "DateTimeCreation";
            dtClientCopy.Columns.Add(dtColumnDateTimeCreationFordtClientCopy);

            DataColumn dtColumnDateTimeLastModificationFordtClientCopy = new DataColumn();
            dtColumnDateTimeLastModificationFordtClientCopy.DataType = typeof(string);
            dtColumnDateTimeLastModificationFordtClientCopy.ColumnName = "DateTimeLastModification";
            dtClientCopy.Columns.Add(dtColumnDateTimeLastModificationFordtClientCopy);

            DataColumn dtColumnUserCreationIdFordtClientCopy = new DataColumn();
            dtColumnUserCreationIdFordtClientCopy.DataType = typeof(string);
            dtColumnUserCreationIdFordtClientCopy.ColumnName = "UserCreationId";
            dtClientCopy.Columns.Add(dtColumnUserCreationIdFordtClientCopy);

            DataColumn dtColumnUserLastModificationIdFordtClientCopy = new DataColumn();
            dtColumnUserLastModificationIdFordtClientCopy.DataType = typeof(string);
            dtColumnUserLastModificationIdFordtClientCopy.ColumnName = "UserLastModificationId";
            dtClientCopy.Columns.Add(dtColumnUserLastModificationIdFordtClientCopy);

            DataColumn dtColumnBooleanFordtClientCopy = new DataColumn();
            dtColumnBooleanFordtClientCopy.DataType = typeof(string);
            dtColumnBooleanFordtClientCopy.ColumnName = "Boolean";
            dtClientCopy.Columns.Add(dtColumnBooleanFordtClientCopy);

            DataColumn dtColumnDateTimeFordtClientCopy = new DataColumn();
            dtColumnDateTimeFordtClientCopy.DataType = typeof(string);
            dtColumnDateTimeFordtClientCopy.ColumnName = "DateTime";
            dtClientCopy.Columns.Add(dtColumnDateTimeFordtClientCopy);

            DataColumn dtColumnDecimalFordtClientCopy = new DataColumn();
            dtColumnDecimalFordtClientCopy.DataType = typeof(string);
            dtColumnDecimalFordtClientCopy.ColumnName = "Decimal";
            dtClientCopy.Columns.Add(dtColumnDecimalFordtClientCopy);

            DataColumn dtColumnIntegerFordtClientCopy = new DataColumn();
            dtColumnIntegerFordtClientCopy.DataType = typeof(string);
            dtColumnIntegerFordtClientCopy.ColumnName = "Integer";
            dtClientCopy.Columns.Add(dtColumnIntegerFordtClientCopy);

            DataColumn dtColumnTextAreaFordtClientCopy = new DataColumn();
            dtColumnTextAreaFordtClientCopy.DataType = typeof(string);
            dtColumnTextAreaFordtClientCopy.ColumnName = "TextArea";
            dtClientCopy.Columns.Add(dtColumnTextAreaFordtClientCopy);

            DataColumn dtColumnTextBasicFordtClientCopy = new DataColumn();
            dtColumnTextBasicFordtClientCopy.DataType = typeof(string);
            dtColumnTextBasicFordtClientCopy.ColumnName = "TextBasic";
            dtClientCopy.Columns.Add(dtColumnTextBasicFordtClientCopy);

            DataColumn dtColumnTextEditorFordtClientCopy = new DataColumn();
            dtColumnTextEditorFordtClientCopy.DataType = typeof(string);
            dtColumnTextEditorFordtClientCopy.ColumnName = "TextEditor";
            dtClientCopy.Columns.Add(dtColumnTextEditorFordtClientCopy);

            DataColumn dtColumnTextEmailFordtClientCopy = new DataColumn();
            dtColumnTextEmailFordtClientCopy.DataType = typeof(string);
            dtColumnTextEmailFordtClientCopy.ColumnName = "TextEmail";
            dtClientCopy.Columns.Add(dtColumnTextEmailFordtClientCopy);

            DataColumn dtColumnTextFileFordtClientCopy = new DataColumn();
            dtColumnTextFileFordtClientCopy.DataType = typeof(string);
            dtColumnTextFileFordtClientCopy.ColumnName = "TextFile";
            dtClientCopy.Columns.Add(dtColumnTextFileFordtClientCopy);

            DataColumn dtColumnTextHexColourFordtClientCopy = new DataColumn();
            dtColumnTextHexColourFordtClientCopy.DataType = typeof(string);
            dtColumnTextHexColourFordtClientCopy.ColumnName = "TextHexColour";
            dtClientCopy.Columns.Add(dtColumnTextHexColourFordtClientCopy);

            DataColumn dtColumnTextPasswordFordtClientCopy = new DataColumn();
            dtColumnTextPasswordFordtClientCopy.DataType = typeof(string);
            dtColumnTextPasswordFordtClientCopy.ColumnName = "TextPassword";
            dtClientCopy.Columns.Add(dtColumnTextPasswordFordtClientCopy);

            DataColumn dtColumnTextPhoneNumberFordtClientCopy = new DataColumn();
            dtColumnTextPhoneNumberFordtClientCopy.DataType = typeof(string);
            dtColumnTextPhoneNumberFordtClientCopy.ColumnName = "TextPhoneNumber";
            dtClientCopy.Columns.Add(dtColumnTextPhoneNumberFordtClientCopy);

            DataColumn dtColumnTextTagFordtClientCopy = new DataColumn();
            dtColumnTextTagFordtClientCopy.DataType = typeof(string);
            dtColumnTextTagFordtClientCopy.ColumnName = "TextTag";
            dtClientCopy.Columns.Add(dtColumnTextTagFordtClientCopy);

            DataColumn dtColumnTextURLFordtClientCopy = new DataColumn();
            dtColumnTextURLFordtClientCopy.DataType = typeof(string);
            dtColumnTextURLFordtClientCopy.ColumnName = "TextURL";
            dtClientCopy.Columns.Add(dtColumnTextURLFordtClientCopy);

            DataColumn dtColumnClientStatusIdFordtClientCopy = new DataColumn();
            dtColumnClientStatusIdFordtClientCopy.DataType = typeof(string);
            dtColumnClientStatusIdFordtClientCopy.ColumnName = "ClientStatusId";
            dtClientCopy.Columns.Add(dtColumnClientStatusIdFordtClientCopy);


            #endregion

            dtClientOriginal = dtClient;

            foreach (DataRow DataRow in dtClientOriginal.Rows)
            {
                dtClientCopy.Rows.Add(DataRow.ItemArray);
            }

            var Sheet = Book.Worksheets.Add(dtClientCopy);

            Sheet.ColumnsUsed().AdjustToContents();

            Book.SaveAs(Path);
        }

        public void ExportToCSV(string Path, List<Client> lstClient)
        {
            using var Writer = new StreamWriter(Path);

            using var CsvWriter = new CsvWriter(Writer, CultureInfo.InvariantCulture);

            CsvWriter.WriteRecords(lstClient);
        }

        public void ExportToPDF(string Path, List<Client> lstClient)
        {
            string ProjectName = "EmptyProject";
            string Table = "Client";
            var Renderer = new HtmlToPdf();
            string RowsAsHTML = "";


            foreach (Client? Client in lstClient)
            {
                RowsAsHTML += $@"{Client?.ToStringOnlyValuesForHTML()}";
            }

            Renderer.RenderHtmlAsPdf($@"<table cellpadding=""0"" cellspacing=""0"" border=""0"" width=""88%"" style=""width: 88% !important; min-width: 88%; max-width: 88%;"">
    <tr>
    <td align=""left"" valign=""top"">
        <font face=""'Source Sans Pro', sans-serif"" color=""#1a1a1a"" style=""font-size: 52px; line-height: 55px; font-weight: 300; letter-spacing: -1.5px;"">
            <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #1a1a1a; font-size: 52px; line-height: 55px; font-weight: 300; letter-spacing: -1.5px;"">{ProjectName}</span>
        </font>
        <div style=""height: 25px; line-height: 25px; font-size: 23px;"">&nbsp;</div>
        <font face=""'Source Sans Pro', sans-serif"" color=""#4c4c4c"" style=""font-size: 36px; line-height: 45px; font-weight: 300; letter-spacing: -1px;"">
            <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #4c4c4c; font-size: 36px; line-height: 45px; font-weight: 300; letter-spacing: -1px;"">Registers of {Table}</span>
        </font>
        <div style=""height: 35px; line-height: 35px; font-size: 33px;"">&nbsp;</div>
    </td>
    </tr>
</table>
<br>
<table cellpadding=""0"" cellspacing=""0"" border=""0"" width=""100%"" style=""width: 100% !important; min-width: 100%; max-width: 100%;"">
    <tr>
        <th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">ClientId&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Active&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">DateTimeCreation&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">DateTimeLastModification&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">UserCreationId&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">UserLastModificationId&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Boolean&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">DateTime&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Decimal&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Integer&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextArea&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextBasic&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextEditor&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextEmail&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextFile&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextHexColour&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextPassword&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextPhoneNumber&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextTag&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextURL&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">ClientStatusId&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th>
    </tr>
    {RowsAsHTML}
</table>
<br>
<font face=""'Source Sans Pro', sans-serif"" color=""#868686"" style=""font-size: 17px; line-height: 20px;"">
    <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #868686; font-size: 17px; line-height: 20px;"">Printed on: {DateTime.Now}</span>
</font>
").SaveAs(Path);
        }
        #endregion

        #region Importations
        public List<Client> ImportExcel(string path, int userId)
        {
            List<Client> lstClient = [];

            var WorkBook = new XLWorkbook(path);
            var Rows = WorkBook.Worksheet(1).RangeUsed().RowsUsed();

            foreach (var row in Rows)
            {
                var rowNumber = row.RowNumber();

                if (rowNumber > 1)
                {
                    bool Boolean= Convert.ToBoolean(row.Cell(7).GetString());
                    DateTime DateTime = Convert.ToDateTime(row.Cell(8).GetString());
                    decimal Decimal = Convert.ToDecimal(row.Cell(9).GetString());
                    int Integer = Convert.ToInt32(row.Cell(10).GetString());
                    string TextArea = row.Cell(11).GetString();
                    string TextBasic = row.Cell(12).GetString();
                    string TextEditor = row.Cell(13).GetString();
                    string TextEmail = row.Cell(14).GetString();
                    string TextFile = row.Cell(15).GetString();
                    string TextHexColour = row.Cell(16).GetString();
                    string TextPassword = row.Cell(17).GetString();
                    string TextPhoneNumber = row.Cell(18).GetString();
                    string TextTag = row.Cell(19).GetString();
                    string TextURL = row.Cell(20).GetString();
                    int ClientStatusId = Convert.ToInt32(row.Cell(21).GetString());

                    Client Client = new()
                    {
                        ClientId = 0,
                        Active = true,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        UserCreationId = userId,
                        UserLastModificationId = userId,
                        Boolean = Boolean,
                        DateTime = DateTime,
                        Decimal = Decimal,
                        Integer = Integer,
                        TextArea = TextArea,
                        TextBasic = TextBasic,
                        TextEditor = TextEditor,
                        TextEmail = TextEmail,
                        TextFile = TextFile,
                        TextHexColour = TextHexColour,
                        TextPassword = TextPassword,
                        TextPhoneNumber = TextPhoneNumber,
                        TextTag = TextTag,
                        TextURL = TextURL,
                        ClientStatusId = ClientStatusId
                    };

                    lstClient.Add(Client);
                }
            }

            return lstClient;
        }
        #endregion
    }
}
