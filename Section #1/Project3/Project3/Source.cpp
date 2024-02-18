#include <iostream>
#include <fstream>
#include <string>

using namespace std;

class Person
{
public:
	string lastName;
	string firstName;
	string address;
	string city;
	string state;
	string zipCode;
	Person(); // Constructor declaration
	void getDataFromUser(); // Method to get data from user
	void saveToFile(const string& filePath); // Method to save data to file
};

// Constructor Definition
Person::Person()
{
	lastName = "0";
	firstName = "0";
	address = "0";
	city = "0";
	state = "0";
	zipCode = "0";
}

// Method to get data from user
void Person::getDataFromUser()
{
	cout << "Enter Last Name: ";
	getline(cin, lastName);

	cout << "Enter First Name: ";
	getline(cin, firstName);

	cout << "Enter Address: ";
	getline(cin, address);

	cout << "Enter City: ";
	getline(cin, city);

	cout << "Enter State: ";
	getline(cin, state);

	cout << "Enter Zip Code: ";
	getline(cin, zipCode);
}

// Method to save data to file
void Person::saveToFile(const string& filePath)
{
	ofstream outFile(filePath); // Open file
								// Check if the file is opened successfully
	if (!outFile.is_open())
	{
		cerr << "Error: Unable to open the file.\n";
		return;
	}
	// Write data to file
	outFile << "Last Name: " << lastName << endl;
	outFile << "First Name: " << firstName << endl;
	outFile << "Address: " << address << endl;
	outFile << "City: " << city << endl;
	outFile << "State: " << state << endl;
	outFile << "Zip Code: " << zipCode << endl;
	outFile.close();
}

int main()
{
	// Create a Person object
	Person person1;

	// Get data from the user
	person1.getDataFromUser();

	// Save the Person object's data to a text file at specific location
	person1.saveToFile("D:\\data.txt");

	cout << "Person data saved to file.\n";

	return 0;
}
