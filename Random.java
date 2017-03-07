import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class Random {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		int from, to, howMany;
		System.out.print("**Starting random!! User input is required**\nStarting Value: ");
		from = sc.nextInt();
		System.out.print("Ending Value: ");
		to = sc.nextInt();
		System.out.print("How many values do you want to display: ");
		howMany = sc.nextInt();
		System.out.print("Your values are: ");
		display(random(from, to), howMany);
		System.out.println("**Stopping Random!! Thank you for using it**");
		sc.close();
	}
	public static ArrayList<Integer> random(int from, int to){
		ArrayList<Integer> stevila = new ArrayList<>();
		for(int i = from; i < (to+1); i++){
			stevila.add(i);
		}
		Collections.shuffle(stevila);
		return stevila;
	}
	public static void display(ArrayList<Integer> stevila, int howMany){
		ArrayList<Integer> forDisplay = new ArrayList<>();
		for(int i = 0; i < howMany; i++){
			forDisplay.add(stevila.get(i));
		}
		Collections.sort(forDisplay);
		System.out.println(forDisplay);
	}
}
