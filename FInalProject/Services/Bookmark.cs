using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Interface;

namespace FInalProject.Services
{
    class Bookmark
    {
        private Document doc = null;
        public Bookmark(Document document)
        {
            doc = document;
        }
 
        /// <summary>
        /// Replace the content of the specified bookmark with text
        /// </summary>
                 /// <param name="bookmarkName">Book signature</param>
                 /// <param name="text">text</param>
                 /// <param name="saveFormatting">Do you want to keep the format when deleting the original bookmark content</param>
        /// <returns>TextRange</returns>
        public TextRange ReplaceContent(string bookmarkName, string text, bool saveFormatting)
        {
            BookmarksNavigator navigator = new BookmarksNavigator(doc);
                         navigator.MoveToBookmark(bookmarkName);//Point to a specific bookmark
                         navigator.DeleteBookmarkContent(saveFormatting);//Delete the original bookmark content     
                         Spire.Doc.Interface.ITextRange textRange = navigator.InsertText(text);//Write text
            return textRange as TextRange;
        }
 
        /// <summary>
                 /// Replace the content of the specified bookmark with a picture
        /// </summary>
                 /// <param name="bookmarkName">Book signature</param>
                 /// <param name="picPath">picture path</param>
                 /// <param name="widthScale">width scaling, positive integer above 0</param>
                 /// <param name="heightScale">Height scale, positive integer above 0</param>
                 /// <param name="wrapStyle">Surrounding method</param>
        /// <param name="horizontalAlignment"></param>
        public void ReplaceContent(string bookmarkName, string picPath, float widthScale, float heightScale, TextWrappingStyle wrapStyle, ShapeHorizontalAlignment horizontalAlignment)
        {
            BookmarksNavigator navigator = new BookmarksNavigator(doc);
            navigator.MoveToBookmark(bookmarkName);
            navigator.DeleteBookmarkContent(false);
                         IParagraphBase paragraphBase = navigator.InsertParagraphItem(ParagraphItemType.Picture);//Insert type is picture
                         Image image = Image.FromFile(picPath);//Load the image
                         DocPicture picture = paragraphBase.OwnerParagraph.AppendPicture(image);//Insert picture
            picture.WidthScale = widthScale;
            picture.HeightScale = heightScale;
            picture.TextWrappingStyle = wrapStyle;
            picture.HorizontalAlignment = horizontalAlignment;
        }
 
        /// <summary>
                 /// Replace the content of the specified bookmark with a table
        /// </summary>
                 /// <param name="bookmarkName">Book signature</param>
                 /// <param name="table">Table instance</param>
        public void ReplaceContent(string bookmarkName, Table table)
        {
            BookmarksNavigator navigator = new BookmarksNavigator(doc);
            navigator.MoveToBookmark(bookmarkName);
            TextBodyPart body = new TextBodyPart(doc);
            body.BodyItems.Add(table);
            navigator.ReplaceBookmarkContent(body);
        }
 
        /// <summary>
                 /// Create table and write data, return Table object
        /// </summary>
                 /// <param name="rowsNum">number of rows</param>
                 /// <param name="columnsNum">number of columns</param>
                 /// <param name="columnWidth">column width</param>
                 /// <param name="horizontalAlignment">horizontal alignment</param>
                 /// <param name="datatable">DataTable instance</param>
        /// <returns></returns>
        public Table CreateTable(int rowsNum, int columnsNum, float columnWidth, RowAlignment horizontalAlignment, System.Data.DataTable datatable)
        {
                         Table table = new Table(doc, true, 1f);//Initialize Table object
                         table.ResetCells(rowsNum, columnsNum);//Set the number of rows and columns
                         //Data input 
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                for (int j = 0; j < datatable.Columns.Count; j++)
                {
                    table.Rows[i].Cells[j].AddParagraph().AppendText(datatable.Rows[i][j].ToString());
                }
            }
                         //Set the column width
            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < columnsNum; j++)
                {
                    table.Rows[i].Cells[j].Width = columnWidth;
                }               
            }
                         table.TableFormat.HorizontalAlignment = horizontalAlignment;//Table horizontal alignment
            return table;
        }
    }
}