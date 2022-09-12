#include <iostream>

void showMenu()
{
	system("cls");
	std::cout << "Menu:\n";
	std::cout << "1. Pole kwadratu\n";
	std::cout << "2. Pole trojkata\n";
}

int chooseOptionFromUser()
{
	std::cout << "Wybierz opcje\n";
	int selectedOption;
	std::cin >> selectedOption;
	return selectedOption;
}

void SquareArea()
{
	std::cout << "Podaj wartosc boku kwadratu:\n";
	int side;
	std::cin >> side;
	int area = side * side;
	std::cout << "Pole kwadratu to " << area << "\n";
}

void TriangleArea()
{
	std::cout << "Podaj wartosc podstawy trojkata:\n";
	int base;
	std::cin >> base;
	std::cout << "Podaj wartosc wysokosci trojkata:\n";
	int height;
	std::cin >> height;
	int area = base * height / 2;
	std::cout << "Pole trojkata to " << area << "\n";
}

void doSelectedTask(int selectedOption)
{
	if (selectedOption == 1)
	{
		SquareArea();
	}
	if (selectedOption == 2)
	{
		TriangleArea();
	}
}

void mainProgram()
{
	//1. wyświetlenie menu
	showMenu();

	//2. wybranie opcji przez użytkownika
	int selected = chooseOptionFromUser();

	//3. Wykonanie wybranego zadania
	doSelectedTask(selected);
}

void main()
{
	mainProgram();
}

