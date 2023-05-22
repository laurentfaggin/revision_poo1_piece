using System;

namespace revision_poo1_piece
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Piece valve = new Piece ("Valve a eau", "#0481", 1234);
            Piece Base = new PieceMoulee ("Base", "#0474", 1387);
            Piece systActivation = new PieceSousEnsemble ("Systeme d'activation", "#0574", 1887);
            Piece pin = new PieceUsinee ("Pin", "#0974", 1687);
            Piece plug = new PieceUsinee ("Plug", "#0964", 1657);
            Piece poignee = new PieceUsinee ("Poignee", "#2547", 3157);
            Piece couvercleMonobloc = new PieceUsinee("Couvercle Monobloc", "#9874", 1257);
            Piece vis = new PieceAssemblage ("Vis M8", "#3774", 8757);
           

            valve.AjouterPiece(Base);
            valve.AjouterPiece(systActivation);
            systActivation.AjouterPiece(pin);
            systActivation.AjouterPiece(plug);
            systActivation.AjouterPiece(poignee);
            for (int i = 0; i < 2; i++)
            {
                Piece couvercleLateral = new PieceSousEnsemble("Couvercle Lateral", "#0374", 1987);
                valve.AjouterPiece(couvercleLateral);
                couvercleLateral.AjouterPiece(couvercleMonobloc);
                for (int j = 0; j < 4; j++)
                {
                    couvercleLateral.AjouterPiece(vis);
                }
            }
            

            Console.WriteLine (valve.ToString());
            Console.WriteLine   (valve.Bom());
        }
    }
}