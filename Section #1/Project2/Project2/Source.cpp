#include <iostream>
#include <fstream>
#include <string>
#include <conio.h>
using namespace std;
void writeToFile(const string& filepath)
{
	ofstream outputFile(filepath ,ios::app); // Open file for writing
	if (!outputFile.is_open()) {
		cerr << "Error opening file " << filepath << " for writing." << endl;
		return;
	}
	string data;
	cout << "Enter data to write to the file (enter 'q' to quit):" << endl;
	while (true) {
		getline(cin, data);
		if (data == "q")
			break;
		outputFile << data << endl; // Write data to file
	}
	outputFile.close(); // Close the file
	cout << "Data has been written to the file." << endl;
}
void readFromFile(const string& filepath)
{
	ifstream inputFile(filepath); // Open file for reading
	if (!inputFile.is_open()) {
		cerr << "Error opening file " << filepath << " for reading." << endl;
		return;
	}
	string line;
	cout << "Contents of the file:" << endl;
	while (getline(inputFile, line)) {
		cout << line << endl; // Print each line of the file
	}
	inputFile.close(); // Close the file
}

void main()
{
	string path = "D:/data.txt"; // Specify the path to the file
	writeToFile(path); // Write data to file
	readFromFile(path); // Read data from file

	_getch();
}
