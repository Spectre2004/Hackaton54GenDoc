using Hackacton.ClassHelper;
using Microsoft.Office.Interop.Word;
using word = Microsoft.Office.Interop.Word;
using System;
using System.IO;


namespace Hackacton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CmdRunner.Execute("Список студентов.xlsx", "");*/

            TextChanger();
        }
        public static void TextChanger() 
        {

            var helper = new WordHelper("Экзаменационная ведомость.doc");

            var items = new Dictionary<string, string>() 
            {
                { "<teacher>", "Адышки С.С." },
                { "<group>", "4ИСП9-18ВБ" },
                { "<special>", "09.04 Информационные системы и программирование" },
                { "<courseNumber>", "4" },
            };

            helper.Process(items);
        }
    }
}