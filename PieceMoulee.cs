using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1_piece
{
    public class PieceMoulee: Piece
    {
        public PieceMoulee(string p_description, string p_reference, int p_numero_serie): base(p_description, p_reference, p_numero_serie)
        {
        }

        public override string ToString()
        {
            return $"Piece: {this.Description}   part - {this.Reference},  numero serie: #{this.NumeroSerie}";
        }

        
    }
}