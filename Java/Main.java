// Author : Aniruddh Abhisheki
// Roll No : 7
// Title : Displaying the institutions details
// Start Date : 17/07/2024
// Modified Date : 24/07/2024
// Description : Finding Classes, Objects and Relation between the institutions

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

class Institution {
    String name;
    String city;
    String state;
    String act;
    String ministry;

    // Constructor
    public Institution(String name, String city, String state, String act, String ministry) {
        this.name = name;
        this.city = city;
        this.state = state;
        this.act = act;
        this.ministry = ministry;
    }
}

public class Main {
    // Function to display details of an institution
    static void displayInstitution(Institution inst) {
        System.out.println("Name: " + inst.name);
        System.out.println("City: " + inst.city + ", " + inst.state);
        System.out.println("Act: " + inst.act);
        System.out.println("Ministry: " + inst.ministry);
        System.out.println("----------------------------------");
    }

    // Function to search institutions by city
    static void searchByCity(List<Institution> institutions, String city) {
        boolean found = false;
        for (Institution inst : institutions) {
            if (inst.city.equalsIgnoreCase(city)) {
                displayInstitution(inst);
                found = true;
            }
        }
        if (!found) {
            System.out.println("No institutions found in " + city);
        }
    }

    // Function to search institutions by state
    static void searchByState(List<Institution> institutions, String state) {
        boolean found = false;
        for (Institution inst : institutions) {
            if (inst.state.equalsIgnoreCase(state)) {
                displayInstitution(inst);
                found = true;
            }
        }
        if (!found) {
            System.out.println("No institutions found in " + state);
        }
    }

    public static void main(String[] args) {
        // Sample data of institutions
        List<Institution> institutions = new ArrayList<>();
        institutions.add(new Institution("Aligarh Muslim University", "Aligarh", "Uttar Pradesh", "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India", "Ministry of Education"));
        institutions.add(new Institution("Banaras Hindu University", "Varanasi", "Uttar Pradesh", "", ""));
        institutions.add(new Institution("University of Delhi", "Delhi", "Delhi", "", ""));

        Scanner scanner = new Scanner(System.in);
        int choice;
        String searchCity, searchState;

        do {
            // Menu options
            System.out.println("========== Menu ==========");
            System.out.println("1. Search by city");
            System.out.println("2. Search by state");
            System.out.println("3. Exit");
            System.out.print("Enter your choice: ");
            choice = scanner.nextInt();

            scanner.nextLine(); // Clear the newline character from input buffer

            switch (choice) {
                case 1:
                    System.out.print("Enter city to search: ");
                    searchCity = scanner.nextLine();
                    searchByCity(institutions, searchCity);
                    break;
                case 2:
                    System.out.print("Enter state to search: ");
                    searchState = scanner.nextLine();
                    searchByState(institutions, searchState);
                    break;
                case 3:
                    System.out.println("Exiting program...");
                    break;
                default:
                    System.out.println("Invalid choice! Please enter again.");
            }
        } while (choice != 3);

        scanner.close();
    }
}
