//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFO1
{
    using System;
    using System.Collections.Generic;
    
    public partial class DepartureTimeTable
    {
        public int ID { get; set; }
        public int AirID { get; set; }
        public string FlightNo { get; set; }
        public int CityID { get; set; }
        public int StatusID { get; set; }
        public System.TimeSpan BoradingTime { get; set; }
        public int TerminalID { get; set; }
    
        public virtual Airlines_Departure Airlines_Departure { get; set; }
        public virtual Cities_Departure Cities_Departure { get; set; }
        public virtual Status_Departure Status_Departure { get; set; }
        public virtual Terminal_Departure Terminal_Departure { get; set; }
    }
}
