#include <iostream>
#include <fstream>
#include <conio.h>
using namespace std;

void main() {
	char ch;
	fstream file;
	char filename[20];
	cout << "Enter the name of the file: " << flush;
	cin >> filename;
	file.open(filename, ios::in);
	//file.unsetf(ios::skipws);
	while (1)
	{
		file >> ch;
		if (file.fail())
			break;
		cout << ch;
	}
	file.close();
	_getch();
}
