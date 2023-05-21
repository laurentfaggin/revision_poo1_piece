using System;

namespace revision_poo1_piece
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Piece echangeur = new Piece ("echangeur", 123456, "m-1");
            PieceSousEnsemble piquage = new PieceSousEnsemble ("piquage", 012, "p-12");
            PieceSousEnsemble fond = new PieceSousEnsemble ("fond", 006, "r-1");
            Piece vis = new PieceAssemblage ("vis", 587, "v-m8", 8);
            Piece bolt = new PieceAssemblage ("bolt", 588, "r-0.175", 8);
            Piece tube = new PieceUsinee ("tube", 268, "t-168", 4);
            Piece bride = new PieceUsinee ("bride", 645, "b-587", 4);

            piquage.AjouterPieceDansSousEnsemble(tube);
            piquage.AjouterPieceDansSousEnsemble(bride);
            System.Console.WriteLine($"{bride.GetType()}  {bride.GetQuantite}");
            piquage.AjouterPieceDansSousEnsemble(vis);
            piquage.AjouterPieceDansSousEnsemble(bolt);
            fond.AjouterPieceDansSousEnsemble(tube);
            fond.AjouterPieceDansSousEnsemble(bride);
            System.Console.WriteLine($"{bride.GetType()}  {bride.GetQuantite}");
            fond.AjouterPieceDansSousEnsemble(vis);
            fond.AjouterPieceDansSousEnsemble(bolt);
            fond.AjouterPieceDansSousEnsemble(bride);
            System.Console.WriteLine($"{bride.GetType()}  {bride.GetQuantite}");

            echangeur.AjouterSousEnsembleDansPiece(fond);
            echangeur.AjouterSousEnsembleDansPiece(piquage);

            Console.WriteLine(echangeur.ToString());
            Console.WriteLine(echangeur.Bom());
        }
    }
}