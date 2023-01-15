using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Spreadsheets;

var gsh = new GoogleSheetsHelper.GoogleSheetsHelper("my-service-account@my-project-csharp-374714.iam.gserviceaccount.com", "https://docs.google.com/spreadsheets/d/1BbMSymBV7-Hu-1IbES5BS_FXBvfHNT5NR0D-GbAIZ9o/edit?usp=sharing");

var row1 = new GoogleSheetRow();
var row2 = new GoogleSheetRow();

var cell1 = new GoogleSheetCell() { CellValue = "Header 1", IsBold = true, BackgroundColor = Color.DarkGoldenrod };
var cell2 = new GoogleSheetCell() { CellValue = "Header 2", BackgroundColor = Color.Cyan };

var cell3 = new GoogleSheetCell() { CellValue = "Value 1" };
var cell4 = new GoogleSheetCell() { CellValue = "Value 2" };

row1.Cells.AddRange(new List<GoogleSheetCell>() { cell1, cell2 });
row2.Cells.AddRange(new List<GoogleSheetCell>() { cell3, cell4 });

var rows = new List<GoogleSheetRow>() { row1, row2 };

gsh.AddCells(new GoogleSheetParameters() { SheetName = "Sheet44", RangeColumnStart = 1, RangeRowStart = 1 }, rows);