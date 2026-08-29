using System;
List<Policy> policies = new List<Policy>
{
    new Policy
    {
        PolicyId = 1,
        PolicyNumber ="PO 01",
        CustomerId = 101,
        CustomerName ="Sanket Katkar",
        PolicyType = "Life",
        Status ="Active",
        Premium =50000,
        SumAssured =600000
    },
    new Policy
    {
        PolicyId =2,
        PolicyNumber = "PO 02",
        CustomerId =102,
        CustomerName ="Omkar katkar",
        PolicyType ="Health",
        Status ="Expired",
        Premium =25000,
        SumAssured =500000
    },
    new Policy
    {
         PolicyId =3,
        PolicyNumber = "PO 03",
        CustomerId =103,
        CustomerName ="Samadhan Katkar",
        PolicyType ="Vechicle",
        Status ="Expired",
        Premium =30000,
        SumAssured =400000
    },
    new Policy
    {
         PolicyId =4,
        PolicyNumber = "PO 04",
        CustomerId =103,
        CustomerName ="Shantilal Yajgar",
        PolicyType ="Life",
        Status ="Active",
        Premium =24000,
        SumAssured =300000
    },
    new Policy
    {
         PolicyId =5,
        PolicyNumber = "PO 05",
        CustomerId =105,
        CustomerName ="Ranjit Bhosale",
        PolicyType ="Health",
        Status ="Active",
        Premium =25000,
        SumAssured =200000
    },
    new Policy
    {
         PolicyId =6,
        PolicyNumber = "PO 06",
        CustomerId =106,
        CustomerName ="Ritesh Shinde",
        PolicyType ="Life",
        Status ="Expride",
        Premium =26000,
        SumAssured =100000
    },new Policy
    {
         PolicyId =7,
        PolicyNumber = "PO 07",
        CustomerId =107,
        CustomerName ="Om Jawle",
        PolicyType ="Vechicle",
        Status ="Active",
        Premium =35000,
        SumAssured =350000
    },new Policy
    {
         PolicyId =8,
        PolicyNumber = "PO 08",
        CustomerId =108,
        CustomerName ="Nikhil Jadhav",
        PolicyType ="Health",
        Status ="Active",
        Premium =24000,
        SumAssured =360000
    },


};

//LINQ Quries
var activePolicies = policies
    .Where(p => p.Status == "Active")
    .ToList();

foreach (var p in activePolicies)
{
    Console.WriteLine($"{p.PolicyNumber} - {p.CustomerName} -{p.PolicyType}");
}
{
    Console.WriteLine(); 
}



//Premium Grater Than 10000
{
    var highPremiumPolicies = policies
     .Where(p => p.Premium > 10000)
     .ToList();

    foreach (var p in highPremiumPolicies)
    {
        Console.WriteLine($"{p.PolicyNumber} - ₹{p.Premium}");
    }
}