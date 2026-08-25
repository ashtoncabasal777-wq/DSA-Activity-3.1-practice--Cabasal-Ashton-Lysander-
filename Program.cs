

string[] months = new string[12];
for (int i = 0; i < months.Length; i++)
{
    months[i] = new DateTime(DateTime.Now.Year, month, 1);
    string monthName = months[i].ToString("MMMM");

}
