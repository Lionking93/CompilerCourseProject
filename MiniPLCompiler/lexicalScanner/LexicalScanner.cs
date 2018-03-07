using System;
using System.IO;
using System.Collections.Generic;

namespace MiniPLCompiler.lexicalScanner
{
    public class LexicalScanner
    {
        private Dictionary<int, Token> tokenTable;
        private Stack<char> buffer;

        // Gets source program file as constructor parameter
        public LexicalScanner()
        {
            initializeAutomaton();
        }

        private void initializeAutomaton() {
            String rawTransitionsData = System.IO.File.ReadAllText("../../transition_table.txt");
            String[] dataRows = rawTransitionsData.Split(Convert.ToChar(Environment.NewLine));
            for (int i = 1; i < dataRows.Length - 1; i++) {
                String[] dataRowFields = dataRows[i].Split(',');
                String inputState = dataRowFields[0];
                String inputChar = dataRowFields[1];
                String outputState = dataRowFields[2];
                Console.WriteLine("Input state: " + inputState);
                Console.WriteLine("Input char: " + inputChar);
                Console.WriteLine("Output state: " + outputState);
            }
        }
    }
}
