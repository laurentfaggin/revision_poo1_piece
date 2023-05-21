using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1_piece
{
    public class PieceSousEnsemble: Piece
    {
        private int m_quantite_piece_sous_ensemble;
        private List<Piece>m_liste_pieces = new List<Piece>();
        public PieceSousEnsemble(string p_description, int p_numero_serie, string p_reference): base(p_description, p_numero_serie, p_reference)
        {
        }

        public int GetQuantitePeceSousEnsemble
        {
            get {return this.m_quantite_piece_sous_ensemble;}
        }

        public int SetQuantitePieceSousEnsemble
        {
            set {this.m_quantite_piece_sous_ensemble = value;}
        }
        public List<Piece>  GetListe
        {
            get { return this.m_liste_pieces; }
        }

        public List<Piece> SetListe
        {
            set { this.m_liste_pieces = value; }
        }

        public void AjouterPieceDansSousEnsemble(Piece p_piece)
        {
            if (!this.m_liste_pieces.Contains(p_piece))
            {
                this.m_liste_pieces.Add(p_piece);
            }
            else
            {
                this.m_quantite_piece_sous_ensemble += p_piece.GetQuantite;
            }
        }

        public string Bom_Sous_Ensemble()
        {
            string bom ="";
            foreach(Piece p in this.GetListe)
            {                
                bom += $"{p.GetDescription, -30} {p.GetReference, -25} {p.GetQuantite, -10}\n";   
            }

            return bom;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.GetDescription, this.GetReference);
        }
        
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is PieceSousEnsemble))
            {
                return false;
            }
            return (this.GetDescription == ((PieceSousEnsemble)obj).GetDescription && this.GetNumeroSerie == ((PieceSousEnsemble)obj).GetNumeroSerie
                                                && this.GetReference == ((PieceSousEnsemble)obj).GetReference && this.GetType() == ((PieceSousEnsemble)obj).GetType());
        }

        public override string ToString()
        {
            string message =$"Piece: {this.GetDescription}  Numero de serie: {this.GetNumeroSerie}  Reference: {this.GetReference}\n";
            foreach (Piece p in this.m_liste_pieces)
            {
                message += $"    {p.ToString()}\n";
            }
            return message;
        }        
    }
}