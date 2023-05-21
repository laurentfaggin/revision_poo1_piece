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
        private int m_quantite;
        private List<PieceSousEnsemble> m_liste_Piece = new List<PieceSousEnsemble>();
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

        public int GetQuantite
        {
            get {return this.m_quantite;}
        }

        public int SetQuantite
        {
            get { return this.m_quantite; }
            set {this.m_quantite = value;}
        }
        public List<PieceSousEnsemble> GetListePiece
        {
            get {return this.m_liste_Piece;}
        }
        public List<PieceSousEnsemble> SetListePiece
        {
            set {this.m_liste_Piece=value;}
        }
        public Piece(string p_description, int p_numero_serie, string p_reference)
        {
            this.m_description = p_description;
            this.m_numero_serie = p_numero_serie;
            this.m_reference = p_reference;
            this.m_quantite = 1;
        }

        public string Bom()
        {
            string bom = string.Format("{0, -30} {1, -25} {2, -10}\n", "Description", "Reference", "Quantite"); 
            bom += string.Format("{0, -30} {1, -25} {2, -10}\n", this.m_description, this.m_reference, this.m_quantite);
            foreach (PieceSousEnsemble pse in this.m_liste_Piece)
            {
                bom += pse.Bom_Sous_Ensemble();
            }
            return bom;
        }

        public void AjouterSousEnsembleDansPiece(PieceSousEnsemble p_sousEnsemble)
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