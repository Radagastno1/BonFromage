using System.Net;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BonFromage.Models;

public class Booking
{
    public int Id{get;set;}
    public string? Name{get;set;}
    // [DataType(DataType.Date)]
    // public DateTime Date{get;set;}
    //  [DataType(DataType.Time)]
    // public DateTime Time{get;set;}
    public DateTime BookingDate{get;set;}
    public int PartySize{get;set;}
    public bool IsConfirmed{get;set;}

    public Booking(string name, DateTime bookingDate ,int partysize)
    {
        Name = name;
        BookingDate = bookingDate;
        PartySize = partysize;
        IsConfirmed = true;
    }
    public Booking(){}
}