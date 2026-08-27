using System;
public class Policy
{
    public int Id {get; set;}
    public string  PolicyNumber{get ;set;}
    public string policyHolderName{get; set;}
    public int premium{get; set;}
    public bool isActive {get; set;}
    public DateTime startDate {get;set;}
    public DateTime endDate {get;set;}

}