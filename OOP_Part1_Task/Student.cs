namespace OOP_Part1_Task;

public class Student
{

    public int Grade { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    private string email { get; set; }
    int age { get; set; }

    public void Register(string Email)
    {
        email = Email;

        SendEmail();
    }

    private void SendEmail()
    {

    }

}
