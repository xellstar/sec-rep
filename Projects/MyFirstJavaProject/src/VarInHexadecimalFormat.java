import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by User on 10/25/2016.
 */
public class VarInHexadecimalFormat {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String inputHexadecimal = console.nextLine();
        char[] inputToCharArray = inputHexadecimal.toCharArray();
        char[] inputToCharArrayWithout0x = Arrays.copyOfRange(inputToCharArray, 2, inputToCharArray.length);
        System.out.println(HexToDecimal(inputHexadecimal));
    }

    public static int HexToDecimal(String inputToCharArrayWithout0x) {
        String digits = "0123456789ABCDEF";
        inputToCharArrayWithout0x = inputToCharArrayWithout0x.toUpperCase();
        int val = 0;
        for (int i = 0; i < inputToCharArrayWithout0x.length(); i++) {
            char c = inputToCharArrayWithout0x.charAt(i);
            int d = digits.indexOf(c);
            val = 16 * val + d;
        }
        return val;
    }
}

