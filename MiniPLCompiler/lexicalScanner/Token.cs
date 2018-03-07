using System;
namespace MiniPLCompiler
{
    public class Token
    {
        private String category;
        private String value;

        public Token(String pCategory, String pValue)
        {
            this.category = pCategory;
            this.value = pValue;
        }
    }
}
