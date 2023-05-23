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
        protected int count;
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
        public string SetReference
        {
            set { this.m_reference = value; }
        }
        public int Count
        {
            get {return count;}
            set {count = value;}
        }

        public Piece(string p_description, string p_reference, int p_numero_serie)
        {
            this.m_description = p_description;
            this.m_reference = p_reference;
            this.m_numero_serie = p_numero_serie;
            Count = 1;
        }

        public virtual string Bom()
        {
            string bom = string.Format($"{"Description", -30} {"Reference", -15} {"Quantite", -10}\n");
            bom += string.Format($"{this.m_description, -30} {this.m_reference, -15} {this.Count, -10}\n");
            foreach (Piece pse in this.m_liste_Piece)
            {
                bom += pse.Bom();
            }
            
            return bom;
        }

        public virtual void AjouterPiece(Piece p_sousEnsemble)
        {
            this.m_liste_Piece.Add(p_sousEnsemble);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Piece))
            {
                return false;
            }
            return (this.GetDescription == ((Piece)obj).GetDescription && this.GetNumeroSerie == ((Piece)obj).GetNumeroSerie
                                                && this.GetReference == ((Piece)obj).GetReference && this.GetType() == ((Piece)obj).GetType());
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.m_description, this.m_reference);
        }

        public override string ToString()
        {
            string message="";
            foreach (Piece p in this.m_liste_Piece)
            {
                message +=$"  {p.ToString()}\n"; 
            }
            
            return $"Piece: {this.m_description} part - #{this.m_reference} numero serie: #{this.m_numero_serie}\n{message}";
        }
    }
}