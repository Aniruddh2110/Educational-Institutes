// Author : Aniruddh Abhisheki
// Roll No : 7
// Title : Displaying the institutions details
// Start Date : 17/07/2024
// Modified Date : 24/07/2024
// Description : Finding Classes, Objects and Relation between the institutions

#include <iostream>
#include <string>
#include <vector>

using namespace std;

struct Institution {
    string name;
    string city;
    string state;
    string act;
    string ministry;
};

// Function to display details of an institution
void displayInstitution(const Institution& inst) {
    cout << "Name: " << inst.name << endl;
    cout << "City: " << inst.city << ", " << inst.state << endl;
    cout << "Act: " << inst.act << endl;
    cout << "Ministry: " << inst.ministry << endl;
    cout << "----------------------------------" << endl;
}

// Function to search institutions by city
void searchByCity(const vector<Institution>& institutions, const string& city) {
    bool found = false;
    for (const auto& inst : institutions) {
        if (inst.city == city) {
            displayInstitution(inst);
            found = true;
        }
    }
    if (!found) {
        cout << "No institutions found in " << city << endl;
    }
}

// Function to search institutions by state
void searchByState(const vector<Institution>& institutions, const string& state) {
    bool found = false;
    for (const auto& inst : institutions) {
        if (inst.state == state) {
            displayInstitution(inst);
            found = true;
        }
    }
    if (!found) {
        cout << "No institutions found in " << state << endl;
    }
}

int main() {
    // Sample data of institutions
    vector<Institution> institutions = {
        {"Aligarh Muslim University", "Aligarh", "Uttar Pradesh", "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India", "Ministry of Education"},
        {"Banaras Hindu University", "Varanasi", "Uttar Pradesh", "", ""},
        {"University of Delhi", "Delhi", "Delhi", "", ""},
    };

    int choice;
    string searchcity, searchState;

    do {
        // Menu options
        cout << "========== Menu ==========" << endl;
        cout << "1. Search by city" << endl;
        cout << "2. Search by state" << endl;
        cout << "3. Exit" << endl;
        cout << "Enter your choice: ";
        cin >> choice;

        cin.ignore(); // Clear the newline character from input buffer

        switch (choice) {
            case 1:
                cout << "Enter city to search: ";
                getline(cin, searchCity);
                searchByCity(institutions, searchCity);
                break;
            case 2:
                cout << "Enter state to search: ";
                getline(cin, searchState);
                searchByState(institutions, searchState);
                break;
            case 3:
                cout << "Exiting program..." << endl;
                break;
            default:
                cout << "Invalid choice! Please enter again." << endl;
        }
    } while (choice != 3);

    return 0;
}
