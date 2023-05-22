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

        public string SetReference
        {
            set { this.m_reference = value; }
        }

        public List<Piece> GetListePiece
        {
            get {return this.m_liste_Piece;}
        }
        public List<Piece> SetListePiece
        {
            set {this.m_liste_Piece=value;}
        }
        public Piece(string p_description, int p_numero_serie, string p_reference)
        {
            this.m_description = p_description;
            this.m_numero_serie = p_numero_serie;
            this.m_reference = p_reference;
        }

        public virtual string Bom()
        {
            string bom = string.Format("{0, -30} {1, -15} {2, -10}\n", "Description", "Reference"); 
            bom += string.Format("{0, -30} {1, -15} {2, -10}\n", this.m_description, this.m_reference);
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
            foreach (PieceSousEnsemble p in this.m_liste_Piece)
            {
                message +=$"  {p.ToString()}\n"; 
            }
            
            return $"Piece: {this.m_description} Numero de serie: {this.m_numero_serie} Reference: {this.m_reference}\n{message}\n";
        }
    }
}