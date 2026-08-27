public static class PolicyExtentiion
{
    public static bool isValid(this Policy policy)
    {
        DateTime Today=DateTime.Today;
        return policy.isActive&& policy .startDate<= Today && policy.endDate >=Today;

    }
    public static int DadysRemaining(this Policy policy)
    {
        int days =(policy.endDate.Date-DateTime.Today).Days;
        return days;
    }
     public static string GetSummary(this Policy policy)
    {
        return
            $"Policy: {policy.PolicyNumber}\n" +
            $"Holder: {policy.policyHolderName}\n" +
            $"Premium: ₹{policy.premium}\n" +
            $"Status: {(policy.isValid() ? "Valid" : "Invalid")}";
    }
}
