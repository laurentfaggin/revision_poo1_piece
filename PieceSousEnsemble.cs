using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace revision_poo1_piece
{
    public class PieceSousEnsemble: Piece
    {
        private List<Piece>m_liste_pieces;
        private List<Piece>m_liste_composants;        
        
        public PieceSousEnsemble(string p_description, string p_reference, int p_numero_serie): base(p_description, p_reference, p_numero_serie)
        {
            m_liste_pieces = new List<Piece>();
            m_liste_composants = new List<Piece>();
        }

        public List<Piece> ListeComposants
        {
            get{return m_liste_composants;}
            private set {m_liste_composants = value;}
        }
        public List<Piece> ListePieces
        {
            get { return this.m_liste_pieces; }
            private set { this.m_liste_pieces = value; }
        }

        public override void AjouterPiece(Piece p_piece)
        {
                this.m_liste_pieces.Add(p_piece);     
        }

        public override void RemplirListeAplatie()
        {
            base.RemplirListeAplatie();
            ListeAplatie.AddRange(m_liste_pieces);
        }

        public override string AfficheListeAplatie()
        {
            string affiche="\nliste des composants: ";
            foreach (Piece p in this.m_liste_composants)
            {
                affiche +=$"\n{p.Description}";
            }
            return affiche;
        }

           public override string ToString()
        {
            string message =$"Piece: {this.Description}   part - {this.Reference},  numero serie: #{this.NumeroSerie}\n";
            foreach (Piece p in this.m_liste_pieces)
            {
                message += $"    {p.ToString()}\n";
            }
            return message;
        }        
    }
}