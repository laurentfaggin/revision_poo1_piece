using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1_piece
{
    public class Piece
    {
        private string m_description;
        private int m_numero_serie;
        private string m_reference;
        private List<Piece> m_liste_Piece = new List<Piece>();

        public string GetDescription
        {
            get { return this.m_description; }
        }

        public string SetDescription
        {
            set {this.m_description=value; }
        }

        public int GetNumeroSerie
        {
            get { return this.m_numero_serie; }
        }

        public int SetNumeroSerie
        {
            set { this.m_numero_serie = value; }
        }

        public string GetReference
        {
            get { return this.m_reference; }
        }

        public int SetReference
        {
            set { this.m_reference=value; }
        }

        public List<Piece> GetListePiece
        {
            get {return this.m_liste_Piece;}
        }
        public List<Piece> SetListePiece
        {
            set {this.m_liste_Piece=value;}
        }

        public override string ToString()
        {
            
        }
    }
}