# Author : Aniruddh Abhisheki
# Roll No : 7
# Title : Displaying the institutions details
# Start Date : 17/07/2024
# Modified Date : 24/07/2024
# Description : Finding Classes, Objects and Relation between the institutions


class Institution:
    def __init__(self, name, city, state, act, ministry):
        self.name = name
        self.city = city
        self.state = state
        self.act = act
        self.ministry = ministry


def display_institution(inst):
    print("----------------------------------")
    print("Name : ", inst.name)
    print("City : ", inst.city)
    print("State : ", inst.state)
    print("Act : ", inst.act)
    print("Ministry : ", inst.ministry)
    print("----------------------------------")


def search_by_city(institutions, city):
    found = False
    for inst in institutions:
        if inst.city.lower() == city.lower():
            display_institution(inst)
            found = True
    if not found:
        print(f"No institutions found in {city}")


def search_by_state(institutions, state):
    found = False
    for inst in institutions:
        if inst.state.lower() == state.lower():
            display_institution(inst)
            found = True
    if not found:
        print(f"No institutions found in {state}")


def main():

    institutions = [
        Institution(
            "Aligarh Muslim University",
            "Aligarh",
            "Uttar Pradesh",
            "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India",
            "Ministry of Education",
        ),
        Institution(
            "Banaras Hindu University",
            "Varanasi",
            "Uttar Pradesh",
            "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India",
            "Ministry of Education",
        ),
        Institution(
            "University of Delhi",
            "Delhi",
            "Delhi",
            "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India",
            "Ministry of Education",
        ),
    ]

    while True:
        print("========== Institutions ==========")
        print("1. Search by city")
        print("2. Search by state")
        print("3. Exit")
        choice = input("Enter your choice: ")

        if choice == "1":
            search_city = input("Enter city to search: ")
            search_by_city(institutions, search_city)
        elif choice == "2":
            search_state = input("Enter state to search: ")
            search_by_state(institutions, search_state)
        elif choice == "3":
            print("Exiting program...")
            break
        else:
            print("Invalid choice! Please enter again.")


if __name__ == "__main__":
    main()
