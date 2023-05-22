using System;

namespace revision_poo1_piece
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Piece echangeur = new Piece ("echangeur", 123456, "m-1");
            Piece piquage = new PieceSousEnsemble ("piquage", 012, "p-12");
            Piece fond = new PieceSousEnsemble ("fond", 006, "r-1");
            Piece nut = new PieceAssemblage ("nut", 587, "v-m8");
            Piece bolt = new PieceAssemblage ("bolt", 588, "r-0.175");
            Piece tube = new PieceUsinee ("tube", 268, "t-168");
            Piece bride = new PieceUsinee ("bride", 645, "b-587");

            piquage.AjouterPiece(tube);
            piquage.AjouterPiece(bride);
            piquage.AjouterPiece(bride);
            piquage.AjouterPiece(bride);
            piquage.AjouterPiece(nut);
            piquage.AjouterPiece(nut);
            piquage.AjouterPiece(nut);
            piquage.AjouterPiece(nut);
            piquage.AjouterPiece(nut);
            piquage.AjouterPiece(nut);
            piquage.AjouterPiece(nut);
            piquage.AjouterPiece(bolt);
            fond.AjouterPiece(tube);
            fond.AjouterPiece(bride);
            fond.AjouterPiece(nut);
            fond.AjouterPiece(nut);
            fond.AjouterPiece(nut);
            fond.AjouterPiece(nut);
            fond.AjouterPiece(nut);
            fond.AjouterPiece(nut);
            fond.AjouterPiece(nut);
            fond.AjouterPiece(nut);
            fond.AjouterPiece(bolt);
            fond.AjouterPiece(bolt);
            fond.AjouterPiece(bolt);
            fond.AjouterPiece(bolt);
            fond.AjouterPiece(bolt);
            fond.AjouterPiece(bolt);
            fond.AjouterPiece(bolt);
            fond.AjouterPiece(bolt);
            fond.AjouterPiece(bride);

            echangeur.AjouterPiece(fond);
            echangeur.AjouterPiece(piquage);

            //Console.WriteLine(echangeur.ToString());
            Console.WriteLine(echangeur.Bom());
        }
    }
}