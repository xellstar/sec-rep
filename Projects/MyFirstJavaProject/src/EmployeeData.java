import java.util.Scanner;

/**
 * Created by User on 10/25/2016.
 */
public class EmployeeData
{
    public static void main (String[] args) {
        Scanner console = new Scanner(System.in);
        String FirstName = console.nextLine();
        String LastName = console.nextLine();
        String AgeStr = console.nextLine();
        int Age = Integer.parseInt(AgeStr);
        String GenderStr = console.nextLine();
        char Gender = GenderStr.charAt(0);
        String IDStr = console.nextLine();
        long ID = Long.parseLong(IDStr);
        String EmployeeNumberStr = console.nextLine();
        int EmployeeNumber = Integer.parseInt(EmployeeNumberStr);
        System.out.println("First name: " + FirstName);
        System.out.println("Last name: " + LastName);
        System.out.println("Age: " + Age);
        System.out.println("Gender: " + Gender);
        System.out.println("Personal ID: " + ID);
        System.out.println("Unique Employee number: " + EmployeeNumber);
    }
}
