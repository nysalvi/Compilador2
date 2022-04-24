using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador2
{
    internal class Token
    {
        private static readonly Dictionary<int, string> valuesList = new Dictionary<int, string>()
        {
            {-1, "ERROR"},
            {3, "INTEGER"},
            {4, "IF"},
            {5, "ID"},
            {10, "FLOAT"},
            {12, "FOR"},
            {16, "CHAR"},
            {23, "BOOLEAN"},
            {27, "ELSE"},
            {32, "WHILE"},
            {37, "SCANF"},
            {41, "MAIN"},
            {48, "PRINTLN"},
            {54, "RETURN"},
            {55, "<"},
            {56, ">"},
            {57, "!"},
            {58, "="},  
            {59, "<="},
            {60, ">="},
            {61, "!="},
            {62, "=="},
            {64, "||"},
            {65, "&"},
            {66, "&&"},
            {67, "("},
            {68, ")"},
            {69, "["},
            {70, "]"},
            {71, "{"},
            {72, "}"},
            {73, ","},
            {74, ";"},
            {75, "+"},
            {76, "-"},
            {77, "*"},
            {79, "%"},
            {80, "COMMENT"},
            {83, "DECIMAL_NUMBER"},
            {87, "STRING"}
        };

        
        private string lexemeType;
        public string Lexeme => lexemeType;
        private string value;
        public string Value => value;
        public Token(string lexemeType, int value)
        {
            this.lexemeType = lexemeType;
            this.value = valuesList[value];
        }
    }
}
