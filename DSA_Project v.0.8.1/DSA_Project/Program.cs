using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

using System.Data.SqlClient;
using System.Net;
using System.Data;

namespace DSA_Project
{
    internal static class Program
    {
        static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Documents\\University\\BSE 3B\\DSA Data Structure and Algorithme\\Project\\DSA_Project v.0.8.1\\DSA_Project\\DSA_Project_DB.mdf\";Integrated Security=True");

        static public HuffmanTree huffmanTree = new HuffmanTree();          // huffman tree class object

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new FormRegister().Show();
            Application.Run();
        }

        static public void CompressUploadPdfFile(string filePath, string binFilePath, string codingSchemePath,string sid,string course,int row)
        {

            string pdfString = GetTextFromPdfFile(filePath);

            // Build the Huffman tree
            huffmanTree.Build_Tree(pdfString);

            // Encode the input file in BitArray in binary form
            BitArray bit_array = huffmanTree.Encode(pdfString);

            // Byte array for storing the bits from BitArray to save in bin file
            byte[] bytes = new byte[bit_array.Length / 8 + (bit_array.Length % 8 == 0 ? 0 : 1)];
            bit_array.CopyTo(bytes, 0);

            //uploading
            con.Open();
            UploadFile(sid,bytes,course,row);
            con.Close();
            
            //make codingscheme file, not sure if its important
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < bit_array.Count; i++)
            {
                char bitChar = bit_array[i] ? '1' : '0';
                stringBuilder.Append(bitChar);
            }
            var stringBuilder2 = stringBuilder.ToString();
            File.WriteAllText(codingSchemePath, stringBuilder2);
        }
        static public void UploadFile(string sid, byte[] content,string course, int row)
        {
            MessageBox.Show(""+content.Length);
            SqlCommand cmd;
            
            using (cmd = new SqlCommand("Insert into tbl_Submission (Student_Id,[Submission],Course,Sno) values (@Student_Id,@Submission,@Course,@Sno)", con))
            {
                cmd.Parameters.AddWithValue("@Student_Id", sid);
                cmd.Parameters.AddWithValue("@Submission", content);
                cmd.Parameters.AddWithValue("@Course", course);
                cmd.Parameters.AddWithValue("@Sno", row);
                cmd.ExecuteNonQuery();
            }
        }
        static public string GetTextFromPdfFile(string filePath)
        {
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(filePath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            return text.ToString();
        }

        static public void ExtractPdfFile(byte[] bytes, string extractFilePath)
        {
            var bitarray = new BitArray(bytes);

            // decode the huffman tree
            string decoded = huffmanTree.Decode(bitarray);

            //write the decoded file in pdf file
            iTextSharp.text.Document oDoc = new iTextSharp.text.Document();
            PdfWriter.GetInstance(oDoc, new FileStream(extractFilePath, FileMode.Create));
            oDoc.Open();
            oDoc.Add(new iTextSharp.text.Paragraph(decoded));
            oDoc.Close();
        }
    }
}
