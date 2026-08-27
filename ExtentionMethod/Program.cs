Policy policy = new Policy
{
  Id=1,
  PolicyNumber="PO9909090988",
  policyHolderName="Sanket Katkar",
  premium=12000,
  startDate=DateTime.Today.AddMonths(-10),
  endDate =DateTime.Today.AddDays(30),
  isActive= true  

};

Console.WriteLine("Hello, World!");
Console.WriteLine (policy.isValid());
Console.WriteLine(policy.DadysRemaining());
Console.WriteLine(policy.GetSummary());
