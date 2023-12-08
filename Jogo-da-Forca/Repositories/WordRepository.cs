using Jogo_da_Forca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca.Repositories
{
    internal class WordRepository
    {
        private List<Word> _words;
        public WordRepository() 
        {
            _words = new List<Word>();
            _words.Add(new Word(tips: "Nome", text: "Maria".ToUpper()));
            _words.Add(new Word(tips: "Vegetal", text: "Cenoura".ToUpper()));
            _words.Add(new Word(tips: "Fruta", text: "Abacate".ToUpper()));
            _words.Add(new Word(tips: "Tempero", text: "Nordestino".ToUpper()));
            _words.Add(new Word(tips: "Carro", text: "Ferrari".ToUpper()));
            _words.Add(new Word(tips: "Banco Relacional", text: "MySql".ToUpper()));
        }

        public Word GetRandomWord()
        {
            Random rand = new();
            var number = rand.Next(0, _words.Count);
            return _words[number];
        }
    }
}
