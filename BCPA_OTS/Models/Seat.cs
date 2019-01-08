using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    public enum SeatTypes
    {
        Orchestra,
        Stalls,
        Back
    }

    public enum SeatStatus
    {
        Available, Hold, Sold
    }

    /// <summary>
    /// William Foster
    /// </summary>
    public class Seat
    {
        /// <summary>
        /// An identification number assigned to 
        /// each seat that combines its seat and row 
        /// number.
        /// </summary>
        public int SeatID { get; set; }

        [Range(1,20)]
        public int RowNo { get; set; }


        [Range(1,20)]
        public int SeatNo { get; set; }

        /// <summary>
        /// A specification of seat that each one will 
        /// have. The types are: Orchestra, Stall and 
        /// Back seat.
        /// </summary>
        [Display(Name ="Seat Type")]
        public SeatTypes SeatType { get; set; }

        // Navigation Property

        public int ShowID { get; set; }

        public virtual Show Show { get; set; }

        /// <summary>
        /// A true of false statement which states whether or not
        /// the seat is an aisle seat or not
        /// </summary>
        [Display(Name ="Aisle Seat")]
        public bool AisleSeat
        {
            get { return (SeatNo == 10) || (SeatNo == 11); }
        }

        public SeatStatus Status { get; set; }

        public string SeatRow
        {
            get { return "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(RowNo - 1, 1); }
        }

        public Seat()
        {
            RowNo = 0;
            SeatNo = 0;
        }

        public Seat(int row, int seat)
        {
            this.
            RowNo = row;
            SeatNo = seat;
            Status = SeatStatus.Available;
        }

    }
}
