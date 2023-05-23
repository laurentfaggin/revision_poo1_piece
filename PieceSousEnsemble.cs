using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1_piece
{
    public class PieceSousEnsemble: Piece
    {
        private List<Piece>m_liste_pieces = new List<Piece>();
        
        
        public PieceSousEnsemble(string p_description, string p_reference, int p_numero_serie): base(p_description, p_reference, p_numero_serie)
        {
        }


        public List<Piece>  GetListe
        {
            get { return this.m_liste_pieces; }
        }

        public List<Piece> SetListe
        {
            set { this.m_liste_pieces = value; }
        }

        public override void AjouterPiece(Piece p_piece)
        {
                this.m_liste_pieces.Add(p_piece);     
        }


        public override string Bom()
        {
            string bom ="";
            foreach(Piece p in this.GetListe)
            {
                for (int i = 0; i < GetListe.Count; i++){
                    if(p.GetDescription == GetListe[i].GetDescription)
                    {
                        p.Count ++;
                    }
                }                
                bom += $"{p.GetDescription, -30} {p.GetReference, -15} {p.Count, -10}\n";   
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
            string message =$"Piece: {this.GetDescription}   part - {this.GetReference},  numero serie: #{this.GetNumeroSerie}\n";
            foreach (Piece p in this.m_liste_pieces)
            {
                message += $"    {p.ToString()}\n";
            }
            return message;
        }        
    }
}